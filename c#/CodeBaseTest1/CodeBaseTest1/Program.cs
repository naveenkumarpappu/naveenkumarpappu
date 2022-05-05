using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest1
{
    internal class Program
    {
        class passenger
        {
            public string Name { get; set; }
            public int Age { get; set; }
            Ticket Tickets { get; set; }
           public string DateofTravel { get; set; }

            public passenger(string name, int age,string DateofTravel)
            {
                Name = name;
                Age = age;
                DateofTravel = DateofTravel;
                Tickets = new Ticket();

            }
            public void TicketBooking(int tickets)
            {
                Ticket.ticket= tickets;
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
                    passenger TicketB = new passenger("naveen", 15,"02/05/2022");
                    Console.WriteLine("enter the no of tickets ");
                    TicketB.TicketBooking(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                }
            }
        }
    }
}
