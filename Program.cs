using System.Diagnostics.CodeAnalysis;

namespace EmployeeWagesProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation problem");
            int IS_FULL_TIME = 1;
            int Emp_Rate_Per_Hour = 20;
            int IS_PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
                empWage = empHrs * Emp_Rate_Per_Hour;
            }
            else if(empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            Console.WriteLine("EmployeeWage" + empWage);
        }
    }
}
