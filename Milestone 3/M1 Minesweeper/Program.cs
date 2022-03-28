using MinesweeperModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace M1_Minesweeper
{
    public class Program
    {
        static Board my_new_board = new Board(8);
        static void Main(string[] args)
        {
            do
            {
                // We need to show the empty board
                printBoard(my_new_board);

                // Ask the user for the x and y coordinates
                Cell currentCell = setCurrentCell();
                currentCell.Currently_Occupied_Cell = true;


                // Calculate all the legal moves
                // my_new_board.Legal_Move(currentCell);
            }
            while (true);

                // Show the board
                printBoard(my_new_board); // This will now show the latest updates to the board
            

                // Wait for another key press
                Console.ReadLine();
            
        }

        private static Cell setCurrentCell()
        {
            // This will get the user's x and y coordinates and return the cell's location.

            Console.WriteLine("Enter the current row number: ");
            int current_Row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current column: ");
            int current_Column = int.Parse(Console.ReadLine());

            return my_new_board.MinesweeperGrid[current_Row, current_Column];

        }

        private static void printBoard(Board my_new_board)
        {
            // This will print the minesweeper board to the console. We will use X for the user's piece location.
            // + will be the next avaliable move and . for an empty square
            for (int i = 0; i < my_new_board.Size; i++) // One Row at a time
            {
                for (int j = 0; j < my_new_board.Size; j++) // One Column at a time
                {
                    Cell c = my_new_board.MinesweeperGrid[i, j];

                    if (c.Currently_Occupied_Cell == true)
                    {
                        Console.Write("X"); // This will print the X in the same line.
                    }
                    else if (c.Legal_Move == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n================END OF THE BOARD================");
        }
    }
}