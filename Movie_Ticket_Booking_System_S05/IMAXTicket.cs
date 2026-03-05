using Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System_S03
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, decimal price, bool is3D)
            : base(movie, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | {BookingStatus}");
        }

        public override object Clone()
        {
            return new IMAXTicket(MovieName, Is3D ? Price - 30 : Price, Is3D);
        }
    }
}
