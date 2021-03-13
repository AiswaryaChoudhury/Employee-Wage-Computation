using System;

namespace EmployeeWage
{
    class Program
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company,int empRatePerHour, int numOfWorkingDays,int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0, totEmpHrs = 0, totWorkingDays = 0;
            //computation
            while (totEmpHrs <= maxHoursPerMonth &&
                 totWorkingDays < numOfWorkingDays)
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
            Console.WriteLine(" Total Employee Wage for company  : " +company+"is :"+ totEmpWage);
            return totEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart",20,2,10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}