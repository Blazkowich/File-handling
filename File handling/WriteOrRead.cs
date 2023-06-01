using System;
using System.IO;
using PersonInfo;

namespace WriteOrRead
{
    public class InformationChange
    {
        public string FilePath { get; }

        public InformationChange(string path)
        {
            FilePath = path;
        }



        public void Write(PersonInformation[] persons)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            foreach (var person in persons)
            {
                string personFromArray = $"{person.Name}, {person.Surname}, {person.Sex}, {person.Age}";
                sw.WriteLine(personFromArray);
            }
            sw.Close();
        }


        public string[] Read()
        {
            string[] arrInf = new string[4];

            StreamReader sr = new StreamReader(FilePath);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] infoArray = line.Split(",");

                if (infoArray.Length >= 4)
                {
                    string name = infoArray[0].Trim();
                    string surname = infoArray[1].Trim();
                    string sex = infoArray[2].Trim();
                    string age = infoArray[3].Trim();
                    Console.WriteLine($"Name: {name}\nSurname: {surname}\nSex: {sex}\nAge: {age}\n");
                }
            }
            sr.Close();
            return arrInf;
        }
    }
}
