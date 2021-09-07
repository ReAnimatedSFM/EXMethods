using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXMethods
{
    class Program
    {
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Print(int[] a)
        {
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static bool HasEqualLenght(int[] array1, string[] array2)
        {
            if (array1.Length == array2.Length)
            {
                return true;
            }
            else
                return false;
        }

        private static (double, double) Calculate(int val1)
        {
            if (val1 > 0)
            {
                double squareRoot = Math.Sqrt(val1);
                double squared = val1 * val1;
                Console.WriteLine("Input was " + isPositive(val1));
                return (squared, squareRoot);
            }
            else
            {
                Console.Clear();
                double squareRoot = Math.Sqrt(val1);
                double squared = val1 * val1;
                Console.WriteLine("Input was " + isPositive(val1));
                return (squared, squareRoot);
            }
        }

        static bool isPositive(int val)
        {
            bool result;
            if (val > 0)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        private static bool isEven(int number)
        {
            int numberResult = number % 2;
            if (numberResult == 0)
            {
                bool isEven = true;
                return isEven;
            }
            else
            {
                bool isEven = false;
                return isEven;
            }
        }

        private static double Average(int[] array1)
        {
            return array1.Average();
        }

        private static decimal Median(int[] array1)
        {
            int[] tempArray = array1;
            int count = array1.Length;

            Array.Sort(tempArray);

            decimal medianValue = 0;

            if (count % 2 == 0)
            {
                int x = tempArray[(count / 2) - 1];
                int y = tempArray[(count / 2)];
                medianValue = (x + y) / 2;
                return medianValue;
            }
            else
            {
                medianValue = tempArray[(count / 2)];
                return medianValue;
            }
        }

        /* Kom tilbage til opgaven
        static void Mode(int[] Mode)
        {

        }
        */

        static void Main(string[] args)
        {
            int[] num = { 33, 54, 77, 10, 10, 33, 10, 54, 55, 77 };
            int a = 5;
            bool answer = isPositive(a);
            (double, double) result = Calculate(a);
            Console.WriteLine(result);
            Console.WriteLine(Average(num));
            Print(num);
            Console.WriteLine(Median(num));


            Console.ReadKey();
        }
    }
}
