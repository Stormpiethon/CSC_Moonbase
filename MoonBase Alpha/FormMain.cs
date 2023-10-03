using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoonBase_Alpha.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MoonBase_Alpha
{
    public partial class FormMain : Form
    {
        // Variable to hold an integer value associated with the user's positon/the form being viewed
        int player_position;

        public FormMain()
        {
            InitializeComponent();
            player_position = 0;
        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.AI_Core_MoonBase;
            this.Label_1.Text = "AI Core";
            this.textBox1.Text = "The AI core that overseas all of the automated systems of Icarus Landing. Access to " +
                "the core requires the highest security clearance of all the personnel on site. There are rumors about " +
                "sentience that has developed naturally within the core's algorithms.";
            player_position = 1;
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Laboratory_MoonBase;
            this.Label_1.Text = "Research Laboratory";
            this.textBox1.Text = "The Icarus Landing research and development laboratories are used to conduct experiments " +
                "that are unique to the Lunar environment's conditions, too dangerous to be done on Earth, or so highly " +
                "classified that the off-planet location serves the security demands of the Corporation.";
            player_position = 2;
        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Cafeteria_MoonBase;
            this.Label_1.Text = "Base Cafeteria";
            this.textBox1.Text = "The Icarus Landing cafeteria is equipped with some of the most advanced food processing and " +
                "preperation systems of all humanity. It was deemed appropriate to make sure that the dietary needs of all of " +
                "those who are employed at Icarus Landing were met.";
            player_position = 3;
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Movie_Theatre_MoonBase;
            this.Label_1.Text = "Theatre";
            this.textBox1.Text = "The state of the art theatre at Icarus Landing is on of the primary centers of entertainment " +
                "for staff. The theatre is also used for large scale breifings and announcements from management. Some of the " +
                "staff managed to bring some video game consoles with them to the Lunar base, and sometimes use them in the theatre.";
            player_position = 4;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Moon_base_image;
            this.Label_1.Text = "Overview";
            this.textBox1.Text = "The Icarus Landing Moon Base was founded as a mining colony and travel hub for asteroid mining vessels. " + 
                "The colony has roughly 200 people living in it at any given time. 5 children have been born on the moon base, are known " +
                "as Lunartians, and have citizenship in multiple countries at birth.";
            player_position = 0;
        }       
    }
}
