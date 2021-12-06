using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgettoCSharpFormDataBase
{ 
    public partial class Form1 : Form
    {
        //ordina la list view
        //private ListViewColumnSorter lvwColumnSorter;
        Random rnd = new Random();

        string MyConnectionString = "Server=localhost;Database=progetto;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
            //ordina la list view
            //lvwColumnSorter = new ListViewColumnSorter();
            //this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        //evento bottone per inserire utente
        private void BtnInvia_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("InserisciUtente", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nome", "CIao");
            cmd.Parameters.AddWithValue("Cognome", "Rossi");
            cmd.Parameters.AddWithValue("Email", "ciao@ciao.com");
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //evento bottone per visualizzae database
        private void BtnVisualizza_Click(object sender, EventArgs e)
        {
            //listView1.Columns.Clear();
            //setColumns();
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SelezionaTutto", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet dp = new DataSet();
                da.Fill(dp);

                dataGridView1.DataSource = dp.Tables[0];
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void utenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Close();
            m.Show();
        }

        //setta i nomi delle colonne
        /*public void setColumns()
        {
            listView1.Columns.Add("Id", 70);
            listView1.Columns.Add("Nome", 70);
            listView1.Columns.Add("Cognome", 70);
            listView1.Columns.Add("Email", 100);
        }*/


        //ordina la colonna una volta che si schiaccia su di essa
        /*private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.listView1.Sort();
        }*/
    }
}
