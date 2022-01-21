using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace TEST2
{
    public partial class Prova : Form
    {
        Utente u;
        FilterInfoCollection filtercollection;
        VideoCaptureDevice cam;
        Result lastRes;
        public Prova()
        {
            InitializeComponent();
            Menu.TabPages.Remove(Tab_Home);
            Menu.TabPages.Remove(Tab_QR);
            Size s = new Size(355, 489);
            Menu.Size = s;
            this.MaximizeBox = false;
            u = new Utente();
            lastRes = null;
            pictureQR.Visible = false;
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
                        if (t == "true")
                        {
                            this.Hide();
                            Menu f = new Menu();
                            f.ShowDialog();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            resetLabel();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //1315; 676
            Size s = new Size(1315, 676);
            Menu.Size = s;
            Menu.TabPages.Add(Tab_Home);
            Menu.TabPages.Remove(Tab_Utente);
            Menu.TabPages.Add(Tab_Utente);
            Menu.TabPages.Add(Tab_QR);

        }

        private void Tab_Utente_Click(object sender, EventArgs e)
        {

        }

        private void Prova_Load(object sender, EventArgs e)
        {
            filtercollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo temp in filtercollection)
            {
                comboCam.Items.Add(temp.Name);
                comboCam.SelectedIndex = 0;
            }
        }

        private void comboCam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(filtercollection[comboCam.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timerQR.Start();            
            while(pictureQR.Image == null)
            {

            }
            pictureQR.Size = pictureQR.Image.Size;
            pictureQR.Visible = true;
          
          
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureQR.Image = (Bitmap)eventArgs.Frame.Clone();
            
        }

        private void timerQR_Tick(object sender, EventArgs e)
        {
            if (pictureQR.Image != null)
            {
                BarcodeReader br = new BarcodeReader();
                Result r = br.Decode((Bitmap)pictureQR.Image);
                if (lastRes == null && r != null)
                {
                    lblReaded.Text += "\n" + r.ToString();
                    lastRes = r;

                }
                else if (r != null && r.ToString() != lastRes.ToString())
                {
                    lblReaded.Text += "\n" + r.ToString();
                    lastRes = r;
                }
            }
        }

        private void Prova_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
                timerQR.Stop();
            }
        }
    }
}

