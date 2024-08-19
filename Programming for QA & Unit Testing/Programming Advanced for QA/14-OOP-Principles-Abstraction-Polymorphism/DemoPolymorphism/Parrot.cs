using System;
namespace DemoPolymorphism
{
    public class Parrot : Animal
    {
        //наследява всички полета и методи на клас Animal
        public override void MakeSound()
        {
            Console.WriteLine("Hello, QA!");
        }
    }
}

