using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWageBuilderObject
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totEmpHrs = 0, totWorkingDays = 0;
            //computation
            while (totEmpHrs <= this.maxHoursPerMonth &&
                 totWorkingDays < this.numOfWorkingDays)
            {
                totWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totEmpHrs += empHrs;
                Console.WriteLine("Day# :" + totWorkingDays + "    Employee hours: " + empHrs);

            }
            int totEmpWage = totEmpHrs * empRatePerHour;
            Console.WriteLine(" Total Employee Wage for company  : " + company + " is :" + totEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company: " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
