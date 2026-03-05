using Movie_Ticket_Booking_System.Enum;
using Movie_Ticket_Booking_System_S03;
using Movie_Ticket_Booking_System_S04;

namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            StandardTicket t1 = new StandardTicket("Inception", 120m, "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", 150m, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180m, false);

            Console.WriteLine("\n========= SetPrice Test =========");

            Console.WriteLine("Setting price directly: 150");
            t1.SetPrice(150m);

            Console.WriteLine("Setting price with multiplier: 100 × 1.5");
            t1.SetPrice(100m, 1.5m);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            TicketProcessor.ProcessTicket(t2);

            cinema.CloseCinema();
        }
    }
}
