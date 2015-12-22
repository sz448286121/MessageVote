using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vote
{
    public partial class voting : Form
    {
        public delegate void updatestatehandler();
        updatestatehandler updatestate;
        
        string meetingname;
        string pollnum;
        GsmModem gm;
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public voting(string meetingname)
        {
            InitializeComponent();
            this.meetingname = meetingname;
        }
        private void voting_Load(object sender, EventArgs e)
        {
            pollnum_select.DataSource = mainform.db.query_dt("select pollnum from poll where meetingname='"+meetingname+"'");
            pollnum_select.DisplayMember = "pollnum";
            pollnum_select.SelectedIndexChanged += new EventHandler(pollnum_select_SelectedIndexChanged);
            
            pollnum_select_SelectedIndexChanged(this, e);

            updatestate += update_vote_state;

            asc.controllInitializeSize(this);
            this.SizeChanged += new EventHandler(voting_SizeChanged);
        }
        private void voting_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        private void pollnum_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pollnum = pollnum_select.Text;
            DataTable dt = new DataTable();
            dt = mainform.db.query_dt("select pollname,method,finish from poll where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
            string pollname = Convert.ToString(dt.Rows[0].ItemArray[0]);
            string pollmethod = Convert.ToString(dt.Rows[0].ItemArray[1]);
            this.pollname.Text = pollname;
            if (pollmethod == "100")
                this.pollmethod.Text = "百分制";
            else if (pollmethod == "10")
                this.pollmethod.Text = "十分制";
            else this.pollmethod.Text = "01制";
            int flag = Convert.ToInt32(dt.Rows[0].ItemArray[2]);
            if (flag == 1)
            {
                start.Enabled = false; finish.Enabled = false;
                check_result.Enabled = false;
                voting_dg.DataSource = mainform.db.query_dt("select project.projectnum,project.projectname,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname + "' and result.pollnum='" + pollnum_select.Text + "'order by result.sum DESC");
                voting_dg.Columns[0].HeaderText = "项目编号";
                voting_dg.Columns[1].HeaderText = "项目名称";
                voting_dg.Columns[2].HeaderText = "负责人";
                voting_dg.Columns[3].HeaderText = "得分";
                voting_dg.ReadOnly = true;
                voting_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                voting_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                start.Enabled = true; finish.Enabled = false ;
                check_result.Enabled = false;
                voting_dg.DataSource = mainform.db.query_dt("select projectnum,projectname,principal from project where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
                voting_dg.Columns[0].HeaderText = "项目编号";
                voting_dg.Columns[1].HeaderText = "项目名称";
                voting_dg.Columns[2].HeaderText = "负责人";
                voting_dg.ReadOnly = true;
                voting_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                voting_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
          //  this.Invoke(updatestate);
        }

        private void check_result_Click(object sender, EventArgs e)
        {
            int method = Convert.ToInt32(mainform.db.query_dt("select method from poll where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'").Rows[0].ItemArray[0]);
            if (method == 100 || method == 10)
            {
                DataTable dt = new DataTable();
                int cnt = mainform.db.query_dt("select *from votestate where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "' and voted=1").Rows.Count;
                if (cnt == 0) return;
                dt = mainform.db.query_dt("select projectnum,sum,max,min from result where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string projectnum = Convert.ToString(dt.Rows[i].ItemArray[0]);
                    double sum = Convert.ToDouble(dt.Rows[i].ItemArray[1]);
                    double max = Convert.ToDouble(dt.Rows[i].ItemArray[2]);
                    double min = Convert.ToDouble(dt.Rows[i].ItemArray[3]);
                    if (Convert.ToBoolean(calmethod.Checked))
                    {
                        sum = sum - max - min;
                        sum /= (cnt - 2);
                    }
                    else
                    {
                        sum /= cnt;
                    }
                    mainform.db.update("update result set sum=" + sum.ToString() + " where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "' and projectnum='" + projectnum + "'");
                }
            }
            voting_dg.DataSource = mainform.db.query_dt("select project.projectnum,project.projectname,project.principal,result.sum from result,project where result.meetingname=project.meetingname and result.pollnum=project.pollnum and project.projectnum=result.projectnum and result.meetingname='" + meetingname + "' and result.pollnum='" + pollnum_select.Text + "'order by result.sum  DESC");
            voting_dg.Columns[0].HeaderText = "项目编号";
            voting_dg.Columns[1].HeaderText = "项目名称";
            voting_dg.Columns[2].HeaderText = "负责人";
            voting_dg.Columns[3].HeaderText = "得分";
            voting_dg.ReadOnly = true;
            voting_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            voting_dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            check_result.Enabled = false;
        }
        private void start_Click(object sender, EventArgs e)
        {
            mainform.db.update("delete from result where meetingname='"+meetingname+"' and pollnum='"+pollnum_select.Text+"'");
            mainform.db.update("delete from sms where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
            for (int i = 0; i < voting_dg.Rows.Count; i++)
            {
                string projectnum = Convert.ToString(voting_dg.Rows[i].Cells[0].Value);
                mainform.db.update("insert into result values('" + meetingname + "','" + pollnum_select.Text + "','" + projectnum + "'," + "0,0,100,0)");
            }
            mainform.db.update("delete from votestate where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
            DataTable dt = new DataTable();
            dt = mainform.db.query_dt("select phone from voter where meetingname='"+meetingname+"' and present=1");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string phone = Convert.ToString(dt.Rows[i].ItemArray[0]);
                mainform.db.update("insert into votestate(meetingname,pollnum,phone,voted,information) values('"+meetingname+"','"+pollnum_select.Text+"','"+phone+"',0,'')");
            }
            this.Invoke(updatestate);
            gm = new GsmModem(GsmModem.FindPort(), 9600);
            gm.OnRecieved += new GsmModem.OnRecievedHandler(gm_OnReceived);
            try
            {
                gm.Open();
            }
            catch{}
            gm.SendAT("AT");
            gm.SendAT("ATE0");
            gm.SendAT("AT+CMGF=0");
            gm.SendAT("AT+CMGDA=6");
            MessageBox.Show("串口开启成功!");
            start.Enabled = false;
            finish.Enabled = true;
            check_result.Enabled = false;
            int num = mainform.db.query_dt("select *from project where meetingname='" + meetingname + "' and pollnum='" + pollnum + "'").Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string phone = Convert.ToString(dt.Rows[i].ItemArray[0]);
                string message = "*";
                for (int j = 0; j < num; j++)
                    message += "*#";
                gm.SendMsg(phone,message);
            }   
        }

        void gm_OnReceived(object sender, EventArgs e)
        {
            try
            {
                string temp = gm.ReadNewMsg();
                string sum = temp.Substring(0, 2);
                string num = temp.Substring(2, 2);
                string phone = temp.Split(',')[2];
                string data = temp.Split(',')[4];
                DataTable dt = new DataTable();
                dt = mainform.db.query_dt("select *from voter where meetingname='" + meetingname + "' and phone='" + phone + "'");
                if (dt.Rows.Count == 0) return;
                dt = mainform.db.query_dt("select voted from votestate where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and phone='" + phone + "'");
                Boolean flag = Convert.ToBoolean(dt.Rows[0].ItemArray[0]);
                if (flag)
                {
                    gm.SendMsg(phone, "不能重复投票");
                    return;
                }
                mainform.db.update("insert into sms(meetingname,pollnum,phone,sum,num,data) values('" + meetingname + "','" + pollnum + "','" + phone + "'," + sum + "," + num + ",'" + data + "')");
                dt = mainform.db.query_dt("select sum,data from sms where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and phone='" + phone + "' order by num");
                int sum_sms = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                int acc_sms = dt.Rows.Count;
                  if (sum_sms == acc_sms)
                {
                    string tempdata = "";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string single=Convert.ToString(dt.Rows[i].ItemArray[1]);
                        single = single.Substring(0, single.IndexOf("\0"));
                        tempdata += single;
                    }
                   tempdata = tempdata.Replace("\0", "");
                    this.Invoke(updatestate);
                    if (check_data(tempdata))
                    {
                        update_result(tempdata);
                        mainform.db.update("update votestate set voted=1,information='" + tempdata + "' where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and phone='" + phone + "'");
                        this.Invoke(updatestate);
                        gm.SendMsg(phone, "您已成功投票！");
                    }
                    else
                    {
                        mainform.db.update("delete from sms where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and phone='" + phone + "'");
                        gm.SendMsg(phone, "格式错误，请重发！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              //  gm.SendAT("AT+CMGDA=1");
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            try
            {
                gm.Close();
                mainform.db.update("update poll set finish=1 where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("串口已关闭！");
            finish.Enabled = false;
            check_result.Enabled = true;
            int method = Convert.ToInt32(mainform.db.query_dt("select method from poll where meetingname='" + meetingname + "' and pollnum='" + pollnum_select.Text + "'").Rows[0].ItemArray[0]);
            if (method == 1) calmethod.Enabled = false;
            else calmethod.Enabled = true;
        }

        public void update_vote_state()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = mainform.db.query_dt("select *from votestate where meetingname='"+meetingname+"' and pollnum='"+pollnum+"'");
            dt2 = mainform.db.query_dt("select *from votestate where meetingname='" + meetingname + "' and voted=1 and pollnum='"+pollnum+"'");
            int cnt1 = dt1.Rows.Count;
            int cnt2 = dt2.Rows.Count;
            state.Text = cnt2.ToString() + "/" + cnt1.ToString();
        }
        private bool check_data(string data)
        {
            int tmp = data.IndexOf("**");
            if (tmp == -1) return false;
            string content = data.Substring(tmp + 2);
            string[] split = content.Split('*');
            DataTable dt = new DataTable();
            dt = mainform.db.query_dt("select method from poll where meetingname='" + meetingname + "' and pollnum='" + pollnum + "'");
            int method = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            foreach(string s in split)
            {
                if (s == "") continue;
                if (s.IndexOf('#') == -1) return false;
                string s1 = s.Split('#')[0];
                string s2 = s.Split('#')[1];
                if (s1 == "") return false;
                if (mainform.db.query_dt("select * from project where meetingname='"+meetingname+"' and pollnum='"+pollnum+"' and projectnum='"+s1+"'").Rows.Count == 0) return false; 
                if (method == 100 || method == 10)
                {
                    if (s2 == "") return false;
                }
                if (method == 100)
                {
                    double num = Convert.ToDouble(s2);
                    if (num < 0 || num > 100) return false;
                }
                if (method == 10)
                {
                    double num = Convert.ToDouble(s2);
                    if (num < 0 || num > 10) return false;
                }
                if (method == 1)
                {
                    int num = Convert.ToInt32(s2);
                    if (num != 1 && num != 0) return false;
                }
            }
            return true;
        }
        private void  update_result(string data)
        {
            int tmp = data.IndexOf("**");
            string content = data.Substring(tmp + 2);
            string[] split = content.Split('*');
            DataTable dt = new DataTable();
            dt=mainform.db.query_dt("select method from poll where meetingname='"+meetingname+"' and pollnum='"+pollnum+"'");
            int method=Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            foreach (string s in split)
            {
                if (s == "") continue;
                string s1 = s.Split('#')[0];
                string s2 = s.Split('#')[1];
                float score =(float) Convert.ToDouble(s2);
                dt = mainform.db.query_dt("select sum,max,min,waive from result where meetingname='"+meetingname+"' and pollnum='"+pollnum+"' and projectnum='"+s1+"'");
                if (method == 100 || method == 10)
                {
                    float sum = (float)Convert.ToDouble(dt.Rows[0].ItemArray[0]);
                    float max = (float)Convert.ToDouble(dt.Rows[0].ItemArray[1]);
                    float min = (float)Convert.ToDouble(dt.Rows[0].ItemArray[2]);
                    sum += score;
                    if (score > max) max = score;
                    if (score < min) min = score;
                    mainform.db.update("update  result set sum="+sum.ToString()+",max="+max.ToString()+",min="+min.ToString()+"  where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and projectnum='" + s1 + "'");
                }
                else
                {
                    float sum = (float)Convert.ToDouble(dt.Rows[0].ItemArray[0]);
                    int waive = Convert.ToInt32(dt.Rows[0].ItemArray[3]);
                    if (s2 == "") waive++;
                    else sum+=score;
                    mainform.db.update("update  result set sum=" + sum.ToString() + ",waive=" + waive.ToString() + "  where meetingname='" + meetingname + "' and pollnum='" + pollnum + "' and projectnum='" + s1 + "'");
                }
            }
        }
    }
}
 