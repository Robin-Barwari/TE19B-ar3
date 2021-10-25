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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labb_2
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

        private void Click_OK(object sender, RoutedEventArgs e)
        {
            // Deklarera en sträng
            string text = rutaText.Text;

            // Läs in texten
            string omvändText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                omvändText += text[i];
            }

            // Skriv in i nedre rutan
            omvändRuta.Text = omvändText;
        }
    }
}
