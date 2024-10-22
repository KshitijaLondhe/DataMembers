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

            //Book b = new Book(111, "Mahabharat", 1500, "Valmiki");
            //Console.WriteLine(b.Display());

            //Code For Properties

            /*// Property initializer syntax
            DateProperties d1 = new DateProperties();
            d1.Day = 22;   // internally C# calls the set assessor
            d1.Month = "Oct";
            d1.Year = 2024;
            // internally C# calls the get assessor
            Console.WriteLine("Date Details :");
            Console.WriteLine($"Date is {d1.Day}/ {d1.Month} / {d1.Year}");

            // object initializer syntax

            DateProperties d2 = new DateProperties { Day = 23, Month = "Sept", Year = 2024 };
            Console.WriteLine($"Date is {d2.Day}/ {d2.Month} / {d2.Year}");
            Console.WriteLine();

            // Property initializer syntax
            StudentProperties s1 = new StudentProperties();
            // whenever we assign value to data members internally C# calls the set accessor

            s1.Id = 101;
            s1.Name = "Kshitija";
            s1.Marks = 85;

            // internally C# calls the get accessor
            Console.WriteLine("Student Details :");
            Console.WriteLine($"Id:{s1.Id} Name:{s1.Name} Marks:{s1.Marks}");

            // object initializer syntax
            //() are optional
            StudentProperties s2 = new StudentProperties() {Id=102,Name="Raj",Marks=90 };
            Console.WriteLine($"Id:{s2.Id} Name:{s2.Name} Marks:{s2.Marks}");

            StudentProperties s3 = new StudentProperties{ Id = 103, Name = "Viraj", Marks = 70 };
            Console.WriteLine($"Id:{s3.Id} Name:{s3.Name} Marks:{s3.Marks}");
            Console.WriteLine();
    
            // Property initializer syntax
            ProductProperties p1 = new ProductProperties();
            p1.Id = 111;
            p1.Name = "Laptop";
            p1.Price = 45000;

            Console.WriteLine("Product Details:");
            Console.WriteLine($"Id:{p1.Id} Name:{p1.Name} Price:{p1.Price}");

            // object initializer syntax
            ProductProperties p2 = new ProductProperties {Id=112,Name="Mobile",Price=30000 };
            Console.WriteLine($"Id:{p2.Id} Name:{p2.Name} Price:{p2.Price}");
            Console.WriteLine();

            // Property initializer syntax
            BookProperties b1 = new BookProperties();
            b1.Id = 1;
            b1.Name = "Mahabharat";
            b1.Price = 5000;

            Console.WriteLine("Book Details:");
            Console.WriteLine($"Id:{b1.Id} Name:{b1.Name} Price:{b1.Price}");

            // object initializer syntax
            BookProperties b2 = new BookProperties { Id = 2, Name = "Ramayan", Price = 4000 };
            Console.WriteLine($"Id:{b2.Id} Name:{b2.Name} Price:{b2.Price}");
            Console.WriteLine();

            // Property initializer syntax
            EmployeeProperties e1 = new EmployeeProperties();
            e1.Id = 201;
            e1.Name = "Rohit";
            e1.Salary = 55000;

            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Id:{e1.Id} Name:{e1.Name} Price:{e1.Salary}");

            // object initializer syntax
            EmployeeProperties e2 = new EmployeeProperties { Id = 202, Name = "Ramayan", Salary = 46000 };
            Console.WriteLine($"Id:{e2.Id} Name:{e2.Name} Salary:{e2.Salary}");
            Console.WriteLine();*/

            /*//code For static members
            StaticStudent ss1 = new StaticStudent("Kritika",75);
            StaticStudent ss2 = new StaticStudent("Vedang", 85);
            StaticStudent ss3 = new StaticStudent("Harsh", 80); 

            Console.WriteLine(ss1.Print());
            Console.WriteLine(ss2.Print());
            Console.WriteLine(ss3.Print());

            // static method is a class method , always we will call using class name
            Console.WriteLine("Total objects " + StaticStudent.StudentCount());
            */

            //Code For Method Overloading
            AdditionMethodOverloading am = new AdditionMethodOverloading();
            //Addition
            Console.WriteLine("Addition:"+am.Add(10, 20));
            Console.WriteLine("Addition:" + am.Add(10.05, 20));
            Console.WriteLine("Addition:" + am.Add(10, 20.05));
            Console.WriteLine("Addition:" + am.Add(10.5f, 20));
            Console.WriteLine("Addition:" + am.Add(10, 20.5f));
            Console.WriteLine("Addition:" + am.Add(20.5f,20.5));
            Console.WriteLine();

            //Substraction
            Console.WriteLine("Substraction:" + am.Sub(30, 20));
            Console.WriteLine("Substraction:" + am.Sub(50.05, 20));
            Console.WriteLine("Substraction:" + am.Sub(30, 20.05));
            Console.WriteLine("Substraction:" + am.Sub(30.5f, 20));
            Console.WriteLine("Substraction:" + am.Sub(50, 20.5f));
            Console.WriteLine("Substraction:" + am.Add(30.5f, 20.5));
            Console.WriteLine();

            //Multiplication
            Console.WriteLine("Multiplication:" + am.Mul(10, 20));
            Console.WriteLine("Multiplication:" + am.Mul(10.05, 20));
            Console.WriteLine("Multiplication:" + am.Mul(10, 20.05));
            Console.WriteLine("Multiplication:" + am.Mul(10.5f, 20));
            Console.WriteLine("Multiplication:" + am.Mul(10, 20.5f));
            Console.WriteLine("Multiplication:" + am.Mul(20.5f, 20.5));
            Console.WriteLine();

            //Division
            Console.WriteLine("Division:" + am.Div(30, 20));
            Console.WriteLine("Division:" + am.Div(50.05, 20));
            Console.WriteLine("Division:" + am.Div(30, 20.05));
            Console.WriteLine("Division:" + am.Div(30.5f, 20));
            Console.WriteLine("Division:" + am.Div(50, 20.5f));
            Console.WriteLine("Division:" + am.Div(30.5f, 20.5));
            Console.WriteLine();



        }
    }
}
