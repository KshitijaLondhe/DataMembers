using System;
/*We can create Auto implemented property 
If we are using auto implemented property, 
then we don't have to use variables in the class, 
variables are created internally by the property.
*/
namespace DataMembers
{
    public class DateAutoProperties
    {
        //auto implemented properties
        public int Day { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
    }
}
