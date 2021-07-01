using System;

namespace NUnit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user
            Console.WriteLine("Enter program number to execute");
            Console.WriteLine("1.NotedVendingMachine\n2.Print day of week\n3.TemperatureConversion\n4.MonthlyPayment\n5.Newton SqareRoot\n6.Decimal to Binary\n7.Swap Nibbles");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    NotesVendingMachine.ReadInput();
                    break;
                case 2:
                    DaysOfWeek.ReadInput();
                    break;
                case 3:
                    TemperatureConversion.ReadInput();
                    break;
                case 4:
                    MonthlyPayment.ReadInput();
                    break;
                case 5:
                    NewtonSqrt.ReadInput();
                    break;
                case 6:
                    DecimalToBinary.ReadInput();
                    break;
                case 7:
                    SwapNibbles.ReadInput();
                    break;
            }
        }
    }
}
