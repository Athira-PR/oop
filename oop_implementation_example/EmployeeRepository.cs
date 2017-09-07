using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_implementation_example
{
    class EmployeeRepository
    {
        
        public List<Employee> get()
        {
            
                List<Employee> emp = new List<Employee>();
                int ch;

                Console.WriteLine("MENU");
                Console.WriteLine("-----");
                Console.WriteLine("1.PERMENENT");
                Console.WriteLine("2.TEMPORARY");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            int PFAccountNumber, NoOfLeaves, Pay;
                            string name;
                            Console.Write("Enter name:");
                            name = Console.ReadLine();
                            Console.Write("Enter PFAccountNumber:");
                            PFAccountNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter NoOfLeaves:");
                            NoOfLeaves = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Pay:");
                            Pay = Convert.ToInt32(Console.ReadLine());
                            PermenenetEmployee pe = new PermenenetEmployee(name, PFAccountNumber, NoOfLeaves, Pay);
                            emp.Add(pe);

                        }
                        break;
                    case 2:
                        {
                            int ContractDate, WagePerHour, HoursWorked, OT;
                            string name;
                            Console.Write("Enter name:");
                            name = Console.ReadLine();
                            Console.Write("Enter ContractDate:");
                            ContractDate = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter WagePerHour:");
                            WagePerHour = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter HoursWorked:");
                            HoursWorked = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter OT:");
                            OT = Convert.ToInt32(Console.ReadLine());
                            TemporaryEmployee te = new TemporaryEmployee(name, ContractDate, WagePerHour, HoursWorked, OT);
                            emp.Add(te);

                        }
                        break;

                }
           
            return emp;


        }
      }
}

