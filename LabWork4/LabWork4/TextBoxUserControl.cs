using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Class TextBox User Control
    /// </summary>
    public partial class TextBoxUserControl : UserControl
    {
        /// <summary>
        /// Is valid TextBox auto-prop
        /// </summary>
        public bool IsValidTextBox { get; private set; }

        /// <summary>
        /// Text length of TextBox auto-prop
        /// </summary>
        public int TextLength
        {
            get => ValueTextBox.Text.Length;
        }
        
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string Text
        {
            get => ValueTextBox.Text;
            set => ValueTextBox.Text = value;
        }

        /// <summary>
        /// TextBox User Control instance constructor
        /// </summary>
        public TextBoxUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Value validating
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        private bool IsValidValue(string value, out string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                errorMessage = "Empty value";
                return false;
            }

            if (double.TryParse(value, out var tmpValue))
            {
                if (tmpValue > 0)
                {
                    if (value[0] == '0' && value[1] != ',')
                    {
                        errorMessage = "Incorrect format. Maybe expected ','";
                        return false;
                    }

                    errorMessage = "";
                    return true;
                }

                errorMessage = "Value must be positive";
                return false;
            }

            errorMessage = "Value must be an integer of decimal number";
            return false;
        }

        /// <summary>
        /// Event TextBox text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;

            string errorMessage;

            if (IsValidValue(textBox.Text, out var errorMsg))
            {
                errorMessage = errorMsg;
                IsValidTextBox = true;
            }
            else
            {
                errorMessage = errorMsg;
                IsValidTextBox = false;
            }

            ValueErorProvider.SetError(textBox, errorMessage);
        }
    }
}
