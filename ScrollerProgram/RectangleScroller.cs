using System;
using System.Text;
using System.Threading;

namespace Q_BIX_Zach.ScrollerDemo
{
    public class RectangleScroller : IScrollerObject
    {
        // Character to use
        private string fillChar { get; set; }

        // How many chars appear on the current line
        private int charWidth { get; set; }

        // The index where the characters start at for the line
        private int charStartIndex { get; set; }

        // The max number of characters wide that a rectangle can be.
        private int maxRectWidth { get; set; } = 20;

        // If currently displaying a rectangle or not
        private bool displaying = true;

        // This object helps us generate random numbers
        // The parameter makes the rnd in each instance generate different random numbers
        private Random rnd { get; set; }

        public RectangleScroller(char fillChar)
        {
            // Accepting a char assures that we are always dealing with just 1 char instead of many.
            this.fillChar = fillChar.ToString();

            // Set up the rnd in a way that it generates different numbers in each instance
            Thread.Sleep(42);
            rnd = new Random();

            charWidth = rnd.Next(3, 15);
        }

        public void EditLine(StringBuilder sb)
        {
            if (displaying)
            {
                // Remove the number of characters that will be inserted as stars next
                sb.Remove(charStartIndex, charWidth);

                // Insert the appropriate number of stars onto the line in the right position
                sb.Insert(charStartIndex, fillChar, charWidth);
            }
        }

        public void Calc(int lineLength)
        {
            // if not displaying there is a change to turn display back on
            if (!displaying)
            {
                if (rnd.Next(1, 100) < 15)
                {
                    displaying = true;
                    charStartIndex = rnd.Next(0, lineLength - maxRectWidth);
                    charWidth = rnd.Next(3, maxRectWidth);

                    // correct rectangles that overflow the right side
                    if (charStartIndex + charWidth >= lineLength)
                    {
                        charStartIndex = lineLength - charWidth - 1;
                    }
                }
            }
            else
            {
                if (rnd.Next(1, 100) < 15)
                {
                    displaying = false;
                }
            }

        }
    }
}
