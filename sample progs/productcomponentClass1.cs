using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcomponent
{
    public class product
    {
      public int productid { get; set; }
        
        public string productname { get; set; }

        public int productprice { get; set; }

        public double GetPrice(int n,int sp)
        {
            var Price = n * sp;
            return Price;
        }

    }
    
}
