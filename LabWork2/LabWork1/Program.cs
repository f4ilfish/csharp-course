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
            var tmpAdult = new Adult("Mikhail", "Chernobrov", 23, GenderType.Male, 12345678, null, null);
            var tmpChild = new Child("Misha", "Chernobrov", 1, GenderType.Male, null, null, null);

            Console.WriteLine(tmpAdult.ToString());
            Console.WriteLine(tmpChild.ToString());

            /*
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            // Input person
            ColorfulPrint("Let's input own person:", ConsoleColor.Yellow);
            var ownPerson = ReadPerson();
            
            // Print person
            ColorfulPrint("Input person:", ConsoleColor.Yellow);
            Console.WriteLine(ownPerson.ToString());
            */
        }

        /*
        /// <summary>
        /// Method to persons input
        /// </summary>
        /// <returns>Configure person</returns>
        private static PersonBase ReadPerson()
        {
            var inputPerson = new PersonBase();
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (
                    () =>
                    {
                        inputPerson.Name = Console.ReadLine();
                    },
                    "Input name of person:"),
                (
                    () =>
                    {
                        inputPerson.Surname = Console.ReadLine();
                    },
                    "Input surname of person:"),
                (
                    () =>
                    {
                        inputPerson.Age =
                            Convert.ToInt32(Console.ReadLine());
                    },
                    "Input age of person:"),
                (
                    () =>
                    {
                        var gender = Convert.ToInt32(Console.ReadLine());
                        switch (gender)
                        {
                            case 1:
                            {
                                inputPerson.Gender = GenderType.Male;
                                return;
                            }
                            case 2:
                            {
                                inputPerson.Gender = GenderType.Female;
                                return;
                            }
                            case 3:
                                inputPerson.Gender = GenderType.Other;
                                return;
                            default:
                            {
                                throw new ArgumentException
                                    ("Please input 1, 2 or 3");
                            }
                        }
                    },
                    "Choose gender of person. " +
                    "Input 1 - Male, 2 - Female, 3 - Other.")
            };

            foreach(var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return inputPerson;
        }

        /// <summary>
        /// Handler of enter person from console
        /// </summary>
        /// <param name="action">Executable action</param>
        /// <param name="inputMessage">Message to action</param>
        private static void ActionHandler(Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    ColorfulPrint(e.Message, ConsoleColor.Red);
                    ColorfulPrint("Please try again.", ConsoleColor.Green);
                }
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
                    Console.WriteLine(tmpPerson.ToString());
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
        */
    }
}
