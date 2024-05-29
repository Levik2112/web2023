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

namespace gyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox.Items.Add("Lány");
            combobox.Items.Add("Fiú");
            combobox2.Items.Add("Lakhely1");
            combobox2.Items.Add("Lakhely2");
            combobox2.Items.Add("Lakhely3");
            combobox2.Items.Add("Lakhely4");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Add("Név: "+textb1.Text);
            lista.Items.Add("Cím: " + textb2.Text);
            lista.Items.Add("Életkor: " + textb3.Text);
            lista.Items.Add("Nem:"+combobox.SelectedItem);
            lista.Items.Add("Lakhely:" + combobox2.SelectedItem);
        }
    }
}
