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
            // Console.WriteLine("------------------");
            person secondPerson = firstPerson;
            secondPerson.showInfo();

            person thirdPerson = new person("ala", "kowalska", 18);
            thirdPerson.showInfo();

            secondPerson = thirdPerson;
            secondPerson.showInfo();

            thirdPerson.setSurname("Nowakowska");
            thirdPerson.showInfo();

            string dana = thirdPerson.getSurname();
            Console.WriteLine(dana);

            int d = thirdPerson.Age;
            Console.WriteLine(d);

        }
    }
}
