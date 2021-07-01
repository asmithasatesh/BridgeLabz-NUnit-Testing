using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {
            //Get input from Utility Class
            Console.WriteLine("Enter a principal");
            double principal = Utility.ReadInput();
            Console.WriteLine("Enter a interest amount ");
            double rate = Utility.ReadInput();
            Console.WriteLine("No of years");
            int year = Utility.ReadInput();
            //Call method to calculate monthly pay
            MonthlyPaymentCalculate(principal, rate, year);

        }

        private static void MonthlyPaymentCalculate(double principle, double rate, int year)
        {
            //local variable 
            double r = rate / 1200;
            double n = 12 * year;
            double temp = Math.Pow(r+1, n);

            //Coomputing -> principle / ((1+r)^n  - 1)
            double temp1= principle / (temp - 1) ;

            //Computing ->  r * ((1+r)^n)
            double monthlyPayment = (r * temp) * temp1;
            Console.WriteLine("Monthly payment " + Math.Round(monthlyPayment));

        }
    }
}
