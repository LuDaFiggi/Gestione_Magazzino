
namespace TEST2
{
    partial class Prova
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prova));
            this.Menu = new System.Windows.Forms.TabControl();
            this.Tab_Home = new System.Windows.Forms.TabPage();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.Tab_Utente = new System.Windows.Forms.TabPage();
            this.Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PasswordUtente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeUtente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_QR = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReaded = new System.Windows.Forms.Label();
            this.pictureQR = new System.Windows.Forms.PictureBox();
            this.comboCam = new System.Windows.Forms.ComboBox();
            this.Tab_GeneraQR = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerQR = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.Tab_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.Tab_Utente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tab_QR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Tab_Home);
            this.Menu.Controls.Add(this.Tab_Utente);
            this.Menu.Controls.Add(this.Tab_QR);
            this.Menu.Controls.Add(this.Tab_GeneraQR);
            this.Menu.Location = new System.Drawing.Point(-2, 3);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1319, 646);
            this.Menu.TabIndex = 0;
            // 
            // Tab_Home
            // 
            this.Tab_Home.BackColor = System.Drawing.Color.Gray;
            this.Tab_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tab_Home.Controls.Add(this.pictureHome);
            this.Tab_Home.Location = new System.Drawing.Point(4, 22);
            this.Tab_Home.Name = "Tab_Home";
            this.Tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Home.Size = new System.Drawing.Size(1311, 620);
            this.Tab_Home.TabIndex = 0;
            this.Tab_Home.Text = "HOME";
            // 
            // pictureHome
            // 
            this.pictureHome.BackColor = System.Drawing.Color.White;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureHome.Image = global::TEST2.Properties.Resources.Logo;
            this.pictureHome.Location = new System.Drawing.Point(0, 0);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(1305, 103);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 20;
            this.pictureHome.TabStop = false;
            // 
            // Tab_Utente
            // 
            this.Tab_Utente.Controls.Add(this.Error);
            this.Tab_Utente.Controls.Add(this.pictureBox1);
            this.Tab_Utente.Controls.Add(this.btnLogin);
            this.Tab_Utente.Controls.Add(this.PasswordUtente);
            this.Tab_Utente.Controls.Add(this.label2);
            this.Tab_Utente.Controls.Add(this.NomeUtente);
            this.Tab_Utente.Controls.Add(this.label1);
            this.Tab_Utente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tab_Utente.Location = new System.Drawing.Point(4, 22);
            this.Tab_Utente.Name = "Tab_Utente";
            this.Tab_Utente.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Utente.Size = new System.Drawing.Size(1311, 620);
            this.Tab_Utente.TabIndex = 1;
            this.Tab_Utente.Text = "Utente";
            this.Tab_Utente.UseVisualStyleBackColor = true;
            this.Tab_Utente.Click += new System.EventHandler(this.Tab_Utente_Click);
            // 
            // Error
            // 
            this.Error.Location = new System.Drawing.Point(3, 398);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(355, 36);
            this.Error.TabIndex = 27;
            this.Error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 78);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(60, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 65);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PasswordUtente
            // 
            this.PasswordUtente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordUtente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordUtente.Location = new System.Drawing.Point(39, 240);
            this.PasswordUtente.Name = "PasswordUtente";
            this.PasswordUtente.PasswordChar = '*';
            this.PasswordUtente.Size = new System.Drawing.Size(241, 29);
            this.PasswordUtente.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password:";
            // 
            // NomeUtente
            // 
            this.NomeUtente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NomeUtente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUtente.Location = new System.Drawing.Point(43, 148);
            this.NomeUtente.Name = "NomeUtente";
            this.NomeUtente.Size = new System.Drawing.Size(241, 29);
            this.NomeUtente.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome utente:";
            // 
            // Tab_QR
            // 
            this.Tab_QR.Controls.Add(this.label3);
            this.Tab_QR.Controls.Add(this.lblReaded);
            this.Tab_QR.Controls.Add(this.pictureQR);
            this.Tab_QR.Controls.Add(this.comboCam);
            this.Tab_QR.Location = new System.Drawing.Point(4, 22);
            this.Tab_QR.Name = "Tab_QR";
            this.Tab_QR.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_QR.Size = new System.Drawing.Size(1311, 620);
            this.Tab_QR.TabIndex = 2;
            this.Tab_QR.Text = "QR";
            this.Tab_QR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TESTO QR";
            // 
            // lblReaded
            // 
            this.lblReaded.AutoEllipsis = true;
            this.lblReaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaded.Location = new System.Drawing.Point(39, 48);
            this.lblReaded.Name = "lblReaded";
            this.lblReaded.Size = new System.Drawing.Size(245, 516);
            this.lblReaded.TabIndex = 3;
            // 
            // pictureQR
            // 
            this.pictureQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureQR.Location = new System.Drawing.Point(327, 75);
            this.pictureQR.Name = "pictureQR";
            this.pictureQR.Size = new System.Drawing.Size(946, 483);
            this.pictureQR.TabIndex = 1;
            this.pictureQR.TabStop = false;
            // 
            // comboCam
            // 
            this.comboCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCam.FormattingEnabled = true;
            this.comboCam.Location = new System.Drawing.Point(327, 48);
            this.comboCam.Name = "comboCam";
            this.comboCam.Size = new System.Drawing.Size(386, 21);
            this.comboCam.TabIndex = 0;
            this.comboCam.SelectionChangeCommitted += new System.EventHandler(this.comboCam_SelectionChangeCommitted);
            // 
            // Tab_GeneraQR
            // 
            this.Tab_GeneraQR.Location = new System.Drawing.Point(4, 22);
            this.Tab_GeneraQR.Name = "Tab_GeneraQR";
            this.Tab_GeneraQR.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_GeneraQR.Size = new System.Drawing.Size(1311, 620);
            this.Tab_GeneraQR.TabIndex = 3;
            this.Tab_GeneraQR.Text = "Genera QR";
            this.Tab_GeneraQR.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerQR
            // 
            this.timerQR.Interval = 500;
            this.timerQR.Tick += new System.EventHandler(this.timerQR_Tick);
            // 
            // Prova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 637);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Prova";
            this.Text = "Prova";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prova_FormClosing);
            this.Load += new System.EventHandler(this.Prova_Load);
            this.Shown += new System.EventHandler(this.Prova_Shown);
            this.Menu.ResumeLayout(false);
            this.Tab_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.Tab_Utente.ResumeLayout(false);
            this.Tab_Utente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tab_QR.ResumeLayout(false);
            this.Tab_QR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage Tab_Home;
        private System.Windows.Forms.TabPage Tab_Utente;
        private System.Windows.Forms.TabPage Tab_QR;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox PasswordUtente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeUtente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.PictureBox pictureQR;
        private System.Windows.Forms.ComboBox comboCam;
        private System.Windows.Forms.Label lblReaded;
        private System.Windows.Forms.Timer timerQR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Tab_GeneraQR;
    }
}