using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Person
    {
        public abstract string ID { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime DOB { get; set; }
        public abstract string Designation {get; set;}
        public abstract DateTime JoinDate { get; set; }
        public abstract int Basic { get; set; }

        public virtual string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public virtual string GetAge()
        {
            TimeSpan age = DateTime.Now - DOB;
            int years = age.Days / 365;
            int months = (age.Days % 365) / 30;
            int days = age.Days - ((years * 365) + (months * 30));
            return "Years : " + years.ToString() + " Months : " + 
                months.ToString() + " Days : " + days.ToString();
        }



    }
}
