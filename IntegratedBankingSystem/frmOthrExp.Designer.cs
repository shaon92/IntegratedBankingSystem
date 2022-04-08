namespace IntegratedBankingSystem
{
    partial class frmOthrExp
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
            this.lblUser = new System.Windows.Forms.Label();
            this.bxtExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveExptrn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtGridExpTrn = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttrnDes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTrnTyp = new System.Windows.Forms.ComboBox();
            this.txtTrnamt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMnth = new System.Windows.Forms.TextBox();
            this.lblEncAc = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatno = new System.Windows.Forms.TextBox();
            this.btnGenerateDPTrn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridExpTrn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(22, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 112;
            // 
            // bxtExit
            // 
            this.bxtExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bxtExit.Location = new System.Drawing.Point(543, 579);
            this.bxtExit.Name = "bxtExit";
            this.bxtExit.Size = new System.Drawing.Size(102, 35);
            this.bxtExit.TabIndex = 5;
            this.bxtExit.Text = "Exit";
            this.bxtExit.UseVisualStyleBackColor = true;
            this.bxtExit.Click += new System.EventHandler(this.bxtExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(409, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveExptrn
            // 
            this.btnSaveExptrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveExptrn.Location = new System.Drawing.Point(275, 579);
            this.btnSaveExptrn.Name = "btnSaveExptrn";
            this.btnSaveExptrn.Size = new System.Drawing.Size(102, 35);
            this.btnSaveExptrn.TabIndex = 3;
            this.btnSaveExptrn.Text = "Save";
            this.btnSaveExptrn.UseVisualStyleBackColor = true;
            this.btnSaveExptrn.Click += new System.EventHandler(this.btnSaveExptrn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 5);
            this.label3.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(882, 5);
            this.label2.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(237, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 38);
            this.label1.TabIndex = 109;
            this.label1.Text = "Add Expenditure Transaction";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(771, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 113;
            // 
            // dtGridExpTrn
            // 
            this.dtGridExpTrn.AllowUserToAddRows = false;
            this.dtGridExpTrn.AllowUserToDeleteRows = false;
            this.dtGridExpTrn.BackgroundColor = System.Drawing.Color.White;
            this.dtGridExpTrn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridExpTrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridExpTrn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridExpTrn.Location = new System.Drawing.Point(38, 348);
            this.dtGridExpTrn.Name = "dtGridExpTrn";
            this.dtGridExpTrn.ReadOnly = true;
            this.dtGridExpTrn.Size = new System.Drawing.Size(801, 121);
            this.dtGridExpTrn.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(326, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 117;
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
            this.groupBox2.Location = new System.Drawing.Point(16, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(650, 39);
            this.txtYr.Name = "txtYr";
            this.txtYr.ReadOnly = true;
            this.txtYr.Size = new System.Drawing.Size(96, 23);
            this.txtYr.TabIndex = 107;
            this.txtYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(601, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Year";
            // 
            // txttrnDes
            // 
            this.txttrnDes.Location = new System.Drawing.Point(204, 127);
            this.txttrnDes.Multiline = true;
            this.txttrnDes.Name = "txttrnDes";
            this.txttrnDes.Size = new System.Drawing.Size(350, 56);
            this.txttrnDes.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(78, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction\r\nDescription";
            // 
            // cmbTrnTyp
            // 
            this.cmbTrnTyp.FormattingEnabled = true;
            this.cmbTrnTyp.Items.AddRange(new object[] {
            "Salary Expenditure",
            "Allowance Expenditure",
            "Miscellaneous Expenditure"});
            this.cmbTrnTyp.Location = new System.Drawing.Point(206, 38);
            this.cmbTrnTyp.Name = "cmbTrnTyp";
            this.cmbTrnTyp.Size = new System.Drawing.Size(176, 24);
            this.cmbTrnTyp.TabIndex = 0;
            this.cmbTrnTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTrnTyp_SelectedIndexChanged);
            // 
            // txtTrnamt
            // 
            this.txtTrnamt.Location = new System.Drawing.Point(207, 87);
            this.txtTrnamt.Name = "txtTrnamt";
            this.txtTrnamt.Size = new System.Drawing.Size(123, 23);
            this.txtTrnamt.TabIndex = 1;
            this.txtTrnamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(48, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 101;
            this.label12.Text = "Transaction Amount";
            // 
            // txtMnth
            // 
            this.txtMnth.Location = new System.Drawing.Point(477, 39);
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
            this.lblEncAc.Location = new System.Drawing.Point(421, 42);
            this.lblEncAc.Name = "lblEncAc";
            this.lblEncAc.Size = new System.Drawing.Size(50, 18);
            this.lblEncAc.TabIndex = 97;
            this.lblEncAc.Text = "Month";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(649, 86);
            this.txtVC.Name = "txtVC";
            this.txtVC.Size = new System.Drawing.Size(97, 23);
            this.txtVC.TabIndex = 2;
            this.txtVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(546, 86);
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
            this.label6.Location = new System.Drawing.Point(53, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Transaction Type";
            // 
            // txtBatno
            // 
            this.txtBatno.Location = new System.Drawing.Point(411, 498);
            this.txtBatno.Name = "txtBatno";
            this.txtBatno.ReadOnly = true;
            this.txtBatno.Size = new System.Drawing.Size(110, 20);
            this.txtBatno.TabIndex = 1;
            // 
            // btnGenerateDPTrn
            // 
            this.btnGenerateDPTrn.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateDPTrn.Location = new System.Drawing.Point(536, 497);
            this.btnGenerateDPTrn.Name = "btnGenerateDPTrn";
            this.btnGenerateDPTrn.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateDPTrn.TabIndex = 2;
            this.btnGenerateDPTrn.Text = "Generate";
            this.btnGenerateDPTrn.UseVisualStyleBackColor = true;
            this.btnGenerateDPTrn.Click += new System.EventHandler(this.btnGenerateDPTrn_Click);
            // 
            // frmOthrExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 630);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveExptrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtGridExpTrn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBatno);
            this.Controls.Add(this.btnGenerateDPTrn);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOthrExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Other Expenditure Transaction";
            this.Load += new System.EventHandler(this.frmOthrExp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridExpTrn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveExptrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dtGridExpTrn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttrnDes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTrnTyp;
        private System.Windows.Forms.TextBox txtTrnamt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMnth;
        private System.Windows.Forms.Label lblEncAc;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatno;
        private System.Windows.Forms.Button btnGenerateDPTrn;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.Label label4;
    }
}