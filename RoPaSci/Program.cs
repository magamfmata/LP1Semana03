using System;
using GameItems;
using GameStatuses;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<GameItem>(args[0]);
            GameItem player2 = Enum.Parse<GameItem>(args[1]);

            GameStatus result = RockPaperScissors(player1, player2);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw; // Draw
            }
            if ((player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
                (player1 == GameItem.Scissors && player2 == GameItem.Paper) ||
                (player1 == GameItem.Paper && player2 == GameItem.Rock))
            {
                return GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                return GameStatus.Player2Wins; // Player 2 wins
            }
        }
    }
}