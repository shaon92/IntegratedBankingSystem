namespace IntegratedBankingSystem.Report
{
    partial class plCR
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
            this.plRptV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plRptV
            // 
            this.plRptV.ActiveViewIndex = -1;
            this.plRptV.AutoSize = true;
            this.plRptV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plRptV.Cursor = System.Windows.Forms.Cursors.Default;
            this.plRptV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plRptV.Location = new System.Drawing.Point(0, 0);
            this.plRptV.Name = "plRptV";
            this.plRptV.Size = new System.Drawing.Size(884, 666);
            this.plRptV.TabIndex = 2;
            this.plRptV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.plRptV.Load += new System.EventHandler(this.plRptV_Load);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(510, 7);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(616, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(69, 22);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // plCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.plRptV);
            this.MinimizeBox = false;
            this.Name = "plCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Loss Report";
            this.Load += new System.EventHandler(this.plCR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer plRptV;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnView;
    }
}