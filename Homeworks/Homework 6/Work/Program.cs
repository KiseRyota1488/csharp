using System;
using Office;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Department renome = new Department();

                    
            char key;
            do {
                Console.Write(
                    "\tOffice" +
                    "\n1: Add employee" +
                    "\n2: Remove employee" +
                    "\n3: Show office" +
                    "\n4: Exit" +
                    "\n->_"
                    );
                key = char.Parse(Console.ReadLine());

                switch (key)
                {
                    case '1':
                        {
                            renome.AddEmployee();

                            break;
                        }
                    case '2':
                        {
                            renome.RemoveEmployee();

                            break;
                        }
                    case '3':
                        {
                            char choice;

                            Console.Write(
                                "1: Show all office" +
                                "\n2: Show employees who have salavy less than avg" +
                                "\n3: Show reverse all office" +
                                "\n->_"
                                );
                            choice = char.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case '1':
                                    foreach (var item in renome)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    break;
                                case '2':
                                    foreach (Employee item in renome.GetSalaryEnum())
                                    {
                                        Console.WriteLine(item);
                                    }

                                    break;
                                case '3':
                                    foreach (var item in renome.GetReverseEnum())
                                    {
                                        Console.WriteLine(item);
                                    }

                                    break;
                                default:
                                    break;
                            }

                            break;
                        }
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (key != '4');

            
        }
    }
}
