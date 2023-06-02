using WriteOrRead;
using PersonInfo;
using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\LEGION Y520\New folder\log.txt";

            PersonInformation[] Persons = new PersonInformation[4];

            Persons[0] = new PersonInformation();
            Persons[0].Name = "Vajiko";
            Persons[0].Surname = "Kokoradze";
            Persons[0].Age = 15;
            Persons[0].Sex = "Mamakacuri";

            Persons[1] = new PersonInformation();
            Persons[1].Name = "Jimsher";
            Persons[1].Surname = "Sheylashvili";
            Persons[1].Age = 30;
            Persons[1].Sex = "Ylekaca";

            Persons[2] = new PersonInformation();
            Persons[2].Name = "Luka";
            Persons[2].Surname = "Jabakhidze";
            Persons[2].Age = 24;
            Persons[2].Sex = "Geh";


            Persons[3] = new PersonInformation();
            Persons[3].Name = "Tako";
            Persons[3].Surname = "Jabauri";
            Persons[3].Age = 25;
            Persons[3].Sex = "Gogo";




            InfoReadOrWrite manager = new InfoReadOrWrite(filePath);
            manager.Write(Persons);

            PersonInformation[] Recovered = manager.Read();

            for (int i = 0; i < Recovered.Length; i++)
            {
                Console.WriteLine(Recovered[i]);
            }
        }
    }
}
