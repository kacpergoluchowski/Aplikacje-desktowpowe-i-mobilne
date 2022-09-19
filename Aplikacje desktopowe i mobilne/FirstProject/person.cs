using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class person
    {
        private string name;
        private string surname;
        private int age;

        public person()
        {
            name = "Adam";
            surname = "Nowak";
            age = 30;
        }
        public person(string i, string n, int w)
        {
            name = i;
            surname = n;
            age = w;
        }
        public void showInfo()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine("*******************************");
        }
    }
}
