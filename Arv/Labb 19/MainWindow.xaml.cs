using System;
using System.Collections.Generic;
using System.Windows;


namespace Labb_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //static List<Bok> bokSamling = new List<Bok>();
        //static List<Film> filmSamling = new List<Film>();
        static List<Media> samling = new List<Media>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            // Skapa en instans av bok för att lagra bokens data
            Bok boken = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
            //bokSamling.Add(boken);
            samling.Add(boken);

            // Fyll på i stora textrutan
            rutaResultat.Items.Add(boken.TillText());
        }
        private void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            // Skapa en instans av film för att lagra filmens data
            Film filmen = new Film(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängd.Text);
            //filmSamling.Add(filmen);
            samling.Add(filmen);

            // Fyll på i stora textrutan
            rutaResultat.Items.Add(filmen.TillText());
        }
        private void CheckaRadio(object sender, RoutedEventArgs e)
        {
            if (allt.IsChecked == true)
            {
                Console.WriteLine("Radiobutton allt trycktes!");
            }
            if (bocker.IsChecked == true)
            {
                Console.WriteLine("Radiobutton böcker trycktes!");
            }
            if (filmer.IsChecked == true)
            {
                Console.WriteLine("Radiobutton filmer trycktes!");
            }
        }
    }
}