using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        // Music/Sound player
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        // Constants
        const int MAX_ANIMALS = 15;
        const int MIN_ANIMALS = 2;

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
                        Animal a = new Animal(this, interval, speed);

                        a.Left = startX;
                        a.Top = startY;
                        a.Width = 50;
                        a.Height = 50;
                        a.Text = i.ToString();
                        a.SizeMode = PictureBoxSizeMode.StretchImage;

                        //// Finish this!!! -- Pictures


                        this.Controls.Add(a);
                        startY += 60;
                        animalList.Add(a);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (animalList.Count == 0) // if animals were not yet generated
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text = "No " + animalType.ToLower() + "at the starting line";
            }
            else // if animals were generated
            {
                lblMessages.ForeColor = Color.Black;
                lblMessages.Text = "Let the race begin!";

                // play Carnival of the Animals track based on selected animal
                try
                {
                    switch (animalType)
                    {
                        case "Lions":
                            player.SoundLocation = @"C:\\Users\\Owner\\Documents\\Programming_Files\\C#\\AnimalCarnivalRaces\\Songs\\LionsRoyalMarch.wav";
                            break;
                        case "Hens & Roosters":
                            player.SoundLocation = @"C:\\Users\\Owner\\Documents\\Programming_Files\\C#\\AnimalCarnivalRaces\\Songs\\Hens&Roosters.wav";
                            break;
                        case "Elephants":
                        default:
                            player.SoundLocation = @"C:\Users\Owner\Documents\Programming_Files\C#\AnimalCarnivalRaces\Songs\TheElephant.wav";
                            break;
                    }
                    player.Play(); // Play the selected track
                }
                catch (FileNotFoundException ex) // catch any file not found errors
                {
                    MessageBox.Show($"File not found! {ex.Message}", "FileNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // catch any remaining errors
                {
                    MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Animal animal in animalList)
                {
                    animal.IsStarted = true; // start race
                }
            }
        }

        private void btnShowWinners_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Animal.aResult, animalType + " Race Results", MessageBoxButtons.OK);
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            Animal.aResult = "";
            GameForm newRace = new GameForm();
            newRace.Show();
        }

        private void btnEndRace_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }

        private void txtNumberOfAnimals_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtNumberOfAnimals.Text;
            int parsedint;
            bool isInteger = int.TryParse(inputText, out parsedint);
            if (!isInteger)
            {
                txtNumberOfAnimals.BackColor = Color.FromArgb(248, 112, 80);
            }
            else
            {
                txtNumberOfAnimals.BackColor = Color.White;
            }
        }
    }
}
