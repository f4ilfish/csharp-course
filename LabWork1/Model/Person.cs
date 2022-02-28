using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

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
        /// Maximum age value
        /// </summary>
        private const int MaxAge = 150;

        /// <summary>
        /// Minimum age value
        /// </summary>
        private const int MinAge = 0;

        /// <summary>
        /// Name field's property
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = FormatName(value);
            }
        }

        /// <summary>
        /// Surname field's property
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                CheckAccordanceSurnameToName(value);
                _surname = FormatName(value);
            }
        }

        ///  <summary>
        /// Age field's property
        ///  </summary>
        public int Age
        {
            get => _age;
            set
            {
                CheckAge(value);
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
        public Person() : this("Unknown", 
                               "Unknown", 
                               99, GenderType.Other)
        { }

        /// <summary>
        /// Convert class field value to string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Surname}; {Age}; {Gender}";
        }
        
        /// <summary>
        /// Set random name, surname person's parameters
        /// </summary>
        public static Person GetRandomPerson()
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

            var random = new Random();

            var numberOfGenders = Enum.GetNames(typeof(GenderType)).Length;
            var chosenGender = random.Next(numberOfGenders - 1);

            var tmpGender = GenderType.Other;
            var tmpName = "Unknown";
            
            switch (chosenGender)
            {
                case 0:
                    tmpGender = GenderType.Male;
                    tmpName = maleNames[random.Next(maleNames.Length)];
                    break;
                case 1:
                    tmpGender = GenderType.Female;
                    tmpName = femaleNames[random.Next(femaleNames.Length)];
                    break;
                case 2:
                    tmpGender = GenderType.Other;
                    var tmpNames = maleNames.Concat(femaleNames).ToArray();
                    tmpName = tmpNames[random.Next(tmpNames.Length)];
                    break;
            }

           var tmpSurname = surnames[random.Next(surnames.Length)];
           var tmpAge = random.Next(MaxAge);

           return new Person(tmpName, tmpSurname, tmpAge, tmpGender);
        }

        /// <summary>
        /// Check age value's range
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        private static void CheckAge(int age)
        {
            if (age is < MinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException(
                    $"Age value must be in range [{MinAge}:{MaxAge}].");
            }
        }

        /// <summary>
        /// Check name / surname string format
        /// </summary>
        /// <param name="name">Input name string</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="FormatException"></exception>
        private static void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new FormatException(
                    "Name can't be null or empty.");
            }

            var namePattern = new Regex(
                @"(^[A-z]+(-[A-z])?[A-z]*$)|(^[А-я]+(-[А-я])?[А-я]*$)");

            if (namePattern.IsMatch(name) == false)
            {
                throw new FormatException(
                    "Name must consist only Cyrillic or Latin characters.");
            }
        }

        /// <summary>
        /// Check surname's language accordance to the name's language
        /// </summary>
        /// <param name="surname"></param>
        private void CheckAccordanceSurnameToName(string surname)
        {
            var latinPattern = new Regex(@"^[A-z]+(-[A-z])?[A-z]*$");
            var cyrillicPattern = new Regex(@"^[А-я]+(-[А-я])?[А-я]*$");

            CheckName(surname);

            if (latinPattern.IsMatch(Name))
            {
                if (latinPattern.IsMatch(surname) == false)
                {
                    throw new FormatException(
                        "Name and Surname must consist only Latin characters.");
                }
            }

            if (cyrillicPattern.IsMatch(Name))
            {
                if (cyrillicPattern.IsMatch(surname) == false)
                {
                    throw new FormatException(
                        "Name and Surname must consist only Cyrillic characters.");
                }
            }
        }

        /// <summary>
        /// Capitalize first char in name / surname
        /// </summary>
        /// <param name="name">Input name</param>
        /// <returns>Capitalize name / surname string</returns>
        private static string FormatName(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        }
    }
}
