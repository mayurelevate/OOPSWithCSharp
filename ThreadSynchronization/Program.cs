using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BookMyShow bookMyShow = new BookMyShow();


            Thread t1 = new Thread(bookMyShow.TicketBook)
            {
                Name = "Thread1"
            };

            Thread t2 = new Thread(bookMyShow.TicketBook)
            {
                Name = "Thread2"
            };

            Thread t3 = new Thread(bookMyShow.TicketBook)
            {
                Name = "Thread3"
            };


            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }


    public class BookMyShow
    {

        private object lockObject = new object();

        int availableTickets = 3;
        static int i = 1, j = 2, k = 3;

        public void BookTicket(string name, int wantedtickets)
        {
           lock(lockObject)
            {
                if (wantedtickets <= availableTickets)
                {
                    Console.WriteLine(wantedtickets + "booked to" + name);
                    availableTickets = availableTickets - wantedtickets;
                }
                else
                {
                    Console.WriteLine("No tickets available to book");
                }
            }
        }

        public void TicketBook()
        {
            string name = Thread.CurrentThread.Name;

            if(name.Equals("Thread1"))
            {
                BookTicket(name, i);
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(name, j);
            }
            else
            {
                BookTicket(name, k);
            }
        }
    }
}
