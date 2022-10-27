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

            Cat firstCat = new Cat();
            firstCat.showInfo();
            Cat secondCat = new Cat("reksio", 15);
            secondCat.showInfo();
            secondCat.meow();

            Cat thirdCat = new Cat(secondCat);
            thirdCat.climbOnTree();
            ShowInfoForDog(firstDog);
            //ShowInfoForDog(firstCat);
            ShowInfoForCat(firstCat);

        }

        static void ShowInfoForDog(dog pies)
        {
            pies.showInfo();
        }
        static void ShowInfoForCat(Cat kot)
        {
            kot.showInfo();
        }
    }
}
