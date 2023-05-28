using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace PersonInfo
{
    #region Person Structure
    class Person
    {
        StreamWriter sw;
        StreamReader sr;

        public string nameg;
        public string surname;
        public string sex;
        public int age;
        public string fileDir;

    }
    #endregion
    class Information
    {

        #region Write File
        static void WriteFile()
        {
            StreamWriter sw = new StreamWriter(fileDir);
            sw.WriteLine("Name: " + name);
            sw.WriteLine("Surname: " + surname);
            sw.WriteLine("Sex: " + sex);
            sw.WriteLine("Age: " + age.ToString());
            sw.Close();
        }
        #endregion

        #region Read File
        static void ReadFile()
        {
            StreamReader sr = new StreamReader(fileDir, true);

            List<string> lines = new List<string>();

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }

            foreach (string textLine in lines)
            {
                Console.WriteLine(textLine);
            }

        }
        #endregion

        public Information()
        {
            nam
        }

    }
    
}
