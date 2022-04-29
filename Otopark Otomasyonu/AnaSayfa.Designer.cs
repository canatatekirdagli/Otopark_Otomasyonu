namespace Otopark_Otomasyonu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.kayitli_arac_giris = new System.Windows.Forms.Button();
            this.arac_cikis = new System.Windows.Forms.Button();
            this.kullanici_kaydi = new System.Windows.Forms.Button();
            this.otopark_durumu = new System.Windows.Forms.Button();
            this.tarih_saat = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Label();
            this.kayitli_kullanici_sil = new System.Windows.Forms.Button();
            this.ayarlar = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.oturum_kapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ayarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oturum_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // kayitli_arac_giris
            // 
            this.kayitli_arac_giris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kayitli_arac_giris.BackColor = System.Drawing.Color.Navy;
            this.kayitli_arac_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitli_arac_giris.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitli_arac_giris.ForeColor = System.Drawing.Color.White;
            this.kayitli_arac_giris.Location = new System.Drawing.Point(492, 67);
            this.kayitli_arac_giris.Name = "kayitli_arac_giris";
            this.kayitli_arac_giris.Size = new System.Drawing.Size(334, 73);
            this.kayitli_arac_giris.TabIndex = 0;
            this.kayitli_arac_giris.Text = "Kayıtlı Araç Giriş";
            this.kayitli_arac_giris.UseVisualStyleBackColor = false;
            this.kayitli_arac_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // arac_cikis
            // 
            this.arac_cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arac_cikis.BackColor = System.Drawing.Color.Navy;
            this.arac_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.arac_cikis.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arac_cikis.ForeColor = System.Drawing.Color.White;
            this.arac_cikis.Location = new System.Drawing.Point(492, 162);
            this.arac_cikis.Name = "arac_cikis";
            this.arac_cikis.Size = new System.Drawing.Size(334, 73);
            this.arac_cikis.TabIndex = 1;
            this.arac_cikis.Text = "Araç Çıkış";
            this.arac_cikis.UseVisualStyleBackColor = false;
            this.arac_cikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullanici_kaydi
            // 
            this.kullanici_kaydi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanici_kaydi.BackColor = System.Drawing.Color.Navy;
            this.kullanici_kaydi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kullanici_kaydi.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_kaydi.ForeColor = System.Drawing.Color.White;
            this.kullanici_kaydi.Location = new System.Drawing.Point(492, 262);
            this.kullanici_kaydi.Name = "kullanici_kaydi";
            this.kullanici_kaydi.Size = new System.Drawing.Size(334, 73);
            this.kullanici_kaydi.TabIndex = 2;
            this.kullanici_kaydi.Text = "Kullanıcı Kaydı";
            this.kullanici_kaydi.UseVisualStyleBackColor = false;
            this.kullanici_kaydi.Click += new System.EventHandler(this.button3_Click);
            // 
            // otopark_durumu
            // 
            this.otopark_durumu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otopark_durumu.BackColor = System.Drawing.Color.Navy;
            this.otopark_durumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otopark_durumu.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otopark_durumu.ForeColor = System.Drawing.Color.White;
            this.otopark_durumu.Location = new System.Drawing.Point(492, 362);
            this.otopark_durumu.Name = "otopark_durumu";
            this.otopark_durumu.Size = new System.Drawing.Size(334, 73);
            this.otopark_durumu.TabIndex = 3;
            this.otopark_durumu.Text = "Otopark Durumu";
            this.otopark_durumu.UseVisualStyleBackColor = false;
            this.otopark_durumu.Click += new System.EventHandler(this.button4_Click);
            // 
            // tarih_saat
            // 
            this.tarih_saat.AutoSize = true;
            this.tarih_saat.BackColor = System.Drawing.Color.Navy;
            this.tarih_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarih_saat.ForeColor = System.Drawing.SystemColors.Control;
            this.tarih_saat.Location = new System.Drawing.Point(99, 87);
            this.tarih_saat.Name = "tarih_saat";
            this.tarih_saat.Size = new System.Drawing.Size(92, 32);
            this.tarih_saat.TabIndex = 6;
            this.tarih_saat.Text = "label2";
            this.tarih_saat.Click += new System.EventHandler(this.dateTimeLabel_Click);
            // 
            // cikis
            // 
            this.cikis.AutoSize = true;
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.Font = new System.Drawing.Font("Cascadia Mono", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.White;
            this.cikis.Location = new System.Drawing.Point(1218, 20);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(50, 57);
            this.cikis.TabIndex = 7;
            this.cikis.Text = "X";
            this.cikis.Click += new System.EventHandler(this.label1_Click);
            // 
            // kayitli_kullanici_sil
            // 
            this.kayitli_kullanici_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kayitli_kullanici_sil.BackColor = System.Drawing.Color.Navy;
            this.kayitli_kullanici_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitli_kullanici_sil.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitli_kullanici_sil.ForeColor = System.Drawing.Color.White;
            this.kayitli_kullanici_sil.Location = new System.Drawing.Point(492, 462);
            this.kayitli_kullanici_sil.Name = "kayitli_kullanici_sil";
            this.kayitli_kullanici_sil.Size = new System.Drawing.Size(334, 73);
            this.kayitli_kullanici_sil.TabIndex = 4;
            this.kayitli_kullanici_sil.Text = "Kayıtlı Kullanıcı Sil";
            this.kayitli_kullanici_sil.UseVisualStyleBackColor = false;
            this.kayitli_kullanici_sil.Click += new System.EventHandler(this.button5_Click);
            // 
            // ayarlar
            // 
            this.ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.ayarlar.Image = ((System.Drawing.Image)(resources.GetObject("ayarlar.Image")));
            this.ayarlar.Location = new System.Drawing.Point(1108, 422);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(160, 160);
            this.ayarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayarlar.TabIndex = 9;
            this.ayarlar.TabStop = false;
            this.ayarlar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // oturum_kapat
            // 
            this.oturum_kapat.BackColor = System.Drawing.Color.Transparent;
            this.oturum_kapat.Image = ((System.Drawing.Image)(resources.GetObject("oturum_kapat.Image")));
            this.oturum_kapat.Location = new System.Drawing.Point(55, 447);
            this.oturum_kapat.Name = "oturum_kapat";
            this.oturum_kapat.Size = new System.Drawing.Size(119, 120);
            this.oturum_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oturum_kapat.TabIndex = 10;
            this.oturum_kapat.TabStop = false;
            this.oturum_kapat.Click += new System.EventHandler(this.oturum_kapat_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 579);
            this.ControlBox = false;
            this.Controls.Add(this.oturum_kapat);
            this.Controls.Add(this.ayarlar);
            this.Controls.Add(this.kayitli_kullanici_sil);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.tarih_saat);
            this.Controls.Add(this.otopark_durumu);
            this.Controls.Add(this.kullanici_kaydi);
            this.Controls.Add(this.kayitli_arac_giris);
            this.Controls.Add(this.arac_cikis);
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oturum_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitli_arac_giris;
        private System.Windows.Forms.Button arac_cikis;
        private System.Windows.Forms.Button kullanici_kaydi;
        private System.Windows.Forms.Button otopark_durumu;
        private System.Windows.Forms.Label tarih_saat;
        private System.Windows.Forms.Label cikis;
        private System.Windows.Forms.Button kayitli_kullanici_sil;
        private System.Windows.Forms.PictureBox ayarlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox oturum_kapat;
    }
}

