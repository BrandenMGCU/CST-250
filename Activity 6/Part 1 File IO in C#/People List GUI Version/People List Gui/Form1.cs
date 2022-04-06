using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_List_Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will add the information to the list
            listBox1.Items.Add("First Name: " + textBox1.Text + " Last Name: " + textBox2.Text + " URL Address: " + textBox3.Text);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\coin.wav");
            player.Play();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will hold the information from the user in the list box.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Save list to file

            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\Hard.wav");
                player.Play();

                MessageBox.Show("You must enter a First Name, Last Name and URL!");
                textBox1.BackColor = Color.LightGray;
                textBox2.BackColor = Color.LightGray;
                textBox3.BackColor = Color.LightGray;
                
            }
            if (textBox1.Text != string.Empty | textBox2.Text != string.Empty | textBox3.Text != string.Empty)
            { 
            var SaveToFile = new SaveFileDialog();
            SaveToFile.Filter = "Text (*.txt)|*.txt";
                if (SaveToFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (var sw = new StreamWriter(SaveToFile.FileName, false))
                        foreach (var item in listBox1.Items)
                            sw.Write(item.ToString() + Environment.NewLine);
                    MessageBox.Show("The file was saved successufully!", "FILE SAVING");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Load the file
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete an item from the listbox
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
