using WriteOrRead;
using PersonInfo;
using System.Xml.Linq;
using System;

namespace FileHandling;
class Program
{
    static void Main(string[] args)
    {

        PersonInformation personInformation = new PersonInformation("Vajiko","Kokoradze","Mamakacuri",15);
      

        InformationChange informationChange = new InformationChange(@"/Users/otar/Desktop/Person Information/log.txt");



        informationChange.Write(personInformation);

        informationChange.Read();
        
        Console.WriteLine($"Name: {personInformation.name}\nSurname: {personInformation.surname}\nAge: {personInformation.age}\nSex: {personInformation.sex}");
        
    }
}

