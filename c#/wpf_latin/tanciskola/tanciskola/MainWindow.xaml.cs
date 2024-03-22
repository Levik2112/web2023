using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace tanciskola
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

        List<Par> tancok = new List<Par>();

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("tancrend.txt");
            while (!olvas.EndOfStream)
            {
                string[] sorok = new string[3];
                for (int i = 0; i < sorok.Length; i++)
                {
                    sorok[i] = olvas.ReadLine();
                }

                tancok.Add(new Par(sorok[0], sorok[1], sorok[2]));
            }
            
            olvas.Close();

            List<string> tancnevek = new List<string>();
            for (int i = 0;i < tancok.Count; i++)
            {
                if (!tancnevek.Contains(tancok[i].tanc))
                {
                    tancnevek.Add(tancnevek[i]);
                }
            }
            listbox1.ItemsSource = tancnevek;
            listbox2.ItemsSource = tancnevek;
        }

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "Első tánc: " + tancok[0].tanc + " az utolsó tánc: " + tancok[tancok.Count-1].tanc;
            textblock.Text = szoveg;
        }

        private void gomb2_Click(object sender, RoutedEventArgs e)
        {
            textbloc2.Text = "A samba-t" + tancSzamol("samba") + " pár táncolta."; 
        }

        private int tancSzamol(string tanc)
        {
            int db = 0;
            for (int i = 0; i < tancok.Count; i++)
            {
                if (tancok[i].tanc == tanc)
                {
                    db++;
                }
            }

            return db;
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            label2.Content=tancSzamol(lb.SelectedItem.ToString());
        }

        private void listbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            string partner = "Ilyet nem táncolt!";
            //label2.Content = tancSzamol(lb.SelectedItem.ToString());
            for (int i = 0; i < tancok.Count; i++)
            {
                if (tancok[i].lany == "Vilma")
                {
                    if (tancok[i].tanc== lb.SelectedItem.ToString())
                    {
                        partner = tancok[i].fiu;
                    }
                    
                }
            }
            label5.Content = partner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> fiuk = new List<string>();
            List<string> lanyok = new List<string>();

            for (int i = 0; i < tancok.Count; i++)
            {
                if (!fiuk.Contains(tancok[i].fiu))
                {
                    fiuk.Add(tancok[i].fiu);
                }
                if (!lanyok.Contains(tancok[i].lany)){
                    lanyok.Add(tancok[i].lany);
                }
            }
            StreamWriter ir = new StreamWriter("szereplok.txt");
            ir.WriteLine("Lányok: {0}", String.Join(", ",lanyok));
            ir.WriteLine("Fiúk: {0}", String.Join(", ", fiuk));
            /*tancosok
             fiuk
            nev
            tancosok
            */
            ir.Close();
        }
    }
}
