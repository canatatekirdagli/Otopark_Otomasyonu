namespace Otopark_Otomasyonu
{
    partial class KayıtlıKullanıcıSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtlıKullanıcıSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kayitli_kullanici_sil = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.geri_don = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.kayitli_kullanici_sil);
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(376, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sililinicek Kişi Bilgileri";
            // 
            // kayitli_kullanici_sil
            // 
            this.kayitli_kullanici_sil.BackColor = System.Drawing.Color.Navy;
            this.kayitli_kullanici_sil.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitli_kullanici_sil.ForeColor = System.Drawing.SystemColors.Control;
            this.kayitli_kullanici_sil.Location = new System.Drawing.Point(253, 118);
            this.kayitli_kullanici_sil.Name = "kayitli_kullanici_sil";
            this.kayitli_kullanici_sil.Size = new System.Drawing.Size(212, 73);
            this.kayitli_kullanici_sil.TabIndex = 1;
            this.kayitli_kullanici_sil.Text = "Kayıtlı Kullanıcıyı Sil";
            this.kayitli_kullanici_sil.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik No :";
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Navy;
            this.geri_don.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_don.ForeColor = System.Drawing.SystemColors.Control;
            this.geri_don.Location = new System.Drawing.Point(947, 462);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(213, 69);
            this.geri_don.TabIndex = 2;
            this.geri_don.Text = "Geri Dön";
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.button8_Click);
            // 
            // KayıtlıKullanıcıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 594);
            this.ControlBox = false;
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "KayıtlıKullanıcıSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYITLI KULLANICI SİL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kayitli_kullanici_sil;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri_don;
    }
}