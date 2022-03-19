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
using System.Net;
using System.IO;
using System.Data;
using System.Xml;

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
        Login l;
        public MainFrom()
        {
            InitializeComponent();
            Size s = new Size(400, 489);
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
            Test();

        }
        private void Test()
        {
            //this.Size = new Size(1298, 559);
            Menu.Size = new Size(1920, 1080);


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
        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (kryptonTextBox2.Text == "")
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

                            showAllPages();
                            Test();
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

                dataGridView1.DataSource = dsTest.Tables[0];
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

        private void MainFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

