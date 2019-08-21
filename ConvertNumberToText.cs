using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class ConvertNumberToText
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                int userNumber = GetNumber("Enter a number between 1 and 20, or press 0 to quit.", 20);
                if (userNumber == 0)
                    break;
                Console.WriteLine(NumberToText(userNumber));
            }
           
        }

        static string NumberToText(int number)
        {
            string converted = "";
            
            if (number < 10)
            {
                converted = OnesPlace(number);
            }
            else if (number >= 10)
            {
                converted = TensPlace(number);
            }
            return converted;
        }

        static string OnesPlace(int number)
        {
            string text = "";
            switch (number)
            {
                case 1:
                    text = "One";
                    break;
                case 2:
                    text = "Two";
                    break;
                case 3:
                    text = "Three";
                    break;
                case 4:
                    text = "Four";
                    break;
                case 5:
                    text = "Five";
                    break;
                case 6:
                    text = "Six";
                    break;
                case 7:
                    text = "Seven";
                    break;
                case 8:
                    text = "Eight";
                    break;
                case 9:
                    text = "Nine";
                    break;
            }
            return text;
        }

        static string TensPlace(int number)
        {
            string text = "";
            switch (number)
            {
                case 10:
                    text = "Ten";
                    break;
                case 11:
                    text = "Eleven";
                    break;
                case 12:
                    text = "Twelve";
                    break;
                case 13:
                    text = "Thirteen";
                    break;
                case 14:
                    text = "Fourteen";
                    break;
                case 15:
                    text = "Fifteen";
                    break;
                case 16:
                    text = "Sixteen";
                    break;
                case 17:
                    text = "Seventeen";
                    break;
                case 18:
                    text = "Eighteen";
                    break;
                case 19:
                    text = "Nineteen";
                    break;
                case 20:
                    text = "Twenty";
                    break;
            }
            return text;
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string str = Console.ReadLine();
            return str;
        }

        public static int GetNumber(string prompt, int maxNum)
        {
            int userNumber;
            string strNumber;
            do
            {
                strNumber = GetInput(prompt);
                if (Int32.TryParse(strNumber, out userNumber) && userNumber <= maxNum)
                {
                    break;
                }

                Console.WriteLine("That is not an integer, or it is > {0}", maxNum);
            } while (true);
            
            return userNumber;
        }
    }
}
