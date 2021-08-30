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

namespace WpfMeddelande
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Skriv ut en varning
            rutaMeddelande.Text = "Servern är nere!";
        }

        private void Click_OK(object sender, RoutedEventArgs e)
        {
            // Deklarera en sträng
            string texten = "";
            texten = rutaText.Text;

            // Läs in texten
            Console.WriteLine(texten);
            rutaText.Text = "";

            // Skriv in i nedre rutan
            rutaMeddelande.Text += "\n" + texten;

        }
    }
}
