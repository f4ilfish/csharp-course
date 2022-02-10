using System;
using System.Collections.Generic;

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
            set => _name = value;
        }

        /// <summary>
        /// Surname field's property
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = value;
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
        ///Age field's property
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Age value can`t be negative");
                }
                _age = value;
            }
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
        public Person() : this("Unknown", "Unknown", 99, GenderType.Other)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{Name} {Surname}; {Age}; {Gender}");
        }
    }
}
