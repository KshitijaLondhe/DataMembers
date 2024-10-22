using System;
/*Method Overloading
It is in single class
Multiple methods have the same name, but their parameters are different , so it is called method overloading.
No of parameters should be different
If no of parameters are same then data types should be different
If data types are same then , their sequence should be different 
It is for ease of development, as multiple method names need not to remember
Return type is not considered in method overloading 
C# compiler will identify method to invoke based on parameters that we will pass.
That is set at the time of compilation, there fore this is also called as  
compile time polymorphism, early binding / static binding 
*/

namespace DataMembers
{
    public class AdditionMethodOverloading
    {
        //Addition
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }

        public double Add(int a,double b)
        {
            return a + b;
        }
        public double Add(double a,int b)
        {
            return a + b;
        }
        public double Add(int a, float b)
        {
            return a + b;
        }
        public double Add(float a, int b)
        {
            return a + b;
        }
        public double Add(float a, double b)
        {
            return a + b;
        }

        //Substraction
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        public double Sub(int a, double b)
        {
            return a - b;
        }
        public double Sub(double a, int b)
        {
            return a - b;
        }
        public double Sub(int a, float b)
        {
            return a - b;
        }
        public double Sub(float a, int b)
        {
            return a - b;
        }
        public double Sub(float a, double b)
        {
            return a - b;
        }

        //Multiplication
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Mul(int a, double b)
        {
            return a * b;
        }
        public double Mul(double a, int b)
        {
            return a * b;
        }
        public double Mul(int a, float b)
        {
            return a * b;
        }
        public double Mul(float a, int b)
        {
            return a * b;
        }
        public double Mul(float a, double b)
        {
            return a * b;
        }

        //Division
        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Div(int a, int b, int c)
        {
            return a / b / c;
        }

        public double Div(int a, double b)
        {
            return a / b;
        }
        public double Div(double a, int b)
        {
            return a / b;
        }
        public double Div(int a, float b)
        {
            return a / b;
        }
        public double Div(float a, int b)
        {
            return a / b;
        }
        public double Div(float a, double b)
        {
            return a / b;
        }
    }
}
