using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_parameterd_to_methods
{
    class testingParameters
    {
        public void test1()
        {
            byte number = 15;
            Console.WriteLine("Zmienna number: " + number);
            // ChangeValue(number);
            //ChangeValue(6);
            ChangeValueV2(ref number);
            //ChangeValueV2(ref 6); --> to jest błędne
            Console.WriteLine("Zmienna number: " + number);
            int number = GetRandomNumber;
            GetRandomNumber(out random);
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
    }
}
