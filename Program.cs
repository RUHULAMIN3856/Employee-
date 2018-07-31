using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nImployees Information Entry GUI :\n=============\n");
            Console.Write("\nEnter ID :  ");
            string id = Console.ReadLine();

            Console.Write("Enter First Name : ");
            string fName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            string lName = Console.ReadLine();

            Console.Write("Enter Date of Birth (dd/mm/yyyy) : ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.Write("List of Designation :\n-------------\n");
            Console.Write("1. GM\n2. DGM\n3. AGM\n4. SM\n5. Manage\n6. Executive\n7. Assignment\n");
            Console.Write("\nEnter Designation(Only Input Serial Number) : ");
            int designation = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Date of Joining (dd/mm/yyyy) : ");
            DateTime joinDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Roles(seperate by comma) : ");
            string role = Console.ReadLine();

            Console.Write("Enter Basic Salary : ");
            int bSalary = int.Parse( Console.ReadLine());

            Employee em = new Employee(id, fName, lName, dob, designation, joinDate, bSalary);
            string[] roles = em.GetRole(role);

            Console.Clear();

            Console.Write("ID : " + em.ID + "\nName :" + em.GetFullName() + "\nAge :" 
                + em.GetAge() + "\nDesignation : " + em.Designation
                          + "\nJoin Date : " + em.JoinDate.ToShortDateString()+"\n");


            for (int i = 0; i < roles.Length; i++)
            {
                Console.WriteLine("{0}.  {1}\n", i + 1, roles[i]); ;
            }
             
            Console.Write("Basic Salary : " + em.Basic + "\nHouse Rent : " + em.GetHouseRent() 
                + "\nMedical : " + em.GetMedical() + "\nConvence : " + em.GetConvence()
                         + "\nOver Time : " + em.GetOverTime() + "\n");

           
            Console.WriteLine("Gross Salary :{0} ", em.Basic + em.GetHouseRent() + em.GetMedical() 
                + em.GetConvence() + em.GetOverTime());

            Console.Read();
        }
    }
}
