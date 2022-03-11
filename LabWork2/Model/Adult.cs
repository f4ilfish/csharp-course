using System;
using System.Linq;

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
        /// Low passport id bound
        /// </summary>
        private const int LowPassportIdBound = 10000000;

        /// <summary>
        /// High passport id bound
        /// </summary>
        private const int HighPassportIdBound = 99999999;

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
                CheckSpouseGender(value);
                _spouse = value;
            }
        }

        /// <summary>
        /// Employer field's property
        /// </summary>
        private string Employer
        {
            get => _employer;
            set
            {
                CheckEmployer(value);
                _employer = value;
            }
        }

        /// <summary>
        /// Adult's instance constructor
        /// </summary>
        /// //TODO: XML
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

        //TODO: RSDN
        /// <summary>
        /// Default adult's instance constructor
        /// </summary>
        public Adult() : this("Unknown", "Unknown", 99, GenderType.Other, 999999999, null, null)
        { }

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

        public static Adult GetRandomPerson()
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
            var tmpAge = random.Next((MaxAge - AdultMinAge)) + AdultMinAge;

            var tmpPassportId = random.Next((HighPassportIdBound - LowPassportIdBound)) + LowPassportIdBound;

            return new Adult(tmpName, tmpSurname, tmpAge, tmpGender, tmpPassportId, null, null);
        }


        /// <summary>
        /// Method to check passport id values
        /// </summary>
        /// <param name="passportId">Passport ID</param>
        private static void CheckPassportId(int passportId)
        {
            var maxDigits = Math.Floor((double)HighPassportIdBound / LowPassportIdBound) - 1;

            if (passportId is < LowPassportIdBound or > HighPassportIdBound)
            {
                throw new IndexOutOfRangeException(
                    $"Passport ID must contain {maxDigits} digits.");
            }
        }

        /// <summary>
        /// Method to check spouse's gender
        /// </summary>
        /// <param name="spouse"></param>
        private void CheckSpouseGender(Adult spouse)
        {
            if (spouse != null && spouse.Gender == Gender)
            {
                throw new ArgumentException
                    ("Gender of spouse must be other");
            }
        }

        /// <summary>
        /// Check employer institute naming
        /// </summary>
        /// <param name="employer"></param>
        private static void CheckEmployer(string employer)
        {
            const int maxLength = 30;
            if (employer.Length > maxLength)
            {
                throw new FormatException(
                    $"Employer name must be short then {maxLength} chars");
            }
        }
    }
}