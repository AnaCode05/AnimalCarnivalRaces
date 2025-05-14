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
    /// <summary>
    /// Form to hold a given animal race
    /// </summary>
    public partial class GameForm : Form
    {
        public string result; // instance result in form
        public static string fResult; // static result in form
        List<Animal> animalList = new List<Animal>();
        public string animalType = "";
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        const int MAX_ANIMALS = 15;

        public GameForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (animalList.Count > 0)
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text = $"{animalType} already generated";
            }
            else
            {
                lblMessages.Text = "";
                animalList.Clear();

                int startX = 10;
                int startY = 60;
                int numberOfAnimals;
                bool isInteger = int.TryParse(txtNumberOfAnimals.Text, out numberOfAnimals);
                if (!isInteger)
                {
                    lblMessages.ForeColor = Color.Red;
                    lblMessages.Text = $"Enter a valid number of {animalType.ToLower()}";
                }
                else if (numberOfAnimals > MAX_ANIMALS)
                {
                    lblMessages.ForeColor = Color.Red;
                    lblMessages.Text = $"There can only be {MAX_ANIMALS} {animalType.ToLower()} in a race";
                }
                else // Happy path - valid number inputted
                {
                    lblMessages.ForeColor = Color.Green;
                    lblMessages.Text = $"{animalType} ready!";

                    // Create random speed for each animal
                    Random random = new Random();
                    int minSpeed = 5;
                    int maxSpeed = 10;
                    switch (animalType)
                    {
                        case "Lions":
                            minSpeed = 5; 
                            maxSpeed = 10;
                            break;
                        case "Hens & Roosters":
                            minSpeed = 15;
                            maxSpeed = 20;
                            break;
                        case "Elephants":
                        default:
                            minSpeed = 2;
                            maxSpeed = 7;
                            break;
                    }

                    

                }

            }
        }
    }
}
