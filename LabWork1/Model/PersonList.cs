using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Class that describe a certain list of persons
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// List of persons
        /// </summary>
        private Person[] _listOfPersons = new Person[0];

        /// <summary>
        /// Number of persons in the list property
        /// </summary>
        public int NumberOfPersons => _listOfPersons.Length;

        /// <summary>
        /// Add certain person to the end of list
        /// </summary>
        /// <param name="person">Person`s instance</param>
        public void AddToEnd(Person person)
        {
            var indexToNewPerson = _listOfPersons.Length;
            Array.Resize(ref _listOfPersons, _listOfPersons.Length + 1);
            _listOfPersons[indexToNewPerson] = person;
        }

        /// <summary>
        /// Delete person from the end of list 
        /// </summary>
        public void DeleteFromEnd()
        {
            //TODO: bug
            Array.Resize(ref _listOfPersons, _listOfPersons.Length - 1);
        }

        /// <summary>
        /// Delete person from list by index
        /// </summary>
        /// <param name="index">Index value of person in the list</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public void DeleteByIndex(int index)
        {
            //TODO: RSDN
            if (index < 0 || index >= _listOfPersons.Length)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            
            var tmpListOfPerson = new Person[_listOfPersons.Length - 1];
            var tmpIndex = 0;

            foreach (var person in _listOfPersons)
            {
                if (person == _listOfPersons[index]) continue;

                tmpListOfPerson[tmpIndex] = person;
                tmpIndex++;
            }

            Array.Resize(ref _listOfPersons, _listOfPersons.Length - 1);
            _listOfPersons = tmpListOfPerson;
        }

        /// <summary>
        /// Get person by index from the list
        /// </summary>
        /// <param name="index">Index value of person in the list</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <returns></returns>
        public Person GetPersonByIndex(int index)
        {
            //TODO:
            if (index < 0 || index >= _listOfPersons.Length) throw new IndexOutOfRangeException("Index out of bounds");
            return _listOfPersons[index];
        }

        /// <summary>
        /// Get index of person in the list
        /// </summary>
        /// <param name="person">Person`s instance</param>
        /// <returns></returns>
        public int GetIndexByPerson(Person person)
        {
            for (var index = 0; index < _listOfPersons.Length; index++)
            {
                if (_listOfPersons[index] == person)
                {
                    return index;
                }
            }

            throw new Exception("List doesn't contain the element");
        }

        /// <summary>
        /// Clear list of persons
        /// </summary>
        public void ClearList()
        {
            Array.Resize(ref _listOfPersons, 0);
        }

        //TODO:
        /// <summary>
        /// Print list in console
        /// </summary>
        public void PrintList()
        {
            foreach (var person in _listOfPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
