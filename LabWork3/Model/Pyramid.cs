using System;

namespace Model
{
    /// <summary>
    /// Class pyramid
    /// </summary>
    public class Pyramid : FigureBase
    {
        /// <summary>
        /// Height
        /// </summary>
        private double _height;

        /// <summary>
        /// Number of corners of the base of the pyramid
        /// </summary>
        private int _numberOfCorners;

        /// <summary>
        /// Length of the side of the base of the pyramid
        /// </summary>
        private double _lengthOfSide;

        /// <summary>
        /// Max number of corners of the base of the pyramid
        /// </summary>
        private const int MinCornersNumber = 3;

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
        /// NumberOfCorners field's property
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private int NumberOfCorners
        {
            get => _numberOfCorners;
            set
            {
                //TODO:{}
                if (value < MinCornersNumber) throw new ArgumentOutOfRangeException(
                    $"{value} must be greater than {MinCornersNumber}");
                
                _numberOfCorners = value;
            }
        }

        /// <summary>
        /// LengthOfSide field's property
        /// </summary>
        private double LengthOfSide
        {
            get => _lengthOfSide;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _lengthOfSide = value;
            }
        }

        /// <summary>
        /// Pyramid's instance constructor
        /// </summary>
        /// <param name="height">Height of pyramid</param>
        /// <param name="numberOfCorners">Number of corners</param>
        /// <param name="lengthOfSide">Length of the side</param>
        public Pyramid(double height, int numberOfCorners, double lengthOfSide)
        {
            Height = height;
            NumberOfCorners = numberOfCorners;
            LengthOfSide = lengthOfSide;
        }

        /// <summary>
        /// Get base area value
        /// </summary>
        /// <returns></returns>
        private double GetBaseArea()
        {
            return NumberOfCorners * Math.Pow(LengthOfSide, 2) /
                   (4 * Math.Tan(Math.PI / NumberOfCorners));
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override double GetVolume()
        {
            var baseArea = GetBaseArea();
            var volume = baseArea * Height / 3;
            
            return Math.Round(volume, 2);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override string GetFigureInfo()
        {
            return $"Pyramid H: {Height}; N: {NumberOfCorners}; L: {LengthOfSide}";
        }

        /// <summary>
        /// Get random parallelepiped
        /// </summary>
        /// <returns></returns>
        public static Pyramid GetRandomPyramid()
        {
            var rnd = new Random();
            const int maxLengthHeight = 100;
            const int maxCornersNumbers = 12;

            var tmpHeight = rnd.Next((int)MinFigureParamValue, maxLengthHeight)
                            + Math.Round(rnd.NextDouble(), 2);
            var tmpNumberOfCorners = rnd.Next(MinCornersNumber, maxCornersNumbers);
            var tmpLengthSide = rnd.Next((int)MinFigureParamValue, maxLengthHeight)
                             + Math.Round(rnd.NextDouble(), 2);

            return new Pyramid(tmpHeight, tmpNumberOfCorners, tmpLengthSide);
        }
    }
}