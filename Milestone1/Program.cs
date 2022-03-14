using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milestone1
{
    public class Program
    {
        //Here we will setup the GameBoard for the user
        static GameBoard gameBoard = new GameBoard(16); // Wanted a larger game board when playing minesweeper

        public static string Difficulty { get; private set; }

        static void Main(string[] args)
        {
            // Now we will print a new minesweeper game board.
            printGameBoard(gameBoard);

            GameCell users_cell = Set_Users_Cell();
            users_cell.ItsVisible = true;
        }

        private static GameCell Set_Users_Cell()
        {
            Console.WriteLine("What row would you like to start in?");
            int Row = int.Parse(Console.ReadLine());
            // This will set the row for the user to start in.

            Console.WriteLine("What column would you like to start in?");
            int Column = int.Parse(Console.ReadLine());
            // This will set the column for the user to start in.

            gameBoard.BoardGrid[Row, Column].ItsVisible = true;
        }

        private static void printGameBoard(GameBoard gameBoard)
        {

            // This is going to give us a visual of the game board layout
            for (int i = 0; i < gameBoard.Size; i++)
            {
                for (int a = 0; a < gameBoard.Size; a++)
                {
                    Console.WriteLine("+--");
                }
                Console.Write("+");
                Console.Write("");
                Console.Write("|");

                for (int j = 0 ; j < gameBoard.Size; j++)
                {
                    GameCell gc = gameBoard.BoardGrid[i,j];

                    if (gc.Live == true)
                    {
                        Console.WriteLine("What would you like the difficulty to be?");
                        Console.WriteLine("1 for Easy, 2 for Medium, 3 for Hard");
                        Difficulty = Console.ReadLine();
                        if (Difficulty == "1")
                        {
                            Console.WriteLine("Difficulty is set to Easy.");
                        }
                        if (Difficulty == "2")
                        {
                            Console.WriteLine("Difficulty is set to Medium.");
                        }

                        if (Difficulty == "3")
                        {
                            Console.WriteLine("Difficulty is set to Hard!");
                        }
                        break;
                    }
                    Console.WriteLine("-----------------------------------------");
                }   
            }
        }
    }
}
