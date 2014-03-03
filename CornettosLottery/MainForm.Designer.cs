namespace CornettosLottery
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CornettosLottery = new System.Windows.Forms.GroupBox();
            this.lblLotteryCount = new System.Windows.Forms.Label();
            this.txtLotteryCount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblWon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLottery = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllMember = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSelectPersons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.CornettosLottery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CornettosLottery
            // 
            this.CornettosLottery.Controls.Add(this.lblRemain);
            this.CornettosLottery.Controls.Add(this.label3);
            this.CornettosLottery.Controls.Add(this.lblLotteryCount);
            this.CornettosLottery.Controls.Add(this.txtLotteryCount);
            this.CornettosLottery.Controls.Add(this.btnConfirm);
            this.CornettosLottery.Controls.Add(this.lblWon);
            this.CornettosLottery.Controls.Add(this.label2);
            this.CornettosLottery.Controls.Add(this.btnLottery);
            this.CornettosLottery.Controls.Add(this.lblPageSize);
            this.CornettosLottery.Controls.Add(this.label1);
            this.CornettosLottery.Controls.Add(this.txtAllMember);
            this.CornettosLottery.Controls.Add(this.btnSelectFile);
            this.CornettosLottery.Location = new System.Drawing.Point(12, 12);
            this.CornettosLottery.Name = "CornettosLottery";
            this.CornettosLottery.Size = new System.Drawing.Size(583, 111);
            this.CornettosLottery.TabIndex = 0;
            this.CornettosLottery.TabStop = false;
            this.CornettosLottery.Text = "CornettosLottery";
            // 
            // lblLotteryCount
            // 
            this.lblLotteryCount.AutoSize = true;
            this.lblLotteryCount.Location = new System.Drawing.Point(259, 59);
            this.lblLotteryCount.Name = "lblLotteryCount";
            this.lblLotteryCount.Size = new System.Drawing.Size(67, 13);
            this.lblLotteryCount.TabIndex = 10;
            this.lblLotteryCount.Text = "LotteryCount";
            // 
            // txtLotteryCount
            // 
            this.txtLotteryCount.Location = new System.Drawing.Point(332, 56);
            this.txtLotteryCount.Name = "txtLotteryCount";
            this.txtLotteryCount.Size = new System.Drawing.Size(62, 20);
            this.txtLotteryCount.TabIndex = 9;
            this.txtLotteryCount.Text = "5";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(502, 54);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(212, 59);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(13, 13);
            this.lblWon.TabIndex = 7;
            this.lblWon.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winner in the past:";
            // 
            // btnLottery
            // 
            this.btnLottery.Location = new System.Drawing.Point(421, 54);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(75, 23);
            this.btnLottery.TabIndex = 5;
            this.btnLottery.Text = "Lottery";
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(67, 59);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(13, 13);
            this.lblPageSize.TabIndex = 3;
            this.lblPageSize.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PageSize:";
            // 
            // txtAllMember
            // 
            this.txtAllMember.Location = new System.Drawing.Point(6, 21);
            this.txtAllMember.Name = "txtAllMember";
            this.txtAllMember.Size = new System.Drawing.Size(490, 20);
            this.txtAllMember.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(502, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "SelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 428);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(607, 112);
            this.txtLog.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelectPersons);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 270);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RandomPersons";
            // 
            // txtSelectPersons
            // 
            this.txtSelectPersons.Location = new System.Drawing.Point(6, 19);
            this.txtSelectPersons.Multiline = true;
            this.txtSelectPersons.Name = "txtSelectPersons";
            this.txtSelectPersons.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSelectPersons.Size = new System.Drawing.Size(571, 267);
            this.txtSelectPersons.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remove duplicate ramain:";
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Location = new System.Drawing.Point(142, 83);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(13, 13);
            this.lblRemain.TabIndex = 12;
            this.lblRemain.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.CornettosLottery);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CornettosLottery.ResumeLayout(false);
            this.CornettosLottery.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CornettosLottery;
        private System.Windows.Forms.TextBox txtAllMember;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelectPersons;
        private System.Windows.Forms.Label lblLotteryCount;
        private System.Windows.Forms.TextBox txtLotteryCount;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label label3;
    }
}

