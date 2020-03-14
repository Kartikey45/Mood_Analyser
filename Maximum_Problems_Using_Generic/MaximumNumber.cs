using System;
using System.Linq;

namespace Maximum_Problems_Using_Generic
{
    public class MaximumNumber
    {
        //METHOD FOR FINDING MAXIMUM ELEMENT
        public anyDataType MaximumElement<anyDataType>(anyDataType element1, anyDataType element2, anyDataType element3)
        {
            //ARRAY DECALRE
            anyDataType[] array = { element1, element2, element3 };

            //FIND MAXIMUM ELEMENT
            anyDataType MaximumValue = array.Max();
            return MaximumValue;
        }

        //MAIN METHOD
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Generics");
            Console.ReadKey();
        }
    }
}
