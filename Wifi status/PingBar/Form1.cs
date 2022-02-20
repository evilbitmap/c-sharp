using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

using System.Net;
using System.Timers;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace PingBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height - 25);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Keyboard.IsKeyToggled(Keys.Home);


            timerCheckWifiStatus.Start();
            timerStopper.Start();
        }

        static bool CheckIfConnected()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if(connection) {
                return true;
            } else {
                return false;
            }
        }

        static int GetPing()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("216.58.201.78", 1000);
            if (reply != null) {
                return Convert.ToInt32(reply.RoundtripTime);
            }
            else {
                return Convert.ToInt32(reply.RoundtripTime);
            }


        }

        private void timerCheckWifiStatus_Tick(object sender, EventArgs e)
        {
            if (CheckIfConnected()) {
                labelWifiStatus.Text = "CONNECTED";
                labelWifiStatus.ForeColor = Color.Green;
                labelPingStatus.Text = "Ping: " + GetPing().ToString();
            } else if (!CheckIfConnected()) {
                labelWifiStatus.Text = "DISCONNECTED";
                labelWifiStatus.ForeColor = Color.Red;
            }
        }
        public abstract class Keyboard
        {
            [Flags]
            private enum KeyStates {
                None = 0,
                Down = 1,
                Toggled = 2
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            private static extern short GetKeyState(int keyCode);

            private static KeyStates GetKeyState(Keys key) {
                KeyStates state = KeyStates.None;

                short retVal = GetKeyState((int)key);

                //If the high-order bit is 1, the key is down
                //otherwise, it is up.
                if ((retVal & 0x8000) == 0x8000)
                    state |= KeyStates.Down;

                //If the low-order bit is 1, the key is toggled.
                if ((retVal & 1) == 1)
                    state |= KeyStates.Toggled;

                return state;
            }

            public static bool IsKeyDown(Keys key) {
                return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
            }

            public static bool IsKeyToggled(Keys key) {
                return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
            }
        }

        static int value = 0;

        private void timerStopper_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyToggled(Keys.Home)) {
                this.Opacity = 0;
                timerCheckWifiStatus.Stop();
                timerCheckBeforeClosing.Start();

            } else {
                this.Opacity = 100;
                timerCheckWifiStatus.Start();
                timerCheckBeforeClosing.Stop();
                value = 0;
            }
        }

        private void timerCheckBeforeClosing_Tick(object sender, EventArgs e)
        {
            if(value == 1)
            {
                this.Close();
            }

            if (Keyboard.IsKeyDown(Keys.Home))
            {
                value++;
            }
        }
    }
}