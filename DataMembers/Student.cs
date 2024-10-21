using System;
/*1.
WAP to create a class Student, accept the rollno, name & 3 subjects marks from constructor, 
create a method to calculate total marks & percentage. Print the details of students.
*/

namespace DataMembers
{
    public class Student
    {
        private int id;
        private string name;
        private int m1, m2, m3;
        private double percentage;
        public Student(int sid, string sname,int m11,int m22,int m33)
        {
            id = sid;
            name = sname;
            m1 = m11;
            m2 = m22;
            m3 = m33;
        }

        public void CalculatePercentage()
        {
            int add = m1 + m2 + m3;
            percentage= (add * 100) / 300;
        }

        public string Print()
        {
            return $"Id :{id} Name :{name} Percentage :{percentage}";
        }
    }
}
