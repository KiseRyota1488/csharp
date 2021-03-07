using System;
using System.Threading;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			//1
			/*int money = 1000;
			int per = -1;
			while(money <= 4000)
			{
				while(per > 25 || per < 0)
				{
					Console.Write("Enter percent: ");
					per = int.Parse(Console.ReadLine());
				}
				money += money * per / 100;
				Console.WriteLine(money);
				Thread.Sleep(500);
			}*/
			//2
			/*
			int a = 1,b = 0;
			while(a>b)
			{
				Console.WriteLine("Enter a: ");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter b(must be bigger than a): ");
				b = int.Parse(Console.ReadLine());
			}
			for(int i = a;i<=b;i++)
			{
				for(int j = 0;j < i;j++)
				{
					Console.Write("{0} ",i);
				}
				Console.WriteLine();
			}
			Console.ReadKey();*/
			//3
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
			
			Console.ReadKey();
		}
	}
}