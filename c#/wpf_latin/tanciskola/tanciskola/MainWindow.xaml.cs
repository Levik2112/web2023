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

            ir = new StreamWriter("szereplok.xml");
            ir.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            ir.WriteLine("<tancosok>");
                ir.WriteLine("\t<fiuk>");
                    ir.WriteLine("\t\t<nev>{0}</nev>", String.Join("</nev>\r\n\t\t<nev>",fiuk));
                ir.WriteLine("\t</fiuk>");
                ir.WriteLine("\t<lanyok>");
                    ir.WriteLine("\t\t<nev>{0}</nev>", String.Join("</nev>\r\n\t\t<nev>",lanyok));
                ir.WriteLine("\t</lanyok>");
            ir.WriteLine("</tancosok>");


            ir.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dictionary<string,int> statFiuk = new Dictionary<string,int>();
            Dictionary<string, int> statLanyok = new Dictionary<string, int>();
            for (int i = 0; i < tancok.Count; i++)
            {
                if (statFiuk.ContainsKey(tancok[i].fiu))
                {
                    statFiuk[tancok[i].fiu]++;
                }
                else
                {
                    statFiuk.Add(tancok[i].fiu,1);
                }
                if (statLanyok.ContainsKey(tancok[i].lany))
                {
                    statLanyok[tancok[i].lany]++;
                }
                else
                {
                    statLanyok.Add(tancok[i].lany, 1);
                }
            }
        }
    }
}
