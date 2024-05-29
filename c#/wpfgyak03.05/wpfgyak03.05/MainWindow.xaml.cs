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

namespace wpfgyak03._05
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

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            textBlock.Text = textBox.Text;
        }

        private void textBlock_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlock.Text = textBox.Text;
            if(checkBox.IsChecked == true) 
            {
                textBlock.Text = textBlock.Text.ToUpper();
            }

            string[] tomb = textBox.Text.Split(" ");
            listBox.ItemsSource = tomb;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            
            textBlock.Text = textBlock.Text.ToUpper();

            textBox.Focus();
            
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBox.Text;
            textBox.Focus();
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            string vissza = "";
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if(listBox.SelectedIndex != i)
                {
                    vissza += listBox.Items[i] + " ";
                }
            }
            textBox.Text = vissza;
            vissza.Trim();
        }
    }
}
