using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Parallelepiped UserControl class
    /// </summary>
    public partial class ParallelepipedUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override bool IsValidControl => Validator.IsValidTextBoxes(ParallelepipedTableLayout);

        /// <summary>
        /// Parallelepiped UserControl instance constructor
        /// </summary>
        public ParallelepipedUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get Parallelepiped
        /// </summary>
        /// <returns></returns>
        public Parallelepiped GetParallelepiped()
        {
            var newParallelepiped = new Parallelepiped();

            var actions = new List<Action>()
            {
                () =>
                {
                    newParallelepiped.Height = Convert.ToDouble(HeightTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.LengthFirstSide = Convert.ToDouble(FirstSideTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.LengthSecondSide = Convert.ToDouble(SecondSideTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.AngleOfSides = Convert.ToDouble(AngleOfSidesTextBox.Text);
                },
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return newParallelepiped;
        }
    }
}
