using System;
using System.IO;
using PersonInfo;
namespace WriteOrRead
{
    public static class InformationChange
    {
        public static string FilePath;
        #region Write in Document
        public static void Write(PersonInformation person)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"{person.name},{person.surname},{person.age},{person.sex}");
            sw.Close();

        }
        #endregion

        #region Read from File
        public static string Read()
        { 
            StreamReader sr = new StreamReader(FilePath);

            string readInformation = sr.ReadLine();
            sr.Close();
            return readInformation;
        }
        #endregion

        #region Direction Constructor
        static InformationChange()
        {
            FilePath = @"/Users/otar/Desktop/Person Information/log.txt";
        }
        #endregion
    }
}
