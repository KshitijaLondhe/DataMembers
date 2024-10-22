using System;

namespace DataMembers
{
    public class ProductProperties
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
