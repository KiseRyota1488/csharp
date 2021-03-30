using System;
using System.Collections.Generic;
using System.Text;

namespace T1
{
    class EventService
    {
        List<Event> events = new List<Event>();

        public Event Events { get; set; }

        public void Print()
        {
            foreach (var item in events)
            {
                Console.WriteLine(item);
            }
        }
        public void Print(DateTime date)
        {
            foreach (var item in events)
            {
                if (date == item.Date)
                    Console.WriteLine(item);
            }
        }
        public void Print(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
                Swap(ref date1, ref date2);

            foreach (var item in events)
            {
                if (date2 >= item.Date && item.Date >= date1)
                    Console.WriteLine(item);
            }
        }
        public void Print(string name)
        {
            foreach (var item in events)
            {
                if (name == item.Client.Name)
                    Console.WriteLine(item);
            }
        }
        public void AddEvent()
        {
            int month, day;
            string name, placeHolder, clientName, number;
            short peopleCount;
            DateTime date;

            Console.Write("Enter event name: ");
            name = Console.ReadLine();
            Console.Write("Enter event place holder: ");
            placeHolder = Console.ReadLine();
            Console.Write("Enter event people count: ");
            peopleCount = short.Parse(Console.ReadLine());
            Console.Write("Enter date (month 1-12, then date 1-31): ");
            month = int.Parse(Console.ReadLine());
            day = int.Parse(Console.ReadLine());

            date = new DateTime(2021, month, day);

            Console.Write("Enter client name: ");
            clientName = Console.ReadLine();
            Console.Write("Enter number: ");
            number = Console.ReadLine();

            Client client = new Client(clientName, number);
            Event tempEvent = new Event(name, peopleCount, placeHolder, client, date);

            this.events.Add(tempEvent);
        }

        public void RemoveEvent()
        {
            if (events.Count != 0)
            {

                string name;
                Console.Write("Enter event name: ");
                name = Console.ReadLine();

                foreach (var item in events)
                {
                    if (item.Name == name)
                    {
                        events.RemoveAt(events.IndexOf(item));
                        break;
                    }

                }
            }
            else
                Console.WriteLine("Sorry, events is empty!");
        }

        public void RemoveAllEvents()
        {
            events.Clear();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }



    }
}
