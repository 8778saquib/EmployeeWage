﻿using System;

namespace employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage program");




            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1.checkingpresentORAbsent ");
            Console.WriteLine(" 2.caldailywage");
            Console.WriteLine(" 3.parttimeornot");
            Console.WriteLine(" 4.usingswitch");
            Console.WriteLine(" 5. monthlywage");
            Console.WriteLine(" 6.totaoWorkingDaysOrHoursReached");
            Console.WriteLine(" 7.ClassMethodAndVars");
            Console.WriteLine(" 8.MultipleCompanies");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    checkingpresentORAbsent a = new checkingpresentORAbsent();
                    a.CheckingpresentORAbsent();


                    break;
                case 2:
                    caldailywage c = new caldailywage();
                    c.Caldailywage();

                    break;
                case 3:
                    parttimeornot d = new parttimeornot();
                    d.Parttimeornot();

                    break;
                case 4:
                    usingswitch e = new usingswitch();
                    e.Usingswitch();


                    break;
                case 5:
                    monthlywage f = new monthlywage();
                    f.Monthwage();

                    break;
                case 6:
                    totaoWorkingDaysOrHoursReached g = new totaoWorkingDaysOrHoursReached();
                    g.TotaoWorkingDaysOrHoursReached();

                    break;
                case 7:
                    ClassMethodAndVars h = new ClassMethodAndVars();
                    h.EmpWage();

                    break;
                case 8:
                    MultipleCompanies z = new MultipleCompanies();
                    z.Companies();

                    break;


                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }





            
            
            
            

            
            
            

        }
    }
}
