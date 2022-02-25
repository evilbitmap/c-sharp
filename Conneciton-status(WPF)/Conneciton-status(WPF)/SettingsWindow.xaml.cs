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
using System.Windows.Shapes;

namespace Conneciton_status_WPF_
{
    /// <summary>
    /// Interakční logika pro SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        // LOAD
        private void SettingsWindow_Loaded(object sender, EventArgs e)
        {
            // ping
            TextBoxPingHost.Text = Properties.Settings.Default.PingHost;
            TextBoxInterval.Text = Convert.ToString(Properties.Settings.Default.PingInterval);
            // window
            SliderWindowOpacity.Value = Properties.Settings.Default.WindowOpacity;
            
            // slider pos x,y
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            SliderPosX.Maximum = screenWidth - App.Current.MainWindow.Width;
            SliderPosY.Maximum = screenHeight - App.Current.MainWindow.Height;
            SliderPosX.Value = Properties.Settings.Default.WindowPosX;
            SliderPosY.Value = Properties.Settings.Default.WindowPosY;
        }
        private void SliderPosX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeWindowPos.ChangePos(SliderPosX.Value, SliderPosY.Value);
        }

        private void SliderPosY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeWindowPos.ChangePos(SliderPosX.Value, SliderPosY.Value);
        }

        private void SliderWindowOpacity_Changed(object sender, RoutedEventArgs e)
        {
            ChangeWindowOpacity.Change(SliderWindowOpacity.Value);
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            // ping host
            Properties.Settings.Default.PingHost = TextBoxPingHost.Text;
            // ping interval
            Properties.Settings.Default.PingInterval = Convert.ToInt32(TextBoxInterval.Text);
            // window opacity
            Properties.Settings.Default.WindowOpacity = SliderWindowOpacity.Value;
            // window pos x
            Properties.Settings.Default.WindowPosX = SliderPosX.Value;
            // window pos y
            Properties.Settings.Default.WindowPosY = SliderPosY.Value;

            Properties.Settings.Default.Save();
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ButtonResumePing_Click(object sender, RoutedEventArgs e)
        {
            GetPing.IsPaused = false;
        }
        private void ButtonPausePing_Click(object sender, RoutedEventArgs e)
        {
            GetPing.IsPaused = true;
        }
    }
}
