using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdomashno.classes
{
   public  class Class1
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Class1(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;

        }
    }
}
