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
    }

    public class CustomMessage
    {
        public const string FileNotCorrect = "this file is not correct";
        public const string HistoryNotExist = "this history file is not exist";
    }
}
