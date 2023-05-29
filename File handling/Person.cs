using System;
using System.IO;
using WriteOrRead;
namespace PersonInfo
{
    #region Basic Information get / set
    public class PersonInformation
	{ 
		public string name { get; set; }
        	public string surname { get; set; }
        	public string sex { get; set; }
        	public int age { get; set; }
        #endregion

        #region Display Information from Read
        public static void DisplayInfo()
	{
            	string fullInfo = InformationChange.Read();
            	string[] array = fullInfo.Split(",");

            	string name = array[0];
            	string surname = array[1];
            	int age = int.Parse(array[2]);
            	string sex = array[3];

            	PersonInformation person = new(name, surname, sex, age);

            	Console.WriteLine($"Name: {person.name}\nSurname: {person.surname}\nAge: {person.age}\nSex: {person.sex}");
        }
        #endregion

        #region Constructor for information merging
        public PersonInformation(string name, string surname, string sex, int age)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.age = age;

        }
        #endregion
    }
}
