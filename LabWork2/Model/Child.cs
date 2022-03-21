using System;
using System.Linq;

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
        private string _educationalInstitute;

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
                CheckParentGender(value, GenderType.Female);
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
                CheckParentGender(value, GenderType.Male);
                _mother = value;
            }
        }

        /// <summary>
        /// Educational institute field's property
        /// </summary>
        private string EducationalInstitute
        {
            get => _educationalInstitute;
            set
            {
                CheckLength(value, "Educational institute");
                _educationalInstitute = value;
            }
        }

        /// <summary>
        /// Child's instance constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="father">Father</param>
        /// <param name="mother">Mother</param>
        /// <param name="educationalInstitute">Educational institute</param>
        public Child(string name, string surname, int age, 
                     GenderType gender, Adult father, Adult mother, 
                     string educationalInstitute) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            EducationalInstitute = educationalInstitute;
        }

        /// <summary>
        /// Default child's constructor
        /// </summary>
        public Child() : this("Unknown", "Unknown", 
                              0, GenderType.Other, null, 
                              null, null)
        {}

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            var parentsStatus = "Orphan";
            if (Father != null || Mother != null)
            {
                if (Father != null)
                {
                    parentsStatus = $"Father: {Father.ToStringNameSurname()}";
                }

                if (Mother != null)
                {
                    parentsStatus = $"{parentsStatus}; Mother: " +
                                    $"{Mother.ToStringNameSurname()}";
                }
            }

            var educationStatus = "Not studying";
            if (!string.IsNullOrEmpty(EducationalInstitute))
            {
                educationStatus = $"Studying in: {EducationalInstitute}";
            }

            return $"{GetBaseInfo()}; {parentsStatus}; {educationStatus}";
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
                    $"Child age value must be in range " +
                    $"[{MinAge}...{ChildMaxAge}].");
            }
        }

        /// <summary>
        /// To-do method to get mission
        /// </summary>
        /// <returns></returns>
        public string GetEasyMission()
        {
            var rnd = new Random();

            string[] missionLevel =
            {
                "C", "D", "E"
            };

            var chosenLevel = missionLevel[rnd.Next(missionLevel.Length)];

            return $"Level {chosenLevel} mission received";
        }
        
        /// <summary>
        /// Check parent gender
        /// </summary>
        /// <param name="parent">Parent</param>
        /// <param name="gender">Gender</param>
        private static void CheckParentGender(Adult parent, GenderType gender)
        {
            if (parent != null && parent.Gender == gender)
            {
                throw new ArgumentException
                    ("Parent gender must be other");
            }
        }

        /// <summary>
        /// Get random child
        /// </summary>
        /// <returns></returns>
        public static Child GetRandomPerson()
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

            string[] educateInst =
            {
                "Hidden Rain Village", "Hidden Waterfall Village", "Hidden Sound Village",
                "Hidden Stone Village", "Hidden Leaf Village", "Hidden Cloud Village",
                "Hidden Sand Village", "Hidden Grass Village", "Hidden Fog Village"
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

            var tmpAge = random.Next(MinAge, ChildMaxAge);

            var tmpEducateInst = educateInst[random.Next(educateInst.Length)];

            return new Child(tmpName, tmpSurname, tmpAge, tmpGender, 
                             null, null, tmpEducateInst);
        }
    }
}