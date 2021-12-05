using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoCSharpFormDataBase
{
    public partial class Login : Form
    {
        Utente u;
        public Login()
        {
            InitializeComponent();
            u = new Utente();
        }

        private void Errore(string t)
        {
            timer.Enabled = false;
            Error.Visible = true;
            Error.BackColor = Color.Red;
            Error.Text = t;
            timer.Enabled = true;
        }


        private void resetLabel()
        {
            Error.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomeUtente.Text == "")
                {
                    MessageBox.Show("Nome utente non inserito", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string t = u.popolaDati(NomeUtente.Text, PasswordUtente.Text);
                    if (t == "true")
                    {
                        t = u.controlloConnessione();
                        if(t == "true")
                        {
                            MessageBox.Show("giusto");
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
            } catch (Exception ex)
            {
                Errore(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            resetLabel();
        }
    }
}
