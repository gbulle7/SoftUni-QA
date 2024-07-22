using System.Text;

//създаване на текстова променлива
string name = "John";

//дължина на текст = брой символи
int length = name.Length;
Console.WriteLine(name.Length);

//достъпвам символ от текст
char symbol = name[1];
Console.WriteLine(name[2]);

//достъпва първия символ от текста
Console.WriteLine(name[0]);

//достъпва последния символ от текста
Console.WriteLine(name[name.Length - 1]);

//конкатенация (+, string.Concat, string.Join) - долепване на текстове
string firstName = "Desislava";
string lastName = "Topuzakova";
string town = "Stara Zagora";

//str + str = str
string fullName = firstName + " " + lastName;

//str + число (int / double) = str
string nameAndAge = firstName + " " + 26;

//конкатенация -> Concat
string result = string.Concat(firstName, " - ", lastName);

//конкатенация с разделител -> Join
string fullNameAndAge = string.Join(":", firstName, lastName, town);
//"Desislava:Topuzakova:Stara Zagora"

//преобразуване текст в масив от символи
//"John".ToCharArray() -> ['J', 'o', 'h', 'n']
char[] symbols = name.ToCharArray(); //['J', 'o', 'h', 'n']
string resultText = symbols.ToString(); //"John"

//Example: Split vs Join

string sentence = "I am Desislava Topuzakova from Stara Zagora.";
string[] words = sentence.Split(" ");
//words = ["I", "am", "Desislava", "Topuzakova", "from", "Stara", "Zagora"]

string resultSentence = string.Join(",", words);
//"I,am,Desislava,Topuzakova,from,Stara,Zagora"

//Searching
//IndexOf -> позицията, на която за първи път срещаме даден текст
//-1 -> този текст не се намира
string fruits = "banana, apple, kiwi, banana, apple";
Console.WriteLine(fruits.IndexOf("banana"));    // 0
Console.WriteLine(fruits.IndexOf("apple"));     // 8
Console.WriteLine(fruits.IndexOf("orange"));    // -1

//LastIndexOf -> позицията, на която за последен път срещаме даден текст
//-1 -> този текст не се намира
Console.WriteLine(fruits.LastIndexOf("banana")); // 21
Console.WriteLine(fruits.LastIndexOf("orange")); // -1

//Contains -> проверка дали в даден текст се съдържа друг текст
//Тrue -> ако в един текст се съдържа другия
//False -> ако в един текст не се съдържа другия
string text = "I love fruits.";
Console.WriteLine(text.Contains("fruits"));// True
Console.WriteLine(text.Contains("banana")); // False

//Substring -> взима определен подтекст

//1. Substring(int startIndex) -> взима текста от дадената позиция до края
string longSentence = "My name is John";
string extractWord = longSentence.Substring(11);
Console.WriteLine(extractWord); // "John"

//2. Substring(int startIndex, int length)
string sentence = "My name is John";
string word = sentence.Substring(11, 2);
Console.WriteLine(word); // "Jo"


//Remove -> премахва символи от текста, започвайки от дадена позиция
string title = "House of Dragon";
title = title.Remove(6, 2);
Console.WriteLine(title);//"House  Dragon"


//Replace -> заменяме даден текст с друг
string email = "Hello, john@softuni.org, you have been using john@softuni.org in your registration.";
string replacedText = email.Replace("john@softuni.org", "john@softuni.com");
Console.WriteLine(replacedText);
// Hello, john@softuni.com, you have been using john@softuni.com in your registration.

string vegetables = "tomato, cucumber, onion, tomato";
vegetables = vegetables.Replace("tomato", "lettuce");
Console.WriteLine(vegetables); //"lettuce, cucumber, onion, lettuce"


//STRING BUILDER
StringBuilder sb = new StringBuilder(); //нов празен StringBuilder

//добавяне на текстове в StringBuilder
sb.Append("Hello, ");
sb.Append("John! ");
sb.Append("I sent you an email.");
Console.WriteLine(sb);

//дължина на StringBuilder = дължина на текста, който имаме в него
//sb = "Desi"
Console.WriteLine(sb.Length); //4

//изпразване на StringBuilder -> премахваме всички символи в него
sb.Clear();

//достъпваме елемент в текста, който е в StringBuilder
Console.WriteLine(sb[0]);

//вмъкване на текст в текста, който е в StringBuilder
//sb = "Desi"
sb.Insert(0, "I am");

//замяна на текст
//sb = "I am Desi".Replace("I am", "You are") -> sb = "You are Desi"
sb.Replace("I am", "You are");

//StringBuilder -> в string
string textBuilder = sb.ToString();

//string -> StringBuilder
string lectureName = "Objects and Classes";
StringBuilder sb2 = new StringBuilder(lectureName);