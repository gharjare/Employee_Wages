﻿using System.Diagnostics.CodeAnalysis;

namespace EmployeeWagesProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation problem");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
