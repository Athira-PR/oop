using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_implementation_example
{
    abstract class Employee
    {
        public string Name;
        public Employee(string _Name)
        {
            Name = _Name;
        }
        public abstract double CalculateSalary();
    }

    class PermenenetEmployee : Employee
    {
        int PFAccountNumber, NoOfLeaves, Pay;
        double salary;
        public PermenenetEmployee(string _Name,int PF_AccountNumber,int No_OfLeaves,int Emp_Pay):base(_Name)
        {
            PFAccountNumber = PF_AccountNumber;
            NoOfLeaves = No_OfLeaves;
            Pay = Emp_Pay;
        }
        public override double CalculateSalary()
        {
            salary = Pay * (30 - NoOfLeaves) / 30;
            return salary;

        }

    }
    class TemporaryEmployee : Employee
    {
        int ContractDate, WagePerHour, HoursWorked,OT;
        double salary;

        public TemporaryEmployee(string _Name, int Contract_Date, int WagePer_Hour, int Hours_Worked, int _OT):base(_Name)
        {
            ContractDate = Contract_Date;
            WagePerHour = WagePer_Hour;
            HoursWorked = Hours_Worked;
            OT = _OT;
        }
        public override double CalculateSalary()
        {

            salary = (HoursWorked + OT * 2) * WagePerHour;
            return salary;

        }

    }
}
