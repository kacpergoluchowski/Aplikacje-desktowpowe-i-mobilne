using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World!");
            /**
            string imie = "Jan";
            string nazwisko = "Kowalski";
            // x = nazwisko.Length;
            // Console.WriteLine(x);
            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1} tutaj", imie, nazwisko);
            Console.WriteLine($"Witaj {imie} {nazwisko} tutaj", imie, nazwisko);
            Console.WriteLine(@"Prędkość to km\h");

            Console.WriteLine(float.MaxValue);
            double a = 5.6;
            Console.WriteLine(a);

            int b = 6. ;
            **/

            person firstPerson = new person();
            firstPerson.showInfo();
        }
    }
}
