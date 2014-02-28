using Excel;
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

        private static DataSet WinnerHistory;

        private void MainForm_Load(object sender, EventArgs e)
        {
            WinnerHistory = GetDataFormExcel(Constants.HistoryPath);
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
            var userDataSet = GetDataFormExcel(this.txtAllMember.Text);
            var userDataTable = new DataTable();
            if (userData != null && userData.Tables.Count != 0)
            {
                this.lblPageSize.Text = userData.Tables[0].Rows.Count.ToString();
            }
            else
            {
                this.txtLog.Text = CustomMessage.FileNotCorrect;
            }
            List<string> userKey = userData.Tables
        }     

        private void btnLottery_Click(object sender, EventArgs e)
        {
           
        }

        private DataSet GetDataFormExcel(string filePath)
        {
            FileStream userStream = new FileStream(filePath, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(userStream);
            //DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet userInfo = excelReader.AsDataSet();
            if (userInfo == null)
            {
                userInfo = ExcelReaderFactory.CreateOpenXmlReader(userStream).AsDataSet();
            }
            excelReader.Close();

            return userInfo;
        }

    }
}
