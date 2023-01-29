﻿using System.Diagnostics.CodeAnalysis;

namespace EmployeeWagesProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation problem");
            const int IS_FULL_TIME = 1;
            int Emp_Rate_Per_Hour = 20;
            const int IS_PART_TIME = 2;
            const int Num_Of_working_Days = 3;
            int totalempWage = 0;
            int empHrs = 0;
            int empWage = 0;
            for (int day = 0; day < Num_Of_working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        empWage = empHrs * Emp_Rate_Per_Hour;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is part time ");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalempWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total EmpWage:" + totalempWage);
        }
    }
}
