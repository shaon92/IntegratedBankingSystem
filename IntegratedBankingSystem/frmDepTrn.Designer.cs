namespace IntegratedBankingSystem
{
    partial class frmDepTrn
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
            this.txtBatno = new System.Windows.Forms.TextBox();
            this.txttrnDes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.trnDt = new System.Windows.Forms.DateTimePicker();
            this.cmbTrnTyp = new System.Windows.Forms.ComboBox();
            this.txtTrnamt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEncAc = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateDPTrn = new System.Windows.Forms.Button();
            this.txtEncAcNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtGridDPTrn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRmPeriod = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMnDep = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTPeriod = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblIntr = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblOpnDt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAcBal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblActitle = new System.Windows.Forms.Label();
            this.txtAcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.bxtExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveDPtrn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDPTrn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBatno
            // 
            this.txtBatno.Location = new System.Drawing.Point(411, 556);
            this.txtBatno.Name = "txtBatno";
            this.txtBatno.ReadOnly = true;
            this.txtBatno.Size = new System.Drawing.Size(110, 20);
            this.txtBatno.TabIndex = 104;
            // 
            // txttrnDes
            // 
            this.txttrnDes.Location = new System.Drawing.Point(146, 114);
            this.txttrnDes.Multiline = true;
            this.txttrnDes.Name = "txttrnDes";
            this.txttrnDes.Size = new System.Drawing.Size(350, 56);
            this.txttrnDes.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(46, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction\r\nDescription";
            // 
            // txtND
            // 
            this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(408, 38);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(38, 26);
            this.txtND.TabIndex = 1;
            this.txtND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtND_KeyDown);
            // 
            // trnDt
            // 
            this.trnDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trnDt.Location = new System.Drawing.Point(148, 76);
            this.trnDt.Name = "trnDt";
            this.trnDt.Size = new System.Drawing.Size(98, 23);
            this.trnDt.TabIndex = 3;
            // 
            // cmbTrnTyp
            // 
            this.cmbTrnTyp.FormattingEnabled = true;
            this.cmbTrnTyp.Items.AddRange(new object[] {
            "Monthly Deposit",
            "Encashment"});
            this.cmbTrnTyp.Location = new System.Drawing.Point(146, 37);
            this.cmbTrnTyp.Name = "cmbTrnTyp";
            this.cmbTrnTyp.Size = new System.Drawing.Size(140, 24);
            this.cmbTrnTyp.TabIndex = 0;
            this.cmbTrnTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTrnTyp_SelectedIndexChanged);
            // 
            // txtTrnamt
            // 
            this.txtTrnamt.Location = new System.Drawing.Point(704, 37);
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
            this.label12.Location = new System.Drawing.Point(554, 39);
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
            this.label11.Location = new System.Drawing.Point(299, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 99;
            this.label11.Text = "No. of Deposit";
            // 
            // lblEncAc
            // 
            this.lblEncAc.AutoSize = true;
            this.lblEncAc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEncAc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncAc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncAc.Location = new System.Drawing.Point(553, 80);
            this.lblEncAc.Name = "lblEncAc";
            this.lblEncAc.Size = new System.Drawing.Size(152, 18);
            this.lblEncAc.TabIndex = 97;
            this.lblEncAc.Text = "Encashment A/C No.";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(407, 77);
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
            this.label9.Location = new System.Drawing.Point(302, 80);
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
            this.label8.Location = new System.Drawing.Point(15, 79);
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
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Transaction Type";
            // 
            // btnGenerateDPTrn
            // 
            this.btnGenerateDPTrn.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateDPTrn.Location = new System.Drawing.Point(536, 555);
            this.btnGenerateDPTrn.Name = "btnGenerateDPTrn";
            this.btnGenerateDPTrn.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateDPTrn.TabIndex = 91;
            this.btnGenerateDPTrn.Text = "Generate";
            this.btnGenerateDPTrn.UseVisualStyleBackColor = true;
            this.btnGenerateDPTrn.Click += new System.EventHandler(this.btnGenerateDPTrn_Click);
            // 
            // txtEncAcNo
            // 
            this.txtEncAcNo.Location = new System.Drawing.Point(704, 76);
            this.txtEncAcNo.Name = "txtEncAcNo";
            this.txtEncAcNo.Size = new System.Drawing.Size(97, 23);
            this.txtEncAcNo.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(326, 557);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 103;
            this.label17.Text = "Batch No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txttrnDes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtND);
            this.groupBox2.Controls.Add(this.trnDt);
            this.groupBox2.Controls.Add(this.cmbTrnTyp);
            this.groupBox2.Controls.Add(this.txtTrnamt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtEncAcNo);
            this.groupBox2.Controls.Add(this.lblEncAc);
            this.groupBox2.Controls.Add(this.txtVC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 180);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(449, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 12);
            this.label16.TabIndex = 107;
            this.label16.Text = "Press Enter after Input";
            // 
            // dtGridDPTrn
            // 
            this.dtGridDPTrn.AllowUserToAddRows = false;
            this.dtGridDPTrn.AllowUserToDeleteRows = false;
            this.dtGridDPTrn.BackgroundColor = System.Drawing.Color.White;
            this.dtGridDPTrn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridDPTrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDPTrn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridDPTrn.Location = new System.Drawing.Point(16, 375);
            this.dtGridDPTrn.Name = "dtGridDPTrn";
            this.dtGridDPTrn.ReadOnly = true;
            this.dtGridDPTrn.Size = new System.Drawing.Size(842, 166);
            this.dtGridDPTrn.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblRmPeriod);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblMnDep);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblTPeriod);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblIntr);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblOpnDt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblAcBal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblActitle);
            this.groupBox1.Controls.Add(this.txtAcno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 96);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(173, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 12);
            this.label5.TabIndex = 105;
            this.label5.Text = "Press Enter after input";
            // 
            // lblRmPeriod
            // 
            this.lblRmPeriod.AccessibleDescription = "  ";
            this.lblRmPeriod.AutoSize = true;
            this.lblRmPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRmPeriod.Location = new System.Drawing.Point(755, 66);
            this.lblRmPeriod.Name = "lblRmPeriod";
            this.lblRmPeriod.Size = new System.Drawing.Size(13, 20);
            this.lblRmPeriod.TabIndex = 100;
            this.lblRmPeriod.Text = " ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(610, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 99;
            this.label15.Text = "Remaining Period";
            // 
            // lblMnDep
            // 
            this.lblMnDep.AccessibleDescription = "  ";
            this.lblMnDep.AutoSize = true;
            this.lblMnDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnDep.Location = new System.Drawing.Point(748, 17);
            this.lblMnDep.Name = "lblMnDep";
            this.lblMnDep.Size = new System.Drawing.Size(13, 20);
            this.lblMnDep.TabIndex = 98;
            this.lblMnDep.Text = " ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(619, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 20);
            this.label18.TabIndex = 97;
            this.label18.Text = "Monthly Deposit";
            // 
            // lblTPeriod
            // 
            this.lblTPeriod.AccessibleDescription = "  ";
            this.lblTPeriod.AutoSize = true;
            this.lblTPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPeriod.Location = new System.Drawing.Point(754, 42);
            this.lblTPeriod.Name = "lblTPeriod";
            this.lblTPeriod.Size = new System.Drawing.Size(13, 20);
            this.lblTPeriod.TabIndex = 96;
            this.lblTPeriod.Text = " ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(628, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 95;
            this.label20.Text = "Total Period";
            // 
            // lblIntr
            // 
            this.lblIntr.AccessibleDescription = "  ";
            this.lblIntr.AutoSize = true;
            this.lblIntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntr.Location = new System.Drawing.Point(515, 62);
            this.lblIntr.Name = "lblIntr";
            this.lblIntr.Size = new System.Drawing.Size(13, 20);
            this.lblIntr.TabIndex = 94;
            this.lblIntr.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(335, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Interest Rate";
            // 
            // lblOpnDt
            // 
            this.lblOpnDt.AccessibleDescription = "  ";
            this.lblOpnDt.AutoSize = true;
            this.lblOpnDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpnDt.Location = new System.Drawing.Point(501, 15);
            this.lblOpnDt.Name = "lblOpnDt";
            this.lblOpnDt.Size = new System.Drawing.Size(0, 20);
            this.lblOpnDt.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(337, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Opening Date";
            // 
            // lblAcBal
            // 
            this.lblAcBal.AccessibleDescription = "  ";
            this.lblAcBal.AutoSize = true;
            this.lblAcBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBal.Location = new System.Drawing.Point(515, 38);
            this.lblAcBal.Name = "lblAcBal";
            this.lblAcBal.Size = new System.Drawing.Size(13, 20);
            this.lblAcBal.TabIndex = 90;
            this.lblAcBal.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(307, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Total Deposited Amount";
            // 
            // lblActitle
            // 
            this.lblActitle.AutoSize = true;
            this.lblActitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActitle.Location = new System.Drawing.Point(71, 59);
            this.lblActitle.Name = "lblActitle";
            this.lblActitle.Size = new System.Drawing.Size(13, 20);
            this.lblActitle.TabIndex = 86;
            this.lblActitle.Text = " ";
            // 
            // txtAcno
            // 
            this.txtAcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcno.Location = new System.Drawing.Point(70, 25);
            this.txtAcno.Name = "txtAcno";
            this.txtAcno.Size = new System.Drawing.Size(97, 26);
            this.txtAcno.TabIndex = 0;
            this.txtAcno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcno_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 84;
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
            this.bxtExit.TabIndex = 94;
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
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveDPtrn
            // 
            this.btnSaveDPtrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveDPtrn.Location = new System.Drawing.Point(274, 614);
            this.btnSaveDPtrn.Name = "btnSaveDPtrn";
            this.btnSaveDPtrn.Size = new System.Drawing.Size(102, 35);
            this.btnSaveDPtrn.TabIndex = 92;
            this.btnSaveDPtrn.Text = "Save";
            this.btnSaveDPtrn.UseVisualStyleBackColor = true;
            this.btnSaveDPtrn.Click += new System.EventHandler(this.btnSaveDPtrn_Click);
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
            this.label1.Location = new System.Drawing.Point(237, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 38);
            this.label1.TabIndex = 95;
            this.label1.Text = "Deposit Account Transaction";
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
            // frmDepTrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.txtBatno);
            this.Controls.Add(this.btnGenerateDPTrn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGridDPTrn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveDPtrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDepTrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Deposit Transaction";
            this.Load += new System.EventHandler(this.frmDepTrn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDPTrn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBatno;
        private System.Windows.Forms.TextBox txttrnDes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.DateTimePicker trnDt;
        private System.Windows.Forms.ComboBox cmbTrnTyp;
        private System.Windows.Forms.TextBox txtTrnamt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEncAc;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateDPTrn;
        private System.Windows.Forms.TextBox txtEncAcNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridDPTrn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAcBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblActitle;
        private System.Windows.Forms.TextBox txtAcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveDPtrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRmPeriod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMnDep;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTPeriod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblIntr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblOpnDt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
    }
}