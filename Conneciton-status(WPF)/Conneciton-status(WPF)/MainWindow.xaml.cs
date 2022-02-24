using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;

namespace Conneciton_status_WPF_
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void StatusWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TimerClass timers = new TimerClass();
            KeyboardHook hook = new KeyboardHook();

            this.Topmost = true;
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width - 10;
            this.Top = desktopWorkingArea.Bottom - this.Height - 10;


            hook.SetHook();
            SetTimerPing();
            SetTimerIsConnected();
        }

        // PING PONG
        void SetTimerPing()
        {
            System.Timers.Timer timerPing;
            timerPing = new System.Timers.Timer();
            timerPing.Elapsed += new ElapsedEventHandler(TimerPingElapsed);
            timerPing.Interval = 1000;
            timerPing.Enabled = true;
        }
        private void TimerPingElapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                TextBlockPing.Text = GetPing.Ping().ToString();
            });
        }
        // END

        // IS CONNECTED
        void SetTimerIsConnected()
        {
            System.Timers.Timer timerIsConnected;
            timerIsConnected = new System.Timers.Timer();
            timerIsConnected.Elapsed += new ElapsedEventHandler(TimerIsConnectedElapsed);
            timerIsConnected.Interval = 1000;
            timerIsConnected.Enabled = true;
        }
        private void TimerIsConnectedElapsed(object sender, ElapsedEventArgs e)
        {
            if(IsConnected.CheckIfConnected())
            {
                this.Dispatcher.Invoke(() =>
                {
                    TextBlockConnection.Text = "   CONNECTED";
                    TextBlockConnection.Foreground = Brushes.Green;
                });
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    TextBlockConnection.Text = "DISCONNECTED";
                    TextBlockConnection.Foreground = Brushes.Red;
                });
            }
        }
        // END
    }
}
