namespace Workshop_Manufaktur_Terpadu
{
    partial class ProjectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plcOnTestButton = new System.Windows.Forms.Button();
            this.plcOffTestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.connect_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serialPortComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connectivity";
            // 
            // serialPortComboBox
            // 
            this.serialPortComboBox.FormattingEnabled = true;
            this.serialPortComboBox.Location = new System.Drawing.Point(75, 19);
            this.serialPortComboBox.Name = "serialPortComboBox";
            this.serialPortComboBox.Size = new System.Drawing.Size(88, 21);
            this.serialPortComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 52);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(157, 46);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plcOffTestButton);
            this.groupBox2.Controls.Add(this.plcOnTestButton);
            this.groupBox2.Location = new System.Drawing.Point(187, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC Test";
            // 
            // plcOnTestButton
            // 
            this.plcOnTestButton.Location = new System.Drawing.Point(6, 19);
            this.plcOnTestButton.Name = "plcOnTestButton";
            this.plcOnTestButton.Size = new System.Drawing.Size(157, 59);
            this.plcOnTestButton.TabIndex = 0;
            this.plcOnTestButton.Text = "ON";
            this.plcOnTestButton.UseVisualStyleBackColor = true;
            // 
            // plcOffTestButton
            // 
            this.plcOffTestButton.Location = new System.Drawing.Point(6, 91);
            this.plcOffTestButton.Name = "plcOffTestButton";
            this.plcOffTestButton.Size = new System.Drawing.Size(157, 59);
            this.plcOffTestButton.TabIndex = 1;
            this.plcOffTestButton.Text = "OFF";
            this.plcOffTestButton.UseVisualStyleBackColor = true;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectForm";
            this.Text = "Final Project: Truck\'s Gate Solution";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button plcOnTestButton;
        private System.Windows.Forms.Button plcOffTestButton;
    }
}