using System;
using System.IO;
using PersonInfo;
namespace WriteOrRead
{
    public static class InformationChange
    {
        public static string filePath;

        public static void Write(PersonInformation person)
        {
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine($"{person.name},{person.surname},{person.age},{person.sex}");
            sw.Close();

        }

        public static string Read()
        { 

            StreamReader sr = new StreamReader(filePath);

            string readInformation = sr.ReadLine();
            sr.Close();
            return readInformation;

        }

        static InformationChange()
        {
            filePath = @"/Users/otar/Desktop/Person Information/log.txt";
        }
    }
}

