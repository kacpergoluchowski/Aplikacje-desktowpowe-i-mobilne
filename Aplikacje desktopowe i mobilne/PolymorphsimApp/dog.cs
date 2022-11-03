using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimApp
{
    class dog : Animal
    {
        private string name;
        // private byte age;

        public dog()
        {
            type = "Pies";
            name = "Azor";
            // age = 10;
        }

        public dog(string name, byte age) : base(name, age)
        {
            type = "Pies";
            this.name = name;
            // this.age = age;
        }

        public dog(dog dogToCopy) : base(dogToCopy)
        {
            type = "Pies";
            name = dogToCopy.name;
            // age = dogToCopy.age;
        }
        public void Bark()
        {
            Console.WriteLine("Pies o imieniu " + name + " szczeka");
        }
        public void ChasePostman()
        {
            Console.WriteLine("Pies o imieniu " + name + " goni listonosza");
        }
        public override void showInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine("Przedstawienie psa: ");
            Console.WriteLine(type + " o imieniu " + name + " ma " + age + " lat");
            Console.WriteLine("****************");
        }
    }
}

    
