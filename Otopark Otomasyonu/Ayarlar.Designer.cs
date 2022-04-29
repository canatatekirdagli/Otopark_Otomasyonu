namespace Otopark_Otomasyonu
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.sifre_degistir = new System.Windows.Forms.Button();
            this.kullanici_ekle = new System.Windows.Forms.Button();
            this.kullanici_sil = new System.Windows.Forms.Button();
            this.geri_don = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifre_degistir
            // 
            this.sifre_degistir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifre_degistir.BackColor = System.Drawing.Color.Navy;
            this.sifre_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sifre_degistir.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_degistir.ForeColor = System.Drawing.Color.White;
            this.sifre_degistir.Location = new System.Drawing.Point(474, 134);
            this.sifre_degistir.Name = "sifre_degistir";
            this.sifre_degistir.Size = new System.Drawing.Size(334, 73);
            this.sifre_degistir.TabIndex = 0;
            this.sifre_degistir.Text = "Şifre Değiştir";
            this.sifre_degistir.UseVisualStyleBackColor = false;
            this.sifre_degistir.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanici_ekle
            // 
            this.kullanici_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanici_ekle.BackColor = System.Drawing.Color.Navy;
            this.kullanici_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kullanici_ekle.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_ekle.ForeColor = System.Drawing.Color.White;
            this.kullanici_ekle.Location = new System.Drawing.Point(474, 234);
            this.kullanici_ekle.Name = "kullanici_ekle";
            this.kullanici_ekle.Size = new System.Drawing.Size(334, 73);
            this.kullanici_ekle.TabIndex = 1;
            this.kullanici_ekle.Text = "Kullanıcı Ekle";
            this.kullanici_ekle.UseVisualStyleBackColor = false;
            this.kullanici_ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullanici_sil
            // 
            this.kullanici_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanici_sil.BackColor = System.Drawing.Color.Navy;
            this.kullanici_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kullanici_sil.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_sil.ForeColor = System.Drawing.Color.White;
            this.kullanici_sil.Location = new System.Drawing.Point(474, 334);
            this.kullanici_sil.Name = "kullanici_sil";
            this.kullanici_sil.Size = new System.Drawing.Size(334, 73);
            this.kullanici_sil.TabIndex = 2;
            this.kullanici_sil.Text = "Kullanıcı Sil";
            this.kullanici_sil.UseVisualStyleBackColor = false;
            this.kullanici_sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Navy;
            this.geri_don.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_don.ForeColor = System.Drawing.SystemColors.Control;
            this.geri_don.Location = new System.Drawing.Point(946, 458);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(213, 69);
            this.geri_don.TabIndex = 3;
            this.geri_don.Text = "Geri Dön";
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.button8_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 594);
            this.ControlBox = false;
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.kullanici_sil);
            this.Controls.Add(this.sifre_degistir);
            this.Controls.Add(this.kullanici_ekle);
            this.MaximizeBox = false;
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYARLAR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifre_degistir;
        private System.Windows.Forms.Button kullanici_ekle;
        private System.Windows.Forms.Button kullanici_sil;
        private System.Windows.Forms.Button geri_don;
    }
}