string password = Console.ReadLine();
string match;

if (password == "s3cr3t!P@ssw0rd")
{
    match = "Welcome";
}
else
{
    match = "Wrong password!";
}
Console.WriteLine(match); 