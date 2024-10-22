using System;


namespace DataMembers
{
    public class DateProperties
    {
        // declare data members
        private int day, year;
        private string month;
        
        // properties for each data member
        // Day is a property name

        public int Day
        {
            set { day = value; }  // assign the value
            get { return day; } // retrieve the value
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
}
