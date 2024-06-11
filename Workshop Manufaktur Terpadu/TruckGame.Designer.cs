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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.chkSensor = new System.Windows.Forms.CheckBox();
            this.sensor = new System.Windows.Forms.Panel();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 352);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(127, 86);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Kiri";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(145, 352);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(127, 86);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Kanan";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 50;
            // 
            // chkSensor
            // 
            this.chkSensor.AutoCheck = false;
            this.chkSensor.AutoSize = true;
            this.chkSensor.Location = new System.Drawing.Point(279, 352);
            this.chkSensor.Name = "chkSensor";
            this.chkSensor.Size = new System.Drawing.Size(59, 17);
            this.chkSensor.TabIndex = 3;
            this.chkSensor.Text = "Sensor";
            this.chkSensor.UseVisualStyleBackColor = true;
            // 
            // sensor
            // 
            this.sensor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sensor.Location = new System.Drawing.Point(347, 175);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(47, 45);
            this.sensor.TabIndex = 4;
            // 
            // picCar
            // 
            this.picCar.BackgroundImage = global::Workshop_Manufaktur_Terpadu.Properties.Resources.vecteezy_ai_generated_black_delivery_truck_on_transparent_background_359073991;
            this.picCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCar.Location = new System.Drawing.Point(42, 159);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(178, 61);
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // TruckGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sensor);
            this.Controls.Add(this.chkSensor);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.picCar);
            this.KeyPreview = true;
            this.Name = "TruckGame";
            this.Text = "TruckGame";
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.CheckBox chkSensor;
        private System.Windows.Forms.Panel sensor;
        private System.Windows.Forms.ListBox listBox1;
    }
}