namespace YemekBurada
{
    partial class FrmYemekBurada
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
            this.picYemek = new System.Windows.Forms.PictureBox();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.lblMenu = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.rdbYarim = new System.Windows.Forms.RadioButton();
            this.rdbTam = new System.Windows.Forms.RadioButton();
            this.grpEkstra = new System.Windows.Forms.GroupBox();
            this.chbKozdePatlican = new System.Windows.Forms.CheckBox();
            this.chbHardal = new System.Windows.Forms.CheckBox();
            this.chbBarbeku = new System.Windows.Forms.CheckBox();
            this.chbPatates = new System.Windows.Forms.CheckBox();
            this.chbSalatalık = new System.Windows.Forms.CheckBox();
            this.chbDomates = new System.Windows.Forms.CheckBox();
            this.chbTursu = new System.Windows.Forms.CheckBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrcAdet = new System.Windows.Forms.NumericUpDown();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblIcecek = new System.Windows.Forms.Label();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picYemek)).BeginInit();
            this.grpEkstra.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // picYemek
            // 
            this.picYemek.Image = global::YemekBurada.Properties.Resources._1;
            this.picYemek.Location = new System.Drawing.Point(18, 15);
            this.picYemek.Margin = new System.Windows.Forms.Padding(4);
            this.picYemek.Name = "picYemek";
            this.picYemek.Size = new System.Drawing.Size(277, 219);
            this.picYemek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYemek.TabIndex = 0;
            this.picYemek.TabStop = false;
            // 
            // tmrSure
            // 
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(18, 256);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(67, 16);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menüler:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(117, 248);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(177, 24);
            this.cmbMenu.TabIndex = 2;
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoyut.Location = new System.Drawing.Point(18, 335);
            this.lblBoyut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(51, 16);
            this.lblBoyut.TabIndex = 3;
            this.lblBoyut.Text = "Boyut:";
            // 
            // rdbYarim
            // 
            this.rdbYarim.AutoSize = true;
            this.rdbYarim.Location = new System.Drawing.Point(118, 331);
            this.rdbYarim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbYarim.Name = "rdbYarim";
            this.rdbYarim.Size = new System.Drawing.Size(66, 20);
            this.rdbYarim.TabIndex = 4;
            this.rdbYarim.TabStop = true;
            this.rdbYarim.Text = "Yarım";
            this.rdbYarim.UseVisualStyleBackColor = true;
            // 
            // rdbTam
            // 
            this.rdbTam.AutoSize = true;
            this.rdbTam.Location = new System.Drawing.Point(218, 331);
            this.rdbTam.Name = "rdbTam";
            this.rdbTam.Size = new System.Drawing.Size(57, 20);
            this.rdbTam.TabIndex = 5;
            this.rdbTam.TabStop = true;
            this.rdbTam.Text = "Tam";
            this.rdbTam.UseVisualStyleBackColor = true;
            // 
            // grpEkstra
            // 
            this.grpEkstra.Controls.Add(this.chbKozdePatlican);
            this.grpEkstra.Controls.Add(this.chbHardal);
            this.grpEkstra.Controls.Add(this.chbBarbeku);
            this.grpEkstra.Controls.Add(this.chbPatates);
            this.grpEkstra.Controls.Add(this.chbSalatalık);
            this.grpEkstra.Controls.Add(this.chbDomates);
            this.grpEkstra.Controls.Add(this.chbTursu);
            this.grpEkstra.Location = new System.Drawing.Point(21, 354);
            this.grpEkstra.Name = "grpEkstra";
            this.grpEkstra.Size = new System.Drawing.Size(274, 161);
            this.grpEkstra.TabIndex = 6;
            this.grpEkstra.TabStop = false;
            this.grpEkstra.Text = "Ekstralar";
            // 
            // chbKozdePatlican
            // 
            this.chbKozdePatlican.AutoSize = true;
            this.chbKozdePatlican.Location = new System.Drawing.Point(47, 131);
            this.chbKozdePatlican.Name = "chbKozdePatlican";
            this.chbKozdePatlican.Size = new System.Drawing.Size(130, 20);
            this.chbKozdePatlican.TabIndex = 6;
            this.chbKozdePatlican.Text = "Közde Patlıcan";
            this.chbKozdePatlican.UseVisualStyleBackColor = true;
            // 
            // chbHardal
            // 
            this.chbHardal.AutoSize = true;
            this.chbHardal.Location = new System.Drawing.Point(127, 102);
            this.chbHardal.Name = "chbHardal";
            this.chbHardal.Size = new System.Drawing.Size(74, 20);
            this.chbHardal.TabIndex = 5;
            this.chbHardal.Text = "Hardal";
            this.chbHardal.UseVisualStyleBackColor = true;
            // 
            // chbBarbeku
            // 
            this.chbBarbeku.AutoSize = true;
            this.chbBarbeku.Location = new System.Drawing.Point(127, 66);
            this.chbBarbeku.Name = "chbBarbeku";
            this.chbBarbeku.Size = new System.Drawing.Size(85, 20);
            this.chbBarbeku.TabIndex = 4;
            this.chbBarbeku.Text = "Barbekü";
            this.chbBarbeku.UseVisualStyleBackColor = true;
            // 
            // chbPatates
            // 
            this.chbPatates.AutoSize = true;
            this.chbPatates.Location = new System.Drawing.Point(127, 31);
            this.chbPatates.Name = "chbPatates";
            this.chbPatates.Size = new System.Drawing.Size(80, 20);
            this.chbPatates.TabIndex = 3;
            this.chbPatates.Text = "Patates";
            this.chbPatates.UseVisualStyleBackColor = true;
            // 
            // chbSalatalık
            // 
            this.chbSalatalık.AutoSize = true;
            this.chbSalatalık.Location = new System.Drawing.Point(5, 102);
            this.chbSalatalık.Name = "chbSalatalık";
            this.chbSalatalık.Size = new System.Drawing.Size(88, 20);
            this.chbSalatalık.TabIndex = 2;
            this.chbSalatalık.Text = "Salatalık";
            this.chbSalatalık.UseVisualStyleBackColor = true;
            // 
            // chbDomates
            // 
            this.chbDomates.AutoSize = true;
            this.chbDomates.Location = new System.Drawing.Point(5, 66);
            this.chbDomates.Name = "chbDomates";
            this.chbDomates.Size = new System.Drawing.Size(89, 20);
            this.chbDomates.TabIndex = 1;
            this.chbDomates.Text = "Domates";
            this.chbDomates.UseVisualStyleBackColor = true;
            // 
            // chbTursu
            // 
            this.chbTursu.AutoSize = true;
            this.chbTursu.Location = new System.Drawing.Point(6, 31);
            this.chbTursu.Name = "chbTursu";
            this.chbTursu.Size = new System.Drawing.Size(66, 20);
            this.chbTursu.TabIndex = 0;
            this.chbTursu.Text = "Turşu";
            this.chbTursu.UseVisualStyleBackColor = true;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.BackColor = System.Drawing.Color.DarkGray;
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.HorizontalExtent = 900;
            this.lstSiparisler.HorizontalScrollbar = true;
            this.lstSiparisler.ItemHeight = 15;
            this.lstSiparisler.Location = new System.Drawing.Point(318, 15);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstSiparisler.Size = new System.Drawing.Size(355, 289);
            this.lstSiparisler.TabIndex = 7;
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnSiparisTamamla);
            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Controls.Add(this.btnHesapla);
            this.grpIslemler.Controls.Add(this.txtTutar);
            this.grpIslemler.Controls.Add(this.label1);
            this.grpIslemler.Controls.Add(this.nmrcAdet);
            this.grpIslemler.Controls.Add(this.lblAdet);
            this.grpIslemler.Location = new System.Drawing.Point(343, 354);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(305, 161);
            this.grpIslemler.TabIndex = 8;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(210, 21);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(89, 130);
            this.btnSiparisTamamla.TabIndex = 6;
            this.btnSiparisTamamla.Text = "Sipariş Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(106, 115);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 36);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(18, 115);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 36);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(81, 66);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar :";
            // 
            // nmrcAdet
            // 
            this.nmrcAdet.Location = new System.Drawing.Point(81, 25);
            this.nmrcAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcAdet.Name = "nmrcAdet";
            this.nmrcAdet.Size = new System.Drawing.Size(100, 22);
            this.nmrcAdet.TabIndex = 1;
            this.nmrcAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(15, 31);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(48, 16);
            this.lblAdet.TabIndex = 0;
            this.lblAdet.Text = "Adet :";
            // 
            // lblIcecek
            // 
            this.lblIcecek.AutoSize = true;
            this.lblIcecek.Location = new System.Drawing.Point(15, 304);
            this.lblIcecek.Name = "lblIcecek";
            this.lblIcecek.Size = new System.Drawing.Size(62, 16);
            this.lblIcecek.TabIndex = 9;
            this.lblIcecek.Text = "İçecek :";
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Location = new System.Drawing.Point(118, 296);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(176, 24);
            this.cmbIcecek.TabIndex = 10;
            // 
            // FrmYemekBurada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(685, 561);
            this.Controls.Add(this.cmbIcecek);
            this.Controls.Add(this.lblIcecek);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.grpEkstra);
            this.Controls.Add(this.rdbTam);
            this.Controls.Add(this.rdbYarim);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.picYemek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmYemekBurada";
            this.Text = "Yemek Burada";
            this.Load += new System.EventHandler(this.FrmYemekBurada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picYemek)).EndInit();
            this.grpEkstra.ResumeLayout(false);
            this.grpEkstra.PerformLayout();
            this.grpIslemler.ResumeLayout(false);
            this.grpIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picYemek;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.RadioButton rdbYarim;
        private System.Windows.Forms.RadioButton rdbTam;
        private System.Windows.Forms.GroupBox grpEkstra;
        private System.Windows.Forms.CheckBox chbHardal;
        private System.Windows.Forms.CheckBox chbBarbeku;
        private System.Windows.Forms.CheckBox chbPatates;
        private System.Windows.Forms.CheckBox chbSalatalık;
        private System.Windows.Forms.CheckBox chbDomates;
        private System.Windows.Forms.CheckBox chbTursu;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrcAdet;
        private System.Windows.Forms.CheckBox chbKozdePatlican;
        private System.Windows.Forms.Label lblIcecek;
        private System.Windows.Forms.ComboBox cmbIcecek;
    }
}

