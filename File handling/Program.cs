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

            List<PersonInformation> Persons = new List<PersonInformation>
            {
                new PersonInformation
                {
                    Name = "Vajiko",
                    Surname = "Kokoradze",
                    Age = 15,
                    Sex = "Mamakacuri"
                },

                new PersonInformation
                {
                    Name = "Jimsher",
                    Surname = "Sheylashvili",
                    Age = 30,
                    Sex = "Ylekaca"
                },

                new PersonInformation
                {
                    Name = "Luka",
                    Surname = "Jabakhidze",
                    Age = 24,
                    Sex = "Geh"
                },

                new PersonInformation
                {
                    Name = "Tako",
                    Surname = "Jabauri",
                    Age = 25,
                    Sex = "Gogo"
                }
            };


            InfoReadOrWrite manager = new InfoReadOrWrite(filePath);

            foreach(var person in Persons)
            { 
                manager.Write(person); 
            }

            List<PersonInformation> Recovered = manager.Read();

            foreach ( var person in Recovered)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Surname: {person.Surname}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Sex: {person.Sex}");

            }
        }
    }
}
