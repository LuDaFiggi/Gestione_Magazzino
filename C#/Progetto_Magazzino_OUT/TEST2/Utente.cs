using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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
            string i = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ilsitodifacc.altervista.org/?METHOD_=POST&DATO=Login$nome=" + this.nome + "&pass=" + this.password);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader input = new StreamReader(response.GetResponseStream());

                DataSet dsTest = new DataSet();
                dsTest.ReadXml(input);




                return i;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
