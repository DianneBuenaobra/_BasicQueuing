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
    public partial class CustomerView : Form
    {
        private CashierClass cashier = new CashierClass();
        public CustomerView()
        {
            InitializeComponent();
            timer1.Interval = (1 * 100);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cashier.serving();
            lblnowServing.Text = CashierClass.numServing;
            if (CashierClass.cashierQueue.Count == 0)
            {
                lblnowServing.Text = "        -";
            }
        }
    }
}
