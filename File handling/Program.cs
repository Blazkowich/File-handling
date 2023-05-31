using WriteOrRead;
using PersonInfo;
using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] information = new string[] { };

            PersonInformation[] persons = new PersonInformation[]
            {
                new PersonInformation ("Vajiko", "Kokoradze", "Mamakacuri", 15),
                new PersonInformation ("Jimsher", "Doborjginidze", "Mamri", 30),
                new PersonInformation ("Jaba", "Jabadze", "Gay", 24),
                new PersonInformation ("Dodo", "kaclamazashvili", "Mdedruxa", 43)
            };

            InformationChange informationChange = new InformationChange(@"/Users/otar/Desktop/Person Information/log.txt");

            informationChange.Write(persons);

            string[] lines = informationChange.Read();

            foreach (string line in lines)
            {
                string[] data = line.Split(", ");
                Console.WriteLine($"Name: {data[0]}\nSurname: {data[1]}\nAge: {data[2]}\nSex: {data[3]}\n");
            }
        }
    }
}
