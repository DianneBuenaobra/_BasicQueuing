using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuing
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm frm = new CashierWindowQueueForm();
            CustomerView cview = new CustomerView();
            frm.Show(); cview.Show();
            cashier.serving();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            cashier.serving();
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberQueue = lblQueue.Text;
            CashierClass.cashierQueue.Enqueue(CashierClass.getNumberQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
