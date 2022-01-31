using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class TicTacToe
    {
        //UC1
        char[] Board = new char[10];
        public void gameBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Board[i] = ' ';
            }
        }


        /* UC2:- Ability to allow the player to choose a letter X or O
                 - Create a method to allow player to input X or O and call from main
                 - Determine Player and Computer Letter to play the game
         */
        public const char X = 'X';
        public const char O = 'O';

        public void abillityToInput()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X')
            {
                Console.WriteLine("Player Choose " + playerChoice);
                Console.WriteLine(" Computer Choose " + O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine(" Computer Chose " + X);
            }
            else
            {
                Console.WriteLine("Entered invalid input  ");
            }
        }
    }
}
