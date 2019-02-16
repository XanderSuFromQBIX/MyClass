using System;

namespace Q_BIX_Zach
{
    public static class Console2 
    {
        private static int counter = 0;

        public static void WriteLine(string lineToWriteLine)
        {
            counter++;
            lineToWriteLine = counter + "> " + lineToWriteLine;
            Console.WriteLine(lineToWriteLine);

        }
    }
}
