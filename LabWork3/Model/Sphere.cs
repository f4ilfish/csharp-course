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
        private double Radius
        {
            get => _radius;
            set
            {
                CheckValue(value, MinFigureParamValue);
                _radius = value;
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override double Volume => 4 * Math.PI * Math.Pow(Radius, 3) / 3;

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string Info => $"Sphere R: {Radius}";

        /// <summary>
        /// Sphere's instance constructor
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            Radius = radius;
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