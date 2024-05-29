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
using MySqlConnector;

namespace sqlProba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connStr = "Server = localhost;User ID=root;Password=;Database=";
            using var cn = new MySqlConnection(connStr);
            cn.Open();
            string query = "create database if not exists adatBazis default charset=utf8 collate=utf8_hungarian_ci;";
            string asd = "use adatBazis";
            string table = "CREATE TABLE varos\r\n(\r\nid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\niranyszam int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE 'varos'\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE fiok\r\n(\r\nid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nvarosid intCOLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nfelhnev varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nveznevid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\njeszo varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nkeresztnevid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nemail varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nszuldatum date() COLLATE utf8-utf8_hungarian_ci NOT NULL\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE fiok\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE keresztnev\r\n(\r\nid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE keresztnev\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n\r\n\r\nCREATE TABLE vezeteknev\r\n(\r\nid int COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\nneve varchar(50) COLLATE utf8-utf8_hungarian_ci NOT NULL,\r\n)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;\r\n\r\nALTER TABLE vezeteknev\r\n    ADD PRIMARY KEY('id')\r\nCOMMIT;\r\n";
           
            using var cmd = new MySqlCommand(query,cn);
            using var cmd2 = new MySqlCommand(table, cn);
            using var cmd3 = new MySqlCommand(asd, cn);
            
            cmd.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                textb.Text += reader["Tables_in_adatBazis"]+"\n";
            }
            
        }
    }
}
