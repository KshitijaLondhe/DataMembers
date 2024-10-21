using System;
// Object is the super base class for all the classes in C#


namespace DataMembers
{
    public class Date
    {
        //declare data members
        private int day, year;
        private string month;

        //method for assigning values to data members
        public void AcceptDate(int dd, string mm, int yy) 
        {
            day = dd;
            month =mm;
            year = yy;
        }

        // return the date to main method
        public string DisplayDate() 
        {
            return $"Date : {day}/{month}/{year}";
        }
    }
}
