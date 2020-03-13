using System;

namespace Maximum_Problems_Using_Generic
{
    public class MaximumNumber
    {
        //MAIN METHOD
        public int MaximumElement(int number1, int number2, int number3)
        {
            //ARRAY DECALRE
            int[] integer = { number1, number2, number3 };

            //VARIABLE INITIALIZE
            int maximumInteger = 0;
            int arrayLength = integer.Length;

            //FIND MAXIMUM INTEGER
            for (int index = 0; index < arrayLength; index++)
            {
                if (integer[index] > maximumInteger)
                {
                    maximumInteger = integer[index];
                }
            }
            return maximumInteger;
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            Console.ReadKey();
        }
    }
}
