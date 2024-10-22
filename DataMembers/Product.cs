using System;
/*3. Create Product class, add code, name, price . Accept product details, 
     if price >1000 give 10 % discount on product . & display discounted price.
*/

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
