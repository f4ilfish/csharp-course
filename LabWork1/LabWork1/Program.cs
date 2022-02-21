using System;
using System.Text.RegularExpressions;
using Model;

namespace View
{
    static class Program
    {
        static void Main()
        {
            /* Создали 2 списка
            var uchihaList = new PersonList();
            var evilList = new PersonList();

            // Создали 3*2 = 6 персон
            var saske = new Person("Saske", "Uchiha", 18, GenderType.Male);
            var itachi = new Person("Itachi", "Uchiha", 24, GenderType.Male);
            var izumi = new Person("Izumi", "Uchiha", 14, GenderType.Female);

            var kisame = new Person("Kisame", "Hoshikage", 30, GenderType.Male);
            var sasori = new Person("Sasori", "Akasuna", 15, GenderType.Male);
            var deidara = new Person("Deidara", "Oonoki", 20, GenderType.Male);

            // Добавили персоны в списки
            uchihaList.AddToEnd(saske);
            uchihaList.AddToEnd(itachi);
            uchihaList.AddToEnd(izumi);

            evilList.AddToEnd(kisame);
            evilList.AddToEnd(sasori);
            evilList.AddToEnd(deidara);

            // Вывели списки
            Console.WriteLine("---Uchiha list---");
            uchihaList.PrintList();

            Console.WriteLine("---Evil list---");
            evilList.PrintList();

            // Добавили новую персону в первый список
            var madara = new Person("Madara", "Uchiha", 149, GenderType.Male);
            uchihaList.AddToEnd(madara);

            // Копируем вторую персону во второй список
            evilList.AddToEnd(uchihaList.GetPersonByIndex(1));

            // Удаляем человека из списка
            uchihaList.DeleteByIndex(1);

            // Проверяем состав списков
            Console.WriteLine("---Uchiha list---");
            uchihaList.PrintList();

            Console.WriteLine("---Evil list---");
            evilList.PrintList();

            // Очищаем 2й список
            evilList.ClearList();

            // Проверяем состав списков
            Console.WriteLine("---Uchiha list---");
            uchihaList.PrintList();

            Console.WriteLine("---Evil list---");
            evilList.PrintList();
            */

            
            var tmpPerson = new Person
            {
                Name = CheckName(Console.ReadLine())
            };
            
            Console.WriteLine(tmpPerson.ToString());
        }

        /// <summary>
        /// Method to validate input age
        /// </summary>
        /// <param name="age">Input age</param>
        /// <returns></returns>
        private static int CheckAge(string age)
        {
            //TODO: RSDN
            if (!int.TryParse(age, out var checkedAge)) throw new ArgumentException("Аge must be an integer value");
            
            //TODO:
            if (checkedAge is > 0 and < 150)
            {
                return checkedAge;
            }

            //TODO:
            throw new ArgumentException("Age value must be in a range 0...150");
        }

        /// <summary>
        /// Method to validate input name
        /// </summary>
        /// <param name="name">Input name</param>
        /// <returns></returns>
        private static string CheckName(string name)
        {
            //TODO: RSDN
            var namePattern = new Regex(@"([A-Z][a-z]*((-[A-Za-z])*[a-z]*)*)|([А-Я][А-я]*((-[А-Яа-я])*[а-я]*)*)");
            var checkedName = name.Trim(' ');

            if (namePattern.IsMatch(checkedName))
            {
                return checkedName;
            }
            //TODO: RSDN
            throw new ArgumentException("Name must begin with a capital letter and consist only Cyrillic and Latin characters");
        }
    }
}
