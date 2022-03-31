using System;

namespace Model
{
    /// <summary>
    /// Class sphere
    /// </summary>
    public class Sphere : FigureBase
    {
        /// <summary>
        /// Sphere radius
        /// </summary>
        private double _radius;

        /// <summary>
        /// Sphere radius's property
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _radius = value;
            }
        }

        /// <summary>
        /// Sphere's default instance constructor
        /// </summary>
        public Sphere(){}

        /// <summary>
        /// Sphere's instance constructor
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override double GetVolume()
        {
            var volume = 4 * Math.PI * Math.Pow(Radius, 3) / 3;

            return Math.Round(volume, 2);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override string GetFigureInfo()
        {
            return $"Sphere R: {Radius}";
        }

        /// <summary>
        /// Get random sphere
        /// </summary>
        /// <returns></returns>
        public static Sphere GetRandomSphere()
        {
            var rnd = new Random();
            const int maxRadius = 100;

            var tmpRadius = rnd.Next((int)MinFigureParamValue, maxRadius)
                            + Math.Round(rnd.NextDouble(), 2);

            return new Sphere(tmpRadius);
        }
    }
}