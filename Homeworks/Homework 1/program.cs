using System;
using System.Threading;

enum Planets
{
	Mercury = 1,
	Venerus
				
}

namespace Program
{
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
			string key;
			
			Planets pl;
			do{
				Console.Write("Enter planet number to get info or 10 to exit: ");
				
				key = (Planets)Console.ReadLine();
				
				
				switch(key)
				{
					case pl.Mercury:
						Console.Write("1");
						break;
				}
				
				
			
			
			}while(key != 10);
			*/
			
			
			Console.ReadKey();
		}
	}
}