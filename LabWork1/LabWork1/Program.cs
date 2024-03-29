﻿using System;
using System.Collections.Generic;
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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            // Create two lists
            var uchihaList = new PersonList();
            var evilList = new PersonList();

            // Create persons
            var saske = new Person("Saske", 
                                   "Uchiha", 
                                   18, GenderType.Male);
            var itachi = new Person("Itachi", 
                                    "Uchiha", 
                                    24, GenderType.Male);
            var izumi = new Person("Izumi", 
                                   "Uchiha", 
                                   14, GenderType.Female);

            var kisame = new Person("Kisame", 
                                    "Hoshikage", 
                                    30, GenderType.Male);
            var sasori = new Person("Sasori",
                                    "Akasuna", 
                                    15, GenderType.Male);
            var deidara = new Person("Deidara", 
                                     "Oonoki", 
                                     20, GenderType.Male);

            // Add persons to a lists
            uchihaList.AddToEnd(saske);
            uchihaList.AddToEnd(itachi);
            uchihaList.AddToEnd(izumi);

            evilList.AddToEnd(kisame);
            evilList.AddToEnd(sasori);
            evilList.AddToEnd(deidara);

            // Print lists
            ColorfulPrint("Create two lists:", ConsoleColor.Yellow);
            
            Console.WriteLine("  Uchiha list");
            PrintList(uchihaList);

            Console.WriteLine("  Evil list");
            PrintList(evilList);

            // Add new person to the first list
            var madara = new Person("Madara", 
                                    "Uchiha", 
                                    149, GenderType.Male);
            uchihaList.AddToEnd(madara);

            // Copy second person to the second list
            evilList.AddToEnd(uchihaList.GetPersonByIndex(1));

            // Print lists
            ColorfulPrint("Add new person to the first list " +
                          "and copy second person to the second list:", ConsoleColor.Yellow);
            
            Console.WriteLine("  Uchiha list");
            PrintList(uchihaList);

            Console.WriteLine("  Evil list");
            PrintList(evilList);

            // Delete second person from the first list
            uchihaList.DeleteByIndex(1);

            // Print lists
            ColorfulPrint("Delete second person from the first list:", ConsoleColor.Yellow);

            Console.WriteLine(" Uchiha list");
            PrintList(uchihaList);

            Console.WriteLine(" Evil list");
            PrintList(evilList);

            // Clear second list
            evilList.ClearList();

            // Print lists
            ColorfulPrint("Clear second list:", ConsoleColor.Yellow);

            Console.WriteLine(" Uchiha list");
            PrintList(uchihaList);

            Console.WriteLine(" Evil list");
            PrintList(evilList);

            // Input own person
            ColorfulPrint("Let's input own person:", ConsoleColor.Yellow);
            var ownPerson = ReadPerson();
            ColorfulPrint("Input person:", ConsoleColor.Yellow);
            Console.WriteLine(ownPerson.ToString());

        }

        /// <summary>
        /// Method to persons input
        /// </summary>
        /// <returns>Configure person</returns>
        private static Person ReadPerson()
        {
            var inputPerson = new Person();
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
    }
}
