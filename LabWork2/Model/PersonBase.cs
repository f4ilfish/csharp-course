using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Abstract class person
    /// </summary>
    public abstract class PersonBase
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
        protected const int MaxAge = 150;

        /// <summary>
        /// Minimum age value
        /// </summary>
        protected const int MinAge = 0;

        /// <summary>
        /// Maximum field's string length
        /// </summary>
        private const int MaxFieldStringLength = 30;

        /// <summary>
        /// Latin naming pattern
        /// </summary>
        private static readonly Regex LatinPattern = new(@"^[A-z]+(-[A-z])?[A-z]*$");

        /// <summary>
        /// Char naming pattern
        /// </summary>
        private static readonly Regex CyrillicPattern = new(@"^[А-я]+(-[А-я])?[А-я]*$");

        /// <summary>
        /// Name field's property
        /// </summary>
        private string Name
        {
            get => _name;
            set
            {
                NameValidation(value, "Name");
                _name = FormatNaming(value);
            }
        }

        /// <summary>
        /// Surname field's property
        /// </summary>
        private string Surname
        {
            get => _surname;
            set
            {
                NameValidation(value, "Surname");
                SurnameValidation(Name, value, LatinPattern);
                SurnameValidation(Name, value, CyrillicPattern);
                _surname = FormatNaming(value);
            }
        }

        ///  <summary>
        /// Age field's property
        ///  </summary>
        private int Age
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
        protected internal GenderType Gender
        {
            get => _gender;
            set => _gender = value;
        }

        /// <summary>
        /// Base person's instance constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        protected PersonBase(string name, string surname, int age, GenderType gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Default base person's instance constructor
        /// </summary>
        protected PersonBase() : this("Unknown", "Unknown", 99, GenderType.Other)
        { }

        /// <summary>
        /// Get person's info
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfo();

        /// <summary>
        /// Get base person's info
        /// </summary>
        /// <returns></returns>
        public string GetBaseInfo()
        {
            return $"Name: {Name} {Surname}; Age: {Age}; Gender: {Gender}";
        }

        /// <summary>
        /// Convert person's name and surname to single string 
        /// </summary>
        /// <returns></returns>
        public string ToStringNameSurname()
        {
            return $"{Name} {Surname}";
        }

        /// <summary>
        /// Check age boundaries
        /// </summary>
        /// <param name="age">Age</param>
        protected abstract void CheckAge(int age);

        /// <summary>
        /// Check string length
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <param name="fieldName">Field name</param>
        protected static void CheckLength(string inputString, string fieldName)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                if (inputString.Length > MaxFieldStringLength)
                {
                    throw new FormatException(
                        $"{fieldName} string must be short then {MaxFieldStringLength} chars");
                }
            }
        }

        /// <summary>
        /// Name validation
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="fieldName">Field's name</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="FormatException"></exception>
        private static void NameValidation(string name, string fieldName)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new FormatException(
                    $"{fieldName} can't be null or empty.");
            }

            if (LatinPattern.IsMatch(name) == false && CyrillicPattern.IsMatch(name) == false)
            {
                throw new FormatException(
                    $"{fieldName} should be in Latin or Cyrillic.");
            }
        }

        /// <summary>
        /// Surname validation
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="namingPattern">Naming pattern</param>
        private static void SurnameValidation(string name, string surname, Regex namingPattern)
        {
            if (namingPattern.IsMatch(name))
            {
                //TODO: duplication
                if (namingPattern.IsMatch(surname) == false)
                {
                    throw new FormatException(
                        "Name and Surname should have similar char languages. Only Cyrillic or Latin.");
                }
            }
        }

        /// <summary>
        /// Capitalize first char in name
        /// </summary>
        /// <param name="name">Input name</param>
        /// <returns>Capitalize name / surname string</returns>
        private static string FormatNaming(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        }

        /// <summary>
        /// Get mission level
        /// </summary>
        /// <returns></returns>
        public abstract string GetMissionLevel();
    }
}
