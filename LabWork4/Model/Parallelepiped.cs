using System;

namespace Model
{
    /// <summary>
    /// Class parallelepiped
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Height
        /// </summary>
        private double _height;

        /// <summary>
        /// Length of the first side of the base of the parallelepiped
        /// </summary>
        private double _lengthOfFirstSide;

        /// <summary>
        /// Length of the second side of the base of the parallelepiped
        /// </summary>
        private double _lengthOfSecondSide;

        /// <summary>
        /// Angle between first and second side in degrees
        /// </summary>
        private double _angleOfSides;

        /// <summary>
        /// Max angle value
        /// </summary>
        private const double MaxAngle = 180;

        /// <summary>
        /// Min angle value
        /// </summary>
        private const double MinAngle = 0;

        /// <summary>
        /// Height field's property
        /// </summary>
        private double Height
        {
            get => _height;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _height = value;
            }
        }

        /// <summary>
        /// First side field's property
        /// </summary>
        private double LengthFirstSide
        {
            get => _lengthOfFirstSide;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _lengthOfFirstSide = value;
            }
        }

        /// <summary>
        /// Second side field's property
        /// </summary>
        private double LengthSecondSide
        {
            get => _lengthOfSecondSide;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _lengthOfSecondSide = value;
            }
        }

        /// <summary>
        /// Angle of sides field's property
        /// </summary>
        private double AngleOfSides
        {
            get => _angleOfSides;
            set
            {
                if (value is <= MinAngle or >= MaxAngle)
                    throw new ArgumentOutOfRangeException(
                    $"{value} must be greater than {MinAngle} " +
                    $"or less than {MaxAngle}");

                _angleOfSides = value;
            }
        }


        /// <summary>
        /// Parallelepiped's instance constructor
        /// </summary>
        /// <param name="height">Height of parallelepiped</param>
        /// <param name="lengthOfFirstSide">First side</param>
        /// <param name="lengthOfSecondSide">Second side</param>
        /// <param name="angleOfSides"></param>
        public Parallelepiped(double height,
                              double lengthOfFirstSide,
                              double lengthOfSecondSide,
                              double angleOfSides)
        {
            Height = height;
            LengthFirstSide = lengthOfFirstSide;
            LengthSecondSide = lengthOfSecondSide;
            AngleOfSides = angleOfSides;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override double GetVolume()
        {
            var volume = LengthFirstSide * LengthSecondSide *
                         Math.Sin(AngleOfSides * Math.PI / 180) * Height;

            return Math.Round(volume, 2);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override string GetFigureInfo()
        {
            return $"Parallelepiped H: {Height}; L1: {LengthFirstSide}; " +
                   $"L2: {LengthSecondSide}; Angle: {AngleOfSides}";
        }

        /// <summary>
        /// Get random parallelepiped
        /// </summary>
        /// <returns></returns>
        public static Parallelepiped GetRandomParallelepiped()
        {
            var rnd = new Random();
            const int maxLengthSide = 100;


            var tmpHeight = rnd.Next((int)MinFigureParamValue, maxLengthSide)
                            + Math.Round(rnd.NextDouble(), 2);
            var tmpLengthFirstSide = rnd.Next((int)MinFigureParamValue, maxLengthSide)
                                     + Math.Round(rnd.NextDouble(), 2);
            var tmpLengthSecondSide = rnd.Next((int)MinFigureParamValue, maxLengthSide)
                                      + Math.Round(rnd.NextDouble(), 2);
            var tmpAngle = rnd.Next((int)MinAngle, (int)MaxAngle)
                           + Math.Round(rnd.NextDouble(), 2);

            return new Parallelepiped(tmpHeight, tmpLengthFirstSide, tmpLengthSecondSide, tmpAngle);
        }
    }
}