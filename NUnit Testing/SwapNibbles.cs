using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace NUnit_Testing
{
    class SwapNibbles
    {
        public static void ReadInput()
        {
            //Read input from user
            Console.WriteLine("Enter decimal number");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            SwapNibblesCalc(decimalNumber);

        }


        private static void SwapNibblesCalc(int decimalNumber)
        {
            //Local Variables
            int i,len=0;
            string binary="";
            //Convert decimal to binary
            string temp = Convert.ToString(decimalNumber, 2);
            //store length
            len = temp.Length;
            Console.WriteLine("Binary number before swapping is " + temp);
            //Add second half of the binary number
            for(i=len/2;i<len;i++)
            {
                binary+=String.Concat(temp[i]);
            }
            //Add first half of binary number
            for (i = 0; i <+len / 2; i++)
            {
                binary += String.Concat(temp[i]);

            }
            Console.WriteLine("\nBinary number after swapping is "+binary);
            String result = Convert.ToString(Convert.ToInt32(binary, 2), 10);
            Console.WriteLine("\nDecimal number after swapping is " + result);



        }
    }
}
