using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCode_generator
{
    public partial class qr : Form
    {
        string to_qr;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument1;

        public qr(string to_qr)
        {
            InitializeComponent();
            this.to_qr = to_qr;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(to_qr, 70);
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new PrintDocument();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 100, 100, 630, 600);
            string[] contenuto = to_qr.Split(';');
            Font f_tit = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Underline);
            e.Graphics.DrawString("CONTENUTO SCATOLA", f_tit, Brushes.Black, 250, 775);
            Font f_cont = new Font(FontFamily.GenericSansSerif, 16);
            e.Graphics.DrawString("Prodotto: " + contenuto[0], f_cont, Brushes.Black, 100, 850);
            e.Graphics.DrawString("Quantità: " + contenuto[1], f_cont, Brushes.Black, 100, 890);
        }

        private void stampa_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
