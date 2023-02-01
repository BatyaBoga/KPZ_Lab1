using KPZ_Lab1.ConcreteFactory;
using System;

namespace KPZ_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAnimalInZoo(new UsualZoo());
            ShowAnimalInZoo(new ContactZoo());
            ShowAnimalInZoo(new ContarctZoo());

            Console.Read();
        }

        public static void ShowAnimalInZoo(AbstractZoo zoo)
        {
            var cat = zoo.GiveCat();
            var crow = zoo.GiveCrow();
            var lion = zoo.GiveLion();

            Console.WriteLine("Cat say: " + cat.ShowCat());
            Console.WriteLine("Crow say: " + crow.ShowCrow());
            Console.WriteLine("Lion say: " + lion.ShowLion());

            Console.WriteLine();
        }
    }
}