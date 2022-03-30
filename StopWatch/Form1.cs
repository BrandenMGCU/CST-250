using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Branden\Downloads\Game_Sound.wav");
        string simplesound;

        // Want to keep count of the target button
        int counter = 0;

        // This will be the counter for the life's that the user has
        int life_counter = 0;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Start Button
            watch.Start();

            // Want to play a song when the game begins
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Branden\Downloads\Game_Sound.wav");
            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop Button
            watch.Stop();
            simpleSound.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reset Button
            watch.Reset();
            label2.Text = "Score";
            DataBindings.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = watch.Elapsed.ToString();

            if (random.Next(0, 10) < 5)
            {
                button4.Left = random.Next(0, this.Width / 2);
                button4.Top = random.Next(0, this.Height / 2);
                button4.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {


            button4.Visible = false;
            counter++; // This will keep count of how many times it has been clicked
            label2.Text = counter.ToString();
            SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\Branden\Downloads\mario-coin-sound-effect.wav");
            simpleSound1.Play();

            // This will start the timer when the player click's on the Target Button
            watch.Start();
        } 
    }
}
