namespace IntegratedBankingSystem
{
    partial class frmSvtrnD
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
            this.txttrnDes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTrnSign = new System.Windows.Forms.TextBox();
            this.trnDt = new System.Windows.Forms.DateTimePicker();
            this.cmbTrnTyp = new System.Windows.Forms.ComboBox();
            this.txtTrnamt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRcvAc = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRcvAcNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.bxtExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelSVtrn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBatno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttrnDes
            // 
            this.txttrnDes.Location = new System.Drawing.Point(167, 198);
            this.txttrnDes.Multiline = true;
            this.txttrnDes.Name = "txttrnDes";
            this.txttrnDes.ReadOnly = true;
            this.txttrnDes.Size = new System.Drawing.Size(342, 56);
            this.txttrnDes.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(61, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction\r\nDescription";
            // 
            // txtTrnSign
            // 
            this.txtTrnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrnSign.Location = new System.Drawing.Point(412, 84);
            this.txtTrnSign.Name = "txtTrnSign";
            this.txtTrnSign.ReadOnly = true;
            this.txtTrnSign.Size = new System.Drawing.Size(38, 26);
            this.txtTrnSign.TabIndex = 2;
            this.txtTrnSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trnDt
            // 
            this.trnDt.Enabled = false;
            this.trnDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trnDt.Location = new System.Drawing.Point(167, 147);
            this.trnDt.Name = "trnDt";
            this.trnDt.Size = new System.Drawing.Size(98, 23);
            this.trnDt.TabIndex = 4;
            // 
            // cmbTrnTyp
            // 
            this.cmbTrnTyp.Enabled = false;
            this.cmbTrnTyp.FormattingEnabled = true;
            this.cmbTrnTyp.Items.AddRange(new object[] {
            "Cash",
            "Transfer"});
            this.cmbTrnTyp.Location = new System.Drawing.Point(165, 85);
            this.cmbTrnTyp.Name = "cmbTrnTyp";
            this.cmbTrnTyp.Size = new System.Drawing.Size(73, 24);
            this.cmbTrnTyp.TabIndex = 1;
            this.cmbTrnTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTrnTyp_SelectedIndexChanged);
            // 
            // txtTrnamt
            // 
            this.txtTrnamt.Location = new System.Drawing.Point(676, 83);
            this.txtTrnamt.Name = "txtTrnamt";
            this.txtTrnamt.ReadOnly = true;
            this.txtTrnamt.Size = new System.Drawing.Size(97, 23);
            this.txtTrnamt.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(526, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 101;
            this.label12.Text = "Transaction Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(309, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 99;
            this.label11.Text = "Dr(-)/ Cr(+)";
            // 
            // lblRcvAc
            // 
            this.lblRcvAc.AutoSize = true;
            this.lblRcvAc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRcvAc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcvAc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRcvAc.Location = new System.Drawing.Point(530, 151);
            this.lblRcvAc.Name = "lblRcvAc";
            this.lblRcvAc.Size = new System.Drawing.Size(128, 18);
            this.lblRcvAc.TabIndex = 97;
            this.lblRcvAc.Text = "Receiver A/C No.";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(410, 148);
            this.txtVC.Name = "txtVC";
            this.txtVC.ReadOnly = true;
            this.txtVC.Size = new System.Drawing.Size(97, 23);
            this.txtVC.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(307, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Voucher No. ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(34, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 93;
            this.label8.Text = "Transaction Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(34, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Transaction Type";
            // 
            // txtRcvAcNo
            // 
            this.txtRcvAcNo.Location = new System.Drawing.Point(676, 147);
            this.txtRcvAcNo.Name = "txtRcvAcNo";
            this.txtRcvAcNo.ReadOnly = true;
            this.txtRcvAcNo.Size = new System.Drawing.Size(97, 23);
            this.txtRcvAcNo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAcno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttrnDes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTrnSign);
            this.groupBox2.Controls.Add(this.trnDt);
            this.groupBox2.Controls.Add(this.cmbTrnTyp);
            this.groupBox2.Controls.Add(this.txtTrnamt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRcvAcNo);
            this.groupBox2.Controls.Add(this.lblRcvAc);
            this.groupBox2.Controls.Add(this.txtVC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 279);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // txtAcno
            // 
            this.txtAcno.Location = new System.Drawing.Point(165, 37);
            this.txtAcno.Name = "txtAcno";
            this.txtAcno.ReadOnly = true;
            this.txtAcno.Size = new System.Drawing.Size(97, 23);
            this.txtAcno.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "A/C No.";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(22, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 98;
            // 
            // bxtExit
            // 
            this.bxtExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bxtExit.Location = new System.Drawing.Point(542, 614);
            this.bxtExit.Name = "bxtExit";
            this.bxtExit.Size = new System.Drawing.Size(102, 35);
            this.bxtExit.TabIndex = 3;
            this.bxtExit.Text = "Exit";
            this.bxtExit.UseVisualStyleBackColor = true;
            this.bxtExit.Click += new System.EventHandler(this.bxtExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(408, 614);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelSVtrn
            // 
            this.btnDelSVtrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelSVtrn.Location = new System.Drawing.Point(274, 614);
            this.btnDelSVtrn.Name = "btnDelSVtrn";
            this.btnDelSVtrn.Size = new System.Drawing.Size(102, 35);
            this.btnDelSVtrn.TabIndex = 1;
            this.btnDelSVtrn.Text = "Delete";
            this.btnDelSVtrn.UseVisualStyleBackColor = true;
            this.btnDelSVtrn.Click += new System.EventHandler(this.btnDelSVtrn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 5);
            this.label3.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(2, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(882, 5);
            this.label2.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(236, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 38);
            this.label1.TabIndex = 95;
            this.label1.Text = "Delete Savings Transaction";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(771, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 99;
            // 
            // txtBatno
            // 
            this.txtBatno.Location = new System.Drawing.Point(418, 151);
            this.txtBatno.Name = "txtBatno";
            this.txtBatno.Size = new System.Drawing.Size(110, 20);
            this.txtBatno.TabIndex = 0;
            this.txtBatno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatno_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(333, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 106;
            this.label17.Text = "Batch No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(532, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 14);
            this.label7.TabIndex = 107;
            this.label7.Text = "Press Enter after input";
            // 
            // frmSvtrnD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBatno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelSVtrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmSvtrnD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Savings Transaction";
            this.Load += new System.EventHandler(this.frmSvtrnD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttrnDes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTrnSign;
        private System.Windows.Forms.DateTimePicker trnDt;
        private System.Windows.Forms.ComboBox cmbTrnTyp;
        private System.Windows.Forms.TextBox txtTrnamt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRcvAc;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRcvAcNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelSVtrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBatno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}