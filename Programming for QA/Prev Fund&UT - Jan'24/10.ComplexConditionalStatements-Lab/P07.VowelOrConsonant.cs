//char character = char.Parse(Console.ReadLine().ToLower());
char character = Console.ReadLine().ToLower()[0];  // This ensures only the first character is taken if a string of more than one-char-long is entered

switch (character)
{
    case 'a':
    case 'e':
    case 'o':
    case 'i':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}