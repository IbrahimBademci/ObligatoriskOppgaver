using System;
using System.Runtime.InteropServices;

namespace Mandatory_Assaignment1
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string DeathYear { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }


        public Person(int id)
        {
            Id = id;
        }

        public void Show(string prefix, bool getParents)
        {
            var lastName = string.Empty;
            var deathYear = string.Empty;
            var firstWord = prefix;

            if (LastName != null)
            {
                lastName = $"/ Etter Navn:{LastName}";
            }
            if (DeathYear != null)
            {
                deathYear = $"/ Dødsår: {DeathYear}";
            }
            Console.WriteLine($"{firstWord} {FirstName} / Født: {BirthYear} / ID:{Id} {lastName} {deathYear}");
            GetParents(getParents);
        }

        private void GetParents(bool getParents)
        {
            if (getParents)
            {
                if (Mother != null)
                {
                    Mother.Show("      -Mor:", false);
                }

                if (Father != null)
                {
                    Father.Show("      -Far:", false);
                }
            }
        }
    }
}

