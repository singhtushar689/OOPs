using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    public class Encapsulation
    {
        private int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }

            set { accountNumber = value; }
        }
    }
}
