using Q_BIX_Zach.ScrollerDemo;
using System;
using System.Diagnostics;
using System.Threading;

namespace ScrollerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrollerExample();
            Console.ReadLine();
        }

        static void ScrollerExample()
        {
            Stopwatch sw = new Stopwatch();

            while (true)
            {
                var scroller = ScrollerController.CreateRandomScroller();

                sw.Reset();
                sw.Start();
                while (sw.Elapsed.Seconds <= 5)
                {
                    scroller.WriteLine();

                    // The lines display super fast, so wait a little bit between each line display
                    // We do this by making the program sleep a small amount of time
                    Thread.Sleep(scroller.ScrollDelay);
                }
                sw.Stop();
            }
        }
    }
}
