using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingBar
{
    public partial class FormMenu : Form
    {
        int move;
        int movX;
        int movY;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            timerCheckClosing.Start();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerCheckClosing_Tick(object sender, EventArgs e)
        {
            if (KeyboardHook.Pressed2)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardHook.Pressed2 = true;
        }

        private void checkBoxTransparentTrue_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTransparentTrue.Checked)
            {
                checkBoxTransparentFalse.Checked = false;
            }
            else
            {
                checkBoxTransparentFalse.Checked = true;
            }
        }

        private void checkBoxTransparentFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTransparentFalse.Checked)
            {
                checkBoxTransparentTrue.Checked = false;
            }
            else
            {
                checkBoxTransparentTrue.Checked = true;
            }
        }
    }
}
