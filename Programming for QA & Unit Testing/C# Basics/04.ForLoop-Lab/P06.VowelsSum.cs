string text = Console.ReadLine().ToLower();
int vowelSum = 0;

for (int i = 0; i < text.Length; ++i)
{
    char vowel = text[i];
    int point = 0;
    switch (vowel)
    {
        case 'a':
            point = 1;
            break;
        case 'e':
            point = 2;
            break;
        case 'i':
            point = 3;
            break;
        case 'o':
            point = 4;
            break;
        case 'u':
            point = 5;
            break;            
    }
    vowelSum += point;
}

Console.WriteLine(vowelSum);


//string input = Console.ReadLine();
//int sum = 0;

//for (int i = 0; i < input.Length; i++)
//{
//    switch (input[i])
//    {
//        case 'a': sum += 1; break;
//        case 'e': sum += 2; break;
//            // TODO: Add cases for the other vowels.
//    }
//}
//Console.WriteLine(sum);
