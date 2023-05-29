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
