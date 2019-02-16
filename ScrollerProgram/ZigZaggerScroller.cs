using System;
using System.Text;
using System.Threading;

namespace Q_BIX_Zach.ScrollerDemo
{
    public class ZigZaggerScroller : IScrollerObject
    {
        // Character to use
        private string fillChar { get; set; }

        // How many chars appear on the current line
        private int charWidth { get; set; }

        // The index where the characters start at for the line
        private int charStartIndex { get; set; }

        // If line is traveling to the right (increasing), or left (not-increasing)
        private bool increasing = true;

        // This object helps us generate random numbers
        // The parameter makes the rnd in each instance generate different random numbers
        private Random rnd { get; set; }

        public ZigZaggerScroller(char fillChar)
        {
            // Accepting a char assures that we are always dealing with just 1 char instead of many.
            this.fillChar = fillChar.ToString();

            // Set up the rnd in a way that it generates different numbers in each instance
            Thread.Sleep(42);
            rnd = new Random();

            charWidth = rnd.Next(3, 15);
            charStartIndex = -1;
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
            // One time start position init
            if (charStartIndex == -1)
            {
                charStartIndex = rnd.Next(0, lineLength - charWidth - 2);
            }

            if (increasing)
            {
                charStartIndex += 1;
            }
            else
            {
                charStartIndex -= 1;
            }

            // If we hit the left wall
            if (charStartIndex == -1)
            {
                charStartIndex = 0;
                increasing = true;
            }
            else if (charStartIndex > lineLength - charWidth)
            {
                charStartIndex--;
                increasing = false;
            }
            else if(rnd.Next(1, 100) < 15)
            {
                increasing = !increasing;
            }
        }
    }
}
