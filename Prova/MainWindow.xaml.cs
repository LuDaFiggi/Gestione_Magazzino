using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace Prova
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        string MyConnectionString = "Server=localhost;Database=progetto;Uid=root;Pwd=;";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnInvio_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("InserisciUtente", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nome", "CIao");
            cmd.Parameters.AddWithValue("Cognome", "Rossi");
            cmd.Parameters.AddWithValue("mail", "ciao@ciao.com");
            cmd.ExecuteNonQuery();
            connection.Close();
            /*//try
            //{
            /*
                * 	
            CodAlbum
            Titolo
            Anno
            CodCantante*/
            /*cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO utenti(nome,cognome,email)VALUES(@nome,@cognome,@mail)";
            cmd.Parameters.AddWithValue("@nome", "Marco");
            cmd.Parameters.AddWithValue("@cognome", "Rossi");
            cmd.Parameters.AddWithValue("@mail", "ciao@ciao.com");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eseguito");*/
            //}
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();*/
        }

        private void btnCerca_Click(object sender, RoutedEventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SelezionaTutto", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);
                DataGrid.ItemsSource = dt.Tables[0].DefaultView; ;
                /*MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * from utenti";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                DataGrid.ItemsSource = ds.Tables[0].DefaultView;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();

        }
    }
}
