using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Abstract class of FigureBase UserControl
    /// </summary>
    public abstract class FigureBaseUserControl : UserControl
    {
        /// <summary>
        /// Is valid user control auto-prop
        /// </summary>
        public abstract bool IsValidControl { get; }
    }
}