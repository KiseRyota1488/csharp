using System;
using System.Threading;
using System.Collections.Generic;


namespace Program
{
    enum Planets
    {
        Mercury = 1,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    class Program
    {
        static void Main(string[] args)
        {
			//1
			/*
			double temp;
			Console.Write("Enter temp: ");
			temp = double.Parse(Console.ReadLine());
			
			char key;
			do{
				Console.WriteLine("1 Change to cel\n2 Change to far\n3 Show temp");
				key = char.Parse(Console.ReadLine());
				
				if(key == '1')
				{
					temp = (temp - 32) / 1.8;
				}
				else if(key == '2')
				{
					temp = temp * 1.8 + 32;
				}
				else if(key == '3')
				{
					Console.WriteLine(temp);
				}
			}while(key != '4');
			*/

			//2
			/*
			double lenght = 0;
			
			char choice = '1';
			while(choice != '3')
			{
				Console.Write("Enter lenght: ");
				lenght = double.Parse(Console.ReadLine());
				
				Console.Write("Menu\n1 Change to cm\n2Change to inches\n3Exit\n->_");
				choice = char.Parse(Console.ReadLine());
				
				if(choice == '1')
				{
					lenght *= 2.54;
				}
				else if(choice == '2')
				{
					lenght /= 2.54;
				}
				else if(choice != '3')
				{
					Console.WriteLine("Wrong choice!");
				}
				
				Console.WriteLine(lenght);
			}
			*/

			//3
			/*
			int a, b;
			char operation;
			
			char key = '1';
			do{
				Console.WriteLine("CALCULATOR\nYou can choose any of this operations:\n+\n-\n*\n/\nOr enter 3 to exit program");
				
				char input = Console.ReadKey().KeyChar;
				
				Console.Clear();
				
				Console.Write("Enter number 1: ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Enter number 2: ");
				b = int.Parse(Console.ReadLine());
				
				
				switch(input)
				{
					case '+':
						Console.Clear();
						Console.WriteLine("{0} + {1} = {2}",a,b,(a+b));
						Console.ReadKey();
						break;
					case '-':
						Console.Clear();
						Console.WriteLine("{0} - {1} = {2}",a,b,(a-b));
						Console.ReadKey();
						break;
					case '*':
						Console.Clear();
						Console.WriteLine("{0} * {1} = {2}",a,b,(a*b));
						Console.ReadKey();
						break;
					case '/':
						Console.Clear();
						if(b != 0)
						{
							Console.WriteLine("{0} / {1} = {2}",a,b,(a/b));
						}
						else
							Console.WriteLine("Second number is zero!Change it!");
						Console.ReadKey();
						break;
					default:
						Console.WriteLine("Default case");
						break;
				};

				Console.Write("Do you want to continue? 1-yes,0-no: ");
				int choice = int.Parse(Console.ReadLine());
				if(choice == 1)
				{
					key = '1';
				}
				else if(choice == 0)
				{
					key = '3';
					break;
				}
							
			}while(key != '3');
			*/

			//4

			/*
			int key;

			Planets currentPlanet;

			do
			{
				Console.Write("Enter planet number (1-8) to get info or 9 to exit: ");
				key = int.Parse(Console.ReadLine());

				currentPlanet = (Planets)key;

                switch (currentPlanet)
                {
                    case Planets.Mercury:
						Console.Clear();
						Console.WriteLine(@"Mercury is the closest planet to the Sun and due to its proximity it is not easily 
seen except during twilight. For every two orbits of the Sun, Mercury completes 
three rotations about its axis and up until 1965 it was thought that the same 
side of Mercury constantly faced the Sun. Thirteen times a century Mercury 
can be observed from the Earth passing across the face of the Sun in an 
event called a transit, the next will occur on the 9th May 2016.");
						break;
                    case Planets.Venus:
						Console.Clear();
						Console.WriteLine(@"Venus is the second planet from the Sun and is the second largest terrestrial planet. 
Venus is sometimes referred to as the Earth’s sister planet due to their similar size and mass. 
Venus is named after the Roman goddess of love and beauty.");
						break;
                    case Planets.Earth:
						Console.Clear();
						Console.WriteLine(@"Earth is the third planet from the Sun and is the largest of the terrestrial planets. 
The Earth is the only planet in our solar system not to be named after a Greek or Roman deity. 
The Earth was formed approximately 4.54 billion years ago and is the only known planet to support life.");
						break;
                    case Planets.Mars:
						Console.Clear();
						Console.WriteLine(@"Mars is the fourth planet from the Sun and is the second smallest planet in the solar system. 
Named after the Roman god of war, Mars is also often described as the “Red Planet” due to its reddish appearance. 
Mars is a terrestrial planet with a thin atmosphere composed primarily of carbon dioxide.");
						break;
                    case Planets.Jupiter:
						Console.Clear();
						Console.WriteLine(@"Jupiter is the largest planet in the solar system and is the fifth planet out from the Sun. 
It is two and a half times more massive than all the other planets in the solar system combined. 
It is made primarily of gases and is therefore known as a “gas giant”.");
						break;
                    case Planets.Saturn:
						Console.Clear();
						Console.WriteLine(@"Best known for its fabulous ring system, Saturn is the sixth planet 
from the Sun and the second largest in our solar system. Like Jupiter, Saturn is a gas giant and is composed 
of similar gasses including hydrogen, helium and methane.");
						break;
                    case Planets.Uranus:
						Console.Clear();
						Console.WriteLine(@"Uranus is the seventh planet from the Sun. 
It’s not visible to the naked eye, and became the first planet discovered with the use of a telescope. 
Uranus is tipped over on its side with an axial tilt of 98 degrees. It is often described as “rolling around the Sun on its side.”");
						break;
                    case Planets.Neptune:
						Console.Clear();
						Console.WriteLine(@"Neptune is the eighth planet from the Sun, 
making it the most distant in the solar system. This gas giant may have formed much closer 
to the Sun in the early solar system history before migrating out to its current position.");
						break;
                    default:
                        break;
                }


                Console.ReadKey();
				Console.Clear();

            } while (key != 9);

			*/

			//5
			/*
            int password = 51239854, balance = 500;

            char key = '1';
            do
            {
                string choice;
                bool cond = false;
                Console.Write("Do you want to login into user panel? y/n: ");
                choice = Console.ReadLine();

                if (choice.ToLower() == "y")
                    cond = true;
                else if (choice.ToLower() == "n") 
				{
                    cond = false;
					key = '3';
				}

                if (cond)
                {
                    for (int tries = 3; tries > 0; tries--)
                    {
                        Console.Write("Enter your pass: ");
                        int tempPass = int.Parse(Console.ReadLine());

                        if (tempPass == password)
                        {
                            Console.Write("Your balance: {0}\nDo you want to withdraw? y/n: ", balance);

                            string choice1;
                            bool cond1 = false;

                            choice1 = Console.ReadLine();

                            if (choice1.ToLower() == "y")
                                cond1 = true;
                            else if (choice1.ToLower() == "n")
                                cond1 = false;

                            if (cond1)
                            {
                                Console.Write("How much money: ");
                                int withdraw = int.Parse(Console.ReadLine());

                                if (balance > withdraw)
                                    balance -= withdraw;
                                else
                                    Console.WriteLine("Not enought balance!");
                            }

                            break;
                        }
                        else if (tries == 1)
                            Console.WriteLine("Login session will be rebooted!");
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong pass, try again. You have left {0} tries", tries);
                        }
                    }
                }

            } while (key != '3');

			*/

			//6
			/*
			Random random = new Random();

			int elevatorMaxWeight = 50;
			List <int> passengers = new List<int> { 5, 10, 13, 4, 6 };

            foreach (var item in passengers)
            {
                Console.WriteLine(item);
            }

			int i = passengers.Count;
            Console.WriteLine("{0}: summary weight", CountPassWeight(passengers));

			while(!MoreWeight(passengers, elevatorMaxWeight))
            {
				passengers.Add(random.Next(10) + 1);
				Console.WriteLine("{0}: {1}",i,passengers[i]);
				if (MoreWeight(passengers, elevatorMaxWeight)) 
				{
					Console.WriteLine("Passenger with id: {0} will be damaged!", passengers.Count);
					break;
				}
				i++;
			}

			int CountPassWeight(List<int> passengers)
			{
				int weight = 0;

				foreach (var item in passengers)
				{
					weight += item;
				}

				return weight;

			}

			bool MoreWeight(List<int> passengers, int elMaxWeight) 
			{
				if (CountPassWeight(passengers) > elMaxWeight)
					return true;
				else if (CountPassWeight(passengers) <= elMaxWeight)
					return false;

				return false;
			}
			*/

			//7




			Console.ReadKey();

		}

		
    }
}