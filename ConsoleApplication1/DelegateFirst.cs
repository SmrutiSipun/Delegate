using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int DelUtility(int x, int y);
    public delegate Boolean verifySal(Employee emp);
    class DelegateFirst
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { EmpId = 1001, EmpName = "Sipun", EmpSal = 6000});
            emplist.Add(new Employee { EmpId = 1002, EmpName = "Tapun", EmpSal = 3000 });
            emplist.Add(new Employee { EmpId = 1003, EmpName = "Bapun", EmpSal = 4000 });
            emplist.Add(new Employee { EmpId = 1004, EmpName = "Chickun", EmpSal = 5000 });
            //verifySal check = new verifySal(usercondition);


            utility.verifyEmployee(emplist,e => e.EmpId >= 1003);
            Console.ReadKey();
        }
        //public static Boolean usercondition(Employee emp)
        //{
        //    if (emp.EmpSal >= 5000)
        //        return true;
        //    else
        //        return false;
        //}
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSal { get; set; }
        
    }
    class utility
    {
        public static void verifyEmployee(List<Employee> empList,verifySal check)
        {
            foreach(Employee emp in empList)
            {
                if(check(emp))
                {
                    Console.WriteLine(emp.EmpName + " is eligible.");
                }
            }
        }
    }
}
