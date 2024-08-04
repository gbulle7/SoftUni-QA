//в клас Animal целим да опишем всяко животно, с което ще работим

//access modifers / модификатори за достъп
//1. public -> може да бъде достъпен навсякъде
//2. private -> може да се достъпва само в рамките на класа

public class Animal
{
    //част 1: характеристики -> описваме с какво се характеризира всяко едно животно чрез properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Owner { get; set; }

    //част 2: действия -> описваме какво може да прави всяко едно животно чрез методи
    public void Eat()
    {
        Console.WriteLine("Eating.....");
    }

    public void Walk()
    {
        Console.WriteLine("Walking....");
    }

    //част 3: конструктор -> специфичен public метод, който се казва по същия начин, по който и класа
                         // -> целта му е да създава обекти от дадения клас

    //1. default constructor / конструктор по подразбиране
    //                                 -> вграден в класа и няма нужда да го пишем
    //                                 -> създава празен обект от клас
    public Animal()
    {

    }

    //2. custom constructors / създаваме си наши конструктори
    public Animal(string name, int age, string owner)
    {
        //нов празен обект
        //Name = null
        //Age = 0
        //Owner = null
        Name = name;
        Age = age;
        Owner = owner;
    }
}


