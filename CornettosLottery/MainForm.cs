using LinqToExcel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CornettosLottery
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private static List<Row> WinnerHistory;
        private static List<Row> WinnerInfo;
        private static List<Row> SelectPersons;
        private static RowNoHeader ExcelHeader;

        private string BakPath = "bak\\WinnerHistory" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";

        private void MainForm_Load(object sender, EventArgs e)
        {
            WinnerHistory = GetMultipleRows(Constants.HistoryPath);
            if (WinnerHistory == null)
            {
                this.txtLog.Text = CustomMessage.HistoryNotExist;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog
            {
                Filter = Constants.FileExt
            };
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                this.txtAllMember.Text = dialog.FileName;
            }
            WinnerInfo = GetWinnerFormExcel(this.txtAllMember.Text);
            ExcelHeader = GetExcelHeader(this.txtAllMember.Text);
            if (WinnerInfo != null && WinnerInfo.Count != 0)
            {
                this.lblPageSize.Text = WinnerInfo.Count.ToString();
                this.lblWon.Text = WinnerInfo.Count(x => WinnerHistory.Select(y => y[Constants.KeyName].Value).ToList()
                                                         .Contains(x[Constants.KeyName].Value)
                                                    ).ToString();
            }
            else
            {
                this.txtLog.Text = CustomMessage.FileNotCorrect;
            }

        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            int size = 200;
            try
            {
                size = int.Parse(this.txtLotteryCount.Text);
            }
            catch
            {
                this.txtLog.Text = CustomMessage.SetCountError;
                return;
            }
            SelectPersons = WinnerInfo.Where(x => !WinnerHistory.Select(y => y[Constants.KeyName].Value).ToList()
                                                       .Contains(x[Constants.KeyName].Value))
                                                  .OrderBy(x => Guid.NewGuid())
                                                  .Take(size)
                                                  .ToList();
            StringBuilder s = new StringBuilder();
            string line = "-------------------------------------------------------------------------------------------";
            foreach (var person in SelectPersons)
            {
                s.AppendFormat("name:{0},email:{1},mobile:2{2}\r\n" + line + line + "\r\n",
                    person[Constants.Username].Value.PropertyFormatValue(20),
                    person[Constants.Email].Value.PropertyFormatValue(35),
                    person[Constants.Mobile].Value);
            }
            this.txtSelectPersons.Text = s.ToString();
            this.txtLog.Text = CustomMessage.ActionSuccess;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                HSSFWorkbook hssfworkbookDown;
                using (FileStream file = new FileStream(Constants.HistoryPath, FileMode.Open, FileAccess.Read))
                {
                    hssfworkbookDown = new HSSFWorkbook(file);
                    file.Close();
                }
                string rootPath = System.IO.Directory.GetCurrentDirectory() + "\\";

                System.IO.File.Copy(Path.Combine(rootPath + Constants.HistoryPath), Path.Combine(rootPath + BakPath), true);

                PutDataIntoExcel(hssfworkbookDown, Constants.HistoryPath);

           
            }
            catch (Exception ex)
            {
                this.txtLog.Text = ex.Message;
            }

        }

        private List<Row> GetWinnerFormExcel(string filePath)
        {
            var excelFile = GetExcelQuery(filePath);
            var userSheet = excelFile.Worksheet(0);
            var query = from p in userSheet
                        select p;
            return query.ToList();

        }

        private List<Row> GetMultipleRows(string filePath)
        {
            var excelFile = GetExcelQuery(filePath);
            var winnerRows = new List<Row>();
            var sheetsCount = excelFile.GetWorksheetNames().Count();
            for (int i = 0; i < sheetsCount; i++)
            {
                var userSheet = excelFile.Worksheet(i);
                var rows = from p in userSheet
                           select p;
                foreach (var row in rows)
                {
                    winnerRows.Add(row);
                }
            }
            return winnerRows;
        }



        private RowNoHeader GetExcelHeader(string filePath)
        {
            var excelFile = GetExcelQuery(filePath);
            var rows = from c in excelFile.WorksheetNoHeader(0)
                       select c;
            return rows.FirstOrDefault();
        }

        private ExcelQueryFactory GetExcelQuery(string filePath)
        {
            return new ExcelQueryFactory(filePath);
        }

        private void PutHeaderIntoSheet(HSSFSheet newSheet)
        {
            IRow row = newSheet.CreateRow(0);
            int index = 0;
            foreach (var coloumName in ExcelHeader)
            {
                newSheet.GetRow(0).CreateCell(index).SetCellValue(coloumName);
                index++;
            }

        }

        private void PutDataIntoExcel(HSSFWorkbook hssfworkbookDown,string filePath)
        {
            HSSFSheet newSheet = (HSSFSheet)hssfworkbookDown.CreateSheet(DateTime.Now.ToString("yyyyMMddHHmmss"));
            int currentCount = 0;
            if (ExcelHeader != null)
            {
                IRow row = newSheet.CreateRow(0);
                int index = 0;
                foreach (var coloumName in ExcelHeader)
                {
                    newSheet.GetRow(0).CreateCell(index).SetCellValue(coloumName);
                    index++;
                }
                currentCount = 1;
            }

            foreach (var person in SelectPersons)
            {

                IRow row = newSheet.CreateRow(currentCount);
                int index = 0;
                foreach (var personCell in person)
                {
                    newSheet.GetRow(currentCount).CreateCell(index).SetCellValue(person[index]);
                    index++;
                }
                currentCount++;
            }

            FileStream files = new FileStream(filePath, FileMode.Create);
            hssfworkbookDown.Write(files);
            files.Close();
        }



    }
}
