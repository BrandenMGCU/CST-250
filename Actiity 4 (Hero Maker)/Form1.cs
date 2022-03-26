using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actiity_4__Hero_Maker_
{
    public partial class Form1 : Form
    {
        string picture_of_hero = "";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This will be the text box for the super hero's name. 


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This will be the container for all the checkbox special abilities groupbox.




        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // This will contain the Date Picker Group Box. 


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // This is the group box for the office locations selector.
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            // This is the group box for the Speed, Strength and Stamina.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will be the button for creating the super hero!


            // Hero's name
            string heroName = txt_name.Text;

            // This 2D Array will hold all the checkboxes inside of the special abilities tab
            bool[] abilities = { false, false, false, false, false, false, false, false, false, false, false, false };

            //This will set each checkbox inside of the sa tab
            abilities[0] = chk_SuperStrength.Checked;
            abilities[1] = chk_ExtremeLuck.Checked;
            abilities[2] = chk_Fly.Checked;
            abilities[3] = chk_ForceField.Checked;
            abilities[4] = chk_XRay.Checked;
            abilities[5] = chk_ExplosiveFists.Checked;
            abilities[6] = chk_Invisibility.Checked;
            abilities[7] = chk_InsectControl.Checked;
            abilities[8] = chk_AbsorbEnergy.Checked;
            abilities[9] = chk_WaterBreathing.Checked;
            abilities[10] = chk_Telepathy.Checked;
            abilities[11] = chk_TimeChanger.Checked;

            string status_message = "Your super hero's name is: " + txt_name.Text + "\n" + "\n" + "You have selected the following abilities: ";

            if (abilities[0])
                status_message += "Super Strength | ";
            if (abilities[1])
                status_message += "Extreme Luck | ";
            if (abilities[2])
                status_message += "Fly | ";
            if (abilities[3])
                status_message += "Force Field | ";
            if (abilities[4])
                status_message += "X-Ray | ";
            if (abilities[5])
                status_message += "Explosive Fists |  ";
            if (abilities[6])
                status_message += "Invisibility |  ";
            if (abilities[7])
                status_message += "Insect Control | ";
            if (abilities[8])
                status_message += "Absorb Energy | ";
            if (abilities[9])
                status_message += "Water Breathing | ";
            if (abilities[10])
                status_message += "Telepathy | ";
            if (abilities[11])
                status_message += "Time Changer | ";

            int speed = scroll_speed.Value;
            int stamina = scroll_stamina.Value;
            int strength = scroll_strength.Value;
            if (speed + stamina + strength > 100)
            {
                // Told the console to beep when this error occurs.
                Console.Beep();

                // Show the user that they cannot have more than 100 points total for their superhero.
               
                MessageBox.Show("You can't have more than 100 total points for your hero's strength, speed and stamina!", "We Have A Problem!");

                // Then the program will reset the super hero's points back to 0.
                lbl_speed.Text = "0";
                scroll_speed.Value = scroll_speed.Minimum;
                lbl_stamina.Text = "0";
                scroll_stamina.Value = scroll_stamina.Minimum;
                lbl_strength.Text = "0";
                scroll_strength.Value = scroll_strength.Minimum;

                return;
            }

            // This will be for the cities 

            // This will contain the list of cities
            List<String> cities = new List<string>();

            // Add the selected items to the cities list.
           
            
            foreach (String s in lst_cities.SelectedItems)
            {
                cities.Add(s);
            }

            // For the cities
            status_message += "\n \n The hero works in these cities: " ;

            // Print the cities selected by the user
            foreach (String city in cities)
            {
                status_message += city + ", ";
            }



            //Date and Time of Birthday, Super Power and Fate
            DateTime birthday = date_birthday.Value;
            DateTime SuperpowerDiscovery = date_SuperPowerDiscovery.Value;
            DateTime FatefulDay = date_FatefulDay.Value;

            // Tells the years of experience
            decimal years_experience = num_years_experience.Value;

            //Dark Side
            int dark_side = 0;
            dark_side = trk_dark_side.Value;
            

            // Use a single string since only one mode can be the preferred transport.
            string preferred_transport = null;

            if (rdo_jetpack.Checked)
                preferred_transport = "Jet Pack";
            if (rdo_Landspeeder.Checked)
                preferred_transport = "Land Speeder";
            if (rdo_Teleport.Checked)
                preferred_transport = "Teleport";
            if (rdo_Batmobile.Checked)
                preferred_transport = "Batmobile";


            status_message += "\n \n Your hero's selected method of transportation is: " + preferred_transport;

            status_message += "\n \n Your hero's stats are Speed: " + speed + " | " + " Stamina: " + stamina + " | " + " Strength: " + strength + " | " + "\n \n";


            // Will show status message for dates

            status_message += " Your hero's birthday is on: " + birthday + "\n \n"; 

            status_message += " Your hero discovered their super powers on: " + SuperpowerDiscovery + "\n \n";

            status_message += " Your hero's fateful day is on: " + FatefulDay + "\n \n";

            // Tells the years of experience
            status_message += " Your hero has " + years_experience + " of experience! + \n \n";

            status_message += "The cape color for your hero is: " + pic_cape_color.BackColor.ToString() + "\n \n";

            status_message += "Your hero's dark side probability is: " + dark_side + "\n \n";

            status_message += "The picture of your hero is: " + picture_of_hero;


            // Make a new hero
            Hero hero = new Hero(heroName, abilities, cities, preferred_transport, speed, stamina, strength, birthday, SuperpowerDiscovery, FatefulDay, years_experience, pic_cape_color.BackColor.ToString(), dark_side, picture_of_hero);

            HeroList.hallOfFame.Add(hero);
            

            MessageBox.Show(status_message);
            MessageBox.Show("You have made: " + HeroList.hallOfFame.Count() + " different heros!");

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void scroll_speed_Scroll(object sender, ScrollEventArgs e)
        {
            // This is the speed scroll bar

            lbl_speed.Text = scroll_speed.Value.ToString();
            if (scroll_speed.Value > 80)
            {
                scroll_stamina.Value = 10;
                scroll_strength.Value = 10;
            }
            if (scroll_speed.Value > 70)
            {
                scroll_stamina.Value = 15;
                scroll_strength.Value = 15;
            }

            if (scroll_speed.Value > 60)
            {
                scroll_stamina.Value = 20;
                scroll_strength.Value = 20;
            }
            if (scroll_speed.Value > 50)
            {
                scroll_stamina.Value = 25;
                scroll_strength.Value = 25;
            }
        }

    private void scroll_stamina_Scroll(object sender, ScrollEventArgs e)
        {
            // This is the stamina scroll bar

            lbl_stamina.Text = scroll_stamina.Value.ToString();
        }

        private void scroll_strength_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_strength.Text = scroll_strength.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // This will allow the user to change the picture box color

            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pic_cape_color.BackColor = colorPicker.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_dark_side.Text = trk_dark_side.Value.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // open a file and set the picture 

            OpenFileDialog portraitPicker = new OpenFileDialog();
            if (portraitPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(portraitPicker.FileName);

                picture_of_hero = portraitPicker.FileName;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.StartPosition = FormStartPosition.Manual;
            NewForm.Location = this.Location;

            NewForm.Show();
            this.Dispose(false);
        }
    }
}
