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
        private void SettingsWindow_Loaded(object sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                TextBoxPingHost.Text = Properties.Settings.Default.PingHost;
                TextBoxInterval.Text = Convert.ToString(Properties.Settings.Default.PingInterval);
            });
        }
        private void SliderWindowOpacity_Changed(object sender, RoutedEventArgs e)
        {
            double value = SliderWindowOpacity.Value / 100;
            App.Current.MainWindow.Background.Opacity = value;
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.PingHost = TextBoxPingHost.Text;
            Properties.Settings.Default.PingInterval = Convert.ToInt32(TextBoxInterval.Text);
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
