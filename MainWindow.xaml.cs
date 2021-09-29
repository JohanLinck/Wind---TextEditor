using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Wind
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OpenFileDialog openDialog;

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt";
            if (openDialog.ShowDialog() == true)
            {
                window.Title = "Wind - " + openDialog.FileName;
                pathBox.Text = openDialog.FileName;
                textbox.Text = File.ReadAllText(openDialog.FileName);
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (openDialog != null)
            {
                File.WriteAllText(openDialog.FileName, textbox.Text);
                MessageBox.Show("Dateiinhalt wurde angepasst");
            }
            else
                MessageBox.Show("Es muss eine Datei ausgewählt werden", "Keine Datei ausgewählt");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
