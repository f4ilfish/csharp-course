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
        private PersonBase[] _listOfPersons = new PersonBase[0];

        /// <summary>
        /// Number of persons in the list property
        /// </summary>
        public int NumberOfPersons => _listOfPersons.Length;

        /// <summary>
        /// Add certain personBase to the end of list
        /// </summary>
        /// <param name="personBase">PersonBase`s instance</param>
        public void AddToEnd(PersonBase personBase)
        {
            var indexToNewPerson = _listOfPersons.Length;
            Array.Resize(ref _listOfPersons, _listOfPersons.Length + 1);
            _listOfPersons[indexToNewPerson] = personBase;
        }

        /// <summary>
        /// Delete personBase from the end of list 
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
        /// Delete personBase from list by index
        /// </summary>
        /// <param name="index">Index value of personBase in the list</param>
        public void DeleteByIndex(int index)
        {
            IsIndexInRange(index);

            var tmpListOfPerson = new PersonBase[_listOfPersons.Length - 1];
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
        /// Get personBase by index from the list
        /// </summary>
        /// <param name="index">Index value of personBase in the list</param>
        /// <returns>PersonBase from the list</returns>
        public PersonBase GetPersonByIndex(int index)
        {
            IsIndexInRange(index);
            return _listOfPersons[index];
        }

        /// <summary>
        /// Get index of personBase in the list
        /// </summary>
        /// <param name="personBase">PersonBase`s instance</param>
        /// <returns>Int32 index of personBase in the list</returns>
        /// <exception cref="ObjectNotFoundException"></exception>
        public int GetIndexByPerson(PersonBase personBase)
        {
            for (var index = 0; index < _listOfPersons.Length; index++)
            {
                if (_listOfPersons[index] == personBase)
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
}
