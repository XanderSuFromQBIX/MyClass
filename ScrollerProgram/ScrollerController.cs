using System;
using System.Collections.Generic;
using System.Text;

namespace Q_BIX_Zach.ScrollerDemo
{
    /// <summary>
    /// The scroller class keeps track of a number of registered objects that insert characters
    /// into the line using various rules.
    /// </summary>
    public class ScrollerController
    {
        // Each line is made of this many characters
        private int lineCharCount { get; set; }

        // Re-creating a string for every line takes a bit of computing power.
        // Using a string builder allows us to edit the same string over and over without
        // needing to re-create and destroy the object over and over which takes extra time.
        private StringBuilder sbLine { get; set; }

        /// <summary>
        /// Random object that helps generate random numbers
        /// </summary>
        private static Random rnd { get; set; } = new Random();

        /// <summary>
        /// Milliseconds to wait after displaying each line
        /// </summary>
        public int ScrollDelay { get; private set; }

        /// <summary>
        /// These are the scroller objects that the scroller is keeping track of and displaying.
        /// Custom scrollers can be created by adding different scroller objects to a scroller.
        /// </summary>
        public List<IScrollerObject> ScrollerObjects { get; set; }

        // Because the name of this method is the same as the class name, it is called when
        // the class is created
        public ScrollerController(int width)
        {
            lineCharCount = width;

            // Create the string builder object
            sbLine = new StringBuilder(lineCharCount);

            ScrollerObjects = new List<IScrollerObject>();

            ScrollDelay = rnd.Next(0, 100);
        }

        public static ScrollerController CreateRandomScroller()
        {
            char[] fillChars = { '*', '#', 'O', 'x', '_', '4', '?' };
            var scroller = new ScrollerController(220);
            int scrollTypeCount = 5;

            int numScrollerObjects = rnd.Next(2, 15);
            bool hardcodedType = rnd.Next(0, 2) == 0;
            int scrollType = rnd.Next(0, scrollTypeCount);

            for (int i = 1; i <= numScrollerObjects; i++)
            {
                scrollType = hardcodedType ? scrollType : rnd.Next(0, scrollTypeCount);
                int fillCharIndex = rnd.Next(0, fillChars.Length);
                switch (scrollType)
                {
                    case 0:
                        scroller.ScrollerObjects.Add(new RandomDiamondScroller(fillChars[fillCharIndex]));
                        break;
                    case 1:
                        scroller.ScrollerObjects.Add(new ZigZaggerScroller(fillChars[fillCharIndex]));
                        break;
                    case 2:
                        scroller.ScrollerObjects.Add(new RectangleScroller(fillChars[fillCharIndex]));
                        break;
                    case 3:
                        scroller.ScrollerObjects.Add(new DataScroller(
                            new List<string>()
                            {
                                @"      ^      ",
                                @"     /_\     ",
                                @"    /___\    ",
                                @"    |___|    ",
                                @"    |___|    ",
                                @"    |___|    ",
                                @"   /|___|\   ",
                                @"  /_|___|_\  ",
                                @"    !!!!!    ",
                                @"    ^^^^^    ",
                                @"   ~~~~.~~   ",
                                @"   ~o~~~.~   ",
                                @"    ~~o~~    ",
                                @"     ~.~     ",
                                @"      .      ",
                            }));
                        break;
                    case 4:
                        scroller.ScrollerObjects.Add(new DataScroller(
                            new List<string>()
                            {
                                @" !!!!!!!!! ",
                                @" /-------\ ",
                                @" |  o  o | ",
                                @" |   ^   | ",
                                @" |____v__| ",
                                @"   |___|   ",
                                @" __|   |__ ",
                                @"|__    ___|",
                                @"   |  |    ",
                                @"  /    \   ",
                                @" /  / \ \  ",
                                @" |_|   |_| ",
                            }));
                        break;
                }
            }

            return scroller;
        }

        public void WriteLine()
        {
            // Clear anything currently in the string builder
            sbLine.Clear();

            // Fill in spaces
            sbLine.Insert(0, " ", lineCharCount);

            // Process each scroller object
            foreach (var scrollObj in ScrollerObjects)
            {
                // Tell this scroller to calculate what the next line will look like
                scrollObj.Calc(lineCharCount);

                // Tell this scroller object to edit the current line
                scrollObj.EditLine(sbLine);
            }

            // Display the line
            Console.WriteLine(sbLine.ToString());
        }
    }
}
