namespace IntegratedBankingSystem
{
    partial class frmSvAcMnFee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bxtExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnlSvAcMn = new System.Windows.Forms.Button();
            this.dtGridMnTrn = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnDelMn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMnTrn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(16, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 5);
            this.label2.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "Savings Account Maintenance Fee";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(603, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(690, 5);
            this.label3.TabIndex = 104;
            // 
            // bxtExit
            // 
            this.bxtExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bxtExit.Location = new System.Drawing.Point(463, 521);
            this.bxtExit.Name = "bxtExit";
            this.bxtExit.Size = new System.Drawing.Size(85, 27);
            this.bxtExit.TabIndex = 107;
            this.bxtExit.Text = "Exit";
            this.bxtExit.UseVisualStyleBackColor = true;
            this.bxtExit.Click += new System.EventHandler(this.bxtExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(351, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 27);
            this.btnCancel.TabIndex = 106;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnlSvAcMn
            // 
            this.btnlSvAcMn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlSvAcMn.Location = new System.Drawing.Point(132, 521);
            this.btnlSvAcMn.Name = "btnlSvAcMn";
            this.btnlSvAcMn.Size = new System.Drawing.Size(85, 27);
            this.btnlSvAcMn.TabIndex = 105;
            this.btnlSvAcMn.Text = "Process";
            this.btnlSvAcMn.UseVisualStyleBackColor = true;
            this.btnlSvAcMn.Click += new System.EventHandler(this.btnlSvAcMn_Click);
            // 
            // dtGridMnTrn
            // 
            this.dtGridMnTrn.AllowUserToAddRows = false;
            this.dtGridMnTrn.AllowUserToDeleteRows = false;
            this.dtGridMnTrn.BackgroundColor = System.Drawing.Color.White;
            this.dtGridMnTrn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridMnTrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMnTrn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridMnTrn.Location = new System.Drawing.Point(148, 247);
            this.dtGridMnTrn.Name = "dtGridMnTrn";
            this.dtGridMnTrn.ReadOnly = true;
            this.dtGridMnTrn.RowHeadersWidth = 61;
            this.dtGridMnTrn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGridMnTrn.Size = new System.Drawing.Size(370, 212);
            this.dtGridMnTrn.TabIndex = 108;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGridTitle.Location = new System.Drawing.Point(150, 222);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(0, 19);
            this.lblGridTitle.TabIndex = 109;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(271, 144);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(120, 26);
            this.txtYear.TabIndex = 110;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelMn
            // 
            this.btnDelMn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelMn.Location = new System.Drawing.Point(244, 521);
            this.btnDelMn.Name = "btnDelMn";
            this.btnDelMn.Size = new System.Drawing.Size(85, 27);
            this.btnDelMn.TabIndex = 111;
            this.btnDelMn.Text = "Delete";
            this.btnDelMn.UseVisualStyleBackColor = true;
            this.btnDelMn.Click += new System.EventHandler(this.btnDelMn_Click);
            // 
            // frmSvAcMnFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnDelMn);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.dtGridMnTrn);
            this.Controls.Add(this.bxtExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnlSvAcMn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSvAcMnFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account Maintenance Fee";
            this.Load += new System.EventHandler(this.frmSvAcMnFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMnTrn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bxtExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnlSvAcMn;
        private System.Windows.Forms.DataGridView dtGridMnTrn;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnDelMn;
    }
}