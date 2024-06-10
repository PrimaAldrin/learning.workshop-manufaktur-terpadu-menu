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
    public partial class TruckGame : Form
    {
        private int carPositionX;
        private bool moveLeft;
        private bool moveRight;

        public TruckGame()
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

            // Initialize button event handlers
            btnLeft.MouseDown += BtnLeft_MouseDown;
            btnLeft.MouseUp += BtnLeft_MouseUp;
            btnRight.MouseDown += BtnRight_MouseDown;
            btnRight.MouseUp += BtnRight_MouseUp;
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
                MoveCar(-10); // Move car to the left by 10 pixels
            }
            if (moveRight)
            {
                MoveCar(10); // Move car to the right by 10 pixels
            }

            CheckSensor();
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

        private void CheckSensor()
        {
            // Check if the car is in front of the sensor
            Rectangle carRect = new Rectangle(picCar.Location, picCar.Size);
            Rectangle sensorRect = new Rectangle(sensor.Location, sensor.Size);

            if (carRect.IntersectsWith(sensorRect))
            {
                chkSensor.Checked = true;
            }
            else
            {
                chkSensor.Checked = false;
            }
        }
    }
}
