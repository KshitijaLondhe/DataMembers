using System;


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
