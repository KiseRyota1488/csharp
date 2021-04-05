using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();


            char key = '9';
            do
            {
                Console.Write($"\tZoo\nFeed an animal\nVisit an animals\nWatch cameras\n->_");
                key = char.Parse(Console.ReadLine());

                switch (key)
                {
                    case '1':
                        {

                            string name;
                            Console.Write($"What animal you want to feed?: ");
                            name = Console.ReadLine();

                            foreach (var item in zoo.animal)
                            {
                                if (item.GetType().Name == name)
                                {
                                    item.Eat();
                                    break;
                                }
                            }

                            break;
                        }
                    case '2':
                        {
                            Random rnd = new Random();

                            int it = 0;
                            foreach (var item in zoo.animal)
                            {
                                zoo.zooWorkers[it].Watch(item);
                                int act = rnd.Next(3);
                                if (act == 1)
                                    item.Eat();
                                else if (act == 2)
                                    item.Move();
                                else
                                    Console.WriteLine($"{item.GetType().Name} is sleeping, you cant visit sleeping animals!");
                                it++;
                            }
                            break;
                        }
                    case '3':
                        {
                            Random rnd = new Random();
                            int it = 0;
                            foreach (var item in zoo.animal)
                            {
                                zoo.cameras[it].Watch(item);
                                int act = rnd.Next(3);
                                if (act == 1)
                                    item.Eat();
                                else if (act == 2)
                                    item.Move();
                                else
                                    item.Sleep();
                                it++;
                            }
                            break;
                        }

                        break;
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (key != '9');
        }

        void FeedAnimal()
        {

        }

    }


}
