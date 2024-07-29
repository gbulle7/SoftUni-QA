//Dictionary - съвкупност от еднотипни елементи: записи
//запис == KeyValuePair (key - ключ -> value - стойност)

//създаване на празен речник

//всеки един запис: ЕГН (текст) - име на човек (текст)
Dictionary<string, string> peopleData = new Dictionary<string, string>();

//добавяме записи в речника
//!!! винаги трябва да сме сигурни, че няма запис с такъв ключ !!!
//начин 1
if (!peopleData.ContainsKey("9605128756"))
{
    peopleData["9605128756"] = "Ivan Dimitrov Ivanov";
}

//начин 2
peopleData.Add("9804238754", "Georgi Ivanov Ivanov");
peopleData.Add("9812045687", "Peter Georgiev Dimitrov");


//достъпваме стойности в речника
Console.WriteLine(peopleData["9605128756"]); //"Ivan Dimitrov Ivanov"

//създаваме предварително готов речник
Dictionary<string, int> fruits = new()
{
    { "Kiwi", 3 },
    { "Apple", 5 }
};

fruits.Add("Orange", 4);


//премахваме записи от речника
fruits.Remove("Kiwi");

//брой на записите в речника
int count = fruits.Count;
Console.WriteLine(fruits.Count);

//проверка дали има запис с даден ключ
Console.WriteLine(fruits.ContainsKey("Kiwi")); //False
Console.WriteLine(fruits.ContainsKey("Orange")); //True

//проверка дали има запис с даденa стойност
bool containsNumber = fruits.ContainsValue(5); //True
Console.WriteLine(fruits.ContainsValue(10)); //False
Console.WriteLine(fruits.ContainsValue(4)); //True

//обхождане на речник -> foreach
//запис = entry = pair
foreach (KeyValuePair<string, int> entry in fruits)
{
    //запис: key (име на плода) -> value (кг)
    //entry.Key -> име на плода
    //entry.Value -> кг
    Console.WriteLine(entry.Key + " -> " + entry.Value + " kg.");
}


//SortedDictionary == Dictionary, в който записите се сортират спрямо ключ
//записи: име -> възраст

//!!! всичко, което важи за Dictionary работи и за SortedDictionary !!!
SortedDictionary<string, int> employeesAge = new SortedDictionary<string, int>();
employeesAge.Add("Boyan", 34);
employeesAge.Add("Aleks", 45);
employeesAge.Add("Ivan", 23);
employeesAge.Add("Peter", 29);
employeesAge.Add("George", 2);


//намиране на ключ по стойност
string name = employeesAge.First(entry => entry.Value == 34).Key;
Console.WriteLine(name); //Boyan