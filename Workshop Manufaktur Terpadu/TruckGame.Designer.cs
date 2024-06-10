namespace Workshop_Manufaktur_Terpadu
{
    partial class TruckGame
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
            this.components = new System.ComponentModel.Container();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // carPictureBox
            // 
            this.carPictureBox.BackgroundImage = global::Workshop_Manufaktur_Terpadu.Properties.Resources.vecteezy_ai_generated_black_delivery_truck_on_transparent_background_35907399;
            this.carPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPictureBox.Location = new System.Drawing.Point(43, 255);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(178, 110);
            this.carPictureBox.TabIndex = 0;
            this.carPictureBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // TruckGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carPictureBox);
            this.Name = "TruckGame";
            this.Text = "TruckGame";
            this.Load += new System.EventHandler(this.TruckGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}