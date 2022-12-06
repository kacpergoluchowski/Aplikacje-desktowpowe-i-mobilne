using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class ListTest
    {
        public void Test()
        {
            List<int> ListOfInts = new List<int>();

            Console.Write("Ilość elementów w kolekcji intów: " + ListOfInts.Count);

            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                ListOfInts.Add(random.Next(0, 21));
            }

            Console.WriteLine("Lista wylosowanych intów");
            for (int i = 0; i < ListOfInts.Count; i++)
            {
                Console.Write(ListOfInts[i] + ", ");
            }
            Console.WriteLine(" ");
            List<double> ListOfDoubles = new List<double>();
            for(int i = 0; i < 10; i++)
            {
                ListOfDoubles.Add(Math.Round(random.NextDouble() * 20, 2));
            }
            Console.Write("Lista wylosowanych double'ów: ");
            Console.WriteLine(" ");
            foreach(var item in ListOfDoubles)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.Write("Maksymalna liczba to: ");
            Console.WriteLine(MaxFromInts(ListOfInts));

            Console.Write("Maksymalna liczba to:");
            Console.WriteLine(MaxFromDoubles(ListOfDoubles));
            
            
        }
        public int MaxFromInts(List<int> list)
        {
            int max=0;
            foreach(int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        public double MaxFromDoubles(List<double> list)
        {
            double max = 0;
            foreach (double item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
    }
}
