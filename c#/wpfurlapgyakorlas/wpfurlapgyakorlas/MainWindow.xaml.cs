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

namespace wpfurlapgyakorlas
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

        private void gomb1_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox1.Text;
            string szhely = textbox2.Text;
            string kor = textbox3.Text;

            if (nev=="" || szhely == "" || kor=="")
            {
                MessageBox.Show("Töltsd ki mind!");
            }
            else
            {
                listbox.Items.Add(nev + ", " + szhely + ", " + kor);
            }
            

            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
        }
    }
}
