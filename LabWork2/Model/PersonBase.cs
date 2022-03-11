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
        /// Name field's property
        /// </summary>
        private string Name
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
        private string Surname
        {
            get => _surname;
            set
            {
                CheckName(value);
                CheckAccordanceSurnameToName(value);
                _surname = FormatName(value);
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
        /// <param name="name">PersonBase name</param>
        /// <param name="surname">PersonBase surname</param>
        /// <param name="age">Peron age</param>
        /// <param name="gender">PersonBase gender</param>
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
        /// Method to get base info about person
        /// </summary>
        /// <returns></returns>
        protected string ToStringBase()
        {
            return $"Name: {Name} {Surname}; Age: {Age}; Gender: {Gender}";
        }

        /// <summary>
        /// Abstract method to check age boundaries
        /// </summary>
        /// <param name="age"></param>
        protected abstract void CheckAge(int age);

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

            if (latinPattern.IsMatch(Name))
            {
                //TODO: duplication
                if (latinPattern.IsMatch(surname) == false)
                {
                    throw new FormatException(
                        "Name and Surname must consist only Latin characters.");
                }
            }

            if (cyrillicPattern.IsMatch(Name))
            {
                //TODO: duplication
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
