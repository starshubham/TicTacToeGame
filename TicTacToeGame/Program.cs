using System;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            //UC1
            TicTacToe obj = new TicTacToe();
            obj.gameBoard();

            //UC2
            obj.abillityToInput();
        }
    }
}
