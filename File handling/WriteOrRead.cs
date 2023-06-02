using System;
using System.IO;
using PersonInfo;

namespace WriteOrRead
{
    public class InfoReadOrWrite
    {
        public string FilePath { get; }

        public InfoReadOrWrite(string path)
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
                    string nameFromDoc = infoArray[0].Trim();
                    string surnameFromDoc = infoArray[1].Trim();
                    string sexFromDoc = infoArray[2].Trim();
                    int ageFromDoc = int.Parse(infoArray[3].Trim());

                    PersonInformation RecoveredInfo = new PersonInformation(name: nameFromDoc, surname: surnameFromDoc, sex: sexFromDoc, age: ageFromDoc) ;
                    
                    Console.WriteLine($"Name: {nameFromDoc}\nSurname: {surnameFromDoc}\nSex: {sexFromDoc}\nAge: {ageFromDoc}\n");
                }
            }
            sr.Close();
            return arrInf;
        }
    }
}
