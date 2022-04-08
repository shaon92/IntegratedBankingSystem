using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedBankingSystem
{
    public partial class frmMain : Form
    {
        frmCustomer customer = new frmCustomer();
        frmCustomerE customerE = new frmCustomerE();
        frmLogin lg = new frmLogin();
        frmSavings savings = new frmSavings();
        frmSavingsE savingsE = new frmSavingsE();
        frmSvtrn svtrn = new frmSvtrn();
        frmSvtrnD svtrnD = new frmSvtrnD();
        frmDeposit deposit = new frmDeposit();
        frmDepositE depositE = new frmDepositE();
        frmDepTrn dptrn = new frmDepTrn();
        frmDepTrnD dptrnD = new frmDepTrnD();
        frmLoanAssessment lnSA = new frmLoanAssessment();
        frmLoan loan = new frmLoan();
        frmLoanE loanE = new frmLoanE();
        frmLoanTrn lntrn = new frmLoanTrn();
        frmLoanTrnD lntrnD = new frmLoanTrnD();
        frmSvAcMnFee acmn = new frmSvAcMnFee();
        frmOthrExp oexp = new frmOthrExp();
        frmDOthrExp doexp = new frmDOthrExp();
        // frmProfLoss pl = new frmProfLoss();
        Report.plCR pl = new Report.plCR();

        public frmMain()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            lg.Show();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customer.IsDisposed)
                customer = new frmCustomer();
            customer.MdiParent = this;
            customer.Show();
            customer.BringToFront();
        }

        private void editExsistingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerE.IsDisposed)
                customerE = new frmCustomerE();
            customerE.MdiParent = this;
            customerE.Show();
            customerE.BringToFront();
        }

        private void addSavingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savings.IsDisposed)
                savings = new frmSavings();
            savings.MdiParent = this;
            savings.Show();
            savings.BringToFront();
        }

        private void editSavingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savingsE.IsDisposed)
                savingsE = new frmSavingsE();
            savingsE.MdiParent = this;
            savingsE.Show();
            savingsE.BringToFront();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svtrn.IsDisposed)
                svtrn = new frmSvtrn();
            svtrn.MdiParent = this;
            svtrn.Show();
            svtrn.BringToFront();
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svtrnD.IsDisposed)
                svtrnD = new frmSvtrnD();
            svtrnD.MdiParent = this;
            svtrnD.Show();
            svtrnD.BringToFront();
        }

        private void addDepositAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deposit.IsDisposed)
                deposit = new frmDeposit();
            deposit.MdiParent = this;
            deposit.Show();
            deposit.BringToFront();
        }

        private void editDepositAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (depositE.IsDisposed)
                depositE = new frmDepositE();
            depositE.MdiParent = this;
            depositE.Show();
            depositE.BringToFront();
        }

        private void addTransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dptrn.IsDisposed)
                dptrn = new frmDepTrn();
            dptrn.MdiParent = this;
            dptrn.Show();
            dptrn.BringToFront();
        }

        private void deleteTransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dptrnD.IsDisposed)
                dptrnD = new frmDepTrnD();
            dptrnD.MdiParent = this;
            dptrnD.Show();
            dptrnD.BringToFront();
        }

        private void loanSanctionAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lnSA.IsDisposed)
                lnSA = new frmLoanAssessment();
            lnSA.MdiParent = this;
            lnSA.Show();
            lnSA.BringToFront();
        }

        private void addLoanAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loan.IsDisposed)
                loan = new frmLoan();
            loan.MdiParent = this;
            loan.Show();
            loan.BringToFront();
        }

        private void editLoanAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loanE.IsDisposed)
                loanE = new frmLoanE();
            loanE.MdiParent = this;
            loanE.Show();
            loanE.BringToFront();
        }

        private void addTransactionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lntrn.IsDisposed)
                lntrn = new frmLoanTrn();
            lntrn.MdiParent = this;
            lntrn.Show();
            lntrn.BringToFront();
        }

        private void deleteTransactionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lntrnD.IsDisposed)
                lntrnD = new frmLoanTrnD();
            lntrnD.MdiParent = this;
            lntrnD.Show();
            lntrnD.BringToFront();
        }

        private void postFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acmn.IsDisposed)
                acmn = new frmSvAcMnFee();
            acmn.MdiParent = this;
            acmn.Show();
            acmn.BringToFront();
        }

        private void addExpenditureTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oexp.IsDisposed)
                oexp = new frmOthrExp();
            oexp.MdiParent = this;
            oexp.Show();
            oexp.BringToFront();
        }

        private void deleteExpenditureTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doexp.IsDisposed)
                doexp = new frmDOthrExp();
            doexp.MdiParent = this;
            doexp.Show();
            doexp.BringToFront();
        }

        private void profitLossCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   if (pl.IsDisposed)
                   pl = new frmProfLoss();
               pl.MdiParent = this;
               pl.Show();
               pl.BringToFront(); */

            if (pl.IsDisposed)
                pl = new Report.plCR();
            pl.MdiParent = this;
            pl.Show();
            pl.BringToFront(); 
        }
    }
}
