//RegEx - Cheat Sheet

//[a-z] -> 1 малка буква
//[A-Z] -> 1 главна буква
//[0-9] -> 1 цифра
//\W -> 1 символ различен от буква (малка и главна), цифра и _
//\w -> 1 символ, който е буква (малка или главна), цифра и _
//\d -> 1 цифра
//\D -> 1 символ, който не е цифра
//\s -> 1 интервал
//\S -> 1 символ, който не е интервал


//Модификатори за количество -> показват какъв брой от символа искам да имам
//{n} -> символът да се среща n на брой пъти
// + -> символът да се среща един или неограничен брой пъти
// ? -> символът или се среща веднъж, или не се среща въобще
// * -> символът или не се среща, или се среща неогранизен брой пъти

using System.Text.RegularExpressions;

//Създаване на шаблон в C#
Regex regexEmail = new Regex("[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]+"); //шаблон за имейл
string emails = "invalid*name@emai1.bg, valid123@email.bg, desi123@abv.bg, desi123423@abv.bg"; //текст, който ще проверяваме
//върху текста emails да приложим шаблона regexEmail -> съвкупност от текстовете, които отговарят на шаблона
MatchCollection matchedTexts = regexEmail.Matches(emails); //колекция от всички текстове, които отговарят на шаблона
//MatchCollection ~ List<Match>
//-> списък (колекция), в който имате всички текстове (Match), които отговарят на шаблона
//Match -> текст, който отговаря на шаблона 


//брой на текстовете, които отговарят на условието
Console.WriteLine(matchedTexts.Count);

//Първия текст, който отговаря на шаблона
Console.WriteLine(matchedTexts[0].Value);

//Последния текст, който отговаря на шаблона
Console.WriteLine(matchedTexts[matchedTexts.Count - 1].Value);

//oбхождаме всички текстове, които отговарят на шаблона
foreach (Match match in matchedTexts)
{
    Console.WriteLine(match.Value);
}


//ПЪРВИТЕ ТРИ ТЕКСТА, КОИТО ОТГОВАРЯТ НА ШАБЛОНА
for (int textPosition = 0; textPosition <= 2; textPosition++)
{
    Console.WriteLine(matchedTexts[textPosition]);
}


//проверка дали даден текст ми отговаря на шаблона
string text = "Today is 2015-05-11";
Regex regex = new Regex(@"[0-9]{4}-[0-9]{2}-[0-9]{2}"); //шаблон

bool containsValidDate = regex.IsMatch(text);
//IsMatch = True -> ако text отговаря на шаблона
//IsMatch = False -> ако text не отговаря на шаблона
Console.WriteLine(containsValidDate); // True

Match firstText = regex.Match(text);
//първия текст, който ми отговаря на шаблона
Console.WriteLine(firstText.Value);

//втория текст, който ми отговаря на шаблона
Match secondText = firstText.NextMatch();
Console.WriteLine(secondText.Value);


//replace с шаблон
string textForReplace = "Nakov: 123, Branson: 456";
Regex regexForReplace = new Regex(@"[0-9]{3}");
string replacement = "999";

string result = regex.Replace(textForReplace, replacement);

Console.WriteLine(result);
// Nakov: 999, Branson: 999


//splitting по regex
string namesText = "Bethany Taylor Oliver miller sophia Johnson SARah Wilson John Smith Sam	    Smith";
string[] names = Regex.Split(namesText, @"\s+");
Console.WriteLine();