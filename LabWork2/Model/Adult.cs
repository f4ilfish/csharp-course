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
        /// Low passport ID bound
        /// </summary>
        private const int LowPassportIdBound = 10000000;

        /// <summary>
        /// High passport ID bound
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
                CheckLength(value, "Employer");
                _employer = value;
            }
        }

        /// <summary>
        /// Adult's instance constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="passportId">Passport ID</param>
        /// <param name="spouse">Spouse</param>
        /// <param name="employer">Employer</param>
        public Adult(string name, string surname, int age, 
                     GenderType gender, int passportId, Adult spouse, 
                     string employer) : base(name, surname, age, gender)
        {
            PassportId = passportId;
            Spouse = spouse;
            Employer = employer;
        }
        
        /// <summary>
        /// Default adult's instance constructor
        /// </summary>
        public Adult() : this("Unknown", "Unknown", 99, 
                              GenderType.Other, 999999999,
                              null, null)
        { }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            var marriageStatus = "Not married";
            if (Spouse != null)
            {
                marriageStatus = $"Married to: {Spouse.ToStringNameSurname()}";
            }

            var employeeStatus = "Unemployed";
            if (!string.IsNullOrEmpty(Employer))
            {
                employeeStatus = $"Works at: {Employer}";
            }

            return $"{GetBaseInfo()}; {PassportId}; " +
                   $"{marriageStatus}; {employeeStatus}"; 
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
                    $"Adult age value must be in range " +
                    $"[{AdultMinAge}...{MaxAge}].");
            }
        }

        /// <summary>
        /// To-do method to get mission
        /// </summary>
        /// <returns></returns>
        public static string GetHardMission()
        {
            var rnd = new Random();

            string[] missionLevel =
            {
                "S", "A", "B"
            };

            var chosenLevel = missionLevel[rnd.Next(missionLevel.Length)];
            
            return $"Level {chosenLevel} mission received";
        }

        /// <summary>
        /// Method to check passport ID values
        /// </summary>
        /// <param name="passportId">Passport ID</param>
        private static void CheckPassportId(int passportId)
        {
            var requiredDigits = Math.Floor(
                (double)HighPassportIdBound / LowPassportIdBound) - 1;

            if (passportId is < LowPassportIdBound or > HighPassportIdBound)
            {
                throw new IndexOutOfRangeException(
                    $"Passport ID must contain {requiredDigits} digits.");
            }
        }

        /// <summary>
        /// Check spouse gender
        /// </summary>
        /// <param name="spouse"></param>
        private void CheckSpouseGender(Adult spouse)
        {
            if (spouse != null && spouse.Gender == Gender)
            {
                throw new ArgumentException
                    ($"Spouse gender must be other");
            }
        }

        /// <summary>
        /// Get random adult
        /// </summary>
        /// <returns></returns>
        public static Adult GetRandomPerson()
        {
            string[] maleNames =
            {
                "Naruto", "Kakashi", "Sasuke", "Itachi", "Gaara",
                "Shikamaru", "Neji", "Kiba", "Orichimaru", "Kisame"
            };

            string[] femaleNames =
            {
                "Hinata", "Tsunade", "Sakura", "Temari", "Anko",
                "Shizune", "TenTen", "Ino", "Mitsuri", "Sari"
            };

            string[] surnames =
            {
                "Hyuga", "Uchiha", "Uzumaki", "Haruno",
                "Namikaze", "Nara", "Inuzuka", "Lee"
            };

            string[] employers =
            {
                "Wind Country", "Water Country", " Iron Country",
                "Country of Sound", "Country of the Earth", " Lightning Country",
                "Sky Country", "Country of Fire", "Snow Country"
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
            
            var tmpAge = random.Next(AdultMinAge, MaxAge);
            
            var tmpPassportId = random.Next(LowPassportIdBound, HighPassportIdBound);

            var tmpEmployer = employers[random.Next(employers.Length)];

            return new Adult(tmpName, tmpSurname, tmpAge, tmpGender, 
                             tmpPassportId, null, tmpEmployer);
        }
    }
}