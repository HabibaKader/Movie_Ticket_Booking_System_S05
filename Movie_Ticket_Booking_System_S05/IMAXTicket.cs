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

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
