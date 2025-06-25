using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalCarnivalRaces
{
    /// <summary>
    /// Generic Animal class - all animals derive their actions and attributes from this. It inherits from and behaves like a PictureBox control.
    /// </summary>
    abstract class Animal : PictureBox
    {
        public static string aResult; // static result in Animal

        private Timer timer;
        private bool isFinished = false;
        private bool isStarted = false;
        private int interval = 100;
        private int displacement = 50;

        private GameForm ownerForm; // for to hold the game (race)

        public bool IsFinished
        {
            get => isFinished;
            set
            {
                isFinished = value;

                if (isFinished)
                {
                    timer.Enabled = false;
                }
            }
        }
        public bool IsStarted
        {
            get => isStarted;
            set
            {
                isStarted = value;
                if (isStarted)
                {
                    timer.Enabled = true;
                }
            }
        }

        // Animal Constructor
        public Animal(GameForm ownerForm, int interval, int displacement)
        {
            this.ownerForm = ownerForm;

            timer = new Timer();
            this.interval = interval;
            this.displacement = displacement;
            this.BorderStyle = BorderStyle.FixedSingle;

            timer.Interval = this.interval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Left += displacement;
            if (this.Right >= ownerForm.pnlFinishLine.Left)
            {
                IsFinished = true;
                ownerForm.result += this.Text + "\n";
                GameForm.fResult += this.Text + "\n";
                int intResult = -1;
                bool isInteger = int.TryParse(this.Text, out intResult);
                if (isInteger)
                {
                    intResult++;
                }
                aResult += "Animal " + intResult + "\n";
            }
        }
    }
}
