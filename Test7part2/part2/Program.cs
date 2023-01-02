using System;

class Program
{
    static void Main()
    {
        int? TicketsOnsale = null;
        int availableTickets;
        if(TicketsOnsale == null)
        {
            availableTickets = 0;
        }
        else
        {
            availableTickets = (int) TicketsOnsale;
        }
        Console.WriteLine("AvailableTickets  {0}",availableTickets);
    }
}