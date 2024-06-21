List<int> player1 = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();
List<int> player2 = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();

while (player1.Count > 0 && player2.Count > 0)
{
    if (player1[0] > player2[0])
    {
        player1.Add(player2[0]);
        player1.Add(player1[0]);
    }
    else if (player1[0] < player2[0])
    {
        player2.Add(player1[0]);
        player2.Add(player2[0]);
    }
    player1.RemoveAt(0);
    player2.RemoveAt(0);
}

if (player1.Count > 0)
{
    int sum = player1.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else if (player2.Count > 0)
{
    int sum = player2.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}