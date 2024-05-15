static void CountVowels(string text)
{
    int count = 0;
    text = text.ToLower();
    for (int i = 0; i < text.Length; i++)
    {
        switch (text[i])
        {
            case 'a': 
                count++;
                break;
            case 'o':
                count++;
                break;
            case 'e':
                count++;
                break;
            case 'i':
                count++;
                break;
            case 'u':
                count++;
                break;
        }
    }
    Console.WriteLine(count);
}

string text = Console.ReadLine();
CountVowels(text);


/*
string word = Console.ReadLine();
 
int vowelsCount = CountVowelsInText(word);
 
Console.WriteLine(vowelsCount);
 
static int CountVowelsInText(string text)
{
    // Characters in text have indexes -> [0; Length - 1]/[0; Length)
    int vowelsCount = 0;
    for (int i = 0; i < text.Length; i++)
    {
        // Always non-capital letter
        char ch = char.ToLower(text[i]);
        if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
        {
            // Vowel letter
            vowelsCount++;
        }
    }
 
    return vowelsCount;
}
*/