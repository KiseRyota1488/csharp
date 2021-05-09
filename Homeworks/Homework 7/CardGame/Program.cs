using System;
using Table;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.ShuffleCards();

            int it = 0;
            while (game.GameOverCondition() == '3')
            {
                it++;
                Console.Write($"Round {it}:");

                game.OneMove();
                Console.ResetColor();
                Console.WriteLine($"P1 cards amount: {game.players[0].cards.Count} | P2 cards amount: {game.players[1].cards.Count}");

                Console.SetCursorPosition(0, 3);
                Console.WriteLine($"Press SPACE to continue!");
                Console.ReadKey();
                Console.Clear();
            }

            switch (game.GameOverCondition())
            {
                case '1':
                    Console.WriteLine($"P2 Won!");
                    break;
                case '2':
                    Console.WriteLine($"P1 Won!");
                    break;
                default:
                    break;
            }

        }
    }
}
