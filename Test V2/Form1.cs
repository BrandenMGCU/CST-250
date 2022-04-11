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
        string[] files, paths;

        public Form1()
        {
            InitializeComponent();
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
            // This will be the foundation for the user's difficulty

            
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // This will hold all the minesweeper buttons for the game

            foreach (Button button in flowLayoutPanel1.Controls)
            {
                button.ForeColor = Color.Empty;
                button.Text = "?";
                if ((Control.MouseButtons & MouseButtons.Left) != 0)
                {
                    System.Media.SoundPlayer playereasy = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\coin.wav");
                    playereasy.Play();

                    MessageBox.Show("This box has been checked!");
                    Controls.Remove(button);
                }
            } 
        }

        private void Bombs()
        {
            foreach (Button button in flowLayoutPanel1.Controls)
            {
                Random random = new Random();
                flowLayoutPanel1.Controls.Add(button);
                button.BackColor = Color.Red;
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // This is for playing amything inside of the media player.
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            listBox1.Items.Clear();
        }
    }
}