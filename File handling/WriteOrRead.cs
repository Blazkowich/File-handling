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
                string personFromArray = $"{person.Name}," +
                    $" {person.Surname}," +
                    $" {person.Sex}," +
                    $" {person.Age}";

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

                    PersonInformation RecoveredInfo = new PersonInformation(
                        name: infoArray[0],
                        surname: infoArray[1].Trim(),
                        sex: infoArray[2].Trim(),
                        age: int.Parse(infoArray[3].Trim())
                        ) ;
                    
                    Console.WriteLine(
                        $"Name: {RecoveredInfo.Name}" +
                        $"\nSurname: {RecoveredInfo.Surname}" +
                        $"\nSex: {RecoveredInfo.Sex}" +
                        $"\nAge: {RecoveredInfo.Age}\n");
                }
            }
            sr.Close();
            return arrInf;
        }
    }
}
