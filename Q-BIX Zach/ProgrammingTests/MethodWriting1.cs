using System;

namespace Q_BIX_Zach.ProgrammingTests
{
    public class MethodWriting1
    {
        public void Execute()
        {
            string answer = DoStringStuff("MagicHandsFromLands", 5);
            string answer2 = DoStringStuff("TheLandsofMrHandsHat", 7);
            if (
                   answer.Equals("5MagicFingersFromCities")
                && answer2.Equals("7TheCitiesofMrFingersHat"))
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("Nice try, but that is incorrect. You came up with:");
                Console.WriteLine($"answer: {answer}");
                Console.WriteLine($"answer2: {answer2}");
            }


            //int answer = MathForAmaya(4, 7, 97);
            //if (answer == 108)
            //{
            //    Console.WriteLine("correct");
            //}

        }

        string DoStringStuff(string magic, int num)
        {

            string resume = num + magic;
            resume = resume.Replace("Hands", "Fingers");
            resume = resume.Replace("Lands", "Cities");

            return resume;
        }

        int MathForAmaya(int num8, int num5, int num6)
        {
            int res = num8 + num5 + num6;
            return res;
        }


    }
}
