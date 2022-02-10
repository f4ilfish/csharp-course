using System;
using Model;

namespace View
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // Создали 2 списка
            var uchihaList = new PersonList();
            var evilList = new PersonList();

            // Создали 3*2 = 6 персон
            var saske = new Person("Saske", "Uchiha", 18, GenderType.Male);
            var itachi = new Person("Itachi", "Uchiha", 24, GenderType.Male);
            var izumi = new Person("Izumi", "Uchiha", 14, GenderType.Female);

            var kisame = new Person("Kisame", "Hoshikage", 30, GenderType.Male);
            var sasori = new Person("Sasori", "Akasuna", 15, GenderType.Male);
            var deidara = new Person("Deidara", "Oonoki", 20, GenderType.Male);

            // Добавили персон в списки
            uchihaList.AddToEnd(saske);
            uchihaList.AddToEnd(itachi);
            uchihaList.AddToEnd(izumi);

            evilList.AddToEnd(kisame);
            evilList.AddToEnd(sasori);
            evilList.AddToEnd(deidara);

            // Вывели списки
            Console.WriteLine("---Uchiha list---");
            for (var i = 0; i < uchihaList.NumberOfPersons; i++)
            {
                Console.WriteLine(uchihaList.GetPersonByIndex(i).ToString());
            }

            Console.WriteLine("---Evil list---");
            for (var i = 0; i < evilList.NumberOfPersons; i++)
            {
                Console.WriteLine(evilList.GetPersonByIndex(i).ToString());
            }

            // Добавили новую персону в первый список
            var madara = new Person("Madara", "Uchiha", 300, GenderType.Male);
            uchihaList.AddToEnd(madara);

            // Копируем вторую персону во второй список
            evilList.AddToEnd(uchihaList.GetPersonByIndex(1));

            // Удаляем человека из списка
            uchihaList.DeleteByIndex(1);

            // Проверяем состав списков
            Console.WriteLine("---Uchiha list---");
            for (var i = 0; i < uchihaList.NumberOfPersons; i++)
            {
                Console.WriteLine(uchihaList.GetPersonByIndex(i).ToString());
            }

            Console.WriteLine("---Evil list---");
            for (var i = 0; i < evilList.NumberOfPersons; i++)
            {
                Console.WriteLine(evilList.GetPersonByIndex(i).ToString());
            }

            // Очищаем 2й список
            evilList.ClearList();

            // Проверяем состав списков
            Console.WriteLine("---Uchiha list---");
            for (var i = 0; i < uchihaList.NumberOfPersons; i++)
            {
                Console.WriteLine(uchihaList.GetPersonByIndex(i).ToString());
            }

            Console.WriteLine("---Evil list---");
            for (var i = 0; i < evilList.NumberOfPersons; i++)
            {
                Console.WriteLine(evilList.GetPersonByIndex(i).ToString());
            }
        }
    }
}
