namespace AnimalCarnivalRaces
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessages = new System.Windows.Forms.Label();
            this.txtNumberOfAnimals = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowWinners = new System.Windows.Forms.Button();
            this.btnNewRace = new System.Windows.Forms.Button();
            this.pnlFinishLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMessages.Location = new System.Drawing.Point(21, 16);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(210, 25);
            this.lblMessages.TabIndex = 0;
            this.lblMessages.Text = "Enter number of animals:";
            // 
            // txtNumberOfAnimals
            // 
            this.txtNumberOfAnimals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberOfAnimals.Location = new System.Drawing.Point(372, 13);
            this.txtNumberOfAnimals.Name = "txtNumberOfAnimals";
            this.txtNumberOfAnimals.Size = new System.Drawing.Size(164, 31);
            this.txtNumberOfAnimals.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Black;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(606, 16);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 54);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Animals";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(606, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Race!";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnShowWinners
            // 
            this.btnShowWinners.BackColor = System.Drawing.Color.Black;
            this.btnShowWinners.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowWinners.ForeColor = System.Drawing.Color.White;
            this.btnShowWinners.Location = new System.Drawing.Point(750, 16);
            this.btnShowWinners.Name = "btnShowWinners";
            this.btnShowWinners.Size = new System.Drawing.Size(138, 116);
            this.btnShowWinners.TabIndex = 4;
            this.btnShowWinners.Text = "Show Winner List";
            this.btnShowWinners.UseVisualStyleBackColor = false;
            // 
            // btnNewRace
            // 
            this.btnNewRace.BackColor = System.Drawing.Color.Black;
            this.btnNewRace.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRace.ForeColor = System.Drawing.Color.White;
            this.btnNewRace.Location = new System.Drawing.Point(750, 309);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(138, 54);
            this.btnNewRace.TabIndex = 5;
            this.btnNewRace.Text = "New Race";
            this.btnNewRace.UseVisualStyleBackColor = false;
            // 
            // pnlFinishLine
            // 
            this.pnlFinishLine.BackColor = System.Drawing.Color.Red;
            this.pnlFinishLine.Location = new System.Drawing.Point(550, 62);
            this.pnlFinishLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFinishLine.Name = "pnlFinishLine";
            this.pnlFinishLine.Size = new System.Drawing.Size(27, 1249);
            this.pnlFinishLine.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 1324);
            this.Controls.Add(this.pnlFinishLine);
            this.Controls.Add(this.btnNewRace);
            this.Controls.Add(this.btnShowWinners);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumberOfAnimals);
            this.Controls.Add(this.lblMessages);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.TextBox txtNumberOfAnimals;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowWinners;
        private System.Windows.Forms.Button btnNewRace;
        public System.Windows.Forms.Panel pnlFinishLine;
    }
}