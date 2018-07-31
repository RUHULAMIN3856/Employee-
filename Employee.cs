using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Employee : Person, IRole, IOvertime
    {

       public override string ID { get; set; }
        
        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override DateTime DOB { get; set; }

        public override string Designation { get; set; }

        public override DateTime JoinDate { get; set; }
        public override int Basic { get; set; }

       public Employee(string id, string firstName, string lastName, 
           DateTime dob, int designation, DateTime joinDate, int basic)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dob;
            this.Designation = Enum.GetName(typeof(Designation), designation);
            this.JoinDate = joinDate;
            this.Basic = basic;
        }

       
       public string[] GetRole(string role)
       {
           var roles = role.Split(',');
           return roles;
       }

       public int GetOverTime()
       {
           int GrossSalary = (Basic / 720) * 2;
           return GrossSalary;
       }
       public int GetHouseRent()
       {
           int houseRent = (Basic * 25) / 100;
           return houseRent;
       }

       public int GetMedical()
       {
           int medical = (Basic * 10) / 100;
           return medical;
       }
       public int GetConvence()
       {
           int convence = (Basic * 5) / 100;
           return convence;
       }

       
    }
}
