using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit_Testing
{
    public static class Extension
        {
        //To use method Conains in List
        public static bool Check<T>(this List<T> notes, T amount)
        {
            return notes.Contains(amount);
        }
        }
    class NotesVendingMachine
    {
        //Getting Input from user
        public static void ReadInput()
        {
            List<int> notes = new List<int> { 1000, 500, 100, 50, 10, 5, 2, 1 };
            //lcal variable
            int amount;
            Console.WriteLine(" Enter the amount (In Rs)");
            amount = Convert.ToInt32(Console.ReadLine());
            //Calling Vening macine method
            VendingMachine(notes,amount);
        }


        private static void VendingMachine(List<int> notes,int amount)
        {
            //Variable decalaration
            int j=0;
            List<int> value = new List<int>();
            List<int> count = new List<int>();
            //Check if amount is in list
            if (notes.Check(amount) == true) Console.WriteLine("1 note of " + "Rs {0}", amount);
            else
            {
                //Check for closest change to the amount
                for(int i=0;i<notes.Count;i++)
                {
                    if(amount>=notes[i])
                    {
                        count.Add(amount / notes[i]);
                        amount-=(count[j]*notes[i]);
                        value.Add(notes[i]);
                        j++;
                    }
                    if (amount == 0) break;
                }
            }
            //Calling Display Function
            Display(value, count);

        }

        private static void Display(List<int> notes, List<int> count)
        {
            for(int i=0;i<notes.Count;i++ )
            {
                Console.WriteLine("{0} notes of " + "Rs {1}", count[i],notes[i]);
            }
        }
    }
}
