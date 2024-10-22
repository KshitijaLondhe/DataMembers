using System;
/*Static variable
Static variable is also called as class variable
The value is common/ shared for all the objects of a  class, will be managed by static variable
Single copy is created & shared with all the objects of that class
Static will be assigned once in a program execution
Default value for static is zero 
If we want to assign a value to the static data, in C# we can use static constructor
*/
//static variable rules
// 1. it does not have access specifier
// 2. this constructor calles only once, for the first object creatation. first static 
// constructor get executed & then rest other constructor get executed.
//3. can not have parameters to static constructor in C#

namespace DataMembers
{
    public class StaticStudent
    {
        private int id;
        private string name;
        private int marks;
        private static int count;

        static StaticStudent()
        {
            count = 0;
        }

        //constructor
        public StaticStudent(string nm, int mk)
        {
            count++;
            id = count;
            name = nm;
            marks = mk;
        }
        
        // display emp details
        public string Print()
        {
            return $"Id:{id} Name:{name} Marks:{marks}";
        }
        
        // static method
        public static int StudentCount()
        {
            return count;
        }






    }
}
