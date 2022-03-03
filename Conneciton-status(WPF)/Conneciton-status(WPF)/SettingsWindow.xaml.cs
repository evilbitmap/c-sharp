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
        static double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
        static double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
        static double taskbarHeight = System.Windows.SystemParameters.CaptionHeight;
        // LOAD
        private void SettingsWindow_Loaded(object sender, EventArgs e)
        {
            // ping
            TextBoxPingHost.Text = Properties.Settings.Default.PingHost;
            TextBoxInterval.Text = Convert.ToString(Properties.Settings.Default.PingInterval);
            // window
            SliderWindowOpacity.Value = Properties.Settings.Default.WindowOpacity;

            // slider pos x,y
            SliderPosX.Maximum = screenWidth - App.Current.MainWindow.Width;
            SliderPosY.Maximum = screenHeight - App.Current.MainWindow.Height;
            SliderPosX.Value = Properties.Settings.Default.WindowPosX;
            SliderPosY.Value = Properties.Settings.Default.WindowPosY;

            // Checkbox alling
            if(Properties.Settings.Default.AllignToTaskBar)
            {
                CheckBoxAllignToTaskBar.IsChecked = true;
            }
            else
            {
                CheckBoxAllignToTaskBar.IsChecked = false;
            }
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
            // checkbox allign
            if((bool)CheckBoxAllignToTaskBar.IsChecked)
            {
                Properties.Settings.Default.AllignToTaskBar = true;
            }
            else
            {
                Properties.Settings.Default.AllignToTaskBar = false;
            }
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
        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KeyboardHook.Pressed2 = false;
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            DragMove();
        }

        private void CheckBoxAllignToTaskBar_Checked(object sender, RoutedEventArgs e)
        {
            SliderPosY.Maximum = System.Windows.SystemParameters.WorkArea.Height - App.Current.MainWindow.Height;
        }

        private void CheckBoxAllignToTaskBar_Unchecked(object sender, RoutedEventArgs e)
        {
            SliderPosY.Maximum = System.Windows.SystemParameters.PrimaryScreenHeight;
        }
    }
}
