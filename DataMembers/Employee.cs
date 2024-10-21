using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DataMembers
{
    public class Employee
    {
        //data members
        private int id;
        private string name;
        private double basic, hra, da, pf, gross;

        //method to accept the data
        public void AcceptData(int eid, string nm, double bs)
        {
            id = eid;
            name = nm;
            basic = bs;
        }

        //calculate emp salary
        public void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic+hra + da)-pf;
        }

        //display emp details
        public string Print() 
        {
            return $"{id} {name} {gross}";
        }
    }
}
