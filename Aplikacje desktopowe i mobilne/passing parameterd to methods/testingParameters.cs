using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_parameterd_to_methods
{
    struct PersonStruct
    {
        public string name;
        public string surname;
        public int age;
    }


    class testingParameters
    {
        #region Przekazywanie typów prostych

        public void test1()
        {
            byte number = 15;
            Console.WriteLine("Zmienna number: " + number);
            // ChangeValue(number);
            //ChangeValue(6);
            ChangeValueV2(ref number);
            //ChangeValueV2(ref 6); --> to jest błędne
            Console.WriteLine("Zmienna number: " + number);
            //int random = 0;
            //GetRandomNumber(out random);
            GetRandomNumber();
            Console.WriteLine(GetRandomNumber());
            
        }
        private void ChangeValue(byte value)
        {
            Console.WriteLine("Parametr number: " + value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value: " + value);
        }
        private void ChangeValueV2(ref byte value)
        {
            Console.WriteLine("Parametr number: " + value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value: " + value);
        }
        private int GetRandomNumber()
        {
            return new Random().Next();
        }
        private void GetRandomNumber(out int value)
        {
            value = new Random().Next();
        }

        #endregion

        #region Przekazywanie typów referencyjnych

        public void Test2()
        {
            person person = new person();
            person.showInfo();

            //GetPerson(person);
            //GetPerson2(person);
            GetPerson3(ref person);
        }

        private void GetPerson(person p)
        {
            p.showInfo();
            p.Age = 40;
            p.showInfo();
        }
        private void GetPerson2(person p)
        {
            p = new person();
            p.showInfo();
            p.Age = 40;
            p.showInfo();
        }
        private void GetPerson3(ref person p)
        {
            
            p = new person();
            p.showInfo();
            p.Age = 40;
            p.showInfo();
        }
        #endregion

        #region Przekazywanie struktur 

        public void Test3()
        {
            PersonStruct struktura = new PersonStruct();
            struktura.name = "adam";
            Console.WriteLine("Pole name w Test 3 " + struktura.name);
            GetPresonStruct(struktura);
            Console.WriteLine("Pole name w Test 3 " + struktura.name);
        }
        private void GetPresonStruct(PersonStruct struktura)
        {
            Console.WriteLine("Pole name w GetPresonStruct " + struktura.name);
            struktura.name = "Ewa";
            Console.WriteLine("Pole name w GetPresonStruct " + struktura.name);
        }

        #endregion
    }
}
