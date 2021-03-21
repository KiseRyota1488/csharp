using System;
using System.Collections.Generic;
using System.Text;

namespace T1
{
    class EventService
    {
        List<Event> events = new List<Event> (0);

        public void Print()
        {
            foreach (var item in events)
            {
                item.Print();
            }
        }
        public void AddEvent() 
        {
            string name, placeHolder;
            short peopleCount;
            DateTime date = DateTime.Today;

            Console.Write("Enter event name: ");
            name = Console.ReadLine();
            Console.Write("Enter event place holder: ");
            placeHolder = Console.ReadLine();
            Console.Write("Enter event people count: ");
            peopleCount = short.Parse(Console.ReadLine());


            Event tempEvent = new Event(name, peopleCount, placeHolder, date);

            this.events.Add(tempEvent);
        }

        public void RemoveEvent() 
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

          

    }
}
