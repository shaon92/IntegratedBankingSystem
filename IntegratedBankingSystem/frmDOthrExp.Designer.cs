namespace IntegratedBankingSystem
{
    partial class frmDOthrExp
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBatno = new System.Windows.Forms.TextBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.txttrnDes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTrnTyp = new System.Windows.Forms.ComboBox();
            this.txtTrnamt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMnth = new System.Windows.Forms.TextBox();
            this.lblEncAc = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteExptrn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.bxtExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(601, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Year";
            // 
            // txtBatno
            // 
            this.txtBatno.Location = new System.Drawing.Point(386, 118);
            this.txtBatno.Name = "txtBatno";
            this.txtBatno.Size = new System.Drawing.Size(110, 20);
            this.txtBatno.TabIndex = 0;
            this.txtBatno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBatno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatno_KeyDown);
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(650, 42);
            this.txtYr.Name = "txtYr";
            this.txtYr.ReadOnly = true;
            this.txtYr.Size = new System.Drawing.Size(96, 23);
            this.txtYr.TabIndex = 107;
            this.txtYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttrnDes
            // 
            this.txttrnDes.Location = new System.Drawing.Point(204, 153);
            this.txttrnDes.Multiline = true;
            this.txttrnDes.Name = "txttrnDes";
            this.txttrnDes.ReadOnly = true;
            this.txttrnDes.Size = new System.Drawing.Size(350, 56);
            this.txttrnDes.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(301, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 130;
            this.label17.Text = "Batch No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttrnDes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbTrnTyp);
            this.groupBox2.Controls.Add(this.txtTrnamt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMnth);
            this.groupBox2.Controls.Add(this.lblEncAc);
            this.groupBox2.Controls.Add(this.txtVC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(19, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(78, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction\r\nDescription";
            // 
            // cmbTrnTyp
            // 
            this.cmbTrnTyp.Enabled = false;
            this.cmbTrnTyp.FormattingEnabled = true;
            this.cmbTrnTyp.Items.AddRange(new object[] {
            "Salary Expenditure",
            "Allowance Expenditure",
            "Miscellaneous Expenditure"});
            this.cmbTrnTyp.Location = new System.Drawing.Point(206, 41);
            this.cmbTrnTyp.Name = "cmbTrnTyp";
            this.cmbTrnTyp.Size = new System.Drawing.Size(176, 24);
            this.cmbTrnTyp.TabIndex = 0;
            // 
            // txtTrnamt
            // 
            this.txtTrnamt.Location = new System.Drawing.Point(207, 101);
            this.txtTrnamt.Name = "txtTrnamt";
            this.txtTrnamt.ReadOnly = true;
            this.txtTrnamt.Size = new System.Drawing.Size(123, 23);
            this.txtTrnamt.TabIndex = 2;
            this.txtTrnamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(48, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 101;
            this.label12.Text = "Transaction Amount";
            // 
            // txtMnth
            // 
            this.txtMnth.Location = new System.Drawing.Point(477, 42);
            this.txtMnth.Name = "txtMnth";
            this.txtMnth.ReadOnly = true;
            this.txtMnth.Size = new System.Drawing.Size(51, 23);
            this.txtMnth.TabIndex = 5;
            this.txtMnth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEncAc
            // 
            this.lblEncAc.AutoSize = true;
            this.lblEncAc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEncAc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncAc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncAc.Location = new System.Drawing.Point(421, 45);
            this.lblEncAc.Name = "lblEncAc";
            this.lblEncAc.Size = new System.Drawing.Size(50, 18);
            this.lblEncAc.TabIndex = 97;
            this.lblEncAc.Text = "Month";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(649, 100);
            this.txtVC.Name = "txtVC";
            this.txtVC.ReadOnly = true;
            this.txtVC.Size = new System.Drawing.Size(97, 23);
            this.txtVC.TabIndex = 4;
            this.txtVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(546, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Voucher No. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(53, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Transaction Type";
            // 
            // btnDeleteExptrn
            // 
            this.btnDeleteExptrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteExptrn.Location = new System.Drawing.Point(275, 494);
            this.btnDeleteExptrn.Name = "btnDeleteExptrn";
            this.btnDeleteExptrn.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteExptrn.TabIndex = 2;
            this.btnDeleteExptrn.Text = "Delete";
            this.btnDeleteExptrn.UseVisualStyleBackColor = true;
            this.btnDeleteExptrn.Click += new System.EventHandler(this.btnDeleteExptrn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(2, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 5);
            this.label3.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(882, 5);
            this.label2.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(237, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 38);
            this.label1.TabIndex = 123;
            this.label1.Text = "Delete Expenditure Transaction";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(22, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 126;
            // 
            // bxtExit
            // 
            this.bxtExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bxtExit.Location = new System.Drawing.Point(543, 494);
            this.bxtExit.Name = "bxtExit";
            this.bxtExit.Size = new System.Drawing.Size(102, 35);
            this.bxtExit.TabIndex = 4;
            this.bxtExit.Text = "Exit";
            this.bxtExit.UseVisualStyleBackColor = true;
            this.bxtExit.Click += new System.EventHandler(this.bxtExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(409, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(771, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 127;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(503, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 12);
            this.label16.TabIndex = 132;
            this.label16.Text = "Press Enter after Input";
            // 
            // frmDOthrExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 553);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBatno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDeleteExptrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDOthrExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Other Expenditure Transaction";
            this.Load += new System.EventHandler(this.frmDOthrExp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBatno;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.TextBox txttrnDes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTrnTyp;
        private System.Windows.Forms.TextBox txtTrnamt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMnth;
        private System.Windows.Forms.Label lblEncAc;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteExptrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label16;
    }
}