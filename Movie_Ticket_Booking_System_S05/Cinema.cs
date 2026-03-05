using Movie_Ticket_Booking_System_S03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();
            }
        }
    }
}
