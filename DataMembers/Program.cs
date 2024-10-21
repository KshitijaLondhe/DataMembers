using System;
/*3. Create Product class, add code, name, price . 
     Accept product details, if price >1000 give 10 % discount on product 
     & display discounted price.
*/
namespace DataMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // create object of class
             Date date = new Date();
             date.AcceptDate(21, "Oct", 2024);

             //option 1
             //string result = date.DisplayDate();
             //Console.WriteLine(result);

             //option 2
             Console.WriteLine(date.DisplayDate());
            */

            /* Employee emp1 = new Employee();
               emp1.AcceptData(101, "raj", 15000);
               emp1.CalculateSalary();
               Console.WriteLine(emp1.Print());*/

            /*Student s1 = new Student(101, "Kshitija", 86, 95, 76);
              s1.CalculatePercentage();
              Console.WriteLine(s1.Print());*/

            /*Bank b = new Bank(1000);
              b.deposit(500);
              b.withdraw(300);
              Console.WriteLine(b.display());*/

            /*Product p = new Product(101, "Headphones", 1200);
            Console.WriteLine(p.Discount());*/

            Book b = new Book(111, "Mahabharat", 1500, "Valmiki");
            //Console.WriteLine(b.Display());


        }
    }
}
