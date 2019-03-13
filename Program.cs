using System;
using ConsoleAppdomashno.classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdomashno
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] Students = new Class1[5];
            Students[0] = new Class1("Martin", "SEDC", "G2");
            Students[1] = new Class1("Dario", "SEDC", "G2");
            Students[2] = new Class1("Petar", "SEDC", "G2");
            Students[3] = new Class1("Vanco", "Semos", "A");
            Students[4] = new Class1("Riste", "Codecademy", "A");
            var Darko = true;
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();

            foreach (var item in Students)
            {
                if (name == item.Name)
                {
                    Console.WriteLine($"{item.Name}" +
                        $" {item.Academy} {item.Group}");
                    Darko = false;
                    break;

                }
            }
            if (Darko)
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
    }
}
    
