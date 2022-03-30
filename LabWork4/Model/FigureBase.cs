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
        /// Abstract method to get figure volume
        /// </summary>
        /// <returns></returns>
        public abstract double GetVolume();

        /// <summary>
        /// Abstract method to get figure info
        /// </summary>
        /// <returns></returns>
        public abstract string GetFigureInfo();

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