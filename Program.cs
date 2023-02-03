using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeWagesProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderObject paytm = new EmpWageBuilderObject("Paytm", 20, 30, 50);
            EmpWageBuilderObject googlepay = new EmpWageBuilderObject("GooglePay", 30, 50, 60);
            paytm.computeEmpWage();
            Console.WriteLine(paytm.toString());
            googlepay.computeEmpWage();
            Console.WriteLine(googlepay.toString());
        }
    }
}
