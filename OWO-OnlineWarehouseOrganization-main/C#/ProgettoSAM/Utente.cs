using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProgettoCSharpFormDataBase
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

        public string popolaDati(string n,string p)
        {
            try
            {
                this.nome = n;
                this.password = p;
                return "true"; //ha popolato
            }catch(Exception ex)
            {
                return ex.Message; //non ha popoalto
            }
        }

        //contro per vericare se si inserisce un utente esistene
        public string controlloConnessione()
        {  
            try
            {
                //this.MyConnectionString = "Server=localhost;Database=progetto;Uid=root;Pwd=;";
                this.MyConnectionString = "Server=localhost;Database=progetto;Uid=" + this.nome + ";Pwd=" + this.password + ";";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                connection.Open();
                connection.Close();
                return "true";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
