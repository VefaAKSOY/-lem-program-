namespace İşlem_programı
{
    partial class frmHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesaplama));
            this.tbcIşlemler = new System.Windows.Forms.TabControl();
            this.tbpTekSayi = new System.Windows.Forms.TabPage();
            this.lsvTekSayilar = new System.Windows.Forms.ListView();
            this.tbpCiftSayi = new System.Windows.Forms.TabPage();
            this.lsvCiftSayilar = new System.Windows.Forms.ListView();
            this.tbpAsalSayilar = new System.Windows.Forms.TabPage();
            this.lsvAsalSayilar = new System.Windows.Forms.ListView();
            this.tbpArmstrongSayilari = new System.Windows.Forms.TabPage();
            this.lsvArmstrongSayilari = new System.Windows.Forms.ListView();
            this.grpSayiEkrani = new System.Windows.Forms.GroupBox();
            this.mtbIkinciSayi = new System.Windows.Forms.MaskedTextBox();
            this.mtbIlkSayi = new System.Windows.Forms.MaskedTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.lblIlkSayi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.ntfBildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbcIşlemler.SuspendLayout();
            this.tbpTekSayi.SuspendLayout();
            this.tbpCiftSayi.SuspendLayout();
            this.tbpAsalSayilar.SuspendLayout();
            this.tbpArmstrongSayilari.SuspendLayout();
            this.grpSayiEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcIşlemler
            // 
            this.tbcIşlemler.Controls.Add(this.tbpTekSayi);
            this.tbcIşlemler.Controls.Add(this.tbpCiftSayi);
            this.tbcIşlemler.Controls.Add(this.tbpAsalSayilar);
            this.tbcIşlemler.Controls.Add(this.tbpArmstrongSayilari);
            this.tbcIşlemler.Location = new System.Drawing.Point(16, 101);
            this.tbcIşlemler.Name = "tbcIşlemler";
            this.tbcIşlemler.SelectedIndex = 0;
            this.tbcIşlemler.Size = new System.Drawing.Size(641, 322);
            this.tbcIşlemler.TabIndex = 5;
            // 
            // tbpTekSayi
            // 
            this.tbpTekSayi.Controls.Add(this.lsvTekSayilar);
            this.tbpTekSayi.Location = new System.Drawing.Point(4, 25);
            this.tbpTekSayi.Name = "tbpTekSayi";
            this.tbpTekSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTekSayi.Size = new System.Drawing.Size(633, 293);
            this.tbpTekSayi.TabIndex = 0;
            this.tbpTekSayi.Text = "Tek Sayılar";
            this.tbpTekSayi.UseVisualStyleBackColor = true;
            // 
            // lsvTekSayilar
            // 
            this.lsvTekSayilar.HideSelection = false;
            this.lsvTekSayilar.Location = new System.Drawing.Point(3, 0);
            this.lsvTekSayilar.Name = "lsvTekSayilar";
            this.lsvTekSayilar.Size = new System.Drawing.Size(624, 290);
            this.lsvTekSayilar.TabIndex = 0;
            this.lsvTekSayilar.UseCompatibleStateImageBehavior = false;
            this.lsvTekSayilar.View = System.Windows.Forms.View.SmallIcon;
            // 
            // tbpCiftSayi
            // 
            this.tbpCiftSayi.Controls.Add(this.lsvCiftSayilar);
            this.tbpCiftSayi.Location = new System.Drawing.Point(4, 25);
            this.tbpCiftSayi.Name = "tbpCiftSayi";
            this.tbpCiftSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCiftSayi.Size = new System.Drawing.Size(633, 293);
            this.tbpCiftSayi.TabIndex = 1;
            this.tbpCiftSayi.Text = "Çift Sayılar";
            this.tbpCiftSayi.UseVisualStyleBackColor = true;
            // 
            // lsvCiftSayilar
            // 
            this.lsvCiftSayilar.HideSelection = false;
            this.lsvCiftSayilar.Location = new System.Drawing.Point(0, 6);
            this.lsvCiftSayilar.Name = "lsvCiftSayilar";
            this.lsvCiftSayilar.Size = new System.Drawing.Size(627, 284);
            this.lsvCiftSayilar.TabIndex = 0;
            this.lsvCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.lsvCiftSayilar.View = System.Windows.Forms.View.SmallIcon;
            // 
            // tbpAsalSayilar
            // 
            this.tbpAsalSayilar.Controls.Add(this.lsvAsalSayilar);
            this.tbpAsalSayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpAsalSayilar.Name = "tbpAsalSayilar";
            this.tbpAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsalSayilar.Size = new System.Drawing.Size(633, 293);
            this.tbpAsalSayilar.TabIndex = 2;
            this.tbpAsalSayilar.Text = "Asal Sayılar";
            this.tbpAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // lsvAsalSayilar
            // 
            this.lsvAsalSayilar.HideSelection = false;
            this.lsvAsalSayilar.Location = new System.Drawing.Point(6, 6);
            this.lsvAsalSayilar.Name = "lsvAsalSayilar";
            this.lsvAsalSayilar.Size = new System.Drawing.Size(621, 284);
            this.lsvAsalSayilar.TabIndex = 0;
            this.lsvAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.lsvAsalSayilar.View = System.Windows.Forms.View.SmallIcon;
            // 
            // tbpArmstrongSayilari
            // 
            this.tbpArmstrongSayilari.Controls.Add(this.lsvArmstrongSayilari);
            this.tbpArmstrongSayilari.Location = new System.Drawing.Point(4, 25);
            this.tbpArmstrongSayilari.Name = "tbpArmstrongSayilari";
            this.tbpArmstrongSayilari.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArmstrongSayilari.Size = new System.Drawing.Size(633, 293);
            this.tbpArmstrongSayilari.TabIndex = 3;
            this.tbpArmstrongSayilari.Text = "Armstrong Sayıları";
            this.tbpArmstrongSayilari.UseVisualStyleBackColor = true;
            // 
            // lsvArmstrongSayilari
            // 
            this.lsvArmstrongSayilari.HideSelection = false;
            this.lsvArmstrongSayilari.Location = new System.Drawing.Point(6, 6);
            this.lsvArmstrongSayilari.Name = "lsvArmstrongSayilari";
            this.lsvArmstrongSayilari.Size = new System.Drawing.Size(624, 281);
            this.lsvArmstrongSayilari.TabIndex = 0;
            this.lsvArmstrongSayilari.UseCompatibleStateImageBehavior = false;
            this.lsvArmstrongSayilari.View = System.Windows.Forms.View.SmallIcon;
            // 
            // grpSayiEkrani
            // 
            this.grpSayiEkrani.Controls.Add(this.btnGeri);
            this.grpSayiEkrani.Controls.Add(this.btnİleri);
            this.grpSayiEkrani.Controls.Add(this.mtbIkinciSayi);
            this.grpSayiEkrani.Controls.Add(this.mtbIlkSayi);
            this.grpSayiEkrani.Controls.Add(this.btnHesapla);
            this.grpSayiEkrani.Controls.Add(this.lblIkinciSayi);
            this.grpSayiEkrani.Controls.Add(this.lblIlkSayi);
            this.grpSayiEkrani.Location = new System.Drawing.Point(12, 12);
            this.grpSayiEkrani.Name = "grpSayiEkrani";
            this.grpSayiEkrani.Size = new System.Drawing.Size(645, 83);
            this.grpSayiEkrani.TabIndex = 5;
            this.grpSayiEkrani.TabStop = false;
            this.grpSayiEkrani.Text = "Sayı Girişi";
            // 
            // mtbIkinciSayi
            // 
            this.mtbIkinciSayi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbIkinciSayi.Location = new System.Drawing.Point(77, 54);
            this.mtbIkinciSayi.Mask = "00000";
            this.mtbIkinciSayi.Name = "mtbIkinciSayi";
            this.mtbIkinciSayi.Size = new System.Drawing.Size(100, 15);
            this.mtbIkinciSayi.TabIndex = 7;
            this.mtbIkinciSayi.Tag = "";
            this.mtbIkinciSayi.Text = "10000";
            this.mtbIkinciSayi.ValidatingType = typeof(int);
            // 
            // mtbIlkSayi
            // 
            this.mtbIlkSayi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbIlkSayi.Location = new System.Drawing.Point(77, 25);
            this.mtbIlkSayi.Mask = "0000";
            this.mtbIlkSayi.Name = "mtbIlkSayi";
            this.mtbIlkSayi.Size = new System.Drawing.Size(100, 15);
            this.mtbIlkSayi.TabIndex = 6;
            this.mtbIlkSayi.Tag = "";
            this.mtbIlkSayi.Text = "1";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(199, 28);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.Location = new System.Drawing.Point(1, 56);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(70, 17);
            this.lblIkinciSayi.TabIndex = 4;
            this.lblIkinciSayi.Text = "İkinci Sayi";
            // 
            // lblIlkSayi
            // 
            this.lblIlkSayi.AutoSize = true;
            this.lblIlkSayi.Location = new System.Drawing.Point(1, 28);
            this.lblIlkSayi.Name = "lblIlkSayi";
            this.lblIlkSayi.Size = new System.Drawing.Size(52, 17);
            this.lblIlkSayi.TabIndex = 1;
            this.lblIlkSayi.Text = "İlk Sayi";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(382, 28);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(79, 23);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(482, 28);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(79, 23);
            this.btnİleri.TabIndex = 9;
            this.btnİleri.Text = "İleri>>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // ntfBildirim
            // 
            this.ntfBildirim.BalloonTipText = "Uygulamaya Hoşgeldiniz";
            this.ntfBildirim.BalloonTipTitle = "Bakırçay Üniversitesi Ödev";
            this.ntfBildirim.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfBildirim.Icon")));
            this.ntfBildirim.Text = "Uygulamaya Hoşgeldiniz";
            this.ntfBildirim.Visible = true;
            // 
            // frmHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 435);
            this.Controls.Add(this.grpSayiEkrani);
            this.Controls.Add(this.tbcIşlemler);
            this.Name = "frmHesaplama";
            this.Text = "Hesaplama Programı";
            this.Shown += new System.EventHandler(this.frmHesaplama_Shown);
            this.tbcIşlemler.ResumeLayout(false);
            this.tbpTekSayi.ResumeLayout(false);
            this.tbpCiftSayi.ResumeLayout(false);
            this.tbpAsalSayilar.ResumeLayout(false);
            this.tbpArmstrongSayilari.ResumeLayout(false);
            this.grpSayiEkrani.ResumeLayout(false);
            this.grpSayiEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcIşlemler;
        private System.Windows.Forms.TabPage tbpCiftSayi;
        private System.Windows.Forms.TabPage tbpTekSayi;
        private System.Windows.Forms.GroupBox grpSayiEkrani;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.Label lblIlkSayi;
        private System.Windows.Forms.ListView lsvCiftSayilar;
        private System.Windows.Forms.ListView lsvTekSayilar;
        private System.Windows.Forms.TabPage tbpAsalSayilar;
        private System.Windows.Forms.TabPage tbpArmstrongSayilari;
        private System.Windows.Forms.ListView lsvAsalSayilar;
        private System.Windows.Forms.ListView lsvArmstrongSayilari;
        private System.Windows.Forms.MaskedTextBox mtbIkinciSayi;
        private System.Windows.Forms.MaskedTextBox mtbIlkSayi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.NotifyIcon ntfBildirim;
    }
}

