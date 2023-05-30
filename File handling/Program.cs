using WriteOrRead;
using PersonInfo;
using System.Xml.Linq;
using System;

namespace FileHandling;
class Program
{
    static void Main(string[] args)
    {
        //Enter information here ... 
        PersonInformation personInformation = new PersonInformation("Vajiko","Kokoradze","Mamakacuri",15);
      
        //Code Line for File Direction
        InformationChange informationChange = new InformationChange(@"/Users/otar/Desktop/Person Information/log.txt");


        //Write function call
        informationChange.Write(personInformation);


        //Read function call
        informationChange.Read();


        //Read from .txt file
        Console.WriteLine($"Name: {personInformation.name}\nSurname: {personInformation.surname}\nAge: {personInformation.age}\nSex: {personInformation.sex}");

    }
}

