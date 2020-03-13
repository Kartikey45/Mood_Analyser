using System;

namespace Maximum_Problem_Using_Generics
{
    public class Maximum_number
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            //ARRAY DECALRE
            int[] integer = { 56, 32, 87 };

            //VARIABLE INITIALIZE
            int maximumInteger = 0;
            int arrayLength = integer.Length;

            //FIND MAXIMUM INTEGER
            for (int index = 0 ; index < arrayLength ; index++)
            {
                if (integer[index] > maximumInteger)
                {
                    maximumInteger = integer[index];
                }
            }

            //DISPLAY THE MAXIMUM INTEGER
            Console.WriteLine("Welcome to Generics");
            Console.WriteLine("Maximum integer is : " + maximumInteger);
            Console.ReadKey();
        }
    }
}
