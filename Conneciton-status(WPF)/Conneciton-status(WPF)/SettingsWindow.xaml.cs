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
            KeyboardHook.UnHook();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
