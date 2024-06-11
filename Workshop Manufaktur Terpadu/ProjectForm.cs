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
        bool enableConnectPort = false;
        bool enableConnectBaud = false;

        bool ultTempSensorPreviouslyDetected = false;
        bool topLSSensorPreviouslyDetected = false;
        bool bottomLSSensorPreviouslyDetected = false;

        private int carPositionX;
        private bool moveLeft;
        private bool moveRight;
        bool doorOpen;
        int doorSpeed = 1;

        public ProjectForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Set initial position of the car
            carPositionX = picCar.Location.X;

            // Initialize timer
            moveTimer.Interval = 50; // Set interval to 50 milliseconds
            moveTimer.Tick += MoveTimer_Tick;

            openDoorTimer.Interval = 50; // Set interval for door movement
            openDoorTimer.Tick += OpenDoorTimer_Tick;

            closeDoorTimer.Interval = 50; // Set interval for door movement
            closeDoorTimer.Tick += CloseDoorTimer_Tick;

            // Initialize button event handlers
            BtnLeft.MouseDown += BtnLeft_MouseDown;
            BtnLeft.MouseUp += BtnLeft_MouseUp;
            BtnRight.MouseDown += BtnRight_MouseDown;
            BtnRight.MouseUp += BtnRight_MouseUp;
        }

        private void InitializePLC()
        {
            // baru connect langsung cek status pintu
            // cek bottom dan top ls
            serialPort1.WriteLine("@00RR0000002042*");
            serialPort1.WriteLine("@00RR0000004044*");

            // fix error saja
            serialPort1.WriteLine("@00RR0000000848*");
            serialPort1.WriteLine("@00RR0001000445*");
        }

        private void BtnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            moveLeft = true;
            moveTimer.Start();
        }

        private void BtnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeft = false;
            if (!moveRight)
            {
                moveTimer.Stop();
            }
        }

        private void BtnRight_MouseDown(object sender, MouseEventArgs e)
        {
            moveRight = true;
            moveTimer.Start();
        }

        private void BtnRight_MouseUp(object sender, MouseEventArgs e)
        {
            moveRight = false;
            if (!moveLeft)
            {
                moveTimer.Stop();
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft)
            {
                MoveCar(-7); // Move car to the left by 10 pixels
            }
            if (moveRight)
            {
                MoveCar(7); // Move car to the right by 10 pixels
            }

            CheckUltraSensor();
        }

        private void MoveCar(int deltaX)
        {
            carPositionX += deltaX;
            // Ensure car stays within form boundaries
            if (carPositionX < 0)
            {
                carPositionX = 0;
            }
            if (carPositionX + picCar.Width > this.ClientSize.Width)
            {
                carPositionX = this.ClientSize.Width - picCar.Width;
            }
            // Update car position
            picCar.Location = new Point(carPositionX, picCar.Location.Y);
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
                serialPort1.BaudRate = baudrateComboBox.SelectedIndex;
                serialPort1.NewLine = "\r\n";
                serialPort1.Open();
                serialPort1.BaudRate = Int32.Parse(baudrateComboBox.Text);
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
                baudrateComboBox.Enabled = false;
                InitializePLC();
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
            baudrateComboBox.Enabled = true;

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
            enableConnectPort = true;
            if(enableConnectBaud == true)
            {
                connect_button.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void baudrateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableConnectBaud = true;
            if(enableConnectPort == true)
            {
                connect_button.Enabled = true;
            }
        }

        private void CheckUltraSensor()
        {
            // Check if the car is in front of the sensor
            Rectangle carRect = new Rectangle(picCar.Location, picCar.Size);
            Rectangle sensorRect = new Rectangle(ultSensor.Location, ultSensor.Size);

            bool sensorDetected = carRect.IntersectsWith(sensorRect);

            if (sensorDetected && !ultTempSensorPreviouslyDetected)
            {
                // Nyalakan US dan Temp bersamaan
                serialPort1.WriteLine("@00WR0000000C36*");
                serialPort1.WriteLine("@00RR0000000848*");

                // Cek motor up
                serialPort1.WriteLine("@00RR0001000445*");
            }
            else if (!sensorDetected && ultTempSensorPreviouslyDetected)
            {
                serialPort1.WriteLine("@00WR0000000045*");
                serialPort1.WriteLine("@00RR0000000848*");
            }
            ultTempSensorPreviouslyDetected = sensorDetected;
        }
        private void CheckTempSensor()
        {
            // Check if the car is in front of the sensor
            Rectangle carRect = new Rectangle(picCar.Location, picCar.Size);
            Rectangle sensorRect = new Rectangle(tempSensor.Location, tempSensor.Size);
        }

        private void CheckTopLSSensor()
        {
            Rectangle doorRect = new Rectangle(btnDoor.Location, btnDoor.Size);
            Rectangle sensorRect = new Rectangle(topLSSensor.Location, topLSSensor.Size);

            bool sensorDetected = doorRect.IntersectsWith(sensorRect);

            if(sensorDetected && !topLSSensorPreviouslyDetected)
            {
                serialPort1.WriteLine("");
            }
            else
            {
                serialPort1.WriteLine("");
            }
        }

        private void CheckBottomLSSensor()
        {
            Rectangle doorRect = new Rectangle(btnDoor.Location, btnDoor.Size);
            Rectangle sensorRect = new Rectangle(bottomLSSensor.Location, bottomLSSensor.Size);

            bool sensorDetected = doorRect.IntersectsWith(sensorRect);

            if (sensorDetected && !bottomLSSensorPreviouslyDetected)
            {
                
            }
            else
            {
                checkBottom.Checked = false;
            }
        }

        private void OpenDoorTimer_Tick(object sender, EventArgs e)
        {
            if (btnDoor.Location.Y > 0)
            {
                btnDoor.Location = new Point(btnDoor.Location.X, btnDoor.Location.Y - doorSpeed);
            }
            else
            {
                doorOpen = true;
                openDoorTimer.Stop();
            }

            CheckTopLSSensor();
            CheckBottomLSSensor();
        }

        private void CloseDoorTimer_Tick(object sender, EventArgs e)
        {
            if (btnDoor.Location.Y < 220 - btnDoor.Height)
            {
                btnDoor.Location = new Point(btnDoor.Location.X, btnDoor.Location.Y + doorSpeed);
            }
            else
            {
                doorOpen = false;
                closeDoorTimer.Stop();
            }

            CheckTopLSSensor();
            CheckBottomLSSensor();
        }

        private void btnStartProject_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("@00WR0000000144*");
            serialPort1.WriteLine("@00WR0000000045*");

            serialPort1.WriteLine("@00RR0200000143*");

            // Read the ON/OFF status from PLC
            // Read request: @00RR0200000143*
            // ON = <CR>@00RR00000141*; OFF = @00RR00000040*

        }

        private void btnStopProject_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("@00WR0000000247*");
            serialPort1.WriteLine("@00WR0000000045*");

            serialPort1.WriteLine("@00RR0200000143*");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String receivedMsg = serialPort1.ReadExisting();
            Tampilkan(receivedMsg);
        }

        private delegate void TampilkanDelegate(object item);

        private void Tampilkan(object item)
        {
            if (InvokeRequired)
            {
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), item);
            }
            else
            {
                // -------------------------------Change reading status here

                // Project Status
                if (item.ToString().Contains("@00RR00000141*"))
                {
                    projectStatus.Checked = true;
                }
                if (item.ToString().Contains("@00RR00000040*"))
                {
                    projectStatus.Checked = false;
                }

                // Ultrasonic and temperature status
                if (item.ToString().Contains("@00RR00000C000000000000000000000000000033*") || 
                    item.ToString().Contains("@00RR00000C000400000000000000000000000037*"))
                {
                    checkTemptSensor.Checked = true;
                    checkUltSensor.Checked = true;
                }

                if (item.ToString().Contains("@00RR000000000000000000000000000000000040*") ||
                    item.ToString().Contains("@00RR000000000400000000000000000000000044*"))
                {
                    checkTemptSensor.Checked = false;
                    checkUltSensor.Checked = false;
                }

                // Motor up status
                if (item.ToString().Contains("@00RR00000400000000000044*"))
                {
                    checkGateUp.Checked = true;
                    //openDoorTimer.Start();
                }

                if (item.ToString().Contains("@00RR00000000000000000040*"))
                {
                    checkGateUp.Checked = false;
                }

                // LS top status
                if (item.ToString().Contains("@00RR0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000040") ||
                    item.ToString().Contains("000000000000000000000000000000000000000000*"))
                {
                    checkTop.Checked = true;
                }

                // LS bottom Status
                if (item.ToString().Contains("@00RR000000000000000000000000000000000000000000000000000000000000000000000000000000000040*"))
                {
                    checkBottom.Checked = true;
                }

                listBox1.Items.Add(item);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                if(item.ToString().Length == 14)
                {
                    splitData(item);
                }
            }
        }

        private void splitData(object item)
        {
            string[] data = new string[6];

            data[0] = item.ToString().Substring(0, 1);
            data[1] = item.ToString().Substring(1, 2);
            data[2] = item.ToString().Substring(3, 2);
            data[3] = item.ToString().Substring(5, 5);
            data[4] = item.ToString().Substring(10, 1);
            data[5] = item.ToString().Substring(11, 3);

            if (Int32.Parse(data[4]) == 1)
            {
                projectStatus.Checked = true;
            }
            else
            {
                projectStatus.Checked = false;
            }
        }
    }
}
