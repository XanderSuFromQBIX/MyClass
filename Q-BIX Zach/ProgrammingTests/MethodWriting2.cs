using System;

namespace Q_BIX_Zach.ProgrammingTests
{
    public class MethodWriting2
    {
        public void Execute()
        {
           
            //string answer1 = MyMethodA("Purple", 1);
            //string answer2 = MyMethodB(23, "Bananas");
            //string answer3 = MyMethodC(answer1, answer2);

            //if (answer3.Equals("I have 23 Bananas and 1 Purple cat."))
            //{
            //    Console2.WriteLine("This is correct!");
            //}
            //else
            //{
            //    Console2.WriteLine("Try again!");
            //}
        }

        public string MyMethodA(string A, int B)
        {
            string answer1 = $"and {B} {A} cat.";
            return answer1;
        }

        public string MyMethodB(int A, string B)
        {
            string answerB = $"I have {A} {B}";
            return answerB;
        }

        public string MyMethodC(string a, string b)
        {
            string answer3 = $"{b} {a}";
            return answer3;
        }

    }

    public class StoryLine
    {

        public void Execute()
        {
           
            Console2.WriteLine("Hello, this is a test, please state your name: ");
            string name, age, reply, scream, girlname, homename, reply2;
            name = Console.ReadLine();
            Console2.WriteLine($"Hi {name}, please state your age: ");
            age = Console.ReadLine();
            Console2.WriteLine($"Hi {name}, so you are {age} years old, are you ready to begin your very own story told by me?");
            reply = Console.ReadLine();
            Console2.WriteLine($"Ok, {name}, so you said {reply}, I will take that as a yes. (Press Enter To Continue)");
            Console.ReadLine();
            Console2.WriteLine($"{name}, who is {age}, went on the school bus, and the bus blew up while it was driving.");
            Console.Write($"Everyone surived, and {name} yelled, (Type in a thing you would say if this happened)");
            scream = Console.ReadLine();
            Console2.WriteLine($"{scream}. In front of a girl which was called: ");
            girlname = Console.ReadLine();
            Console2.WriteLine($"When {name} saw {girlname}, {name} tryed to kill her, and was arrested.");
            Console.ReadLine();
            Console2.WriteLine($"As you go in jail you find a keypad, now Enter the password to get out of jail.");
            KeepAsking();
            Console.ReadLine();
            Console2.WriteLine($"The Door is now unlocked, at night, you escape.");
            Console2.WriteLine($"You go to a empty place, and dig a home there, you also make a trapdoor to get in.");
            Console2.WriteLine($""); Console.Write("Now what will you call your home?: ");
            homename = Console.ReadLine(); Console2.WriteLine($"You make a sign and carve {homename} into it.");
            Console2.WriteLine($"Do you want to sleep?: "); reply2 = Console.ReadLine();
            Console2.WriteLine($"You think {reply2}, to yourself, but you fall asleep in {homename} anyway. (Press Enter for tomorrow.)");
            Console2.WriteLine($"You wake up, to be nearly shot to death by police.");
            Console2.WriteLine($"\"{name}, put your hands up! You are under arrest for trying to kill {girlname} and escaping!!\"");
            Console2.WriteLine($"The police try to handcuff you, but you kick them in the heads and knock them out, you take their bodies and toss them out.");
            Console2.WriteLine("");
            Console2.WriteLine("----- |   | |-----     |---- |\\   | |-----\\ ");
            Console2.WriteLine("  |   |---| |-----     |---- | \\  | |     | ");
            Console2.WriteLine("  |   |   | |          |     |  \\ | |     | ");
            Console2.WriteLine("  |   |   | |-----     |---- |   \\| |-----/  (Of part 1, Press Enter for part 2)");
            Console.ReadLine();


        }

        static void KeepAsking()
        {
            var secretAnswer = "Death";
            var currentAnswer = "";
            while (!currentAnswer.Equals(secretAnswer))
            {
                Console2.WriteLine("Enter the secret password, it realates to what nearly happend before you went here.");
                currentAnswer = Console.ReadLine();
            }

            Console2.WriteLine("Correct.");
        }
    }
}
