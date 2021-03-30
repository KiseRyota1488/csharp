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
        DateTime date = new DateTime();
        static byte counter = 0;

        public string Name { get; set; }
        public byte Counter { get; set; }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        Client client;

        public Client Client 
        {
            get { return client; }
            set { client = value; }
        }

        public Event(string name, short peopleCount, string placeHolder, Client client, DateTime date)
        {
            this.name = name;
            this.peopleCount = peopleCount;
            this.placeHolder = placeHolder;
            this.date = date;

            this.client = client;

            counter++;
        }

        public override string ToString()
        {
            return $"Event: Name: {name} People count: {peopleCount} Date time {date.ToShortDateString()} | Client: " + client.ToString();
        }

    }
}
