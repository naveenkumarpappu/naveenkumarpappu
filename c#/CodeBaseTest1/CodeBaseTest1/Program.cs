using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest1
{
    internal class Program
    {
        class TicketB
        {
            public string Name { get; set; }
            public int Age { get; set; }
            TicketB Tickets { get; set; }

            public TicketB(string name, int age)
            {
                Name = name;
                Age = age;
                Tickets = new Tickets();
            }
            public void TicketBooking(int tickets)
            {
                Ticket.Tickets= tickets;
                Console.WriteLine("Tickets Booked Succesfully");
            }
            class Ticket
            {
                public int tickets;
                public int Tickets
                {
                    get => tickets;
                    set
                    {
                        if (value < 5)
                            throw new Exception("cannot book more than 5 Tickets");
                        else
                            tickets = value;
                    }
                }
                static void Main(string[] args)
                {
                    TicketB TicketB = new TicketB("naveen", 15);
                    Console.WriteLine("enter the no of tickets ");
                    TicketB.TicketBooking(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                }
            }
        }
    }
}
