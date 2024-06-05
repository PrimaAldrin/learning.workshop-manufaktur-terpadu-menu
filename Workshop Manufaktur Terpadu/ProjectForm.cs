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
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = serialPortComboBox.Text;
            serialPort1.Open();

            // Please change this later
            ProjectForm.ActiveForm.Text = serialPort1.PortName + " is connected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
