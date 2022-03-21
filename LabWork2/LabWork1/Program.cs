using System;
using Model;

namespace View
{
    /// <summary>
    /// Class program
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        private static void Main()
        {
            var tmpPersonList = new PersonList();
            var rnd = new Random();

            for (var i = 0; i < 8; i++)
            {
                PersonBase randomPerson = 
                    rnd.Next(2) == 0
                    ? Adult.GetRandomPerson()
                    : Child.GetRandomPerson();
                tmpPersonList.AddToEnd(randomPerson);
            }

            ColorfulPrint("Created list:", ConsoleColor.Yellow);
            PrintList(tmpPersonList);

            ColorfulPrint("What the fourth person's mission:", ConsoleColor.Yellow);
            
            var person = tmpPersonList.GetPersonByIndex(3);

            switch (person)
            {
                case Adult adult:
                    //TODO: static
                    Adult.GetHardMission();
                    break;
                case Child:
                    Child.GetEasyMission();
                    break;
                default:
                    ColorfulPrint("Unknown person type", ConsoleColor.DarkRed);
                    break;
            }
        }

        /// <summary>
        /// Method to print list to console
        /// </summary>
        /// <param name="listOfPersons">Input list of persons</param>
        private static void PrintList(PersonList listOfPersons)
        {
            if (listOfPersons.NumberOfPersons != 0)
            {
                for (var i = 0; i < listOfPersons.NumberOfPersons; i++)
                {
                    var tmpPerson = listOfPersons.GetPersonByIndex(i);
                    Console.WriteLine(tmpPerson.GetInfo());
                }
            }
            else
            {
                ColorfulPrint("List is empty.", ConsoleColor.Red);
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
