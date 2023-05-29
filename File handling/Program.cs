using WriteOrRead;
using PersonInfo;
namespace FileHandling;
class Program
{
    static void Main(string[] args)
    {
        int age = 15;
        string sex = "Male";
        string name = "Vajiko";
        string surname = "Kokoradze";

        PersonInformation personInformation = new PersonInformation();
        personInformation.age = age;
        personInformation.name = name;
        personInformation.surname = surname;
        personInformation.sex = sex;
        InformationChange.Write(personInformation) ;



        PersonInformation recoverInformation = new PersonInformation();
        string fullInfo = InformationChange.Read();
        string[] array = fullInfo.Split(",");
        recoverInformation.name = array[0];
        recoverInformation.surname = array[1];
        recoverInformation.age = int.Parse(array[2]);
        recoverInformation.sex = array[3];
        

        Console.WriteLine($"Name: {array[0]}\nSurname: {array[1]}\nAge: {array[2]}\nSex: {array[3]}");
    }
}

