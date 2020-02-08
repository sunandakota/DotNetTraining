using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankComponent
{
    public class SavingsBank
    {
        double balance;

         public SavingsBank (double balance)
         {
             this.balance = balance;
         }
         
        public double balance
        {
            get;
        }

        //public int principleamount { get; set; }
        
        //public int time { get; set; }

        //public float rateofinterest { get; set; }

        public double Getsimpleintrest(double p,double t,double r)
        {
              var SI = (p * t * r) / 100;
               return SI ;
        }
        public double Getbalance()
        {
            return balance;
        }
    }
}
