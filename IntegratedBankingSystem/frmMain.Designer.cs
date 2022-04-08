namespace IntegratedBankingSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExsistingCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingAccountOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSavingsAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSavingsAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositAccountOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepositAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDepositAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanAccountOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanSanctionAssessmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoanAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLoanAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingsAccountTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositAccountTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loanAccountTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherExpenditureTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenditureTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExpenditureTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRelatedSpecialFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCMaintenanceFeePostingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postFeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitLossCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpeningToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.accountRelatedSpecialFunctionsToolStripMenuItem,
            this.calculationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileOpeningToolStripMenuItem
            // 
            this.fileOpeningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationToolStripMenuItem,
            this.savingAccountOpeningToolStripMenuItem,
            this.depositAccountOpeningToolStripMenuItem,
            this.loanAccountOpeningToolStripMenuItem});
            this.fileOpeningToolStripMenuItem.Name = "fileOpeningToolStripMenuItem";
            this.fileOpeningToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.fileOpeningToolStripMenuItem.Text = "File Opening";
            // 
            // customerRegistrationToolStripMenuItem
            // 
            this.customerRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.editExsistingCustomerToolStripMenuItem});
            this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
            this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.customerRegistrationToolStripMenuItem.Text = "Customer Registration";
            this.customerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // editExsistingCustomerToolStripMenuItem
            // 
            this.editExsistingCustomerToolStripMenuItem.Name = "editExsistingCustomerToolStripMenuItem";
            this.editExsistingCustomerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editExsistingCustomerToolStripMenuItem.Text = "Edit Existing Customer";
            this.editExsistingCustomerToolStripMenuItem.Click += new System.EventHandler(this.editExsistingCustomerToolStripMenuItem_Click);
            // 
            // savingAccountOpeningToolStripMenuItem
            // 
            this.savingAccountOpeningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSavingsAccountToolStripMenuItem,
            this.editSavingsAccountToolStripMenuItem});
            this.savingAccountOpeningToolStripMenuItem.Name = "savingAccountOpeningToolStripMenuItem";
            this.savingAccountOpeningToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.savingAccountOpeningToolStripMenuItem.Text = "Saving Account Opening";
            // 
            // addSavingsAccountToolStripMenuItem
            // 
            this.addSavingsAccountToolStripMenuItem.Name = "addSavingsAccountToolStripMenuItem";
            this.addSavingsAccountToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addSavingsAccountToolStripMenuItem.Text = "Add Savings Account";
            this.addSavingsAccountToolStripMenuItem.Click += new System.EventHandler(this.addSavingsAccountToolStripMenuItem_Click);
            // 
            // editSavingsAccountToolStripMenuItem
            // 
            this.editSavingsAccountToolStripMenuItem.Name = "editSavingsAccountToolStripMenuItem";
            this.editSavingsAccountToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editSavingsAccountToolStripMenuItem.Text = "Edit Savings Account";
            this.editSavingsAccountToolStripMenuItem.Click += new System.EventHandler(this.editSavingsAccountToolStripMenuItem_Click);
            // 
            // depositAccountOpeningToolStripMenuItem
            // 
            this.depositAccountOpeningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepositAccountToolStripMenuItem,
            this.editDepositAccountToolStripMenuItem});
            this.depositAccountOpeningToolStripMenuItem.Name = "depositAccountOpeningToolStripMenuItem";
            this.depositAccountOpeningToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.depositAccountOpeningToolStripMenuItem.Text = "Deposit Account Opening";
            // 
            // addDepositAccountToolStripMenuItem
            // 
            this.addDepositAccountToolStripMenuItem.Name = "addDepositAccountToolStripMenuItem";
            this.addDepositAccountToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addDepositAccountToolStripMenuItem.Text = "Add Deposit Account";
            this.addDepositAccountToolStripMenuItem.Click += new System.EventHandler(this.addDepositAccountToolStripMenuItem_Click);
            // 
            // editDepositAccountToolStripMenuItem
            // 
            this.editDepositAccountToolStripMenuItem.Name = "editDepositAccountToolStripMenuItem";
            this.editDepositAccountToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editDepositAccountToolStripMenuItem.Text = "Edit Deposit Account";
            this.editDepositAccountToolStripMenuItem.Click += new System.EventHandler(this.editDepositAccountToolStripMenuItem_Click);
            // 
            // loanAccountOpeningToolStripMenuItem
            // 
            this.loanAccountOpeningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanSanctionAssessmentToolStripMenuItem,
            this.addLoanAccountToolStripMenuItem,
            this.editLoanAccountToolStripMenuItem});
            this.loanAccountOpeningToolStripMenuItem.Name = "loanAccountOpeningToolStripMenuItem";
            this.loanAccountOpeningToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.loanAccountOpeningToolStripMenuItem.Text = "Loan Account Opening";
            // 
            // loanSanctionAssessmentToolStripMenuItem
            // 
            this.loanSanctionAssessmentToolStripMenuItem.Name = "loanSanctionAssessmentToolStripMenuItem";
            this.loanSanctionAssessmentToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.loanSanctionAssessmentToolStripMenuItem.Text = "Loan Sanction Assessment";
            this.loanSanctionAssessmentToolStripMenuItem.Click += new System.EventHandler(this.loanSanctionAssessmentToolStripMenuItem_Click);
            // 
            // addLoanAccountToolStripMenuItem
            // 
            this.addLoanAccountToolStripMenuItem.Name = "addLoanAccountToolStripMenuItem";
            this.addLoanAccountToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addLoanAccountToolStripMenuItem.Text = "Add Loan Account";
            this.addLoanAccountToolStripMenuItem.Click += new System.EventHandler(this.addLoanAccountToolStripMenuItem_Click);
            // 
            // editLoanAccountToolStripMenuItem
            // 
            this.editLoanAccountToolStripMenuItem.Name = "editLoanAccountToolStripMenuItem";
            this.editLoanAccountToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editLoanAccountToolStripMenuItem.Text = "Edit Loan Account";
            this.editLoanAccountToolStripMenuItem.Click += new System.EventHandler(this.editLoanAccountToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingsAccountTransactionToolStripMenuItem,
            this.depositAccountTransactionToolStripMenuItem,
            this.loanAccountTransactionToolStripMenuItem,
            this.otherExpenditureTransactionToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // savingsAccountTransactionToolStripMenuItem
            // 
            this.savingsAccountTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.deleteTransactionToolStripMenuItem});
            this.savingsAccountTransactionToolStripMenuItem.Name = "savingsAccountTransactionToolStripMenuItem";
            this.savingsAccountTransactionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.savingsAccountTransactionToolStripMenuItem.Text = "Savings Account Transaction";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem_Click);
            // 
            // depositAccountTransactionToolStripMenuItem
            // 
            this.depositAccountTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem1,
            this.deleteTransactionToolStripMenuItem1});
            this.depositAccountTransactionToolStripMenuItem.Name = "depositAccountTransactionToolStripMenuItem";
            this.depositAccountTransactionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.depositAccountTransactionToolStripMenuItem.Text = "Deposit Account Transaction";
            // 
            // addTransactionToolStripMenuItem1
            // 
            this.addTransactionToolStripMenuItem1.Name = "addTransactionToolStripMenuItem1";
            this.addTransactionToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.addTransactionToolStripMenuItem1.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem1.Click += new System.EventHandler(this.addTransactionToolStripMenuItem1_Click);
            // 
            // deleteTransactionToolStripMenuItem1
            // 
            this.deleteTransactionToolStripMenuItem1.Name = "deleteTransactionToolStripMenuItem1";
            this.deleteTransactionToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.deleteTransactionToolStripMenuItem1.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem1.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem1_Click);
            // 
            // loanAccountTransactionToolStripMenuItem
            // 
            this.loanAccountTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem2,
            this.deleteTransactionToolStripMenuItem2});
            this.loanAccountTransactionToolStripMenuItem.Name = "loanAccountTransactionToolStripMenuItem";
            this.loanAccountTransactionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.loanAccountTransactionToolStripMenuItem.Text = "Loan Account Transaction";
            // 
            // addTransactionToolStripMenuItem2
            // 
            this.addTransactionToolStripMenuItem2.Name = "addTransactionToolStripMenuItem2";
            this.addTransactionToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.addTransactionToolStripMenuItem2.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem2.Click += new System.EventHandler(this.addTransactionToolStripMenuItem2_Click);
            // 
            // deleteTransactionToolStripMenuItem2
            // 
            this.deleteTransactionToolStripMenuItem2.Name = "deleteTransactionToolStripMenuItem2";
            this.deleteTransactionToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.deleteTransactionToolStripMenuItem2.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem2.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem2_Click);
            // 
            // otherExpenditureTransactionToolStripMenuItem
            // 
            this.otherExpenditureTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenditureTransactionToolStripMenuItem,
            this.deleteExpenditureTransactionToolStripMenuItem});
            this.otherExpenditureTransactionToolStripMenuItem.Name = "otherExpenditureTransactionToolStripMenuItem";
            this.otherExpenditureTransactionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.otherExpenditureTransactionToolStripMenuItem.Text = "Other Expenditure Transaction";
            // 
            // addExpenditureTransactionToolStripMenuItem
            // 
            this.addExpenditureTransactionToolStripMenuItem.Name = "addExpenditureTransactionToolStripMenuItem";
            this.addExpenditureTransactionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addExpenditureTransactionToolStripMenuItem.Text = "Add Expenditure Transaction";
            this.addExpenditureTransactionToolStripMenuItem.Click += new System.EventHandler(this.addExpenditureTransactionToolStripMenuItem_Click);
            // 
            // deleteExpenditureTransactionToolStripMenuItem
            // 
            this.deleteExpenditureTransactionToolStripMenuItem.Name = "deleteExpenditureTransactionToolStripMenuItem";
            this.deleteExpenditureTransactionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.deleteExpenditureTransactionToolStripMenuItem.Text = "Delete Expenditure Transaction";
            this.deleteExpenditureTransactionToolStripMenuItem.Click += new System.EventHandler(this.deleteExpenditureTransactionToolStripMenuItem_Click);
            // 
            // accountRelatedSpecialFunctionsToolStripMenuItem
            // 
            this.accountRelatedSpecialFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountBalanceToolStripMenuItem,
            this.aCMaintenanceFeePostingToolStripMenuItem});
            this.accountRelatedSpecialFunctionsToolStripMenuItem.Name = "accountRelatedSpecialFunctionsToolStripMenuItem";
            this.accountRelatedSpecialFunctionsToolStripMenuItem.Size = new System.Drawing.Size(201, 20);
            this.accountRelatedSpecialFunctionsToolStripMenuItem.Text = "Account Related Special Functions";
            // 
            // accountBalanceToolStripMenuItem
            // 
            this.accountBalanceToolStripMenuItem.Name = "accountBalanceToolStripMenuItem";
            this.accountBalanceToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.accountBalanceToolStripMenuItem.Text = "Account Balance";
            // 
            // aCMaintenanceFeePostingToolStripMenuItem
            // 
            this.aCMaintenanceFeePostingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postFeeToolStripMenuItem});
            this.aCMaintenanceFeePostingToolStripMenuItem.Name = "aCMaintenanceFeePostingToolStripMenuItem";
            this.aCMaintenanceFeePostingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.aCMaintenanceFeePostingToolStripMenuItem.Text = "A/C Maintenance Fee Posting";
            // 
            // postFeeToolStripMenuItem
            // 
            this.postFeeToolStripMenuItem.Name = "postFeeToolStripMenuItem";
            this.postFeeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.postFeeToolStripMenuItem.Text = "Post / Delete fee";
            this.postFeeToolStripMenuItem.Click += new System.EventHandler(this.postFeeToolStripMenuItem_Click);
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profitLossCalculationToolStripMenuItem});
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.calculationToolStripMenuItem.Text = "Calculation";
            // 
            // profitLossCalculationToolStripMenuItem
            // 
            this.profitLossCalculationToolStripMenuItem.Name = "profitLossCalculationToolStripMenuItem";
            this.profitLossCalculationToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.profitLossCalculationToolStripMenuItem.Text = "Profit/Loss Calculation";
            this.profitLossCalculationToolStripMenuItem.Click += new System.EventHandler(this.profitLossCalculationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 645);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrated Banking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingAccountOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositAccountOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanAccountOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountRelatedSpecialFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCMaintenanceFeePostingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postFeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingsAccountTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositAccountTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loanAccountTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem calculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitLossCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExsistingCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSavingsAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSavingsAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepositAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDepositAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanSanctionAssessmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLoanAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLoanAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherExpenditureTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenditureTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExpenditureTransactionToolStripMenuItem;
    }
}