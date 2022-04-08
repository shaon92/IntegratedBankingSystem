namespace IntegratedBankingSystem
{
    partial class frmSvtrn
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
            this.btnSaveSVtrn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAcsts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActitle = new System.Windows.Forms.Label();
            this.txtAcno = new System.Windows.Forms.TextBox();
            this.dtGridSVTrn = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttrnDes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTrnSign = new System.Windows.Forms.TextBox();
            this.trnDt = new System.Windows.Forms.DateTimePicker();
            this.cmbTrnTyp = new System.Windows.Forms.ComboBox();
            this.txtTrnamt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRcvAcNo = new System.Windows.Forms.TextBox();
            this.lblRcvAc = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateSvTrn = new System.Windows.Forms.Button();
            this.txtBatno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSVTrn)).BeginInit();
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
            this.lblUser.TabIndex = 82;
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
            // btnSaveSVtrn
            // 
            this.btnSaveSVtrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveSVtrn.Location = new System.Drawing.Point(274, 614);
            this.btnSaveSVtrn.Name = "btnSaveSVtrn";
            this.btnSaveSVtrn.Size = new System.Drawing.Size(102, 35);
            this.btnSaveSVtrn.TabIndex = 1;
            this.btnSaveSVtrn.Text = "Save";
            this.btnSaveSVtrn.UseVisualStyleBackColor = true;
            this.btnSaveSVtrn.Click += new System.EventHandler(this.btnSaveSVtrn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 5);
            this.label3.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(2, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(882, 5);
            this.label2.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(236, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 38);
            this.label1.TabIndex = 79;
            this.label1.Text = "Savings Account Transaction";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(771, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(280, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 84;
            this.label4.Text = "A/C No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblAcBal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAcsts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblActitle);
            this.groupBox1.Controls.Add(this.txtAcno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 89);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(453, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 12);
            this.label20.TabIndex = 92;
            this.label20.Text = "Press Enter after input";
            // 
            // lblAcBal
            // 
            this.lblAcBal.AccessibleDescription = "  ";
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Location = new System.Drawing.Point(621, 58);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(12, 17);
            this.lblAcBal.TabIndex = 90;
            this.lblAcBal.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(477, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 89;
            this.label7.Text = "Account Balance: ";
            // 
            // lblAcsts
            // 
            this.lblAcsts.AutoSize = true;
            this.lblAcsts.Location = new System.Drawing.Point(275, 63);
            this.lblAcsts.Name = "lblAcsts";
            this.lblAcsts.Size = new System.Drawing.Size(12, 17);
            this.lblAcsts.TabIndex = 88;
            this.lblAcsts.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(178, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 87;
            this.label5.Text = "A/C Status: ";
            // 
            // lblActitle
            // 
            this.lblActitle.AutoSize = true;
            this.lblActitle.Location = new System.Drawing.Point(562, 24);
            this.lblActitle.Name = "lblActitle";
            this.lblActitle.Size = new System.Drawing.Size(12, 17);
            this.lblActitle.TabIndex = 86;
            this.lblActitle.Text = " ";
            // 
            // txtAcno
            // 
            this.txtAcno.Location = new System.Drawing.Point(350, 21);
            this.txtAcno.Name = "txtAcno";
            this.txtAcno.Size = new System.Drawing.Size(97, 23);
            this.txtAcno.TabIndex = 0;
            this.txtAcno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcno_KeyDown);
            // 
            // dtGridSVTrn
            // 
            this.dtGridSVTrn.AllowUserToAddRows = false;
            this.dtGridSVTrn.AllowUserToDeleteRows = false;
            this.dtGridSVTrn.BackgroundColor = System.Drawing.Color.White;
            this.dtGridSVTrn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridSVTrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSVTrn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridSVTrn.Location = new System.Drawing.Point(16, 370);
            this.dtGridSVTrn.Name = "dtGridSVTrn";
            this.dtGridSVTrn.ReadOnly = true;
            this.dtGridSVTrn.Size = new System.Drawing.Size(842, 166);
            this.dtGridSVTrn.TabIndex = 86;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(16, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 180);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // txttrnDes
            // 
            this.txttrnDes.Location = new System.Drawing.Point(154, 114);
            this.txttrnDes.Multiline = true;
            this.txttrnDes.Name = "txttrnDes";
            this.txttrnDes.Size = new System.Drawing.Size(342, 56);
            this.txttrnDes.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(54, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction\r\nDescription";
            // 
            // txtTrnSign
            // 
            this.txtTrnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrnSign.Location = new System.Drawing.Point(401, 38);
            this.txtTrnSign.Name = "txtTrnSign";
            this.txtTrnSign.Size = new System.Drawing.Size(38, 26);
            this.txtTrnSign.TabIndex = 1;
            this.txtTrnSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTrnSign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrnSign_KeyPress);
            // 
            // trnDt
            // 
            this.trnDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trnDt.Location = new System.Drawing.Point(156, 76);
            this.trnDt.Name = "trnDt";
            this.trnDt.Size = new System.Drawing.Size(98, 23);
            this.trnDt.TabIndex = 3;
            // 
            // cmbTrnTyp
            // 
            this.cmbTrnTyp.FormattingEnabled = true;
            this.cmbTrnTyp.Items.AddRange(new object[] {
            "Cash",
            "Transfer"});
            this.cmbTrnTyp.Location = new System.Drawing.Point(154, 37);
            this.cmbTrnTyp.Name = "cmbTrnTyp";
            this.cmbTrnTyp.Size = new System.Drawing.Size(73, 24);
            this.cmbTrnTyp.TabIndex = 0;
            this.cmbTrnTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTrnTyp_SelectedIndexChanged);
            // 
            // txtTrnamt
            // 
            this.txtTrnamt.Location = new System.Drawing.Point(665, 37);
            this.txtTrnamt.Name = "txtTrnamt";
            this.txtTrnamt.Size = new System.Drawing.Size(97, 23);
            this.txtTrnamt.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(515, 39);
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
            this.label11.Location = new System.Drawing.Point(298, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 99;
            this.label11.Text = "Dr(-)/ Cr(+)";
            // 
            // txtRcvAcNo
            // 
            this.txtRcvAcNo.Location = new System.Drawing.Point(665, 76);
            this.txtRcvAcNo.Name = "txtRcvAcNo";
            this.txtRcvAcNo.Size = new System.Drawing.Size(97, 23);
            this.txtRcvAcNo.TabIndex = 5;
            // 
            // lblRcvAc
            // 
            this.lblRcvAc.AutoSize = true;
            this.lblRcvAc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRcvAc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcvAc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRcvAc.Location = new System.Drawing.Point(519, 80);
            this.lblRcvAc.Name = "lblRcvAc";
            this.lblRcvAc.Size = new System.Drawing.Size(128, 18);
            this.lblRcvAc.TabIndex = 97;
            this.lblRcvAc.Text = "Receiver A/C No.";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(399, 77);
            this.txtVC.Name = "txtVC";
            this.txtVC.Size = new System.Drawing.Size(97, 23);
            this.txtVC.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(296, 80);
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
            this.label8.Location = new System.Drawing.Point(23, 79);
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
            this.label6.Location = new System.Drawing.Point(23, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Transaction Type";
            // 
            // btnGenerateSvTrn
            // 
            this.btnGenerateSvTrn.Location = new System.Drawing.Point(536, 551);
            this.btnGenerateSvTrn.Name = "btnGenerateSvTrn";
            this.btnGenerateSvTrn.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSvTrn.TabIndex = 0;
            this.btnGenerateSvTrn.Text = "Generate";
            this.btnGenerateSvTrn.UseVisualStyleBackColor = true;
            this.btnGenerateSvTrn.Click += new System.EventHandler(this.btnGenerateSvTrn_Click);
            // 
            // txtBatno
            // 
            this.txtBatno.Location = new System.Drawing.Point(411, 552);
            this.txtBatno.Name = "txtBatno";
            this.txtBatno.ReadOnly = true;
            this.txtBatno.Size = new System.Drawing.Size(110, 20);
            this.txtBatno.TabIndex = 90;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(326, 553);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 89;
            this.label17.Text = "Batch No.";
            // 
            // frmSvtrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.btnGenerateSvTrn);
            this.Controls.Add(this.txtBatno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGridSVTrn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSVtrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSvtrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account Transaction";
            this.Load += new System.EventHandler(this.frmSvtrn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSVTrn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveSVtrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAcsts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblActitle;
        private System.Windows.Forms.TextBox txtAcno;
        private System.Windows.Forms.DataGridView dtGridSVTrn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker trnDt;
        private System.Windows.Forms.ComboBox cmbTrnTyp;
        private System.Windows.Forms.TextBox txtTrnamt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRcvAcNo;
        private System.Windows.Forms.Label lblRcvAc;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrnSign;
        private System.Windows.Forms.TextBox txttrnDes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenerateSvTrn;
        private System.Windows.Forms.TextBox txtBatno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
    }
}