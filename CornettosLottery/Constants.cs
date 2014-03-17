using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CornettosLottery
{
    public class Constants
    {
        public const string FileExt = "xls文件|*.xls";       
        public const string HistoryPath = "WinnerHistory.xls";
        public const string KeyName = "Email Address";
        public const string Username = "User Name";
        public const string Email = "Email Address";
        public const string Mobile = "Mobile No";
        
    }

    public class CustomMessage
    {
        public const string FileNotCorrect = "this file is not correct";
        public const string HistoryNotExist = "the history file is not exist";
        public const string ActionSuccess = "Action Success";
        public const string SetCountError = "the Count of Lottery set wrong format";
        public const string LotteryError = "Lottery information has expired,pls lottery again";
        public const string ConformSuccess = "Conform Success,these persons have been record at {0} ";
    }
}
