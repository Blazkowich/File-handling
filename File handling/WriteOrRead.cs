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
            StreamWriter sw = new StreamWriter(FilePath, true);
            foreach (PersonInformation person in persons)
            {
                sw.WriteLine(person.ToString());
            }
            sw.Close();
        }



        public PersonInformation[] Read()
        {
            PersonInformation[] recovered = new PersonInformation[4];

            StreamReader sr = new StreamReader(FilePath);

            string line;
            int index = 0;


            while ((line = sr.ReadLine()) != null)
            {
                string[] splitedPersonProperties = line.Split(",");

                recovered[index] = CreatePersonStringFromArray(splitedPersonProperties);
                index++;

                Array.Resize(ref recovered, recovered.Length+1);

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
