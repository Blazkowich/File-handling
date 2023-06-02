using System;
using System.IO;
using WriteOrRead;

namespace PersonInfo
{
    public class PersonInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }


        public PersonInformation(
            string name,
            string surname,
            string sex,
            int age)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
        }
    }
}
