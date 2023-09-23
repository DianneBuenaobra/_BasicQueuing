using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuing
{
    internal class CashierClass
    {
        private int x;
        public static string getNumberQueue = "";
        public static string numServing = "        -";
        public static Queue<string> cashierQueue;

        public CashierClass()
        {
            x = 10000;
            cashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
        public void serving()
        {
            if (cashierQueue.Count > 0)
            {
                numServing = cashierQueue.Peek();
            }
        }


    }
}
