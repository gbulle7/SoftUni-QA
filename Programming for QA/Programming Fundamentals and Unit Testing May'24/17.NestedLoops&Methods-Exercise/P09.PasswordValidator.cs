static void CheckPassword(string password)
{
    bool length = CheckLength(password);
    bool charsType = CheckCharsType(password);
    bool minDigits = CheckMinDigits(password);
    if (length && charsType && minDigits)
    {
        Console.WriteLine("Password is valid");
    }
}

static bool CheckLength(string password)
{
    bool isValid = false;
    if (password.Length >= 6 && password.Length <= 10)
    {
        isValid = true;
    }
    else
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    return isValid;

}
static bool CheckCharsType(string password)
{
    bool isValid = true;
    for (int ch = 0; ch < password.Length; ch++)
    {
        if (!char.IsLetterOrDigit(password[ch]))
        {
            isValid = false;
            break;
        }
    }
    if (!isValid)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    return isValid;
}
static bool CheckMinDigits(string password)
{
    bool isValid = false;
    int digitsCount = 0;
    for (int d = 0; d < password.Length; d++)
    {
        if (char.IsDigit(password[d]))
        {
            digitsCount++;
        }
    }
    if (digitsCount >= 2)
    {
        isValid = true;
    }
    else
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
    return isValid;
}

string passwordInput = Console.ReadLine();
CheckPassword(passwordInput);