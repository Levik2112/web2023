using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace teszt
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dobil\\OneDrive\\Documents\\mytest.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into felhasz values(@ID,@nev,@felh)", con);

            cmd.Parameters.AddWithValue("@ID",int.Parse(textb.Text));
            cmd.Parameters.AddWithValue("@nev", textb2.Text);
            cmd.Parameters.AddWithValue("@felh", textb3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("sikerult");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dobil\\OneDrive\\Documents\\mytest.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update felhasz set nev=@nev, felh = @felh where id=@id", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textb.Text));
            cmd.Parameters.AddWithValue("@nev", textb2.Text);
            cmd.Parameters.AddWithValue("@felh", textb3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("frissitve");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dobil\\OneDrive\\Documents\\mytest.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete felhasz where id=@id", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textb.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("törölve");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dobil\\OneDrive\\Documents\\mytest.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from felhasz", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataContext = dt;
        }
    }
}