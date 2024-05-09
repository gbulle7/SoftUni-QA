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