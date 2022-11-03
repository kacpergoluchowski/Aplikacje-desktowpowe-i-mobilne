using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimApp
{
    class Animal
    {
        protected string name;
        protected byte age;
        protected string type;

        public Animal()
        {
            type = "Zwierze";
            name = "No name";
            age = 10;
        }
        public Animal(string name, byte age)
        {
            type = "Zwierze";
            this.name = name;
            this.age = age;
        }
        public Animal(Animal animalToCopy)
        {
            type = "Zwierze";
            name = animalToCopy.name;
            age = animalToCopy.age;
        }

        public virtual void showInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine(type + " o imieniu " + name + " ma " + age + " lat");
            Console.WriteLine("****************");
        }
    }
}
