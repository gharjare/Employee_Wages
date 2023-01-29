using System.Diagnostics.CodeAnalysis;

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
            const int Max_Hrs_In_Month = 100;
            int totalempWage = 0;
            int totalEmpHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_working_Days)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        totalempWage = totalEmpHrs * Emp_Rate_Per_Hour;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is part time ");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
              Console.WriteLine("Total Emp Wage for a Month: " + totalempWage);
        }
    }
}
