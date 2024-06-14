namespace Workshop_Manufaktur_Terpadu
{
    partial class MainForm
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
            this.about_button = new System.Windows.Forms.Button();
            this.project_button = new System.Windows.Forms.Button();
            this.truckGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(12, 12);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(117, 56);
            this.about_button.TabIndex = 0;
            this.about_button.Text = "About";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // project_button
            // 
            this.project_button.Location = new System.Drawing.Point(258, 12);
            this.project_button.Name = "project_button";
            this.project_button.Size = new System.Drawing.Size(117, 56);
            this.project_button.TabIndex = 1;
            this.project_button.Text = "Final Project";
            this.project_button.UseVisualStyleBackColor = true;
            this.project_button.Click += new System.EventHandler(this.project_button_Click);
            // 
            // truckGame
            // 
            this.truckGame.Location = new System.Drawing.Point(381, 12);
            this.truckGame.Name = "truckGame";
            this.truckGame.Size = new System.Drawing.Size(117, 56);
            this.truckGame.TabIndex = 2;
            this.truckGame.Text = "Playground";
            this.truckGame.UseVisualStyleBackColor = true;
            this.truckGame.Click += new System.EventHandler(this.truckGame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "WTAM[5][6][7][8]: Simple Serial Communication";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 78);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.truckGame);
            this.Controls.Add(this.project_button);
            this.Controls.Add(this.about_button);
            this.Name = "MainForm";
            this.Text = "Workshop Manufaktur Terpadu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button project_button;
        private System.Windows.Forms.Button truckGame;
        private System.Windows.Forms.Button button1;
    }
}

