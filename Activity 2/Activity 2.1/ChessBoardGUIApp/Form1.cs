﻿using ChessBoardModel1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        // This will be in reference to the class Board. Contains the values of the board.
        static Board myBoard = new Board(8); // Reference to Board

        // 2D array of buttons whose values are determined by myBoard.
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            // This will create buttons and place them into panel1.
            int buttonSize = panel1.Width / myBoard.Size;

            // Makes the panel a perfect square.
            panel1.Height = panel1.Width;

            // Nested loops. This will create buttons and print them to the screen.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i,j].Height = buttonSize;
                    btnGrid[i,j].Width = buttonSize;

                    // Adding a click event to each button.
                    btnGrid[i, j].Click += Grid_Buttn_Click;

                    // Adding the new button to the panel.
                    panel1.Controls.Add(btnGrid[i,j]);

                    // sets the location of the new button.
                    btnGrid[i,j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i,j].Text = i + "|" + j;

                    // This will allow us to get the info from the button that was clicked.
                    btnGrid[i,j].Tag = new Point(i,j);
                }
            }
        }

        private void Grid_Buttn_Click(object sender, EventArgs e)
        {
            // Get the row and column number of the button clicked. 
            Button clickedButton = (Button)sender;
            Point location = (Point) clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x,y];


            // Determine the next legal moves.
            myBoard.MarkNextLegalMoves(currentCell, comboBox1.Text);
            


            // Update the text on each button.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    btnGrid[i,j].BackColor = default(Color);

                    if (myBoard.theGrid[i,j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "Legal";
                    }
                    else if (myBoard.theGrid[i,i].CurrentlyOccupied == true)
                    {
                        btnGrid[i, j].Text = comboBox1.Text;
                    }
                }
            }
        }
    }
}
