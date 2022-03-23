using System;
using System.Collections.Generic;
using Model;

namespace View
{
    public static class Program
    {
        private static void Main()
        {
            var figureList = new List<FigureBase>();
            var rnd = new Random();

            for (var i = 0; i < 10; i++)
            {
                var choseFigure = rnd.Next(3);
                switch (choseFigure)
                {
                    case 0:
                        figureList.Add(Sphere.GetRandomSphere());
                        break;
                    case 1:
                        figureList.Add(Pyramid.GetRandomPyramid());
                        break;
                    case 2:
                        figureList.Add(Parallelepiped.GetRandomParallelepiped());
                        break;
                    default:
                        Console.WriteLine("Unknown chose of figure");
                        break;
                }
            }

            ColorfulPrint(">>> Created figures:", ConsoleColor.Yellow);
            foreach (var tmpFigure in figureList)
            {
                Console.WriteLine(tmpFigure.GetFigureInfo());
            }

            ColorfulPrint(">>> Volumes of figures:", ConsoleColor.Yellow);
            foreach (var tmpFigure in figureList)
            {
                Console.WriteLine($"{tmpFigure.GetType()} have {tmpFigure.GetVolume()} volume");
            }
        }

        /// <summary>
        /// Method to print colorful text
        /// </summary>
        /// <param name="text">Input text</param>
        /// <param name="color">Color</param>
        private static void ColorfulPrint(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($">>> {text}");
            Console.ResetColor();
        }
    }
}
