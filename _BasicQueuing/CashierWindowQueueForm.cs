using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BasicQueuing
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            timer1.Interval = (1 * 100);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.cashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.cashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.cashierQueue.Count > 0)
            {
                DisplayCashierQueue(CashierClass.cashierQueue.Dequeue());
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No queue", "Attention", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

    }
}
