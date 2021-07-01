using System;

namespace NUnit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user
            Console.WriteLine("Enter program number to execute");
            Console.WriteLine("1.NotedVendingMachine\n2.Print day of week");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    NotesVendingMachine.ReadInput();
                    break;
                case 2:
                    DaysOfWeek.ReadInput();
                    break;
            }
        }
    }
}
