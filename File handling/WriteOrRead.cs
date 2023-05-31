using System;
using System.IO;
using PersonInfo;

namespace WriteOrRead
{
    public class InformationChange
    {
        public string FilePath { get; set; }


        public void Write(PersonInformation[] persons)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            foreach (var person in persons)
            {
                string personData = $"{person.name}, {person.surname}, {person.sex}, {person.age}";
                sw.WriteLine(personData);
            }
            sw.Close();
        }


        public string[] Read()
        {
            StreamReader sr = new StreamReader(FilePath);
            string readInformation = sr.ReadToEnd();
            string[] lines = readInformation.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            sr.Close();
            return lines;
        }


        public InformationChange(string path)
        {
            FilePath = path;
        }
    }
}
