﻿using System;
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

namespace wpfhazi
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox.Text;
            string szulhely = textbox1.Text;
            string eletkor = textbox2.Text;

            if (nev == "" || szulhely == "" || eletkor == "")
            {
                MessageBox.Show("Töltsd ki mind!");
            }
            else
            {
                if(uzenet == "Add vissza az ezresemet!")
                {
                    listbox.Items[listbox.SelectedIndex] = nev + ", " + szulhely + ", " + eletkor;

                    uzenet = "";
                }
                else
                {
                    listbox.Items.Add(nev + ", " + szulhely + ", " + eletkor);
                }
                

                textbox.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";
            }

        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listbox_dblclick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                string[] sor = item.ToString().Split(", ");
                textbox.Text = sor[0].Substring(37);
                textbox1.Text = sor[1];
                textbox2.Text = sor[2];
            }
        }

        string uzenet = "";
        private void listbox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string szoveg = ((ListBox)sender).SelectedItem.ToString();
            MessageBox.Show(szoveg);
            string[] vag = szoveg.Split(", ");
            textbox.Text = vag[0];
            textbox1.Text = vag[1];
            textbox2.Text= vag[2];

            uzenet = "Add vissza az ezresemet!";
        }
    }
}
