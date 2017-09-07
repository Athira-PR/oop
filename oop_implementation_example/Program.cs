using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_implementation_example
{
    class PayrollApp
    {
        static void Main(string[] args)
        {   
           

            EmployeeRepository emprep = new EmployeeRepository();
            List<Employee> emplist = emprep.get();
            Console.WriteLine("Report");
            Console.WriteLine("------");
            foreach (var item in emplist)
            {

                Console.WriteLine("{0}: {1}", item.Name ,item.CalculateSalary());
                
            }

            Console.ReadLine();

        }
    }
}
