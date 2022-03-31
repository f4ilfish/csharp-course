﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Class input form
    /// </summary>
    public partial class InputForm : Form
    {
        ///// <summary>
        ///// Main form reference
        ///// </summary>
        //private MainForm MainForm { get; set; }

        /// <summary>
        /// Figure
        /// </summary>
        private FigureBase FigureBase { get; set; }

        /// <summary>
        /// Dictionary of matching RadioButton to it's list of MaskedTextBoxes
        /// </summary>
        private Dictionary<RadioButton, List<MaskedTextBox>> RadioButtonToTextBoxes { get; set; }

        /// <summary>
        /// Dictionary of matching MaskedTextBox to it's ErrorProvider
        /// </summary>
        private Dictionary<MaskedTextBox, ErrorProvider> TextBoxToErrProvider { get; set; }
        
        /// <summary>
        /// Current checked RadioButton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }

        /// <summary>
        /// Input form instance creator
        /// </summary>
        public InputForm()
        {
            InitializeComponent();

            SphereRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            PyramidRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            ParallelepipedRadioButton.CheckedChanged += RadioButton_CheckedChanged;

            RadioButtonToTextBoxes = new Dictionary<RadioButton, List<MaskedTextBox>>()
            {
                {
                    SphereRadioButton, new List<MaskedTextBox>(){RadiusHeightMaskedTextBox}
                },

                {
                    PyramidRadioButton, new List<MaskedTextBox>(){RadiusHeightMaskedTextBox, 
                                                                  SideFirstSideMaskedTextBox}
                },

                {
                    ParallelepipedRadioButton, new List<MaskedTextBox>(){RadiusHeightMaskedTextBox, 
                                                                         SidesAngleMaskedTextBox, 
                                                                         SideFirstSideMaskedTextBox, 
                                                                         SecondSideMaskedTextBox}
                }
            };

            TextBoxToErrProvider = new Dictionary<MaskedTextBox, ErrorProvider>()
            {
                {RadiusHeightMaskedTextBox, RadiusHeightErrorProvider},
                {SidesAngleMaskedTextBox, SidesAngleErrorProvider},
                {SideFirstSideMaskedTextBox, SideFirstSideErrorProvider},
                {SecondSideMaskedTextBox, SecondSideErrorProvider}
            };

            RadiusHeightMaskedTextBox.TextChanged += MaskedTextBox_TextChanged;
            SidesAngleMaskedTextBox.TextChanged += MaskedTextBox_TextChanged;
            SideFirstSideMaskedTextBox.TextChanged += MaskedTextBox_TextChanged;
            SecondSideMaskedTextBox.TextChanged += MaskedTextBox_TextChanged;
        }

        /// <summary>
        /// Event RadioButton checked change
        /// </summary>
        /// <param name="sender">RadioButton</param>
        /// <param name="e">Event argument</param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            string radioButtonName = radioButton.Name;

            switch (radioButtonName)
            {
                case "SphereRadioButton":
                    CheckedRadioButton = SphereRadioButton;

                    RadiusHeightLabel.Text = "Radius:";
                    BaseGroupBox.Enabled = false;
                    break;
                
                case "PyramidRadioButton":
                    CheckedRadioButton = PyramidRadioButton;

                    RadiusHeightLabel.Text = "Height:";
                    SideFirstSideLabel.Text = "Side:";

                    BaseGroupBox.Enabled = true;
                    NumberOfCornersNumericUpDown.Enabled = true;
                    SidesAngleMaskedTextBox.Enabled = false;
                    SecondSideMaskedTextBox.Enabled = false;
                    break;
                
                case "ParallelepipedRadioButton":
                    CheckedRadioButton = ParallelepipedRadioButton;

                    RadiusHeightLabel.Text = "Height:";
                    SideFirstSideLabel.Text = "First side:";

                    BaseGroupBox.Enabled = true;
                    NumberOfCornersNumericUpDown.Enabled = false;

                    foreach (var control in BaseGroupBox.Controls)
                    {
                        if (control.GetType() == typeof(MaskedTextBox))
                        {
                            ((MaskedTextBox)control).Enabled = true;
                        }
                    }
                    break;
            }
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
        /// Event MaskedTextBox text changed
        /// </summary>
        /// <param name="sender">MaskedTextBox</param>
        /// <param name="e">Event argument</param>
        private void MaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox) sender;

            if (!IsValidValue(maskedTextBox.Text, out var errorMsg))
            {
                TextBoxToErrProvider[maskedTextBox].SetError(maskedTextBox, errorMsg);
            }
            else
            {
                TextBoxToErrProvider[maskedTextBox].SetError(maskedTextBox, "");
            }
        }

        /// <summary>
        /// Validating of corresponding RadioButton MaskedTextBoxes
        /// </summary>
        /// <param name="radioButton">RadioButton</param>
        /// <returns></returns>
        private bool IsValidTextBoxes(RadioButton radioButton)
        {
            foreach (var textBox in RadioButtonToTextBoxes[radioButton])
            {
                if (TextBoxToErrProvider[textBox].GetError(textBox) != "" || textBox.Text.Length == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Set figure field's value
        /// </summary>
        /// <param name="action"></param>
        private void SetValue(Action action)
        {
            action.Invoke();
        }

        /// <summary>
        /// Get sphere
        /// </summary>
        /// <returns></returns>
        private Sphere GetSphere()
        {
            var newSphere = new Sphere();

            var actions = new List<Action>()
            {
                () =>
                {
                    newSphere.Radius = Convert.ToDouble(RadiusHeightMaskedTextBox.Text);
                }
            };
            actions.ForEach(SetValue);
            return newSphere;
        }

        /// <summary>
        /// Get Pyramid
        /// </summary>
        /// <returns></returns>
        private Pyramid GetPyramid()
        {
            var newPyramid = new Pyramid();

            var actions = new List<Action>()
            {
                () =>
                {
                    newPyramid.Height = Convert.ToDouble(RadiusHeightMaskedTextBox.Text);
                },

                () =>
                {
                    newPyramid.NumberOfCorners = Convert.ToInt32(NumberOfCornersNumericUpDown.Text);
                },

                () =>
                {
                    newPyramid.LengthOfSide = Convert.ToDouble(SideFirstSideMaskedTextBox.Text);
                },
            };
            actions.ForEach(SetValue);
            return newPyramid;
        }

        /// <summary>
        /// Get Parallelepiped
        /// </summary>
        /// <returns></returns>
        private Parallelepiped GetParallelepiped()
        {
            var newParallelepiped = new Parallelepiped();

            var actions = new List<Action>()
            {
                () =>
                {
                    newParallelepiped.Height = Convert.ToDouble(RadiusHeightMaskedTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.LengthFirstSide = Convert.ToDouble(SideFirstSideMaskedTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.LengthSecondSide = Convert.ToDouble(SecondSideMaskedTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.AngleOfSides = Convert.ToDouble(SidesAngleMaskedTextBox.Text);
                },
            };

            actions.ForEach(SetValue);
            return newParallelepiped;
        }

        /// <summary>
        /// Event OkInputButton click
        /// </summary>
        /// <param name="sender">OkInputButton</param>
        /// <param name="e">Event argument</param>
        private void OkInputButton_Click(object sender, EventArgs e)
        {
            switch (CheckedRadioButton.Name)
            {
                case "SphereRadioButton":

                    if (IsValidTextBoxes(CheckedRadioButton))
                    {
                        FigureBase = GetSphere();
                        MessageBox.Show("Sphere added");
                    }
                    else
                    {
                        MessageBox.Show("Some of the parameters are missing");
                    }

                    break;
                
                case "PyramidRadioButton":

                    if (IsValidTextBoxes(CheckedRadioButton))
                    {
                        FigureBase = GetPyramid();
                        MessageBox.Show("Pyramid added");
                    }
                    else
                    {
                        MessageBox.Show("Some of the parameters are missing");
                    }

                    break;
                
                case "ParallelepipedRadioButton":

                    if (IsValidTextBoxes(CheckedRadioButton))
                    {
                        FigureBase = GetParallelepiped();
                        MessageBox.Show("Parallelepiped added");
                    }
                    else
                    {
                        MessageBox.Show("Some of the parameters are missing");
                    }

                    break;
            }
        }

        /// <summary>
        /// Event CancelInputButton click
        /// </summary>
        /// <param name="sender">CancelInputButton</param>
        /// <param name="e">Event argument</param>
        private void CancelInputButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}