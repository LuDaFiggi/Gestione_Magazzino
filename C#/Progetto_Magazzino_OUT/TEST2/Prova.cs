﻿using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Collections.Generic;

namespace TEST2
{
    public partial class Prova : Form
    {
        Utente u;
        FilterInfoCollection filtercollection;
        VideoCaptureDevice cam;
        Result lastRes;
        List<TabPage> pages;
        AutoCompleteStringCollection userHistory = new AutoCompleteStringCollection();
        public Prova()
        {
            InitializeComponent();

            Size s = new Size(355, 489);
            Menu.Size = s;
            this.MaximizeBox = false;
            u = new Utente();
            lastRes = null;
            pictureQR.Visible = false;
            pages = returnAllNewPages();
            leaveOnlyLoginTab();

            NomeUtente.GotFocus += RemoveTextUser;
            NomeUtente.LostFocus += AddTextUser;
            PasswordUtente.GotFocus += RemoveTextPass;
            PasswordUtente.LostFocus += AddTextPass;         

        }
        private void RemoveTextPass(object sender, EventArgs e)
        {
            if (PasswordUtente.Text == "Password here")
            {
                PasswordUtente.Text = "";
            }

        }
        private void RemoveTextUser(object sender, EventArgs e)
        {
            if (NomeUtente.Text == "Username here")
            {
                NomeUtente.Text = "";
            }
        }

        private void AddTextPass(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordUtente.Text))
                PasswordUtente.Text = "Password here";

        }
        private void AddTextUser(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeUtente.Text))
                NomeUtente.Text = "Username here";
        }
        private List<TabPage> returnAllNewPages()
        {
            //metodo terribile
            List<TabPage> pages = new List<TabPage>();
            pages.Add(Tab_Home);
            pages.Add(Tab_Utente);
            pages.Add(Tab_QR);
            pages.Add(Tab_GeneraQR);
            return pages;
        }
        private void Errore(string t)
        {
            timer.Enabled = false;
            Error.Visible = true;
            Error.BackColor = Color.Red;
            Error.Text = t;
            timer.Enabled = true;
        }

        private void leaveOnlyLoginTab()
        {
            foreach (TabPage tp in Menu.TabPages)
            {
                string name = tp.Name;
                if (name != "Tab_Utente")
                {
                    Menu.TabPages.Remove(tp);
                }
            }


        }
        private void addAllPages()
        {
            Menu.TabPages.Clear();
            int index = 0;
            foreach (TabPage tp in pages)
            {
                Menu.TabPages.Add(pages[index]);
                index++;
            }
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
                    userHistory.Add(NomeUtente.Text);
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
            addAllPages();

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
            while (pictureQR.Image == null)
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
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
            timerQR.Stop();
        }

        private void Prova_Shown(object sender, EventArgs e)
        {            
            NomeUtente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NomeUtente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NomeUtente.AutoCompleteCustomSource = userHistory;
            PasswordUtente.Select();
            NomeUtente.Select();
            Error.Select();
        
        }

        private void Tab_Utente_Click(object sender, EventArgs e)
        {
            Error.Select();
        }
    }
}

