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
using System.Threading;

namespace PingBar
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();
        public Form1()
        {
            InitializeComponent();
            hook.SetHook();

            FormMenu fm = new FormMenu();
            fm.Show();

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height - 25);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerCheckWifiStatus.Start();
            timerCheckClosing.Start();
        }

        static bool CheckIfConnected()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if(connection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int GetPing()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("216.58.201.78", 1000);
            if (reply != null)
            {
                return Convert.ToInt32(reply.RoundtripTime);
            }
            else
            {
                return Convert.ToInt32(reply.RoundtripTime);
            }
        }

        private void timerCheckWifiStatus_Tick(object sender, EventArgs e)
        {
            if (CheckIfConnected())
            {
                labelWifiStatus.Text = "CONNECTED";
                labelWifiStatus.ForeColor = Color.Green;
                labelPingStatus.Text = "Ping: " + GetPing().ToString();
            }
            else if (!CheckIfConnected())
            {
                labelWifiStatus.Text = "DISCONNECTED";
                labelWifiStatus.ForeColor = Color.Red;
            }
        }

        private void timerCheckClosing_Tick(object sender, EventArgs e)
        {
            if (KeyboardHook.Pressed)
            {
                this.Hide();
                timerCheckWifiStatus.Stop();
            }
            else
            {
                this.Show();
                timerCheckWifiStatus.Start();
            }
        }
    }
}