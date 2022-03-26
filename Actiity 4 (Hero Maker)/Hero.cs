using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actiity_4__Hero_Maker_
{
    public class Hero :IComparable
    {
        public Hero(string name, bool[] specialAbilities, List<string> officeLocations, string preferredTransport, int speed, int stamina, int strength, DateTime birthday, DateTime superPowerDiscoveryDate, DateTime fatefulDay, decimal yearsExperience, string capeColor, int darkSidePropensity, string portrait)
        {
            Name = name;
            SpecialAbilities = specialAbilities;
            OfficeLocations = officeLocations;
            PreferredTransport = preferredTransport;
            Speed = speed;
            Stamina = stamina;
            Strength = strength;
            Birthday = birthday;
            SuperPowerDiscoveryDate = superPowerDiscoveryDate;
            FatefulDay = fatefulDay;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            DarkSidePropensity = darkSidePropensity;
            Portrait = portrait;
        }

        public String Name { get; set; }
        public bool [] SpecialAbilities { get; set; }

        public List<String> OfficeLocations { get; set; }

        public string PreferredTransport { get; set; }

        public int Speed { get; set; }

        public int Stamina { get; set; }

        public int Strength { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime SuperPowerDiscoveryDate { get; set; }

        public DateTime FatefulDay { get; set; }

        public decimal YearsExperience { get; set; }

        public String CapeColor { get; set; }

        public int DarkSidePropensity { get; set; }

        public String Portrait { get; set; }

        public int CompareTo(object obj)
        {
            Hero other = (Hero)obj;
            return Name.CompareTo(other.Name);
        }

        override public string ToString()
        {

            string status_message = "";
            
            // Will get the hero's name
            status_message += "Name: " + this.Name;


             status_message += "\r\n \r\nYou have selected the following abilities: ";

            if (this.SpecialAbilities[0])
                status_message += "Super Strength | ";
            if (this.SpecialAbilities[1])
                status_message += "Extreme Luck | ";
            if (SpecialAbilities[2])
                status_message += "Fly | ";
            if (this.SpecialAbilities[3])
                status_message += "Force Field | ";
            if (this.SpecialAbilities[4])
                status_message += "X-Ray | ";
            if (this.SpecialAbilities[5])
                status_message += "Explosive Fists |  ";
            if (this.SpecialAbilities[6])
                status_message += "Invisibility |  ";
            if (this.SpecialAbilities[7])
                status_message += "Insect Control | ";
            if (this.SpecialAbilities[8])
                status_message += "Absorb Energy | ";
            if (this.SpecialAbilities[9])
                status_message += "Water Breathing | ";
            if (this.SpecialAbilities[10])
                status_message += "Telepathy | ";
            if (this.SpecialAbilities[11])
                status_message += "Time Changer | ";



            status_message += "\r\n\r\nThe hero works in these cities: ";
            foreach (String city in this.OfficeLocations)
            {
                status_message += city + " | " ;
            }


            status_message += "\r\n\r\nYour hero's choice of travel is by: " + this.PreferredTransport;
  
            status_message += "\r\n \r\nYour hero's stats are Speed: " + this.Speed + " | " + " Stamina: " + this.Stamina + " | " + " Strength: " + this.Strength + " | " + "\r\n \r\n";


            // Will show status message for dates

            status_message += "Your hero's birthday is on: " + this.Birthday + "\r\n \r\n";

            status_message += "Your hero discovered their super powers on: " + this.SuperPowerDiscoveryDate + "\r\n \r\n";

            status_message += "Your hero's fateful day is on: " + this.FatefulDay + "\r\n\r\n";

            // Tells the years of experience
            status_message += "Your hero has " + this.YearsExperience + " of experience!\r\n \r\n";

            status_message += "The cape color for your hero is: " + this.CapeColor.ToString() + "\r\n\r\n";

            status_message += "Your hero's dark side probability is: " + this.DarkSidePropensity + "\r\n \r\n";

            status_message += "The picture of your hero is: " + this.Portrait;



            return status_message;
        }
    }
}
