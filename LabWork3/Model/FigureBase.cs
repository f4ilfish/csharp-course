using System;

namespace Model
{
    /// <summary>
    /// Abstract class figure
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Min figure param value
        /// </summary>
        protected const double MinFigureParamValue = 0;

        /// <summary>
        /// Volume field's property
        /// </summary>
        public abstract double Volume { get; }

        /// <summary>
        /// Info field's property
        /// </summary>
        public abstract string Info { get; }

        /// <summary>
        /// Check positive value
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="minValue">Minimum allow value</param>
        protected static void CheckValue(double value, double minValue)
        {
            if (value < minValue)
            {
                throw new ArgumentOutOfRangeException(
                    $"{value} must be greater than {minValue}");
            }
        }
    }
}
