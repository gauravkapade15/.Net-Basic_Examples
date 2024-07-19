using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GitAssignment.ArithmeticA1;

namespace GitAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //assignment  ArithmeticA1
            //ArithmeticA1 calculator = new ArithmeticA1();
            //Console.WriteLine("Enter First Number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Operation operation;
            //operation = calculator.AddNumber;
            //operation += calculator.MultiplyNumber;
            //operation(n1, n2);
            //Console.ReadLine();


            // ArithmeticA2
            //ArithmeticA2 calculator = new  ArithmeticA2();
            // Console.WriteLine("Enter First Number: ");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Second Number: ");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // calculator.AddNumber(n1, n2);
            // calculator.MultiplyNumber(n1, n2);
            // Console.ReadLine();


            // ArithmeticA3

            ArithmeticA3 a = new ArithmeticA3();
            ArithmeticA3.Calculator cal = new ArithmeticA3.Calculator();
            cal.PerformOperation();

        }
    }
}
