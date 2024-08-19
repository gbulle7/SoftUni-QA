using System;
namespace DemoPolymorphism
{
    public class Dog : Animal
    {
        //наследява всички полета и методи на клас Animal
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}

