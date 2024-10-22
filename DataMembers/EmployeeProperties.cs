using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMembers
{
    public class EmployeeProperties
    {
        private int id;
        private string name;
        private double salary;

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
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
