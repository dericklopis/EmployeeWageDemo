using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWageDemo
    {
        static void Main(string[] args)
        {
            //master
            Console.WriteLine("Welcome to EmployeeWageDemo");
            //UC1
            int employeePresent = 1;
            Random r = new Random();
            int employeeImput = r.Next(0, 2);

            if (employeePresent == employeeImput)
            Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();
        }
    }
}
