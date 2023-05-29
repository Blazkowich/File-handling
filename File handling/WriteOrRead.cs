using System;
using System.IO;
using PersonInfo;
namespace WriteOrRead
{
    public class InformationChange
    {
        public string FilePath { get; set; }
        #region Write in Document
        public void Write(PersonInformation person)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"{person.name},{person.surname},{person.age},{person.sex}");
            sw.Close();

        }
        #endregion

        #region Read from File
        public string Read()
        { 
            StreamReader sr = new StreamReader(FilePath);

            string readInformation = sr.ReadLine();
            string[] array = readInformation.Split(",");

            string name = array[0];
            string surname = array[1];
            int age = int.Parse(array[2]);
            string sex = array[3];

            sr.Close();
            return readInformation;
        }
        #endregion

        #region Direction Constructor
        public InformationChange(string path)
        {
            FilePath = path;
            //FilePath = @"/Users/otar/Desktop/Person Information/log.txt";
        }
        #endregion
    }
}
