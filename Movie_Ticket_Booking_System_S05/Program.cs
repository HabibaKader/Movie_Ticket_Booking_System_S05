using Movie_Ticket_Booking_System.Enum;
using Movie_Ticket_Booking_System_S03;
using Movie_Ticket_Booking_System_S04;
using Movie_Ticket_Booking_System_S05;

namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            var t1 = new StandardTicket("Inception", 80, "A5");
            var t2 = new VIPTicket("Avengers", 150, true);
            var t3 = new IMAXTicket("Dune", 100, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAll();

            Console.WriteLine("\n--- Clone Test ---");

            var clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original : ");
            t2.Print();

            Console.Write("Clone    : ");
            clone.Print();

            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

            cinema.CloseCinema();
        }
    }
}
