using Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System_S03
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public VIPTicket(string movie, decimal basePrice, bool lounge)
            : base(movie, basePrice + 50m)
        {
            LoungeAccess = lounge;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | {BookingStatus}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price - ServiceFee, LoungeAccess);
        }
    }
}
