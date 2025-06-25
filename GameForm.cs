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
        const int MIN_ANIMALS = 2;

        public GameForm()
        {
            InitializeComponent();
            this.Text = animalType + " Race";
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
                else if (numberOfAnimals < MIN_ANIMALS)
                {
                    lblMessages.ForeColor = Color.Red;
                    lblMessages.Text = $"There must be at least {MIN_ANIMALS} {animalType.ToLower()} in a race";
                }
                else // Happy path - valid number inputted
                {
                    lblMessages.ForeColor = Color.Green;
                    lblMessages.Text = $"{animalType} ready!";

                    // Create random speed for each animal
                    Random random = new Random();
                    int minSpeed;
                    int maxSpeed;
                    switch (animalType)
                    {
                        case "Lions":
                            minSpeed = 5; 
                            maxSpeed = 15;
                            break;
                        case "Hens & Roosters":
                            minSpeed = 17;
                            maxSpeed = 25;
                            break;
                        case "Elephants":
                        default:
                            minSpeed = 2;
                            maxSpeed = 7;
                            break;
                    }

                    int minInterval = 200;
                    int maxInterval = 500;

                    for (int i = 0; i < numberOfAnimals; i++)
                    {
                        int speed = random.Next(minSpeed, maxSpeed);
                        int interval = random.Next(minInterval, maxInterval);
                        //Animal a = new Animal(this, interval, speed);
                    }
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnShowWinners_Click(object sender, EventArgs e)
        {

        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {

        }
        private void btnEndRace_Click(object sender, EventArgs e)
        {

        }
    }
}
