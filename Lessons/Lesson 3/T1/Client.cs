using System;
using System.Collections.Generic;
using System.Text;

namespace T1
{
    class Client
    {
        string number;
        string name;

        public Client(string name, string number)
        {
            this.name = name;

            if (!NumberCorrectnessCond(number))
                while (!NumberCorrectnessCond(number))
                {
                    Console.WriteLine("Your number is incorrect! Enter again!");
                    Console.Write("Enter your number (should start with 380 and its lenght equals 12 digits): ");
                    number = Console.ReadLine();
                }
            else
            {
                Console.WriteLine("Number is correct!");
            }

            this.number = number;
        }

        public override string ToString() => $"Name: {name}; Number: {number}";

        bool NumberCorrectnessCond(string number)
        {
            foreach (char sym in number)
            {
                if (sym < '0' || sym > '9')
                    return false;
                else
                {
                    if (number[0] != '3')
                        return false;
                    else if (number[1] != '8')
                        return false;
                    else if (number[2] != '0')
                        return false;
                    else if (number.Length > 12 || number.Length < 12)
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

    }
}
