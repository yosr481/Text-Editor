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
    }
}
