using System;
using System.Globalization;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Class that describe a certain person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Surname
        /// </summary>
        private string _surname;

        /// <summary>
        /// Age
        /// </summary>
        private int _age;
        
        /// <summary>
        /// Gender
        /// </summary>
        private GenderType _gender;

        /// <summary>
        /// Name field's property
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Surname field's property
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        ///  <summary>
        /// Age field's property
        ///  </summary>
        ///  <exception cref="ArgumentException"></exception>
        public int Age
        {
            get => _age;
            set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException($"Age value must be in a range [{MinAge}:{MaxAge}]");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Gender field's property
        /// </summary>
        public GenderType Gender
        {
            get => _gender;
            set => _gender = value;
        }

        /// <summary>
        /// Max Age field's property
        /// </summary>
        public int MaxAge { get; } = 150;

        /// <summary>
        /// Min Age field's property
        /// </summary>
        public int MinAge { get; } = 0;

        /// <summary>
        /// Create an instance of the class Person
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="surname">Person surname</param>
        /// <param name="age">Peron age</param>
        /// <param name="gender">Person gender</param>
        public Person(string name, string surname, int age, GenderType gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Create a default instance of the class Person
        /// </summary>
        public Person() : this("Unknown", "Unknown", 99, GenderType.Other)
        {

        }

        /// <summary>
        /// Convert class field value to string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Surname}; {Age}; {Gender}";
        }

        /// <summary>
        /// Get random person with random name, surname
        /// </summary>
        /// <param name="gender"></param>
        public void GetRandomPerson(GenderType gender)
        {
            string[] maleNames =
            {
                "Naruto", "Kakashi", "Sasuke", "Itachi", "Gaara",
                "Shikamaru", "Neji", "Kiba", "Orichimaru", "Kisame"
            };

            string[] femaleNames =
            {
                "Hinata", "Tsunage", "Sakura", "Temari", "Anko",
                "Shizune", "TenTen", "Ino", "Matusri", "Sari"
            };

            string[] surnames =
            {
                "Hyuga", "Uchiha", "Uzumaki", "Haruno",
                "Namikaze", "Nara", "Inuzuka", "Lee"
            };

            Random random = new Random();
            switch (gender)
            {
                case GenderType.Male:
                    Name = maleNames[random.Next(maleNames.Length)];
                    break;
                case GenderType.Female:
                    Name = femaleNames[random.Next(femaleNames.Length)];
                    break;
                case GenderType.Other:
                    var tmpNames = maleNames.Concat(femaleNames).ToArray();
                    Name = tmpNames[random.Next(tmpNames.Length)];
                    break;

            }
            Surname = surnames[random.Next(surnames.Length)];
            Gender = gender;
        }
    }
}
