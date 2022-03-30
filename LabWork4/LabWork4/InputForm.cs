using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SphereRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadiusHeightLabel.Text = "Radius:";
            BaseGroupBox.Enabled = false;
        }

        private void PyramidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadiusHeightLabel.Text = "Height:";
            SideFirstSideLabel.Text = "Side:";

            BaseGroupBox.Enabled = true;
            NumberOfSidesNumericUpDown.Enabled = true;
            SidesAngleMaskedTextBox.Enabled = false;
            SecondSideMaskedTextBox.Enabled = false;
        }

        private void ParallelepipedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadiusHeightLabel.Text = "Height:";
            SideFirstSideLabel.Text = "First side:";

            BaseGroupBox.Enabled = true;
            NumberOfSidesNumericUpDown.Enabled = false;

            foreach (var control in BaseGroupBox.Controls)
            {
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox) control).Enabled = true;
                }
            }
        }

        /// <summary>
        /// Is input value is correct
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        private bool IsValueCorrect(string value, out string errorMessage)
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

        ///// <summary>
        ///// Check wrong key press
        ///// </summary>
        ///// <param name="e"></param>
        ///// <param name="control"></param>
        //private void CheckKeyPress(KeyPressEventArgs e, Control control)
        //{
        //    if (char.IsNumber(e.KeyChar) ||
        //        (!string.IsNullOrEmpty(control.Text) && e.KeyChar == ',') ||
        //        char.IsControl(e.KeyChar))
        //    {
        //        return;
        //    }

        //    e.Handled = true;
        //}

        private void RadiusMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValueCorrect(RadiusHeightMaskedTextBox.Text, out var errorMsg)) return;

            e.Cancel = true;
            RadiusHeightMaskedTextBox.Select(0, RadiusHeightMaskedTextBox.Text.Length);

            RadiusHeightErrorProvider.SetError(RadiusHeightMaskedTextBox, errorMsg);
        }

        private void RadiusHeightMaskedTextBox_Validated(object sender, EventArgs e)
        {
            RadiusHeightErrorProvider.SetError(RadiusHeightMaskedTextBox, "");
        }

        private void SidesAngleMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValueCorrect(SidesAngleMaskedTextBox.Text, out var errorMsg)) return;

            e.Cancel = true;
            SidesAngleMaskedTextBox.Select(0, SidesAngleMaskedTextBox.Text.Length);

            SidesAngleErrorProvider.SetError(SidesAngleMaskedTextBox, errorMsg);
        }

        private void SidesAngleMaskedTextBox_Validated(object sender, EventArgs e)
        {
            SidesAngleErrorProvider.SetError(SidesAngleMaskedTextBox, "");
        }

        private void FirstSideMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValueCorrect(FirstSideMaskedTextBox.Text, out var errorMsg)) return;

            e.Cancel = true;
            FirstSideMaskedTextBox.Select(0, FirstSideMaskedTextBox.Text.Length);

            FirstSideErrorProvider.SetError(FirstSideMaskedTextBox, errorMsg);
        }

        private void FirstSideMaskedTextBox_Validated(object sender, EventArgs e)
        {
            FirstSideErrorProvider.SetError(FirstSideMaskedTextBox, "");
        }

        private void SecondSideMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsValueCorrect(SecondSideMaskedTextBox.Text, out var errorMsg)) return;

            e.Cancel = true;
            SecondSideMaskedTextBox.Select(0, SecondSideMaskedTextBox.Text.Length);

            SecondSideErrorProvider.SetError(SecondSideMaskedTextBox, errorMsg);
        }

        private void SecondSideMaskedTextBox_Validated(object sender, EventArgs e)
        {
            SecondSideErrorProvider.SetError(SecondSideMaskedTextBox, "");
        }

        //private void RadiusHeightMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    CheckKeyPress(e, RadiusHeightMaskedTextBox);
        //}

        //private void RadiusHeightMaskedTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (IsValueCorrect(RadiusHeightMaskedTextBox.Text, out var errorMsg))
        //    {
        //        RadiusHeightErrorProvider.SetError(RadiusHeightMaskedTextBox, "");
        //    }
        //    else
        //    {
        //        RadiusHeightErrorProvider.SetError(RadiusHeightMaskedTextBox, errorMsg);
        //    }
        //}
    }
}
