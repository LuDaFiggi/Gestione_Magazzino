using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Docking;


namespace TEST2
{
    public partial class MainFrom : KryptonForm
    {
        Utente u;
        FilterInfoCollection filtercollection;
        VideoCaptureDevice cam;
        Result lastRes;
        List<TabPage> pages;
        AutoCompleteStringCollection userHistory = new AutoCompleteStringCollection();
        public MainFrom()
        {
            InitializeComponent();
            Size s = new Size(355, 489);
            Menu.Size = s;
            this.Size = s;
            this.MaximizeBox = false;
            u = new Utente();
            lastRes = null;
            pictureQR.Visible = false;          
            leaveOnlyLoginTab();
            kryptonTextBox2.GotFocus += RemoveTextUser;
            kryptonTextBox2.LostFocus += AddTextUser;
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
        private void leaveOnlyLoginTab()
        {
            foreach (KryptonPage tp in Menu.Pages)
            {
                string name = tp.Name;
                if (name != "Tab_Login")
                {
                    tp.Visible = false;
                }
            }


        }
        private void showAllPages()
        {
            foreach (KryptonPage tp in Menu.Pages)
            {
                tp.Visible = true;
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

        private void resetLabel()
        {
            Error.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            resetLabel();
        }
        /*
        protected override void WndProc(ref Message m)
        {
            const int WN_NCCALCSIZE = 0x0083;
            if (m.Msg == WN_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }*/
         

        private void kpt_btnLogin_Click(object sender, EventArgs e)
        {
            showAllPages();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            filtercollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo temp in filtercollection)
            {
                comboCam.Items.Add(temp.Name);
                comboCam.SelectedIndex = 0;
            }
        }       

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureQR.Image = (Bitmap)eventArgs.Frame.Clone();

        }
      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
            timerQR.Stop();
        }
       
        private void comboCam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(filtercollection[comboCam.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timerQR.Start();
            while (pictureQR.Image == null)
            {

            }
            pictureQR.Size = pictureQR.Image.Size;
            pictureQR.Visible = true;


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
        private void opacity(object sender, EventArgs e)
        {
            Form fBackground = new Form();
            try
            {
                using (Login l = new Login())
                {
                    fBackground.StartPosition = FormStartPosition.Manual;
                    fBackground.FormBorderStyle = FormBorderStyle.None;
                    fBackground.Opacity = 0.97d;
                    fBackground.BackColor = Color.Black;
                    fBackground.WindowState = FormWindowState.Maximized;
                    fBackground.TopMost = true;
                    fBackground.Location = this.Location;
                    fBackground.ShowInTaskbar = false;
                    fBackground.Show();
                    l.Owner = fBackground;

                    l.ShowDialog();
                    fBackground.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                fBackground.Dispose();
            }

        }
        private void blur(object sender, EventArgs e)
        {
            Form fBackground = new Form();
            try
            {
                using (Login l = new Login())
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
                    l.Owner = fBackground;

                    l.ShowDialog();
                    fBackground.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                fBackground.Dispose();
            }


        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            kryptonTextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kryptonTextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            kryptonTextBox2.AutoCompleteCustomSource = userHistory;
            kryptonTextBox3.Select();
            kryptonTextBox2.Select();
            Error.Select();

        }

        private void Tab_Utente_Click(object sender, EventArgs e)
        {
            Error.Select();
        }
    }
}

