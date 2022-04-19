using System;
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
        /// <summary>
        /// Figure
        /// </summary>
        private FigureBase FigureBase { get; set; }

        public EventHandler<FigureEventArgs> FigureAdded;

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
            var radioButtonToLabelName = new Dictionary<RadioButton, Dictionary<Label, string>>()
            {
                {SphereRadioButton, new Dictionary<Label, string>()
                {
                    {RadiusHeightLabel, "Radius:"}
                }},

                {PyramidRadioButton, new Dictionary<Label, string>()
                {
                    {RadiusHeightLabel, "Height:"},
                    {SideFirstSideLabel, "Side:"}
                }},

                {ParallelepipedRadioButton, new Dictionary<Label, string>()
                {
                    {RadiusHeightLabel, "Height:"},
                    {SideFirstSideLabel, "First side:"}
                }}
            };

            var radioButtonToControlEnable = new Dictionary<RadioButton, Dictionary<Control, bool>>()
            {
                {SphereRadioButton, new Dictionary<Control, bool>()
                {
                    {BaseGroupBox, false}
                }},

                {PyramidRadioButton, new Dictionary<Control, bool>()
                {
                    {BaseGroupBox, true},
                    {NumberOfCornersNumericUpDown, true},
                    {SidesAngleMaskedTextBox, false},
                    {SecondSideMaskedTextBox, false}
                }},

                {ParallelepipedRadioButton, new Dictionary<Control, bool>()
                {
                    {BaseGroupBox, true},
                    {NumberOfCornersNumericUpDown, false},
                    {SidesAngleMaskedTextBox, true},
                    {SideFirstSideMaskedTextBox, true},
                    {SecondSideMaskedTextBox, true}
                }},
            };

            foreach (var radioButtonLabelPair in radioButtonToLabelName)
            {
                if (sender.Equals(radioButtonLabelPair.Key))
                {
                    foreach (var labelNamePair in radioButtonLabelPair.Value)
                    {
                        labelNamePair.Key.Text = labelNamePair.Value;
                    }

                    foreach (var radioButtonControlPair in radioButtonToControlEnable[radioButtonLabelPair.Key])
                    {
                        radioButtonControlPair.Key.Enabled = radioButtonControlPair.Value;
                    }
                }
            }

            CheckedRadioButton = (RadioButton)sender;
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
            
            var errorMessage = !IsValidValue(maskedTextBox.Text, out var errorMsg)
                ? errorMsg
                : "";
            
            TextBoxToErrProvider[maskedTextBox].SetError(maskedTextBox, errorMessage);
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
            var dictionary = new Dictionary<RadioButton, (string, Func<FigureBase>)>()
            {
                { SphereRadioButton, ("Sphere", GetSphere) },
                { PyramidRadioButton, ("Pyramid", GetPyramid) },
                { ParallelepipedRadioButton, ("Parallelepiped", GetParallelepiped) },
            };
            
            if (IsValidTextBoxes(CheckedRadioButton))
            {
                var figureString = string.Empty;
                
                foreach (var valueTuple in dictionary)
                {
                    if (CheckedRadioButton.Equals(valueTuple.Key))
                    {
                        FigureBase = valueTuple.Value.Item2.Invoke();
                        
                        FigureAdded.Invoke(this, new FigureEventArgs(FigureBase));

                        figureString = valueTuple.Value.Item1;
                    }
                }
                MessageBox.Show($"{figureString} added");
            }
            else
            {
                MessageBox.Show("Some of the parameters are missing or not valid");
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
