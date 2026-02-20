using System;

public class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter title of movie:");
        string MovieTitle = Console.ReadLine();

        Console.WriteLine("Number of tickets:");
        int TicketNumbers = int.Parse(Console.ReadLine());

        Console.WriteLine("Price per ticket:");
        int PriceOfTickets = int.Parse(Console.ReadLine());

        Console.WriteLine("Duration of movie in hours:");
        int Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Screen number");
        int ScreenNum = int.Parse(Console.ReadLine());

        Console.WriteLine("First letter of Seat row:");
        string SeatLetter = Console.ReadLine();

        Console.WriteLine("Is 3D movie (true/false):");
        Boolean ThreeD = Convert.ToBoolean(Console.ReadLine());

        int CostPerHour = PriceOfTickets / Duration;

        Console.WriteLine($"Movies title is {MovieTitle},\nTotal cost of your tickets: {TicketNumbers * PriceOfTickets},\nSeat number {SeatLetter},\nCost per hour : {CostPerHour}");
    }
}