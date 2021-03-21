using System;
using System.Collections.Generic;
using System.Text;

namespace T1
{
    class Event
    {
        string name;
        short peopleCount;
        string placeHolder;
        DateTime date;
        static byte counter = 0;

        public string Name { get; set; }
        public byte Counter { get; set; }

        List<Client> clients = new List<Client>(0);

        public Event(string name, short peopleCount, string placeHolder, DateTime date = default)
        {
            this.name = name;
            this.peopleCount = peopleCount;
            this.placeHolder = placeHolder;
            this.date = DateTime.Today;

            counter++;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}; People count: {peopleCount}; Place holder: {placeHolder}; Date: {date}");
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }
        }

    }
}
