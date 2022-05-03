using System;
using System.IO;
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

namespace typing_game_wpf_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string wordsToType;
        static int accuracy;
        static int errorRate;
        static int amountOfErrors = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextBoxUserInput.IsEnabled = false;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            wordsToType = "";
            TextBoxUserInput.IsEnabled = true;
            TextBoxUserInput.Clear();
            TextBlockTextToType.Text = null;

            string[] wordsList = File.ReadAllLines("words.txt");
            string[] chosenWords = new string[Convert.ToInt32(TextBoxAmountOfWords.Text)];

            Random rdm = new Random();
            for(int i = 0; i < Convert.ToInt32(TextBoxAmountOfWords.Text); i++)
                chosenWords[i] += wordsList[rdm.Next(0, wordsList.Length - 1)];

            foreach (string word in chosenWords)
                wordsToType += word + " ";
            wordsToType = wordsToType.Remove(wordsToType.Length - 1);

            TextBlockTextToType.Text = wordsToType;

            TextBoxUserInput.Focus();
        }

        private void TextBoxUserInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Space)
            //{
            //    e.Handled = true;
            //    TextBoxUserInput.Clear();
            //}
        }

        private void TextBoxUserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (wordsToType != "")
            {
                if (TextBoxUserInput.Text.Length != 0)
                    if (TextBoxUserInput.Text[TextBoxUserInput.Text.Length - 1] != wordsToType[TextBoxUserInput.Text.Length - 1])
                    {
                        amountOfErrors++;
                        MessageBox.Show(amountOfErrors.ToString());
                    }

                if (TextBoxUserInput.Text.Length == wordsToType.Length)
                    if (TextBoxUserInput.Text[wordsToType.Length - 1] == wordsToType[wordsToType.Length - 1])
                    {
                        TextBoxUserInput.IsEnabled = false;

                        //nefunguje
                        errorRate = (amountOfErrors - wordsToType.Length) / wordsToType.Length * 100;
                        accuracy = 100 - errorRate;
                        MessageBox.Show("Accuracy: " + accuracy + "\nERROR rate: " + errorRate);
                    } 
            }
        }
    }
}
