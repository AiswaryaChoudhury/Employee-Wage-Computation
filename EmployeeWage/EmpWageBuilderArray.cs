using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWageBuilderArray
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
            
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
             //variables
            int empHrs = 0, totEmpHrs = 0, totWorkingDays = 0;
            //computation
            while (totEmpHrs <= companyEmpWage.maxHoursPerMonth &&
                 totWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totEmpHrs * companyEmpWage.empRatePerHour;
        }
       
    }
}
