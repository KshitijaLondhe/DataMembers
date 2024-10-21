using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMembers
{
    public class Product
    {
        private int code;
        private string name;
        private double price;
        public Product(int cd,string nm,double pe)
        {
            code = cd;
            name = nm;
            price = pe;
        }

        public string Discount()
        {
            if (price > 1000)
            {
                price = price - (price * 0.10);
            }

            return $"Code:{code} Name:{name} Price:{price}";
        }
    }
}
