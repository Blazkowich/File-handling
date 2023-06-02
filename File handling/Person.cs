using System;
using System.IO;
using WriteOrRead;

namespace PersonInfo
{
    public class PersonInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Age}, {Sex}";
        }
    }
}
