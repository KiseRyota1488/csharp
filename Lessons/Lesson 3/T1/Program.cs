using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            EventService events = new EventService();

            char key;
            do
            {
                Console.Write("Event menu:\n1: Add event\n2: Add client\n->_");
                key = char.Parse(Console.ReadLine());

                switch (key)
                {
                    case '1':
                        events.AddEvent();
                        events.Print();
                        break;
                    case '2':

                        events.

                        break;
                    default:
                        break;
                }

            } while (key != '3');


        }
    }
}
