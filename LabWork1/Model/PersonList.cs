using System;

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
        /// <exception cref="InvalidOperationException"></exception>
        public void DeleteFromEnd()
        {
            if (_listOfPersons.Length != 0)
            {
                Array.Resize(ref _listOfPersons, _listOfPersons.Length - 1);
            }

            throw new InvalidOperationException("Array is empty.");
        }

        /// <summary>
        /// Delete person from list by index
        /// </summary>
        /// <param name="index">Index value of person in the list</param>
        public void DeleteByIndex(int index)
        {
            IsIndexInRange(index);

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
        /// <returns>Person from the list</returns>
        public Person GetPersonByIndex(int index)
        {
            IsIndexInRange(index);
            return _listOfPersons[index];
        }

        /// <summary>
        /// Get index of person in the list
        /// </summary>
        /// <param name="person">Person`s instance</param>
        /// <returns>Int32 index of person in the list</returns>
        public int GetIndexByPerson(Person person)
        {
            for (var index = 0; index < _listOfPersons.Length; index++)
            {
                if (_listOfPersons[index] == person)
                {
                    return index;
                }
            }
            
            throw new ObjectNotFoundException("List doesn't contain the elements.");
        }

        /// <summary>
        /// Clear list of persons
        /// </summary>
        public void ClearList()
        {
            Array.Resize(ref _listOfPersons, 0);
        }

        /// <summary>
        /// Checking the occurrence of the index in the list range 
        /// </summary>
        /// <param name="index">Index of element in the list</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        private void IsIndexInRange(int index)
        {
            if (index < 0 || index >= _listOfPersons.Length)
            {
                throw new IndexOutOfRangeException("Index out of bounds.");
            }
        }
    }

    //TODO: в отдельный cs-файл
    /// <summary>
    /// Object not found in person list exception
    /// </summary>
    public class ObjectNotFoundException : Exception
    {
        public ObjectNotFoundException(string message) : base(message) {}
    }
}
