
namespace OSİTEM_OTEL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttongirs = new System.Windows.Forms.Button();
            this.buttonkayıt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.textKullanici = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonygiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textYSifre = new System.Windows.Forms.TextBox();
            this.textYKullanici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OSİTEM_OTEL.Properties.Resources.OSTİM_PARK_OTEL;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(71, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 221);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 268);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage1.Controls.Add(this.buttongirs);
            this.tabPage1.Controls.Add(this.buttonkayıt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textSifre);
            this.tabPage1.Controls.Add(this.textKullanici);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(436, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Girişi";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttongirs
            // 
            this.buttongirs.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttongirs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttongirs.Location = new System.Drawing.Point(212, 170);
            this.buttongirs.Margin = new System.Windows.Forms.Padding(4);
            this.buttongirs.Name = "buttongirs";
            this.buttongirs.Size = new System.Drawing.Size(85, 36);
            this.buttongirs.TabIndex = 8;
            this.buttongirs.Text = "Giriş";
            this.buttongirs.UseVisualStyleBackColor = false;
            this.buttongirs.Click += new System.EventHandler(this.buttongirs_Click);
            // 
            // buttonkayıt
            // 
            this.buttonkayıt.BackColor = System.Drawing.Color.Aqua;
            this.buttonkayıt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonkayıt.Location = new System.Drawing.Point(24, 170);
            this.buttonkayıt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkayıt.Name = "buttonkayıt";
            this.buttonkayıt.Size = new System.Drawing.Size(92, 36);
            this.buttonkayıt.TabIndex = 7;
            this.buttonkayıt.Text = "Kayıt Ol";
            this.buttonkayıt.UseVisualStyleBackColor = false;
            this.buttonkayıt.Click += new System.EventHandler(this.buttonkayıt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(90, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tc Kimlik No :";
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(155, 110);
            this.textSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textSifre.Name = "textSifre";
            this.textSifre.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(203, 31);
            this.textSifre.TabIndex = 2;
            // 
            // textKullanici
            // 
            this.textKullanici.Location = new System.Drawing.Point(155, 48);
            this.textKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.textKullanici.Name = "textKullanici";
            this.textKullanici.Size = new System.Drawing.Size(203, 31);
            this.textKullanici.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Crimson;
            this.tabPage2.Controls.Add(this.buttonygiris);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textYSifre);
            this.tabPage2.Controls.Add(this.textYKullanici);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(436, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yetkili Girişi";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonygiris
            // 
            this.buttonygiris.BackColor = System.Drawing.Color.Brown;
            this.buttonygiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonygiris.Location = new System.Drawing.Point(182, 171);
            this.buttonygiris.Margin = new System.Windows.Forms.Padding(4);
            this.buttonygiris.Name = "buttonygiris";
            this.buttonygiris.Size = new System.Drawing.Size(118, 42);
            this.buttonygiris.TabIndex = 5;
            this.buttonygiris.Text = "Giriş";
            this.buttonygiris.UseVisualStyleBackColor = false;
            this.buttonygiris.Click += new System.EventHandler(this.buttonygiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(99, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(32, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // textYSifre
            // 
            this.textYSifre.Location = new System.Drawing.Point(161, 130);
            this.textYSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textYSifre.Name = "textYSifre";
            this.textYSifre.PasswordChar = '*';
            this.textYSifre.Size = new System.Drawing.Size(203, 31);
            this.textYSifre.TabIndex = 2;
            // 
            // textYKullanici
            // 
            this.textYKullanici.Location = new System.Drawing.Point(161, 55);
            this.textYKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.textYKullanici.Name = "textYKullanici";
            this.textYKullanici.Size = new System.Drawing.Size(203, 31);
            this.textYKullanici.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ostim Park Otel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttongirs;
        private System.Windows.Forms.Button buttonkayıt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.TextBox textKullanici;
        private System.Windows.Forms.Button buttonygiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textYSifre;
        private System.Windows.Forms.TextBox textYKullanici;
    }
}

