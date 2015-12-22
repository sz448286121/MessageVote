using System;
using System.Collections.Generic;
using System.Text;

namespace vote
{
    /// <summary>
    /// 枚举 仅保留 目的是与上个版本兼容
    /// </summary>
    public enum MsgType
    {
        AUSC2,
        A7Bit               //枚举 短信类型 AUSC2 A7Bit：7位编码 （中文用AUSC2，英文都可以 但7Bit能发送160字符，USC2仅70）
    }
}
