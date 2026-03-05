using Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System_S03
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price)
        {
            SeatNumber = seat;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | {BookingStatus}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, SeatNumber);
        }
    }
}
