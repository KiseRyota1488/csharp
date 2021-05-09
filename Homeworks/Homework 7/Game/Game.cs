using System;
using System.Collections.Generic;

namespace Table
{
    public class Game
    {
        public Player[] players = new Player[2] { new Player(), new Player()};

        List<string>allCards = new List<string>(36)
        {
            "6 Бубна 6",
            "6 Чирва 6",
            "6 Пика 6",
            "6 Хреста 6",

            "7 Бубна 7",
            "7 Чирва 7",
            "7 Пика 7",
            "7 Хреста 7",

            "8 Бубна 8",
            "8 Чирва 8",
            "8 Пика 8",
            "8 Хреста 8",

            "9 Бубна 9",
            "9 Чирва 9",
            "9 Пика 9",
            "9 Хреста 9",
            
            "10 Бубна 10",
            "10 Чирва 10",
            "10 Пика 10",
            "10 Хреста 10",

            "J Бубна 11",
            "J Чирва 11",
            "J Пика 11",
            "J Хреста 11",
            
            "Q Бубна 12",
            "Q Чирва 12",
            "Q Пика 12",
            "Q Хреста 12",

            "K Бубна 13",
            "K Чирва 13",
            "K Пика 13",
            "K Хреста 13",
            
            "A Бубна 14",
            "A Чирва 14",
            "A Пика 14",
            "A Хреста 14",

        };

        public void ShuffleCards()
        {
            string cardName, suit;
            int value;
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 5; i++) // можна змінити, якщо потрібно менша кількість карт у обох гравців
                {
                    Random rnd = new Random();

                    int ind = rnd.Next(allCards.Count);
                    string[] tmpStr = allCards[ind].Split(" ");

                    players[j].AddCard(new Card(tmpStr[0], tmpStr[1], int.Parse(tmpStr[2])));

                    allCards.RemoveAt(ind);
                }
            }
        }

        public void OneMove()
        {
            Random rnd = new Random();

            int playerOne = rnd.Next(players[0].cards.Count), playerTwo = rnd.Next(players[1].cards.Count);

            Console.Write($"{players[0].cards[playerOne]}");
            Console.WriteLine($"| {players[1].cards[playerTwo]}");

            if (players[0].cards[playerOne].Value < players[1].cards[playerTwo].Value)
            {
                players[1].AddCard(players[0].cards[playerOne]);
                players[0].cards.Remove(players[0].cards[playerOne]);
            }
            else
            {
                players[0].AddCard(players[1].cards[playerTwo]);
                players[1].cards.Remove(players[1].cards[playerTwo]);
            }
        }

        public char GameOverCondition()
        {
            if (players[0].cards.Count == 0)
                return '1';
            else if (players[1].cards.Count == 0)
                return '2';
            else
                return '3';
        }
    }
}
