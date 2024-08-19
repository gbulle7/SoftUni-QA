using System;
namespace DemoPolymorphism
{
    public class Cat : Animal
    {
        //наследява всички полета и методи на клас Animal
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}

