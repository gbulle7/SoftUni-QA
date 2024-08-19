
using DemoPolymorphism;


Animal[] animals = new Animal[]
{
    new Cat(),
    new Dog(),
    new Parrot()
};


foreach (Animal animal in animals)
{
    //полиморфизъм
    animal.MakeSound();
}
