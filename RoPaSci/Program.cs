using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<Item>(args[0]);
            GameItem player2 = Enum.Parse<Item>(args[1]);

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

        private static GameStatus RockPaperScissors
        (GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw; // Draw

            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) 
            ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) 
            ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                return 1; // Player 1 wins
            }
            else
            {
                return 2; // Player 2 wins
            }
        }
    }
}
