using System;
using System.IO;
using System.Windows;


namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader = new string[194];

        public MainWindow()
        {
            // Skapar GUI
            InitializeComponent();

            // Läs in alla rader från textfilen countries.csv
            rader = File.ReadAllLines("resurs/countries.csv");
        }

        private void ClickSök(Object sender, RoutedEventArgs e)
        {
            rutaResultat.Text = "";
            int antal = 1;
            string sökterm = rutaSökterm.Text;

                // Loopa igenom alla rader
                //foreach (var rad in rader)
                for (int i = 1; i < rader.Length; i++)
                {
                    // Dela upp raden
                    string[] delar = rader[i].Split(',');

                    // Plocka ut land
                    string land = delar[1];

                    // Plocka ut landskod
                    string landskod = delar[2];

                    if (land.ToLower().Contains(sökterm.ToLower()))
                    {
                        // Skriv ut matchande land och dess landskod
                        rutaResultat.Text += $"{antal} {land}: {landskod}\n";
                        antal++;
                    }
                }
            rutaStatus.Text = $"Hittade {antal} länder.";
        }
        
    }
}
