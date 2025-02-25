﻿using System;
namespace employeewage
{
    internal class ClassMethodAndVars
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        const int empRatePerHour = 20;
        const int numOfWorkingDays = 20;
        const int maxHrsInMonth = 100;

        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        public void EmpWage()
        {
            while (totalEmpHrs < maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
                if (totalEmpHrs == maxHrsInMonth)
                {
                    Console.WriteLine("Total working hours condition has reached i.e. " + maxHrsInMonth + " hrs");
                }
                if (totalWorkingDays == numOfWorkingDays)
                {
                    Console.WriteLine("Total working days condition has reached i.e. " + numOfWorkingDays + " days");
                }
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
