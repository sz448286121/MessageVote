﻿/*----------------------------------------------------------------
 * Copyright (C) 2010 刘中原
 * 版权所有。 
 * 
 * 文件名： GSMModem.cs
 * 
 * 文件功能描述：   完成短信猫设备的打开关闭，短信的发送与接收以及
 *              其他相应功能
 *                  文件包含两个类GSMModem和PDUEncoding，PDUEncod-
 *              ing为私有类，完成PDU格式的编码与解码
 *              
 * 创建标识：   刘中原20101104
 * 
 * 修改标识：   刘中原20101113
 * 修改描述：   类库完善 添加其他需要的接口程序
 * 
 * 修改标识：   刘中原20110307
 * 修改描述：   添加长短信编解码
 * 
 * 修改标识：   刘中原20110409
 * 修改描述：   类库整理 把各个类 分别独立的作为一个文件，更改有关bug
 * 
**----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace vote
{
    /// <summary>
    /// “猫”设备类，完成短信发送 接收等
    /// </summary>
    public class GsmModem
    {
        #region 构造函数
        /// <summary>
        /// 无参数构造函数 完成有关初始化工作
        /// </summary>
        public GsmModem()
        {
            sp = new SerialPort();

            sp.ReadTimeout = 10000;         //读超时时间 发送短信时间的需要
            sp.RtsEnable = true;            //必须为true 这样串口才能接收到数据

            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="comPort">串口号</param>
        /// <param name="baudRate">波特率</param>
        public GsmModem(string comPort, int baudRate)
        {
            sp = new SerialPort();

            sp.PortName = comPort;          //
            sp.BaudRate = baudRate;
            sp.ReadTimeout = 10000;         //读超时时间 发送短信时间的需要
            sp.RtsEnable = true;            //必须为true 这样串口才能接收到数据

            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }

        #endregion 构造函数

        #region 私有字段
        private SerialPort sp;              //私有字段 串口对象

        private int newMsgIndex;            //新消息序号

        private string msgCenter = string.Empty;           //短信中心号码

        #endregion 私有字段

        #region 属性

        /// <summary>
        /// 串口号 运行时只读 设备打开状态写入将引发异常
        /// 提供对串口端口号的访问
        /// </summary>
        public string ComPort
        {
            get
            {
                return sp.PortName;
            }
            set
            {
                try
                {
                    sp.PortName = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 波特率 可读写
        /// 提供对串口波特率的访问
        /// </summary>
        public int BaudRate
        {
            get
            {
                return sp.BaudRate;
            }
            set
            {
                sp.BaudRate = value;
            }
        }

        /// <summary>
        /// 设备是否打开
        /// 对串口IsOpen属性访问
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return sp.IsOpen;
            }
        }

        private bool autoDelMsg = false;

        /// <summary>
        /// 对autoDelMsg访问
        /// 设置是否在阅读短信后自动删除 SIM 卡内短信存档
        /// 默认为 false 
        /// </summary>
        public bool AutoDelMsg
        {
            get
            {
                return autoDelMsg;
            }
            set
            {
                autoDelMsg = value;
            }
        }

        #endregion 属性

        #region 委托和事件

        /// <summary>
        /// 创建事件收到信息的委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void OnRecievedHandler(object sender, EventArgs e);

        /// <summary>
        /// 收到短信息事件 OnRecieved 
        /// 收到短信将引发此事件
        /// </summary>
        public event OnRecievedHandler OnRecieved;

        #endregion 委托和事件

        #region 串口收到数据事件

        /// <summary>
        /// 从串口收到数据 串口事件
        /// 程序未完成需要的可自己添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp = sp.ReadLine();
            if (temp.Length > 8)
            {
                if (temp.Substring(0, 6) == "+CMTI:")
                {
                    newMsgIndex = Convert.ToInt32(temp.Split(',')[1]);  //存储新信息序号
                    OnRecieved(this, e);                                //触发事件
                }
            }
        }

        #endregion 串口收到数据事件

        #region 方法

        #region 设备打开与关闭

        /// <summary>
        /// 设备打开函数，无法时打开将引发异常
        /// </summary>
        public void Open()
        {
            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //初始化设备
            if (sp.IsOpen)
            {
                sp.DataReceived -= sp_DataReceived;

                //更新添加连接识别
                sp.Write("AT\r");
                Thread.Sleep(50);
                string s = sp.ReadExisting().Trim();
                s = s.Substring(s.Length - 2, 2);           //有回显时 去后两位有效字符
                if (s != "OK")
                {
                    throw new Exception("硬件连接错误");    //硬件未连接、串口或是波特率设置错误
                }

                try
                {
                    SendAT("ATE0");
                    SendAT("AT+CMGF=0");
                    SendAT("AT+CNMI=2,1");
                }
                catch { }
            }
        }

        /// <summary>
        /// 设备关闭函数
        /// </summary>
        public void Close()
        {
            try
            {
                sp.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 设备打开与关闭

        #region 获取和设置设备有关信息

        /// <summary>
        /// 获取机器码
        /// </summary>
        /// <returns>机器码字符串（设备厂商，本机号码）</returns>
        public string GetMachineNo()
        {
            string result = SendAT("AT+CGMI");
            if (result.Substring(result.Length - 4, 3).Trim() == "OK")
            {
                result = result.Substring(0, result.Length - 5).Trim();
            }
            else
            {
                throw new Exception("获取机器码失败");
            }
            return result;
        }

        /// <summary>
        /// 设置短信中心号码
        /// </summary>
        /// <param name="msgCenterNo">短信中心号码</param>
        public void SetMsgCenterNo(string msgCenterNo)
        {
            msgCenter = msgCenterNo;
        }

        /// <summary>
        /// 获取短信中心号码
        /// </summary>
        /// <returns></returns>
        public string GetMsgCenterNo()
        {
            string tmp = string.Empty;
            if (msgCenter != null && msgCenter.Length != 0)
            {
                return msgCenter;
            }
            else
            {
                tmp = SendAT("AT+CSCA?");
                if (tmp.Substring(tmp.Length - 4, 3).Trim() == "OK")
                {
                    return tmp.Split('\"')[1].Trim();
                }
                else
                {
                    throw new Exception("获取短信中心失败");
                }
            }
        }

        #endregion 获取和设置设备有关信息

        #region 发送AT指令

        /// <summary>
        /// 发送AT指令 逐条发送AT指令 调用一次发送一条指令
        /// 能返回一个OK或ERROR算一条指令
        /// </summary>
        /// <param name="ATCom">AT指令</param>
        /// <returns>发送指令后返回的字符串</returns>
        public string SendAT(string ATCom)
        {
            string result = string.Empty;
            //忽略接收缓冲区内容，准备发送
            sp.DiscardInBuffer();

            //注销事件关联，为发送做准备
            sp.DataReceived -= sp_DataReceived;

            //发送AT指令
            try
            {
                sp.Write(ATCom + "\r");
            }
            catch (Exception ex)
            {
                sp.DataReceived += sp_DataReceived;
                throw ex;
            }

            //接收数据 循环读取数据 直至收到“OK”或“ERROR”
            try
            {
                string temp = string.Empty;
                while (temp.Trim() != "OK" && temp.Trim() != "ERROR")
                {
                    temp = sp.ReadLine();
                    result += temp;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //事件重新绑定 正常监视串口数据
                sp.DataReceived += sp_DataReceived;
            }
        }

        #endregion 发送AT指令

        #region 发送短信

        /// <summary>
        /// 发送短信
        /// 发送失败将引发异常
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="msg">短信内容</param>
        public void SendMsg(string phone, string msg)
        {
            PDUEncoding pe = new PDUEncoding();
            pe.ServiceCenterAddress = msgCenter;                    //短信中心号码 服务中心地址

            string temp = pe.PDUEncoder(phone, msg);

            string tmp = string.Empty;

            foreach (string str in temp.Split(','))
            {
                int len = (str.Length - Convert.ToInt32(str.Substring(0, 2), 16) * 2 - 2) / 2;  //计算长度

                try
                {
                    //注销事件关联，为发送做准备
                    sp.DataReceived -= sp_DataReceived;

                    sp.Write("AT+CMGS=" + len.ToString() + "\r");
                    sp.ReadTo(">");
                    sp.DiscardInBuffer();

                    //事件重新绑定 正常监视串口数据
                    sp.DataReceived += sp_DataReceived;

                    tmp = SendAT(str + (char)(26));  //26 Ctrl+Z ascii码
                }
                catch (Exception)
                {
                    throw new Exception("短信发送失败");
                }
                finally
                {
                }

                if (tmp.Substring(tmp.Length - 4, 3).Trim() == "OK")
                {
                    continue;
                }

                throw new Exception("短信发送失败");
            }
        }

        /// <summary>
        /// 发送短信 （重载）
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="msg">短信内容</param>
        /// <param name="msgType">短信类型</param>
        public void SendMsg(string phone, string msg, MsgType msgType)
        {
            SendMsg(phone, msg);
        }

        #endregion 发送短信

        #region 读取短信

        /// <summary>
        /// 获取未读信息列表
        /// </summary>
        /// <returns>未读信息列表（中心号码，手机号码，发送时间，短信内容）</returns>
        public string[] GetUnreadMsg()
        {
            string[] result = new string[255];
            string[] temp = null;
            string tmp = string.Empty;

            tmp = SendAT("AT+CMGL=0");
            if (tmp.Substring(tmp.Length - 4, 3).Trim() == "OK")
            {
                temp = tmp.Split('\r');
            }

            PDUEncoding pe = new PDUEncoding();
            int i = 0;
            foreach (string str in temp)
            {
                if (str != null && str.Length != 0 && str.Substring(0, 2).Trim() != "+C" && str.Substring(0, 2) != "OK")
                {
                    result[i] = pe.PDUDecoder(str);
                    i++;
                }
            }

            return result;
        }

        public string ReadNewMsg()
        {
            return ReadMsgByIndex(newMsgIndex);
        }

        /// <summary>
        /// 按序号读取短信
        /// </summary>
        /// <param name="index">序号</param>
        /// <returns>信息字符串 (中心号码，手机号码，发送时间，短信内容)</returns>
        public string ReadMsgByIndex(int index)
        {
            string temp = string.Empty;
            //string msgCenter, phone, msg, time;
            PDUEncoding pe = new PDUEncoding();
            try
            {
                temp = SendAT("AT+CMGR=" + index.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (temp.Trim() == "ERROR")
            {
                throw new Exception("没有此短信");
            }
            temp = temp.Split((char)(13))[2];       //取出PDU串(char)(13)为0x0a即\r 按\r分为多个字符串 第3个是PDU串

            //pe.PDUDecoder(temp, out msgCenter, out phone, out msg, out time);

            if (AutoDelMsg)
            {
                try
                {
                    DelMsgByIndex(index);
                }
                catch
                {

                }
            }

            return pe.PDUDecoder(temp);
            //return msgCenter + "," + phone + "," + time + "," + msg;
        }

        #endregion 读取短信

        #region 删除短信

        public void DelMsgByIndex(int index)
        {
            if (SendAT("AT+CMGD=" + index.ToString()).Trim() == "OK")
            {
                return;
            }

            throw new Exception("删除失败");
        }

        #endregion 删除短信

        #region 查找串口
        public static string FindPort()
        {
            bool found = false;
            string res = "";
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                SerialPort handler = new SerialPort(portName);
                res = portName;
                try
                {
                    handler.Open();
                    found = true;
                }
                catch (Exception) { }
                finally
                {
                    handler.Close();
                }
                if (found) break;
            }
            if (found) return res;
            else return "null";
        }
        #endregion 查找串口

        #endregion 方法
    }

}
