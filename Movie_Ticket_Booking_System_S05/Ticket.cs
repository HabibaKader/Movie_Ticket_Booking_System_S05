using Movie_Ticket_Booking_System.Enum;
using Movie_Ticket_Booking_System_S05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }

        public decimal PriceAfterTax => Price * 1.14m;

        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets() => counter;

        
        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        
        public abstract void Print();

        
        public abstract object Clone();

        protected string BookingStatus =>
            $"Booked: {(IsBooked ? "Yes" : "No")}";
    }
}
