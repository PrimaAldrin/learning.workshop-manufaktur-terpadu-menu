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
        private int carSpeed = 5;
        private int roadWidth;

        private bool goLeft, goRight;

        public TruckGame()
        {
            InitializeComponent();
        }

        private void TruckGame_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            roadWidth = this.ClientSize.Width;

            if (goLeft && carPictureBox.Left > 0)
            {
                carPictureBox.Left -= carSpeed;
            }

            if (goRight && carPictureBox.Right < roadWidth)
            {
                carPictureBox.Left += carSpeed;
            }
        }

        private void TruckGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void TruckGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
