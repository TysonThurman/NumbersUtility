using System.Text;
using System;

namespace NumbersUtility
{
    public class NumbersUtility
    {
        static void Main(string[] args)
        {
            //Method 1. PiToDecimal
            //Console.WriteLine($"Your result = {PiToDecimal()}");

            //Method 2. NumToDecimal
            //Console.WriteLine($"Your result = {NumToDecimalPoint()}");
        }

        public static StringBuilder PiToDecimal() {
            // Find PI to the Nth Digit
            try
            {
                Console.Write("Please Enter the number of decimal points for PI calculation between 0 and 39: ");
                int digits = Convert.ToInt32((Console.ReadLine()));
                StringBuilder result = new StringBuilder();
                string pi = "3.141592653589793238462643383279502884197";

                for (int i = 0; i < digits + 2; i++)
                {
                    result.Append(pi[i]);
                }

                return result;
            }

            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Please enter a number between 0 and 39!");
                return new StringBuilder("Unable to calculate!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number between 0 and 39!");
                return new StringBuilder("Unable to calculate!");
            }
        }
        
        public static StringBuilder NumToDecimalPoint(){
        //Find e to the Nth Digit
            try
            {
                StringBuilder result = new StringBuilder();

                Console.Write("Please enter a number with decimals: ");
                decimal originalNumber = Convert.ToDecimal(Console.ReadLine());
                string numAsString = originalNumber.ToString();

                Console.Write($"Please enter how many decimals to limit {numAsString} by: ");
                int digits = Convert.ToInt32(Console.ReadLine());

                int indexOfDecimalPoint = numAsString.IndexOf('.');
                string firstPart = numAsString.Substring(0,indexOfDecimalPoint);
                string lastPart = numAsString.Substring(indexOfDecimalPoint, digits + 1);

                result.Append(firstPart);
                result.Append(lastPart);

                return result;
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Please enter a number.");
                return new StringBuilder("Unable to calculate!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number.");
                return new StringBuilder("Unable to calculate!");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Number too large.");
                return new StringBuilder("Unable to calculate!");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please input valid number with decimals.");
                return new StringBuilder("Unable to calculate!");
            }
        }
    
        public static StringBuilder Fibbonaci(){
        //Fibonacci Sequence - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
            try
            {

               return new StringBuilder(); 
            }
            catch (System.Exception)
            {
                
                return new StringBuilder(); 
            }
        }


    }
}