using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Manufaktur_Terpadu
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
            {
                serialPortComboBox.Items.Add(portName);
            }

            // At the very start, the you have to fill the Port name to press button
            connect_button.Enabled = false;
            close_button.Enabled = false;
            plcOffTest_button.Enabled = false;
            plcOnTest_button.Enabled = false;
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = serialPortComboBox.Text;
                serialPort1.Open();
                message_toolStripStatusLabel.Text = serialPort1.PortName + " is connected";
            }

            catch(Exception ex)
            {
                message_toolStripStatusLabel.Text = "Error: " + ex.Message.ToString();
            }

            if (serialPort1.IsOpen)
            {
                connect_button.Enabled = false;
                close_button.Enabled = true;

                plcOffTest_button.Enabled = true;
                plcOnTest_button.Enabled = true;

                serialPortComboBox.Enabled = false;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            connect_button.Enabled = true;
            close_button.Enabled = false;
            plcOffTest_button.Enabled = false;
            plcOnTest_button.Enabled = false;

            serialPortComboBox.Enabled = true;

            message_toolStripStatusLabel.Text = serialPort1.PortName + " is closed";
        }

        private void plcOnTest_button_Click(object sender, EventArgs e)
        {
            serialPort1.Write("@00WR0100FFFF44*");
        }

        private void plcOffTest_button_Click(object sender, EventArgs e)
        {
            serialPort1.Write("@00WR0100000044*");
        }

        private void serialPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect_button.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
