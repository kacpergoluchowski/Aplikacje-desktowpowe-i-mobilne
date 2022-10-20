using System;

namespace PolymorphsimApp
{
    class Program
    {
        static void Main(string[] args)
        {
            dog firstDog = new dog();
            dog secondDog = new dog("Burek", 5);
            dog thirdDog = secondDog;
            secondDog.showInfo();
            thirdDog.showInfo();
            firstDog.showInfo();
            secondDog.Bark();
            thirdDog.ChasePostman();
        }
    }
}
