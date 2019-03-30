using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOtPay
{
    class Program
    {

        /* Prompt User for their hourly pay rate, hours worked and if they are
         * single, married, widowed or divorced. It will then calculate gross
         * and net pay. If user works more than 40 hours OT is calculated
         * at 1 1/2 times regular pay and shown seperatley. If married the tax
         * rate is 15%, divorced is 23%, widowed is 13% and single is 22%.*/


        static void Main(string[] args)
        {

            // Initialize Variables.
            double hourlyPay, hoursWorked, grossPay, netPay, taxRate, otPay;
            string maritalStatus;

            // User input for marital status, hours worked, and pay rate.
            Console.WriteLine("What is your hourly pay rate?:  ");
            hourlyPay = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours have you worked?:  ");
            hoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your marital status?:  (M)arried, (S)ingle, (W)idowed or (D)ivorced. ");
            maritalStatus = Console.ReadLine();

            taxRate = 0.0;

            // Calculate the Tax based on Marital Status entered
            if (maritalStatus == "M")
            {
                taxRate = 0.15;
            }
            if (maritalStatus == "S")
            {
                taxRate = 0.22;
            }
            if (maritalStatus == "W")
            {
                taxRate = 0.23;
            }
            if (maritalStatus == "D")
            {
                taxRate = 0.13;
            }

            // Calculate Pay based on Hours worked and pay rate
            if (hoursWorked <= 40)
            {
                grossPay = hoursWorked * hourlyPay;
                netPay = grossPay - (grossPay * taxRate);
                Console.WriteLine("Marital Status: {0}", maritalStatus);
                Console.WriteLine("Tax Rate: {0}", taxRate);
                Console.WriteLine("Gross Pay: {0}", grossPay);
                Console.WriteLine("Net Pay: {0}", netPay);

            }
            else
            {
                otPay = (hourlyPay * 1.5) * (hoursWorked - 40);
                grossPay = (40 * hourlyPay);
                netPay = (grossPay + otPay) - (grossPay * taxRate) - (otPay * taxRate);
                Console.WriteLine("Marital Status: {0}", maritalStatus);
                Console.WriteLine("Tax Rate: {0}", taxRate);
                Console.WriteLine("Regular Pay: {0}", grossPay);
                Console.WriteLine("Overtime Pay: {0}", otPay);
                Console.WriteLine("Gross Pay: {0}", otPay + grossPay);
                Console.WriteLine("Net Pay: {0}", netPay);
            }

            Console.ReadLine();
        }
    }
}
