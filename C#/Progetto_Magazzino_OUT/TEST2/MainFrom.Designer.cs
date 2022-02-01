
namespace TEST2
{
    partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.Menu = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.Tab_Home = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.Tab_Login = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kpt_btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_Ordine = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.Tab_GeneraQR = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Home)).BeginInit();
            this.Tab_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Login)).BeginInit();
            this.Tab_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Ordine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GeneraQR)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Location = new System.Drawing.Point(-2, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.Name = "Menu";
            this.Menu.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.Tab_Home,
            this.Tab_Login,
            this.Tab_Ordine,
            this.Tab_GeneraQR});
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1312, 559);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "kryptonNavigator1";
            // 
            // Tab_Home
            // 
            this.Tab_Home.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_Home.Controls.Add(this.pictureHome);
            this.Tab_Home.Flags = 65534;
            this.Tab_Home.LastVisibleSet = true;
            this.Tab_Home.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_Home.Name = "Tab_Home";
            this.Tab_Home.Size = new System.Drawing.Size(1310, 532);
            this.Tab_Home.Text = "Home";
            this.Tab_Home.ToolTipTitle = "Page ToolTip";
            this.Tab_Home.UniqueName = "AF3FC12826C44E1E4EA9AD413ED1CD34";
            // 
            // pictureHome
            // 
            this.pictureHome.BackColor = System.Drawing.Color.White;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureHome.Image = global::TEST2.Properties.Resources.Logo;
            this.pictureHome.Location = new System.Drawing.Point(2, 0);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(1305, 103);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 21;
            this.pictureHome.TabStop = false;
            // 
            // Tab_Login
            // 
            this.Tab_Login.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_Login.Controls.Add(this.kryptonTextBox2);
            this.Tab_Login.Controls.Add(this.kryptonTextBox3);
            this.Tab_Login.Controls.Add(this.kpt_btnLogin);
            this.Tab_Login.Controls.Add(this.pictureBox2);
            this.Tab_Login.Controls.Add(this.label2);
            this.Tab_Login.Controls.Add(this.label3);
            this.Tab_Login.Controls.Add(this.kryptonTextBox1);
            this.Tab_Login.Controls.Add(this.pictureBox1);
            this.Tab_Login.Controls.Add(this.label1);
            this.Tab_Login.Flags = 65534;
            this.Tab_Login.LastVisibleSet = true;
            this.Tab_Login.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_Login.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_Login.Name = "Tab_Login";
            this.Tab_Login.Size = new System.Drawing.Size(1308, 532);
            this.Tab_Login.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tab_Login.StateCommon.Separator.Border.Rounding = 20;
            this.Tab_Login.StateCommon.Separator.Border.Width = 1;
            this.Tab_Login.Text = "Login";
            this.Tab_Login.ToolTipTitle = "Page ToolTip";
            this.Tab_Login.UniqueName = "3BE15E851E9E4F8EF6A81647FBF6E1E5";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox2.Location = new System.Drawing.Point(53, 172);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(252, 35);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox2.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox2.StateCommon.Border.Width = 1;
            this.kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox2.TabIndex = 44;
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox3.Location = new System.Drawing.Point(53, 264);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.PasswordChar = '●';
            this.kryptonTextBox3.Size = new System.Drawing.Size(252, 35);
            this.kryptonTextBox3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox3.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox3.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox3.StateCommon.Border.Width = 1;
            this.kryptonTextBox3.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox3.TabIndex = 43;
            this.kryptonTextBox3.UseSystemPasswordChar = true;
            // 
            // kpt_btnLogin
            // 
            this.kpt_btnLogin.Location = new System.Drawing.Point(102, 332);
            this.kpt_btnLogin.Name = "kpt_btnLogin";
            this.kpt_btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.kpt_btnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.OverrideDefault.Border.ColorAngle = 45F;
            this.kpt_btnLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kpt_btnLogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kpt_btnLogin.OverrideDefault.Border.Rounding = 20;
            this.kpt_btnLogin.OverrideDefault.Border.Width = 1;
            this.kpt_btnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kpt_btnLogin.Size = new System.Drawing.Size(155, 43);
            this.kpt_btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.StateCommon.Back.ColorAngle = 45F;
            this.kpt_btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.StateCommon.Border.ColorAngle = 45F;
            this.kpt_btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kpt_btnLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kpt_btnLogin.StateCommon.Border.Rounding = 20;
            this.kpt_btnLogin.StateCommon.Border.Width = 1;
            this.kpt_btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kpt_btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kpt_btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpt_btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kpt_btnLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kpt_btnLogin.StatePressed.Back.ColorAngle = 135F;
            this.kpt_btnLogin.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.kpt_btnLogin.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.kpt_btnLogin.StatePressed.Border.ColorAngle = 135F;
            this.kpt_btnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kpt_btnLogin.StatePressed.Border.Rounding = 20;
            this.kpt_btnLogin.StatePressed.Border.Width = 1;
            this.kpt_btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.StateTracking.Back.ColorAngle = 45F;
            this.kpt_btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kpt_btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kpt_btnLogin.StateTracking.Border.ColorAngle = 45F;
            this.kpt_btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kpt_btnLogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kpt_btnLogin.StateTracking.Border.Rounding = 20;
            this.kpt_btnLogin.StateTracking.Border.Width = 1;
            this.kpt_btnLogin.TabIndex = 42;
            this.kpt_btnLogin.Values.Text = "LOGIN";
            this.kpt_btnLogin.Click += new System.EventHandler(this.kpt_btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 78);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nome utente:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox1.Location = new System.Drawing.Point(-17, -46);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(252, 35);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, -188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 78);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-13, -70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome utente:";
            // 
            // Tab_Ordine
            // 
            this.Tab_Ordine.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_Ordine.Flags = 65534;
            this.Tab_Ordine.LastVisibleSet = true;
            this.Tab_Ordine.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_Ordine.Name = "Tab_Ordine";
            this.Tab_Ordine.Size = new System.Drawing.Size(1300, 496);
            this.Tab_Ordine.Text = "Ordine";
            this.Tab_Ordine.ToolTipTitle = "Page ToolTip";
            this.Tab_Ordine.UniqueName = "C7611F491F4F4A19B2B21C6EA4886161";
            // 
            // Tab_GeneraQR
            // 
            this.Tab_GeneraQR.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.Tab_GeneraQR.Flags = 65534;
            this.Tab_GeneraQR.LastVisibleSet = true;
            this.Tab_GeneraQR.MinimumSize = new System.Drawing.Size(50, 50);
            this.Tab_GeneraQR.Name = "Tab_GeneraQR";
            this.Tab_GeneraQR.Size = new System.Drawing.Size(1300, 496);
            this.Tab_GeneraQR.Text = "GeneraQR";
            this.Tab_GeneraQR.ToolTipTitle = "Page ToolTip";
            this.Tab_GeneraQR.UniqueName = "120C7BFAEFE6477DF2A1838524606597";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1294, 535);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Home)).EndInit();
            this.Tab_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Login)).EndInit();
            this.Tab_Login.ResumeLayout(false);
            this.Tab_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Ordine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GeneraQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator Menu;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_Home;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_Login;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_Ordine;
        private ComponentFactory.Krypton.Navigator.KryptonPage Tab_GeneraQR;
        private System.Windows.Forms.PictureBox pictureHome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kpt_btnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}