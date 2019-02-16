using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Q_BIX_Zach.ScrollerDemo
{
    public class DataScroller : IScrollerObject
    {
        private List<string> data { get; set; }

        // The index where the characters start at for the line
        private int charStartIndex { get; set; }

        // Which line from the data should be displayed next
        private int lineIndex { get; set; } = 0;

        // If displaying the data at all
        private bool displaying { get; set; }

        // This object helps us generate random numbers
        // The parameter makes the rnd in each instance generate different random numbers
        private Random rnd { get; set; }

        public DataScroller(List<string> data)
        {
            this.data = data;

            // Set up the rnd in a way that it generates different numbers in each instance
            Thread.Sleep(42);
            rnd = new Random();

            charStartIndex = -1;
        }

        public void EditLine(StringBuilder sb)
        {
            if (displaying)
            {
                // Remove the number of characters that will be inserted
                sb.Remove(charStartIndex, data[lineIndex].Length);

                // Insert the data in the right position
                sb.Insert(charStartIndex, data[lineIndex]);
            }
        }

        public void Calc(int lineLength)
        {
            // Reset data X-position 
            if (charStartIndex == -1)
            {
                charStartIndex = rnd.Next(data[0].Length, lineLength - data[0].Length - 2);
            }

            // If not displaying
            if (!displaying)
            {
                // There is an 18% change to turn displaying back on
                if (rnd.Next(0,100) < 18)
                {
                    displaying = true;
                }
            }
            else
            {
                lineIndex++;
                if (lineIndex >= data.Count)
                {
                    lineIndex = 0;
                    displaying = false;
                    charStartIndex = -1;
                }

            }
        }
    }
}
