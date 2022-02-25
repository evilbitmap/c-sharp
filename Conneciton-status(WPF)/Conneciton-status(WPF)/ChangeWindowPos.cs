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
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;

            App.Current.MainWindow.Top = screenHeight - App.Current.MainWindow.Height - y;
            App.Current.MainWindow.Left = screenWidth - App.Current.MainWindow.Width - x;
        }
    }
}
