using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    /// <summary>
    /// This is the example about params
    /// </summary>
    internal class ParamsExample : IExampleBase
    {
         public void Execute()
         {
            //When we call the example with the params int array, we can do this
            WithParamsExample("First Number", 5, 2, 4, 8, 3);
            // Create a list of ints and then convert it into an int array
            int[] intArray = new List<int>() { 5, 4, 8, 3, 4, 7 }.ToArray();
            // Or just create an int array directly
            int[] intArray2 = new int[] { 2, 3, 4, 8, 12, 5 };

            // We call the first example with 'intArray'
            WithoutParamsExample(intArray, "Second Number");
            // and the second, with 'intArray2'
            WithoutParamsExample(intArray2, "Third Number");
         }

        /// <summary>
        /// This is the example of params with params, there will be only one difference 
        /// between this and WithoutParamsExample
        /// </summary>
        /// <param name="name"> This pramiter will show the name of the number when it writes it to the screen </param>
        /// <param name="numbers"> This is a params parameter, it needs to be the last parameter </param>
        public static void WithParamsExample(string name, params int[] numbers)
        {
            // Here we create the int that will be changed and then put on screen
            int mainNum = 0;

            // For each number in 'numbers' we will add it to 'mainNum'
            foreach(var num in numbers)
            {
                mainNum = mainNum + num;
            }

            // This writes out the final 'mainNum' to the screen
            Console.WriteLine($"{name}-{mainNum}");
        }

        /// <summary>
        /// This is the params example without params, so an
        /// array needs to be passed in
        /// </summary>
        /// <param name="name"> This pramiter will show the name of the number when it writes it to the screen </param>
        /// <param name="numbers"> Since this isn't a params parameter, we don't need to put it at the end </param>
        public static void WithoutParamsExample(int[] numbers, string name)
        {
            // Here we create the int that will be changed and then put on screen
            int mainNum = 0;

            // For each number in 'numbers' we will add it to 'mainNum'
            foreach (var num in numbers)
            {
                mainNum = mainNum + num;
            }

            // This writes out the final 'mainNum' to the screen
            Console.WriteLine($"{name}-{mainNum}");
        }
    }
}
