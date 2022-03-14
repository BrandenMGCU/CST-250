using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milestone1
{
    public class GameBoard
    {
        public int Size { get; set; } // This will get and set the board size

        public GameCell[,] BoardGrid { get; set; }

        public string Difficulty { get; set; } // This will determine the difficulty for the user 
        // This will also set how many cells that will be live with bombs for the user to contend with

        public int SetupLiveNeighbors { get; set; }


        public GameBoard(int s) // This will set the size of the grid
        {
            Size = s;

            BoardGrid = new GameCell[Size, Size]; // Needs 2 Size's for the Row and the Column of the Boards Grid

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    BoardGrid[i, j] = new GameCell();
                }
            }
        }
        public string userDifficulty()
        {
            return Difficulty;
        }

        /* INCOMPLETE */

        public setupLiveNeighbors()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    BoardGrid[i, j].number_of_neighbors++;
                };
            }
        }
    
        public 


