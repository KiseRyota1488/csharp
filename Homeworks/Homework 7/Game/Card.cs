using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    public class Card
    {
        string CardName { get; set; }
        string Suit { get; set; }
        public int Value { get; set; }


        public Card(string cardName, string suit, int value)
        {
            CardName = cardName;
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            if (Suit == "Чирва" || Suit == "Бубна")
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.DarkBlue;

            return $" {CardName} {Suit} ";

        }
    }
}
