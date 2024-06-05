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
            this.close_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plcOffTest_button = new System.Windows.Forms.Button();
            this.plcOnTest_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.message_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.close_button);
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
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(6, 104);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(157, 46);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // serialPortComboBox
            // 
            this.serialPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortComboBox.FormattingEnabled = true;
            this.serialPortComboBox.Location = new System.Drawing.Point(75, 19);
            this.serialPortComboBox.Name = "serialPortComboBox";
            this.serialPortComboBox.Size = new System.Drawing.Size(88, 21);
            this.serialPortComboBox.TabIndex = 0;
            this.serialPortComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPortComboBox_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plcOffTest_button);
            this.groupBox2.Controls.Add(this.plcOnTest_button);
            this.groupBox2.Location = new System.Drawing.Point(187, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC Test";
            // 
            // plcOffTest_button
            // 
            this.plcOffTest_button.Location = new System.Drawing.Point(6, 91);
            this.plcOffTest_button.Name = "plcOffTest_button";
            this.plcOffTest_button.Size = new System.Drawing.Size(157, 59);
            this.plcOffTest_button.TabIndex = 1;
            this.plcOffTest_button.Text = "OFF";
            this.plcOffTest_button.UseVisualStyleBackColor = true;
            this.plcOffTest_button.Click += new System.EventHandler(this.plcOffTest_button_Click);
            // 
            // plcOnTest_button
            // 
            this.plcOnTest_button.Location = new System.Drawing.Point(6, 19);
            this.plcOnTest_button.Name = "plcOnTest_button";
            this.plcOnTest_button.Size = new System.Drawing.Size(157, 59);
            this.plcOnTest_button.TabIndex = 0;
            this.plcOnTest_button.Text = "ON";
            this.plcOnTest_button.UseVisualStyleBackColor = true;
            this.plcOnTest_button.Click += new System.EventHandler(this.plcOnTest_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // message_toolStripStatusLabel
            // 
            this.message_toolStripStatusLabel.Name = "message_toolStripStatusLabel";
            this.message_toolStripStatusLabel.Size = new System.Drawing.Size(53, 17);
            this.message_toolStripStatusLabel.Text = "Message";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 206);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectForm";
            this.Text = "Final Project: Truck\'s Gate Solution";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.Button close_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button plcOnTest_button;
        private System.Windows.Forms.Button plcOffTest_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel message_toolStripStatusLabel;
    }
}