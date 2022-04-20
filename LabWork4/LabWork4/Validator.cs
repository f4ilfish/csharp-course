using System.Linq;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Class Validator
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Is valid control's textboxes method
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsValidTextBoxes(Control control)
        {
            foreach (var validator in control.Controls
                         .OfType<TextBoxUserControl>().ToList())
            {
                if (!validator.IsValidTextBox || validator.TextLength == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}