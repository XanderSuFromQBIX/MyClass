using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        public static Random Rnd = new Random();
        public static int MaxFirstNum = 500, MaxSecondNum = 250, ProblemType = 40, problemsRight = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to math training, press enter when you are ready.");
            Console.ReadLine();
            Console.WriteLine("How much problems do you want there to be?");
            int problemLimit = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int problems = 1;

            while(problems <= problemLimit)
            {
                Console.Clear();
                if(problems == problemLimit)
                {
                    Console.WriteLine("Final problem!");
                    Console.WriteLine();
                }
                int firstNum = Rnd.Next(0, MaxFirstNum), secondNum = Rnd.Next(0, MaxSecondNum), type = Rnd.Next(1, ProblemType), answer = 0, input;
                if(type >= 1 && type < 11)
                {
                    answer = firstNum + secondNum;
                    Console.Write($"{problems}. {firstNum} + {secondNum} = ");
                }
                else if(type >= 11 && type < 21)
                {
                    answer = firstNum - secondNum;
                    Console.Write($"{problems}. {firstNum} - {secondNum} = ");
                }
                else if(type >= 21 && type < 31 )
                {
                    answer = firstNum * secondNum;
                    Console.Write($"{problems}. {firstNum} X {secondNum} = ");
                }
                else if(type >= 31 && type < 41)
                {
                    if(firstNum < secondNum)
                    {
                        int storage;
                        storage = firstNum;
                        firstNum = secondNum;
                        secondNum = storage;
                    }
                    answer = firstNum / secondNum;
                    Console.Write($"{problems}. {firstNum} / {secondNum} = ");
                }
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(answer == input)
                {
                    problemsRight++;
                }
                problems++;
            }
            Console.WriteLine($"Test over, you got {problemsRight}/{problemLimit}.");
            Console.ReadLine();
        }
    }
}
