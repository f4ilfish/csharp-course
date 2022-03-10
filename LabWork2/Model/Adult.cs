using System;

namespace Model
{
    /// <summary>
    /// Class adult
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Passport ID
        /// </summary>
        private int _passportId;

        /// <summary>
        /// Spouse
        /// </summary>
        private Adult _spouse;

        /// <summary>
        /// Employer
        /// </summary>
        private string _employer;

        /// <summary>
        /// Minimum adult age
        /// </summary>
        private const int AdultMinAge = 18;

        /// <summary>
        /// Passport ID field's property
        /// </summary>
        private int PassportId
        {
            get => _passportId;
            set
            {
                CheckPassportId(value);
                _passportId = value;
            }
        }

        /// <summary>
        /// Spouse field's property
        /// </summary>
        private Adult Spouse
        {
            get => _spouse;
            set
            {
                CheckSpouse(value);
                _spouse = value;
            }
        }

        /// <summary>
        /// Employer field's property
        /// </summary>
        private string Employer
        {
            get => _employer;
            set => _employer = value;
        }

        /// <summary>
        /// Adult's instance constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="passportId"></param>
        /// <param name="spouse"></param>
        /// <param name="employer"></param>
        public Adult(string name, string surname, int age, GenderType gender, 
            int passportId, Adult spouse, string employer) : base(name, surname, age, gender)
        {
            PassportId = passportId;
            Spouse = spouse;
            Employer = employer;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var marriageStatus = "Not married";
            if (Spouse != null)
            {
                marriageStatus = $"Married to: {Spouse.ToString()}";
            }

            var employeeStatus = "Unemployed";
            if (!string.IsNullOrEmpty(Employer))
            {
                employeeStatus = $"Works at: {Employer}";
            }

            return $"{ToStringBase()}; {PassportId}; {marriageStatus}; {employeeStatus}"; 
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="age"></param>
        protected override void CheckAge(int age)
        {
            if (age is < AdultMinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException(
                    $"Adult age value must be in range [{AdultMinAge}...{MaxAge}].");
            }
        }
        
        /// <summary>
        /// Method to check passport id values
        /// </summary>
        /// <param name="passportId">Passport ID</param>
        private static void CheckPassportId(int passportId)
        {
            if (passportId is < 10000000 or > 99999999)
            {
                throw new IndexOutOfRangeException(
                    $"Passport ID must contain 8 digits.");
            }
        }

        /// <summary>
        /// Method to check spouse gender
        /// </summary>
        /// <param name="spouse"></param>
        private void CheckSpouse(Adult spouse)
        {
            if(spouse != null && spouse.Gender == Gender)
            {
                throw new ArgumentException
                    ("Gender of spouse must be other");
            }
        }
    }
}