using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeWagesProblem
{
    class program
    {
            const int IS_FULL_TIME = 1;
            const int Emp_Rate_Per_Hour = 20;
            const int IS_PART_TIME = 2;
            const int Num_Of_working_Days = 3;
            const int Max_Hrs_In_Month = 100;
        public static int computeEmpWage()
        {
            int totalWorkingDays = 0, totalEmpHrs = 0, empHrs = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage for a Month: " + totalEmpWage);
            return totalEmpWage;
        }
        public static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}
