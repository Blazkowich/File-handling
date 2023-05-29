using WriteOrRead;
using PersonInfo;
namespace FileHandling;
class Program
{
    static void Main(string[] args)
    {


        PersonInformation personInformation = new PersonInformation("Vajiko","Kokoradze","Mamakacuri",15);



        InformationChange.Write(personInformation) ;



        PersonInformation.DisplayInfo();
        
    }
}

