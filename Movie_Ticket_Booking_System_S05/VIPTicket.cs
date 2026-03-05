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

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price + 50m)
        {
            LoungeAccess = loungeAccess;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
}
