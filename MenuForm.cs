using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalCarnivalRaces
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the form and all components from the menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Creates a lion race form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLions_Click(object sender, EventArgs e)
        {
            GameForm lionRace = new GameForm();
            lionRace.animalType = "Lions";
            lionRace.Text = lionRace.animalType;
            lionRace.Show();

        }
        /// <summary>
        /// Creates a hen and rooster race form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHensRoosters_Click(object sender, EventArgs e)
        {
            GameForm henRoosterRace = new GameForm();
            henRoosterRace.animalType = "Hens & Roosters";
            henRoosterRace.Text = henRoosterRace.animalType;
            henRoosterRace.Show();

        }
        /// <summary>
        /// Creates an elephant race form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnElephants_Click(object sender, EventArgs e)
        {
            GameForm elephantRace = new GameForm();
            elephantRace.animalType = "Elephants";
            elephantRace.Text = elephantRace.animalType;
            elephantRace.Show();

        }
    }
}
