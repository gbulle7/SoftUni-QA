//Error Types
//1. Compile Time Error / Компилационни грешки -> по време на компилация
//2. Runtime Error / По време на изпълнение грешки

//Exception -> грешка
//1. вид
//2. съобщение
//3. stack trace -> показва от къде е възникнала грешката

//Exceptions Example
//int[] numbers = new int[10];
//Console.WriteLine(numbers[20]); //IndexOfOfBoundsException

//Console.WriteLine(int.Parse("test")); //FormatException

//Exception Handling (Обработка на грешки) -> try-catch-finally
try
{
    int[] numbers = new int[10];
    Console.WriteLine(numbers[20]); //IndexOfOfBoundsException

    Console.WriteLine(int.Parse("test")); //FormatException

    int number = 0;
    Console.WriteLine(5 / number); //DivideByZeroException
}
catch (DivideByZeroException ex) //ex се съдържа моя exception / грешка
{
    Console.WriteLine("Warning! Divided by zero");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    throw new ArgumentException("Invalid"); //re-throw
}
catch (FormatException ex1)
{
    Console.WriteLine("Warning! Wrong format!");
    throw ex1; //re-throw
}
catch(IndexOutOfRangeException ex2)
{
    Console.WriteLine("Warning! Wrong index!");
}
finally
{
    //код, който искаме да изпълни без значение дали имаме грешка или не
    Console.WriteLine("Code always available.");
}


static void CheckNumber (int number)
{
    if (number < 0)
    {
        throw new ArgumentException("Negative Number!");
    }
}

//QA

//Arrange -> подготвя отрицателно число

//Act -> изпълним метода с отрицателното число: CheckNumber(-9)

//Assert -> получаваме грешка (вид: ArgumentException, съобщение: "Negative Number!")