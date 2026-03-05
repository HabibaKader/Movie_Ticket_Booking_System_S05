using Movie_Ticket_Booking_System.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System
{
    public class Ticket
    {
        private static int counter = 0;

        private string movieName;
        private decimal price;

        public int TicketId { get; }

        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        public decimal Price
        {
            get => price;
            protected set
            {
                if (value > 0)
                    price = value;
            }
        }

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine(
                $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        public void SetPrice(decimal newPrice)
        {
            Price = newPrice;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

        public static int GetTotalTickets()
        {
            return counter;
        }
    }
}
