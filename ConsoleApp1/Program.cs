using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog("Жирмэн", new DateTime(2018, 10, 10));
            Console.WriteLine(d.Age);
            ((IWalking)d).Walk();

            Butterfly but = new Butterfly("Крылатка", new DateTime(2005, 03, 08));
            ((IFlying)but).Fly();

            Bird bid = new Bird("Лётчик", new DateTime(2009, 12, 12));
            ((IFlying)bid).Fly();

            Fish fis = new Fish("Пузырик", new DateTime(2008, 11, 11));
            ((ISwimming)fis).Swim();
            Console.ReadLine();

        }
    }
}
    

