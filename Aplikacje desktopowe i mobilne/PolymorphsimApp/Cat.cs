using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimApp
{
    class Cat : Animal
    {
        public Cat()
        {
            type = "Kot";
            name = "Puszek";
            age = 10;
        }
        public Cat(string name, byte age) : base(name, age)
        {
            type = "Kot";
            this.name = name;
            this.age = age;
        }
        public Cat(Cat catToCopy) : base(catToCopy)
        {
            type = "Kot";
            name = catToCopy.name;
            age = catToCopy.age;
        }
        

        public void meow()
        {
            Console.WriteLine("Kot o imieniu " + name + " miauczy");
        }

        public void climbOnTree()
        {
            Console.WriteLine("Kot o imieniu " + name + " wspina sie na drzewo");
        }
    }
}
