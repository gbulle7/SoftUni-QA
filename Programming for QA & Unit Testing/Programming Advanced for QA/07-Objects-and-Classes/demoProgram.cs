// Program.cs -> логиката на използване на обекти и класове

//Vet clinic -> Monday
Animal cat = new Animal(); //нов празен обект от клас Animal чрез default constructor

//object cat
//Name: null
//Age: 0
//Owner: null

//задаване на стойности на property -> set
cat.Age = 5;
cat.Name = "John";
cat.Owner = "Ivan";
//object cat
//Age: 5
//Name: "John"
//Owner: "Ivan"

//достъпвам стойностите на property -> get
Console.WriteLine("Cat name: " + cat.Name);
Console.WriteLine("Cat age: " + cat.Age);
Console.WriteLine("Cat owner: " + cat.Owner);

//изпълня действията за животното
cat.Eat();
cat.Walk();


//Vet clinic -> Tuesday

Animal dog = new Animal("Sharo", 10, "Rosi"); //нов обект от клас Animal, чрез custom constructor

//object dog
//Age: 10
//Name: "Sharo"
//Owner: "Rosi"
//действия, които може да извършва: Eat(), Walk()

Console.WriteLine(dog.Age);
Console.WriteLine(dog.Name);
Console.WriteLine(dog.Owner);