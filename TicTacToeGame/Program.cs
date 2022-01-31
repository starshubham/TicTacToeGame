using System;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToe obj = new TicTacToe();
            obj.gameBoard();
        }
    }
}
