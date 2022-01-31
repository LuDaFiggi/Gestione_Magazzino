using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST2
{
    class Utente
    {
        private string nome;
        private string password;
        string MyConnectionString;

        public Utente()
        {
            this.nome = "";
            this.password = "";
        }

        public string popolaDati(string n, string p)
        {
            try
            {
                this.nome = n;
                this.password = p;
                return "true"; //ha popolato
            }
            catch (Exception ex)
            {
                return ex.Message; //non ha popoalto
            }
        }

        //contro per vericare se si inserisce un utente esistene
        public string controlloConnessione()
        {
            try
            {
                this.MyConnectionString = "Server=localhost;Database=db5c;Uid=root;Pwd=;";
                // this.MyConnectionString = "Server=localhost;Database=progetto;Uid=" + this.nome + ";Pwd=" + this.password + ";";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("AccessoDatabase", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Var_nome", nome);
                cmd.Parameters.AddWithValue("Var_pass", password);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet dp = new DataSet();
                da.Fill(dp);
                //cmd.ExecuteNonQuery();
                string i = dp.Tables[0].Rows[0]["accessi"].ToString();


                if (i != "1")
                {
                    i = "Credenziali errate";
                }
                connection.Close();
                return i;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
