using System;
using System.IO;
using PersonInfo;
namespace File_handling;

class Program
{
    static void Main(string[] args)
    {

        PersonInfo.Person PersonInformation = new PersonInfo.Person();

        PersonInformation.fileDir = @"C:\Users\LEGION Y520\Desktop\Text\Info.txt";
        PersonInformation.age = 15;
        PersonInformation.sex = "Male";
        PersonInformation.name = "Vajiko";
        PersonInformation.surname = "Kokoradze";

        


        PersonInformation.WriteFile();
        PersonInformation.ReadFile();

    }
}
