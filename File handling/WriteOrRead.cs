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



        public void Write(PersonInformation person)
        {
            StreamWriter sw = new StreamWriter(FilePath,true);
            sw.WriteLine(person.ToString());
            sw.Close();
        }



        public List<PersonInformation> Read()
        {
            List<PersonInformation> recovered = new List<PersonInformation>();

            StreamReader sr = new StreamReader(FilePath);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] splitedPersonProperties = line.Split(",");

                recovered.Add(CreatePersonStringFromArray(splitedPersonProperties));
            }
            sr.Close();
            return recovered;
        }

        private PersonInformation CreatePersonStringFromArray(string[] properties)
        {
            PersonInformation person = new PersonInformation();
            person.Name = properties[0].Trim();
            person.Surname = properties[1].Trim();
            person.Age = int.Parse(properties[2].Trim());
            person.Sex = properties[3].Trim();

            return person;
        }
    }
}
