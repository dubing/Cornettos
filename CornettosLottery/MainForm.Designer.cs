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
            this.lblWon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLottery = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllMember = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.CornettosLottery.SuspendLayout();
            this.SuspendLayout();
            // 
            // CornettosLottery
            // 
            this.CornettosLottery.Controls.Add(this.lblWon);
            this.CornettosLottery.Controls.Add(this.label2);
            this.CornettosLottery.Controls.Add(this.btnLottery);
            this.CornettosLottery.Controls.Add(this.lblPageSize);
            this.CornettosLottery.Controls.Add(this.label1);
            this.CornettosLottery.Controls.Add(this.txtAllMember);
            this.CornettosLottery.Controls.Add(this.btnSelectFile);
            this.CornettosLottery.Location = new System.Drawing.Point(12, 12);
            this.CornettosLottery.Name = "CornettosLottery";
            this.CornettosLottery.Size = new System.Drawing.Size(583, 91);
            this.CornettosLottery.TabIndex = 0;
            this.CornettosLottery.TabStop = false;
            this.CornettosLottery.Text = "CornettosLottery";
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
            this.btnLottery.Location = new System.Drawing.Point(502, 54);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 540);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.CornettosLottery);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CornettosLottery.ResumeLayout(false);
            this.CornettosLottery.PerformLayout();
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
    }
}

