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

        public StandardTicket(string movieName, decimal price, string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat: {SeatNumber}");
        }
    }
}
