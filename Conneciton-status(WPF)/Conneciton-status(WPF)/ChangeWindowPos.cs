using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Conneciton_status_WPF_
{
    class ChangeWindowPos
    {
        public static void ChangePos(double x, double y)
        {
            if(Properties.Settings.Default.AllignToTaskBar)
            {
                double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
                var workingScreenAreaY = System.Windows.SystemParameters.WorkArea.Height;
                App.Current.MainWindow.Top = workingScreenAreaY - App.Current.MainWindow.Height - y;
                App.Current.MainWindow.Left = screenWidth - App.Current.MainWindow.Width - x;
            }
            else
            {
                double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
                double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
                App.Current.MainWindow.Top = screenHeight - App.Current.MainWindow.Height - y;
                App.Current.MainWindow.Left = screenWidth - App.Current.MainWindow.Width - x;
            }
        }
    }
}
