string movie = Console.ReadLine();
int studentTickets = 0;
int standardTickets = 0;
int kidsTickets = 0;

while  (movie != "Finish")
{
    int availableSeats = int.Parse(Console.ReadLine());
    double ticketsMovie = 0;
    while (availableSeats > ticketsMovie)
    {
        string ticket = Console.ReadLine();
        if (ticket == "End")
        {
            break;
        }
        switch (ticket)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidsTickets++;
                break;
        }
        ticketsMovie++;
    }
    double moviePercentFull = ticketsMovie / availableSeats * 100;
    Console.WriteLine($"{movie} - {moviePercentFull:F2}% full.");
    movie = Console.ReadLine();
}
double totalTickets = studentTickets + standardTickets + kidsTickets;
double pctStudentTickets = studentTickets / totalTickets * 100;
double pctStandardTickets = standardTickets / totalTickets * 100;
double pctKidTickets = kidsTickets / totalTickets * 100;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{pctStudentTickets:F2}% student tickets.");
Console.WriteLine($"{pctStandardTickets:F2}% standard tickets.");
Console.WriteLine($"{pctKidTickets:F2}% kids tickets.");