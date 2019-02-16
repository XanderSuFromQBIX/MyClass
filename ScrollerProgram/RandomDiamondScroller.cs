using System;
using System.Text;
using System.Threading;

namespace Q_BIX_Zach.ScrollerDemo
{
    public class RandomDiamondScroller : IScrollerObject
    {
        // Character to use to make up the diamonds with
        private string fillChar { get; set; }

        // How many chars appear on the current line
        private int charWidth { get; set; }

        // The index where the characters start at for the line
        private int charStartIndex { get; set; }

        // If the number of characters is increasing or decreasing.
        private bool increasing = true;

        // The maximum width that a diamond can be
        private int maxDiamondWidth { get; set; } = 20;

        // This object helps us generate random numbers
        // The parameter makes the rnd in each instance generate different random numbers
        private Random rnd { get; set; }

        public RandomDiamondScroller(char fillChar)
        {
            // Accepting a char assures that we are always dealing with just 1 char instead of many.
            this.fillChar = fillChar.ToString();

            charWidth = 0;

            // Set up the rnd in a way that it generates different numbers in each instance
            Thread.Sleep(42);
            rnd = new Random();
        }

        public void EditLine(StringBuilder sb)
        {
            // Remove the number of characters that will be inserted as stars next
            sb.Remove(charStartIndex, charWidth);

            // Insert the appropriate number of stars onto the line in the right position
            sb.Insert(charStartIndex, fillChar, charWidth);
        }

        public void Calc(int lineLength)
        {
            // If the number of characters that make up the diamond have reached 0
            // then we decide a new location to start drawing the diamond at.
            if (charWidth <= 0)
            {
                // To keep the code a little more simple to read the +maxDiamondWidth/-maxDiamondWidth keeps the diamonds
                // from running into the sides.
                charStartIndex = rnd.Next(0 + maxDiamondWidth, lineLength - maxDiamondWidth);
                charWidth = 0;
                increasing = true;
            }

            if (increasing)
            {
                charStartIndex -= 1;
                charWidth += 2;
            }
            else
            {
                charStartIndex += 1;
                charWidth -= 2;
            }

            // Two things can determine if we are at the max diamond width
            bool maxWidthReached = false;

            // There is a 20% chance on each line to reach max width early
            if (rnd.Next(1, 100) < 20)
            {
                maxWidthReached = true;
            }

            // Also if we've reached the max witch possible
            if (charWidth > maxDiamondWidth)
            {
                maxWidthReached = true;
            }

            if (maxWidthReached)
            {
                increasing = false;
            }
        }
    }
}
