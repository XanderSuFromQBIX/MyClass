using System.Text;

namespace Q_BIX_Zach.ScrollerDemo
{
    /// <summary>
    /// An interface tells the program that all classes that use the interface will have these methods.
    /// These methods are required by all types of scroller objects.
    /// </summary>
    public interface IScrollerObject
    {
        /// <summary>
        /// Edits the line in the string builder to insert any object(s) that the scroller object is presenting.
        /// </summary>
        /// <param name="sb"></param>
        void EditLine(StringBuilder sb);

        /// <summary>
        /// Updates the settings in the scroller object so it is ready to display the next line.
        /// </summary>
        void Calc(int lineLength);
    }
}
