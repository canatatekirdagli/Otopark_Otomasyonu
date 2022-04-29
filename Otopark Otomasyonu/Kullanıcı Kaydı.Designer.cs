namespace Otopark_Otomasyonu
{
    partial class Kullanıcı_Kaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcı_Kaydı));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marka_ekle = new System.Windows.Forms.Button();
            this.park_yeri = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.renk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.plaka = new System.Windows.Forms.TextBox();
            this.kayit = new System.Windows.Forms.Button();
            this.geri_don = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.soyad);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(133, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(253, 221);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(212, 34);
            this.telefon.TabIndex = 3;
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(253, 45);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(212, 34);
            this.tc.TabIndex = 0;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(253, 286);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 34);
            this.email.TabIndex = 4;
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(253, 161);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(212, 34);
            this.soyad.TabIndex = 2;
            // 
            // ad
            // 
            this.ad.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(253, 101);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(212, 34);
            this.ad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(109, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik No :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.marka_ekle);
            this.groupBox2.Controls.Add(this.park_yeri);
            this.groupBox2.Controls.Add(this.marka);
            this.groupBox2.Controls.Add(this.renk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.plaka);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(716, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // marka_ekle
            // 
            this.marka_ekle.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marka_ekle.Location = new System.Drawing.Point(443, 143);
            this.marka_ekle.Name = "marka_ekle";
            this.marka_ekle.Size = new System.Drawing.Size(39, 38);
            this.marka_ekle.TabIndex = 7;
            this.marka_ekle.Text = "+";
            this.marka_ekle.UseVisualStyleBackColor = true;
            this.marka_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // park_yeri
            // 
            this.park_yeri.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.park_yeri.FormattingEnabled = true;
            this.park_yeri.Location = new System.Drawing.Point(246, 259);
            this.park_yeri.Name = "park_yeri";
            this.park_yeri.Size = new System.Drawing.Size(183, 38);
            this.park_yeri.TabIndex = 9;
            // 
            // marka
            // 
            this.marka.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(246, 143);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(183, 38);
            this.marka.TabIndex = 6;
            // 
            // renk
            // 
            this.renk.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renk.Location = new System.Drawing.Point(246, 199);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(183, 34);
            this.renk.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(139, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Renk :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Park Yeri :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(126, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marka :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(126, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Plaka :";
            // 
            // plaka
            // 
            this.plaka.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plaka.Location = new System.Drawing.Point(246, 79);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(183, 34);
            this.plaka.TabIndex = 5;
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.Navy;
            this.kayit.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit.ForeColor = System.Drawing.SystemColors.Control;
            this.kayit.Location = new System.Drawing.Point(391, 472);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(213, 69);
            this.kayit.TabIndex = 10;
            this.kayit.Text = "Kayıt";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.button2_Click);
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Navy;
            this.geri_don.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_don.ForeColor = System.Drawing.SystemColors.Control;
            this.geri_don.Location = new System.Drawing.Point(716, 472);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(213, 69);
            this.geri_don.TabIndex = 11;
            this.geri_don.Text = "Geri Dön";
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.button10_Click);
            // 
            // Kullanıcı_Kaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 594);
            this.ControlBox = false;
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Kullanıcı_Kaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI KAYDI";
            this.Load += new System.EventHandler(this.Kullanıcı_Kaydı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button marka_ekle;
        private System.Windows.Forms.ComboBox park_yeri;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.TextBox renk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox plaka;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button geri_don;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.MaskedTextBox tc;
    }
}