using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Pyramid UserControl class
    /// </summary>
    public partial class PyramidUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override bool IsValidControl => Validator.IsValidTextBoxes(PyramidTableLayout);

        /// <summary>
        /// Pyramid UserControl instance constructor
        /// </summary>
        public PyramidUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get Pyramid
        /// </summary>
        /// <returns></returns>
        public Pyramid GetPyramid()
        {
            var newPyramid = new Pyramid();

            var actions = new List<Action>()
            {
                () =>
                {
                    newPyramid.Height = Convert.ToDouble(HeightTextBox.Text);
                },

                () =>
                {
                    newPyramid.NumberOfCorners = Convert.ToInt32(NumberOfAnglesNumericUpDown.Text);
                },

                () =>
                {
                    newPyramid.LengthOfSide = Convert.ToDouble(SideTextBox.Text);
                },
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return newPyramid;
        }
    }
}
