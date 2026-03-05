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
        private Projector projector = new Projector();

        public void OpenCinema()
        {
            Console.WriteLine("========= Cinema Opened =========");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
            Console.WriteLine("========= Cinema Closed =========");
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========= All Tickets =========");

            foreach (var ticket in tickets)
            {
                if (ticket != null)
                    ticket.PrintTicket(); 
            }
        }
    }
}
