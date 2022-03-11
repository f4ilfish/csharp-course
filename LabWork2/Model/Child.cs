using System;

namespace Model
{
    /// <summary>
    /// Class child
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Father
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Mother
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Educational institute
        /// </summary>
        private string _educationalInstituteName;

        /// <summary>
        /// Maximum child age value
        /// </summary>
        private const int ChildMaxAge = 17;

        /// <summary>
        /// Father field's property
        /// </summary>
        private Adult Father
        {
            get => _father;
            set
            {
                CheckFatherGender(value);
                _father = value;
            }
        }

        /// <summary>
        /// Mother field's property
        /// </summary>
        private Adult Mother
        {
            get => _mother;
            set
            {
                CheckMotherGender(value);
                _mother = value;
            }
        }

        /// <summary>
        /// Educational institute field's property
        /// </summary>
        private string EducationalInstituteName
        {
            get => _educationalInstituteName;
            set
            {
                CheckEducationalInstitute(value);
                _educationalInstituteName = value;
            }
        }

        /// <summary>
        /// Child's instance constructor
        /// </summary>
        /// //TODO: XML
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="father">Father</param>
        /// <param name="mother">Mother</param>
        /// <param name="educationalInstituteName">Educational institute</param>
        public Child(string name, string surname, int age, GenderType gender, Adult father, Adult mother,
            string educationalInstituteName) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            EducationalInstituteName = educationalInstituteName;
        }

        /// <summary>
        /// Default child's constructor
        /// </summary>
        /// //TODO: RSDN
        public Child() : this("Unknown", "Unknown", 0, GenderType.Other, null, null, null)
        {}

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var parentsStatus = "Orphan";
            if (Father != null || Mother != null)
            {
                if (Father != null)
                {
                    parentsStatus = $"Father: {Father.ToString()}";
                }

                if (Mother != null)
                {
                    parentsStatus = $"{parentsStatus}; Mother: {Mother.ToString()}";
                }
            }

            var educationStatus = "Not studying";
            if (!string.IsNullOrEmpty(EducationalInstituteName))
            {
                educationStatus = $"Studying in: {EducationalInstituteName}";
            }

            return $"{ToStringBase()}; {parentsStatus}; {educationStatus}";
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="age"></param>
        protected override void CheckAge(int age)
        {
            if (age is < MinAge or > ChildMaxAge)
            {
                throw new IndexOutOfRangeException(
                    $"Child age value must be in range [{MinAge}...{ChildMaxAge}].");
            }
        }

        //TODO: duplication
        /// <summary>
        /// Method to check father's gender
        /// </summary>
        /// <param name="father"></param>
        private static void CheckFatherGender(Adult father)
        {
            if (father != null && father.Gender == GenderType.Female)
            {
                throw new ArgumentException
                    ("Father's gender must be other");
            }
        }

        //TODO: duplication
        /// <summary>
        /// Method to check mother's gender
        /// </summary>
        /// <param name="mother"></param>
        private static void CheckMotherGender(Adult mother)
        {
            if (mother != null && mother.Gender == GenderType.Male)
            {
                throw new ArgumentException
                    ("Mother's gender must be other");
            }
        }

        /// <summary>
        /// Check educational institute naming
        /// </summary>
        /// <param name="educationalInstitute"></param>
        private static void CheckEducationalInstitute(string educationalInstitute)
        {
            const int maxLength = 30;
            if (educationalInstitute.Length > maxLength)
            {
                throw new FormatException(
                    $"Educational institute name must be short then {maxLength} chars");
            }
        }
    }
}