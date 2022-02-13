using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Docking;
using System.Net;
using System.IO;
using System.Data;
using System.Xml;

namespace TEST2
{
    public partial class Login : KryptonForm
    {
        Utente u;
        AutoCompleteStringCollection userHistory = new AutoCompleteStringCollection();
        public Login()
        {
            InitializeComponent();
            u = new Utente();
            kryptonTextBox2.GotFocus += RemoveTextUser;
            kryptonTextBox2.LostFocus += AddTextUser;
        }
        private void opacity()
        {
            Form fBackground = new Form();
            try
            {
                fBackground.StartPosition = FormStartPosition.Manual;
                fBackground.FormBorderStyle = FormBorderStyle.None;
                fBackground.Opacity = 0.90d;
                fBackground.BackColor = Color.Black;
                fBackground.WindowState = FormWindowState.Maximized;
                //fBackground.TopMost = true;
                fBackground.Location = this.Location;
                fBackground.ShowInTaskbar = false;
                fBackground.Show();
                this.Owner = fBackground;              
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void blur()
        {
            Form fBackground = new Form();
            try
            {
                fBackground.EnableBlur();
                fBackground.TransparencyKey = Color.Azure;
                fBackground.StartPosition = FormStartPosition.Manual;
                fBackground.FormBorderStyle = FormBorderStyle.None;
                fBackground.Opacity = 0.97d;
                fBackground.BackColor = Color.Azure;
                fBackground.WindowState = FormWindowState.Maximized;
                fBackground.TopMost = true;
                fBackground.Location = this.Location;
                fBackground.ShowInTaskbar = false;
                fBackground.Show();
                this.Owner = fBackground;            
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Errore(string t)
        {
            timer.Enabled = false;
            Error.Visible = true;
            Error.BackColor = Color.Red;
            Error.Text = t;
            timer.Enabled = true;
        }
        private void RemoveTextUser(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Username here")
            {
                kryptonTextBox2.Text = "";
            }
        }
        private void AddTextUser(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox2.Text))
                kryptonTextBox2.Text = "Username here";
        }

        private void resetLabel()
        {
            Error.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox2.Text == "" || kryptonTextBox2.Text == "Username here")
                {
                    MessageBox.Show("Nome utente non inserito", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    userHistory.Add(kryptonTextBox2.Text);
                    string t = u.popolaDati(kryptonTextBox2.Text, kryptonTextBox3.Text);
                    if (t == "true")
                    {
                        t = controlloConnessione();
                        if (t == "true")
                        {
                            MainFrom m = new MainFrom();
                            m.Show();
                            this.Hide();                           
                        }
                        else
                        {

                            Errore(t);
                        }
                    }
                    else
                    {
                        Errore(t);
                    }
                }
            }
            catch (Exception ex)
            {
                Errore(ex.Message);
            }
          
        }
        public string controlloConnessione()
        {
            string i = "true";
            try
            {
                string f = "http://ilsitodifacc.altervista.org/?METHOD_=POST&DATO=Login&nome=" + this.kryptonTextBox2.Text + "&pass=" + this.kryptonTextBox3.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(f);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader input = new StreamReader(response.GetResponseStream());

                DataSet dsTest = new DataSet();
                dsTest.ReadXml(input);

                //dataGridView1.DataSource = dsTest.Tables[0];
                //come cazzo si fa
                //i = dsTest.Tables[0].Rows[0];

                return i;
            }
            catch (Exception Except)
            {
                MessageBox.Show(Except.ToString());
                return i;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            resetLabel();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Shown(object sender, EventArgs e)
        {
            kryptonTextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kryptonTextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            kryptonTextBox2.AutoCompleteCustomSource = userHistory;
            kryptonTextBox3.Select();
            kryptonTextBox2.Select();
            Error.Select();

        }
        private void Login_Click(object sender, EventArgs e)
        {
            Error.Select();
        }
    }
}
