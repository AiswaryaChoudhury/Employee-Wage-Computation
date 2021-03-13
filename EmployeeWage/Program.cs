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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            //variables
            int empHrs = 0, empWage = 0, totEmpWage = 0;
            //computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch ((int)empCheck)
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

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totEmpWage += empWage;
                Console.WriteLine(" Employee Wage UC5    : " + empWage);

            }
            Console.WriteLine(" Total Employee Wage : " + totEmpWage);
        }
    }
}