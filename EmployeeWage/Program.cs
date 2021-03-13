using System;

namespace EmployeeWage
{
    class Program
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static int computeEmpWage()
        {
            //variables
            int empHrs = 0, totEmpHrs = 0, totWorkingDays = 0;
            //computation
            while (totEmpHrs <= MAX_HRS_IN_MONTH &&
                 totWorkingDays < NUM_OF_WORKING_DAYS)
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
            int totEmpWage = totEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" Total Employee Wage : " + totEmpWage);
            return totEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}