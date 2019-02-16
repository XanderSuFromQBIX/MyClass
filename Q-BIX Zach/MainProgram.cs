using System;
using System.Text;
using System.Threading;




namespace Q_BIX_Zach
{
    public class MainProgramWithNothingInIt
    {
        static void Main(string[] args)
        {
            Story();
            Console.ReadLine();
        }
        
        public int Test()
        {
            int Num = 3;
            Console.WriteLine(Num + 2);
            return Num;
        }


        

        static void StringMethods()
        {
            //string exampleString = "This is the example string.";

            //Console.WriteLine(exampleString.Contains("and"));
            //Console.WriteLine(exampleString.IndexOf("the"));
            //Console.WriteLine(exampleString.Substring(1, 3));
            //Console.WriteLine(exampleString.Split(' ')[1]);
            //Console.WriteLine(exampleString[3]);
            //Console.WriteLine(exampleString.Replace(".", " for your Death!! "));

            //string foo;
            //foo = "A<S<W<Z.";
            //Console.WriteLine(foo);
            //foo = foo.Replace("<", " > ");
            //Console.WriteLine(foo);


            var sb = new StringBuilder();
            var numStars = 1;
            bool numStUp = true;
            while(true)
            {
                sb.Clear();                
                sb.Append("|                    |");
                sb.Replace(' ', '*', 10, numStars);
                Console.WriteLine(sb);
                Thread.Sleep(30);
                if(numStUp == true)
                {
                    numStars++;
                }
                else
                {
                    numStars--;
                }
                
                if(numStars > 7)
                {
                    numStUp = false;
                }
                if(numStars == 0)
                {
                    numStUp = true;
                }
            }
            

        }

        static void Story()
        {
            string person1Sector1 = "Xander Su";
            int person1Sector1Age = 10;


            Console.WriteLine("Q-BIX Test #1");
            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("Hello, is anyone there? I need help, fast");
            Console.WriteLine("My name is " + person1Sector1 + ", Meet me in the old wooden house");
            Console.WriteLine("on top of the tallest mountain on earth.");
            Console.WriteLine("I might be " + person1Sector1Age + " but you need to get there " +
            " fast, at the speed of a something.");

            string whatPersonTyped;
            whatPersonTyped = Console.ReadLine();
            Console.WriteLine("I know you said " + whatPersonTyped + " but I cannot help you, until you get here");
        }

        static void MadLib()
        {
            string noun, verb, food, noun2, name, gender;
            string num1, num2, num3;
            Console.Write("Type in a proper noun: ");
            noun = Console.ReadLine();

            Console.Write("Type in a verb: ");
            verb = Console.ReadLine();

            Console.Write("Type in the food you eat the most: ");
            food = Console.ReadLine();

            Console.Write("Type in another proper noun: ");
            noun2 = Console.ReadLine();

            Console.Write("Type in a name: ");
            name = Console.ReadLine();

            Console.Write("Type in a Gender (He, She): ");
            gender = Console.ReadLine();

            Console.Write("Type in a number: ");
            num1 = Console.ReadLine();

            Console.Write("Type in a 2nd number: ");
            num2 = Console.ReadLine();

            Console.Write("Type in a third number: ");
            num3 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"{name} went on a trip in the {noun} to do some {verb}ing.");
            Console.WriteLine($"{gender} saw a store called {noun2} so {gender} went inside to eat some {food}.");



        }

        static void Array()
        {
            int[] intRay = { 0, 4, 1, 5 };
            //int answer = intRay[4] + intRay[7] * intRay[1];
            //Console.WriteLine(answer );
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            //int item1index, item2index, item3index, item4index;
            //item1index = 0;
            //item2index = 4;
            //item3index = 1;
            //item4index = 5;



            string[] stringray = { "Amaya", "Zach", "Alex", "Bob", ", go to your room for eating candy in ", "'s room!" };
            Console.Write(stringray[intRay[0]]);
            Console.Write(stringray[intRay[1]]);
            Console.Write(stringray[intRay[2]]);
            Console.Write(stringray[intRay[3]]);



        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }


    }
}
