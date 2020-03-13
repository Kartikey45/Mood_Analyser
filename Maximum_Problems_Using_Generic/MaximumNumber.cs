using System;
using System.Linq;

namespace Maximum_Problems_Using_Generic
{
    public class MaximumNumber
    {
        //METHOD FOR FINDING MAXIMUM INTEGER NUMBER
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

        //METHOD FOR FINDING MAXIMUM FLOAT NUMBER
        public float MaximumElement(float number1, float number2, float number3)
        {
            //ARRAY DECALRE
            float[] floatArray = { number1, number2, number3 };

            //VARIABLE INITIALIZE
            float maximumNumber = 0;
            float arrayLength = floatArray.Length;

            //FIND MAXIMUM INTEGER
            for (int index = 0; index < arrayLength; index++)
            {
                if (floatArray[index] > maximumNumber)
                {
                    maximumNumber = floatArray[index];
                }
            }
            return maximumNumber;
        }

        //METHOD FOR FINDING MAXIMUM STRING
        public int maximumElement1(string element1, string element2, string element3)
        {
            int string1 = element1.Length;
            int string2 = element2.Length;
            int string3 = element3.Length;
            int[] stringElement = { string1, string2, string3 };

            //Find The Maximum Number In Array
            int MaximumValue1 = stringElement.Max();
            return MaximumValue1;
        }


        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            Console.ReadKey();
        }
    }
}
