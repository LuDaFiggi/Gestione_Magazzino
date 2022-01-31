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
            this.MaximizeBox = false;
            u = new Utente();
            lastRes = null;
           // pictureQR.Visible = false;          
            leaveOnlyLoginTab();
            //kryptonTextBox1.GotFocus += RemoveTextUser;
            //kryptonTextBox1.LostFocus += AddTextUser;
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
    }
}

