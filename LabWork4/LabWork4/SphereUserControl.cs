using System;
using System.Collections.Generic;
using Model;

namespace View
{
    /// <summary>
    /// Sphere UserControl class constructor
    /// </summary>
    public partial class SphereUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override bool IsValidControl => Validator.IsValidTextBoxes(SphereTableLayout);

        /// <summary>
        /// Sphere UserControl instance constructor
        /// </summary>
        public SphereUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get sphere
        /// </summary>
        /// <returns></returns>
        public Sphere GetSphere()
        {
            var newSphere = new Sphere();

            var actions = new List<Action>()
            {
                () =>
                {
                    newSphere.Radius = Convert.ToDouble(RadiusTextBox.Text);
                }
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return newSphere;
        }
    }
}
