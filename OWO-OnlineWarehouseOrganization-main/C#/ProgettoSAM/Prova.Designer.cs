
namespace ProgettoCSharpFormDataBase
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pag_QR = new System.Windows.Forms.TabPage();
            this.pag_Info = new System.Windows.Forms.TabPage();
            this.lblOrdine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pag_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pag_QR);
            this.tabControl1.Controls.Add(this.pag_Info);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1521, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // pag_QR
            // 
            this.pag_QR.Location = new System.Drawing.Point(4, 22);
            this.pag_QR.Name = "pag_QR";
            this.pag_QR.Padding = new System.Windows.Forms.Padding(3);
            this.pag_QR.Size = new System.Drawing.Size(1513, 564);
            this.pag_QR.TabIndex = 0;
            this.pag_QR.Text = "QR";
            this.pag_QR.UseVisualStyleBackColor = true;
            // 
            // pag_Info
            // 
            this.pag_Info.Controls.Add(this.lblCliente);
            this.pag_Info.Controls.Add(this.label2);
            this.pag_Info.Controls.Add(this.lblOrdine);
            this.pag_Info.Location = new System.Drawing.Point(4, 22);
            this.pag_Info.Name = "pag_Info";
            this.pag_Info.Padding = new System.Windows.Forms.Padding(3);
            this.pag_Info.Size = new System.Drawing.Size(1513, 564);
            this.pag_Info.TabIndex = 1;
            this.pag_Info.Text = "INFO";
            this.pag_Info.UseVisualStyleBackColor = true;
            // 
            // lblOrdine
            // 
            this.lblOrdine.AutoSize = true;
            this.lblOrdine.Location = new System.Drawing.Point(38, 68);
            this.lblOrdine.Name = "lblOrdine";
            this.lblOrdine.Size = new System.Drawing.Size(91, 13);
            this.lblOrdine.TabIndex = 0;
            this.lblOrdine.Text = "Numero ordine -->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(38, 122);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente -->";
            // 
            // Prova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 588);
            this.Controls.Add(this.tabControl1);
            this.Name = "Prova";
            this.Text = "Prova";
            this.tabControl1.ResumeLayout(false);
            this.pag_Info.ResumeLayout(false);
            this.pag_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pag_QR;
        private System.Windows.Forms.TabPage pag_Info;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrdine; 
    }
}