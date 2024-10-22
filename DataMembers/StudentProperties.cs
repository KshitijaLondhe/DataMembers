using System;
/*Points to remember
Property can have either set or get accessor or both
We can add an access specifier either to set or get accessors. Not for both
We can add conditional statements with set & get
*/
namespace DataMembers
{
    public class StudentProperties
    {
        private int id;
        private string name;
        private int marks;
        
        public int Id
        {
            get { return id; }//retirieve the value
            set { id = value; }//assign the value
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

    }
}
