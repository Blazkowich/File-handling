using WriteOrRead;
using PersonInfo;
using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/otar/Desktop/Person Information/log.txt";
            PersonInformation[] persons = new PersonInformation[]
            {
                new PersonInformation ("Vajiko", "Kokoradze", "Mamakacuri", 15),
                new PersonInformation ("Jimsher", "Doborjginidze", "Mamri", 30),
                new PersonInformation ("Jaba", "Jabadze", "Gay", 24),
                new PersonInformation ("Dodo", "kaclamazashvili", "Mdedruxa", 43)
            };

            InfoReadOrWrite infoReadOrWrite = new InfoReadOrWrite(filePath);

            infoReadOrWrite.Write(persons);

            infoReadOrWrite.Read();
        }
    }
}
