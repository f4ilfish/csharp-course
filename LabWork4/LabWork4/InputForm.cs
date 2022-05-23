using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// IsFormClosed field
        /// </summary>
        private bool _isFormClosed;

        /// <summary>
        /// Handler to event of add figure
        /// </summary>
        public EventHandler<FigureEventArgs> FigureAdded;

        /// <summary>
        /// Handler to event of add figure
        /// </summary>
        public new EventHandler<FormCloseEventArgs> FormClosed;

        /// <summary>
        /// Dictionary of RadioButton to it's UserControl
        /// </summary>
        private readonly Dictionary<RadioButton, UserControl> _radioButtonToUserControl;

        /// <summary>
        /// Dictionary of RadioButton to it's tuple of Figure -> GetMethod
        /// </summary>
        private readonly Dictionary<RadioButton, (string, Func<FigureBase>)> _radioButtonToFigure;

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

#if !DEBUG
            AddRandomFigureButton.Visible = true;
#endif

            SphereRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            PyramidRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            ParallelepipedRadioButton.CheckedChanged += RadioButton_CheckedChanged;

            _radioButtonToUserControl = new Dictionary<RadioButton, UserControl>()
            {
                {SphereRadioButton, SphereUserControl},
                {PyramidRadioButton, PyramidUserControl},
                {ParallelepipedRadioButton, ParallelepipedUserControl}
            };

            _radioButtonToFigure = new Dictionary<RadioButton, (string, Func<FigureBase>)>()
            {
                { SphereRadioButton, (nameof(Sphere), 
                                      SphereUserControl.GetSphere)
                },
                { PyramidRadioButton, (nameof(Pyramid), 
                                       PyramidUserControl.GetPyramid)
                },
                { ParallelepipedRadioButton, (nameof(Parallelepiped), 
                                              ParallelepipedUserControl.GetParallelepiped)
                },
            };

        }

        /// <summary>
        /// Event RadioButton checked change
        /// </summary>
        /// <param name="sender">RadioButton</param>
        /// <param name="e">Event argument</param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectFigureGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(radioButton =>
            {
                _radioButtonToUserControl[radioButton].Visible = radioButton.Checked;

                if (radioButton.Checked)
                {
                    CheckedRadioButton = radioButton;
                }
            });
        }

        /// <summary>
        /// Event OkInputButton click
        /// </summary>
        /// <param name="sender">OkInputButton</param>
        /// <param name="e">Event argument</param>
        private void OkInputButton_Click(object sender, EventArgs e)
        {
            if (((FigureBaseUserControl) _radioButtonToUserControl[CheckedRadioButton]).IsValidControl)
            {
                foreach (var valueTuple in _radioButtonToFigure)
                {
                    if (CheckedRadioButton.Equals(valueTuple.Key))
                    {
                        FigureBase = valueTuple.Value.Item2.Invoke();
                        
                        FigureAdded.Invoke(this, new FigureEventArgs(FigureBase));
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Some of parameters are missing or not valid");
            }
        }

        /// <summary>
        /// Event CancelInputButton click
        /// </summary>
        /// <param name="sender">CancelInputButton</param>
        /// <param name="e">Event argument</param>
        private void CancelInputButton_Click(object sender, EventArgs e)
        {
            _isFormClosed = true;

            FormClosed.Invoke(this, new FormCloseEventArgs(_isFormClosed));

            Close();
        }

#if !DEBUG
        private void AddRandomFigureButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            var choseFigure = rnd.Next(3);
            
            switch (choseFigure)
            {
                case 0:
                    FigureBase = Sphere.GetRandomSphere();
                    FigureAdded.Invoke(this, new FigureEventArgs(FigureBase));
                    break;
                case 1:
                    FigureBase = Pyramid.GetRandomPyramid();
                    FigureAdded.Invoke(this, new FigureEventArgs(FigureBase));
                    break;
                case 2:
                    FigureBase = Parallelepiped.GetRandomParallelepiped();
                    FigureAdded.Invoke(this, new FigureEventArgs(FigureBase));
                    break;
            }
        }
#endif
    }
}
