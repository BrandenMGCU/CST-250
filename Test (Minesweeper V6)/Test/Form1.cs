using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{

    public partial class Form1 : Form
    {
        // THIS IS FOR THE SOUNDS AND MOVIES TO BE PLAYED IN THE MEDIA PLAYER
        string[] files, paths;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("WELCOME TO MINESWEEPER! PLEASE SELECT YOUR DIFFICULTY IN THE BOX TO THE LEFT!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will be the button that adds files to the computer.

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFile.SafeFileNames;
                paths = openFile.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This will be the foundation for the user's difficulty.

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // This will hold all the minesweeper buttons for the game

            foreach (Button button in flowLayoutPanel1.Controls)
            {
                button.ForeColor = Color.Empty;
                button.Text = "";
                if ((Control.MouseButtons & MouseButtons.Left) != 0)
                {
                    System.Media.SoundPlayer playereasy = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\coin.wav");
                    playereasy.Play();

                    MessageBox.Show("This box has been checked!");
                    button.Text = "";
                    button.ForeColor = Color.Empty;
                    button.SendToBack();
                    button.BackColor = Color.Green;
                    button.Text = " ";
                    

                    if (button.BackColor == Color.Red)
                    {
                        Bombs();
                        MessageBox.Show("GAME OVER! YOU HIT A BOMB!");
                        return;
                    }
                }
            }
        }
        private void Bombs()
        {
            if (flowLayoutPanel1.BackColor == Color.Red)
            {
                Button.ReferenceEquals(button14.BackColor, Color.Red);
                flowLayoutPanel1.Hide();
                MessageBox.Show("You hit a bomb! Game Over!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // This will play a sound when the button is clicked.
                System.Media.SoundPlayer playereasy = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\that_was_easy.wav");
                playereasy.Play();

                // This will show the user that the difficulty has been set to Easy.
                MessageBox.Show("Your new difficulty will be: " + radioButton1.Text, "Difficulty");

            }
            if (radioButton2.Checked)
            {
                // This will play a sound when the button is clicked.
                System.Media.SoundPlayer playermedium = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\medrisk.wav");
                playermedium.Play();

                // This will show the user that the difficulty has been set to Medium.
                MessageBox.Show("Your new difficulty will be: " + radioButton2.Text, "Difficulty");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           if (!radioButton3.Checked)
            {
                // Do nothing.
            }
           if (radioButton3.Checked)
            {
                // This will play a sound when the button is clicked.
                System.Media.SoundPlayer playerhard = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\Hard.wav");
                playerhard.Play();
                MessageBox.Show("The new difficulty will be: " + radioButton3.Text, "Difficulty");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This will show a timer for when the game is started.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This will give the score.
            label3.Text = "0";
            
            if (timer1.Enabled == true)
            {
                label3.Text = "100000000";
            }

            if (!radioButton1.Checked || radioButton2.Checked || !radioButton3.Checked)
            {
                MessageBox.Show("Select a difficulty!");
                timer1.Stop();
                label3.Text = "100000000";
            }

            else if (timer1.Enabled == false)
            {
                label3.Text = "0";
            }
         }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button74_Click(object sender, EventArgs e)
        {
            // This will save the players stats and info

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // This is for playing amything inside of the media player.
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            listBox1.Items.Clear();
        }
    }
}