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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Close();
            m.Show();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Close();
            m.Show();
        }

        private void utenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
