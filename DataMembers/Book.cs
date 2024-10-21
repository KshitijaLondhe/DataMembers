using System;
/*4. Create Book class, add bid, name,price, author. 
 * Accept the details & display using constructor
 */
namespace DataMembers
{
    public class Book
    {
        private int bid;
        private string bname;
        private double bprice;
        private string bauthor;

        public Book(int id,string name,double price,string author)
        {
            bid = id;
            bname = name;
            bprice = price;
            bauthor = author;
            Console.WriteLine("Book Id :"+bid+" Book Name:"+bname+" Book Price :"+bprice+" Book Author :"+bauthor);
        }
        //public string Display()
        //{
        //    return $"Book Id :{bid} Book Name:{bname} Book Price:{bprice} Book Author:{bauthor}";
        //}
    }
}
