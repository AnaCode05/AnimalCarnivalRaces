namespace AnimalCarnivalRaces
{
    partial class MenuForm
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.Label lblTitleMenu;
            this.btnElephants = new System.Windows.Forms.Button();
            this.btnLions = new System.Windows.Forms.Button();
            this.btnHensRoosters = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitleMenu = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            exitToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(52, 28);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTitleMenu
            // 
            lblTitleMenu.AutoSize = true;
            lblTitleMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lblTitleMenu.Location = new System.Drawing.Point(177, 56);
            lblTitleMenu.Name = "lblTitleMenu";
            lblTitleMenu.Size = new System.Drawing.Size(447, 45);
            lblTitleMenu.TabIndex = 1;
            lblTitleMenu.Text = "Carnival of the Animals Races";
            // 
            // btnElephants
            // 
            this.btnElephants.BackColor = System.Drawing.Color.Gainsboro;
            this.btnElephants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElephants.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElephants.ForeColor = System.Drawing.Color.Black;
            this.btnElephants.Location = new System.Drawing.Point(521, 193);
            this.btnElephants.Name = "btnElephants";
            this.btnElephants.Size = new System.Drawing.Size(140, 120);
            this.btnElephants.TabIndex = 2;
            this.btnElephants.Text = "The Elephant";
            this.btnElephants.UseVisualStyleBackColor = false;
            // 
            // btnLions
            // 
            this.btnLions.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLions.ForeColor = System.Drawing.Color.Black;
            this.btnLions.Location = new System.Drawing.Point(139, 193);
            this.btnLions.Name = "btnLions";
            this.btnLions.Size = new System.Drawing.Size(140, 120);
            this.btnLions.TabIndex = 3;
            this.btnLions.Text = "Royal March of the Lion";
            this.btnLions.UseVisualStyleBackColor = false;
            this.btnLions.Click += new System.EventHandler(this.btnLions_Click);
            // 
            // btnHensRoosters
            // 
            this.btnHensRoosters.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHensRoosters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHensRoosters.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHensRoosters.ForeColor = System.Drawing.Color.Black;
            this.btnHensRoosters.Location = new System.Drawing.Point(330, 193);
            this.btnHensRoosters.Name = "btnHensRoosters";
            this.btnHensRoosters.Size = new System.Drawing.Size(140, 120);
            this.btnHensRoosters.TabIndex = 4;
            this.btnHensRoosters.Text = "Hens and Roosters";
            this.btnHensRoosters.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHensRoosters);
            this.Controls.Add(this.btnLions);
            this.Controls.Add(this.btnElephants);
            this.Controls.Add(lblTitleMenu);
            this.Controls.Add(menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElephants;
        private System.Windows.Forms.Button btnLions;
        private System.Windows.Forms.Button btnHensRoosters;
    }
}

