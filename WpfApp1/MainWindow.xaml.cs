using System;
using Microsoft.Win32;
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

namespace WpfApp1
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

        private void MenuNew_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You're about to close the Editor");
            this.Close();
        }

        private void MenuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontArial.IsChecked = false;
            menuFontShowcard.IsChecked = false;

            TxtBoxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void MenuFontArial_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontShowcard.IsChecked = false;

            TxtBoxDoc.FontFamily = new FontFamily("Arial");
        }

        private void MenuFontShowcard_Click(object sender, RoutedEventArgs e)
        {
            menuFontArial.IsChecked = false;
            menuFontTimes.IsChecked = false;

            TxtBoxDoc.FontFamily = new FontFamily("Showcard Gothic");
        }

        bool comboFSClosed = true;

        private void ComboFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboFSClosed) ChangeTBFontSize();
            comboFSClosed = true;
        }

        private void ComboFontSize_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboFSClosed = !comboBox.IsDropDownOpen;
            ChangeTBFontSize();
        }

        private void ChangeTBFontSize()
        {
            string fontSize = comboFontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);

            switch (fontSize)
            {
                case "10":
                    TxtBoxDoc.FontSize = 10;
                    break;
                case "12":
                    TxtBoxDoc.FontSize = 12;
                    break;
                case "14":
                    TxtBoxDoc.FontSize = 14;
                    break;
                case "16":
                    TxtBoxDoc.FontSize = 16;
                    break;
                case "18":
                    TxtBoxDoc.FontSize = 18;
                    break;
                case "20":
                    TxtBoxDoc.FontSize = 20;
                    break;
                case "24":
                    TxtBoxDoc.FontSize = 24;
                    break;
                case "36":
                    TxtBoxDoc.FontSize = 36;
                    break;
                case "48":
                    TxtBoxDoc.FontSize = 48;
                    break;
                case "72":
                    TxtBoxDoc.FontSize = 72;
                    break;
            }
        }
    }
}
