using Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System_S04
{
    public static class TicketProcessor
    {
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========= Process Single Ticket =========");
            t.PrintTicket();
        }
    }
}
