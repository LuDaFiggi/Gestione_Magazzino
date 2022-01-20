using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCode_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                cmb_prodotti.Items.Add("Item " + (i + 1));
            }
        }

        private void btn_registra_Click(object sender, EventArgs e)
        {
            if(cmb_prodotti.SelectedIndex != -1 && n_prodotti.Value > 0)
            {
                // apro altra finestra
                qr qr = new qr(cmb_prodotti.SelectedItem.ToString() + ";" + n_prodotti.Value + ";");
                qr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Devi inserire un prodotto!", "Inserisci prodotto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
