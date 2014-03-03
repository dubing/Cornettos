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

        private void MainForm_Load(object sender, EventArgs e)
        {
            WinnerHistory = GetWinnerFormExcel(Constants.HistoryPath);
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
                HSSFSheet firstSheet = (HSSFSheet)hssfworkbookDown.GetSheetAt(0);
                HSSFCellStyle cellstyle = (HSSFCellStyle)hssfworkbookDown.CreateCellStyle();
                HSSFCell cell = (HSSFCell)firstSheet.GetRow(2).CreateCell(1);
                cell.CellStyle = cellstyle;
                cell.CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;
                cell.SetCellValue("TestWriting");
                FileStream files = new FileStream(Constants.HistoryPath, FileMode.Create);
                hssfworkbookDown.Write(files);
                files.Close();
            }
            catch (Exception ex)
            {
                this.txtLog.Text = ex.Message;
            }

        }

        private List<Row> GetWinnerFormExcel(string filePath)
        {
            var excelFile = new ExcelQueryFactory(filePath);
            var userSheet = excelFile.Worksheet(0);
            var query = from p in userSheet
                        select p;
            return query.ToList();

        }



    }
}
