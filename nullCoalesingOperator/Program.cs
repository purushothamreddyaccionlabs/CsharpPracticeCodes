using System;
class program
{
    static void Main()
    {
        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("Available tickets is {0}", AvailableTickets);
    }
}
