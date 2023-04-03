namespace OOP_Hamburgeci.Forms
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            this.grpbxMalzemeSec = new System.Windows.Forms.GroupBox();
            this.flypnlMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.nmrupAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbxBoyut = new System.Windows.Forms.GroupBox();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.btnMalzemeYenile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpbxMalzemeSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxMalzemeSec
            // 
            this.grpbxMalzemeSec.Controls.Add(this.flypnlMalzeme);
            this.grpbxMalzemeSec.Location = new System.Drawing.Point(13, 352);
            this.grpbxMalzemeSec.Name = "grpbxMalzemeSec";
            this.grpbxMalzemeSec.Size = new System.Drawing.Size(439, 192);
            this.grpbxMalzemeSec.TabIndex = 32;
            this.grpbxMalzemeSec.TabStop = false;
            this.grpbxMalzemeSec.Text = "MALZEME SEÇİN";
            // 
            // flypnlMalzeme
            // 
            this.flypnlMalzeme.Location = new System.Drawing.Point(7, 18);
            this.flypnlMalzeme.Name = "flypnlMalzeme";
            this.flypnlMalzeme.Size = new System.Drawing.Size(434, 142);
            this.flypnlMalzeme.TabIndex = 11;
            // 
            // lblTutar
            // 
            this.lblTutar.ForeColor = System.Drawing.Color.Red;
            this.lblTutar.Location = new System.Drawing.Point(488, 612);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(84, 43);
            this.lblTutar.TabIndex = 31;
            this.lblTutar.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(464, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(468, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(566, 564);
            this.listBox1.TabIndex = 28;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(597, 590);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(266, 60);
            this.btnSiparisTamamla.TabIndex = 27;
            this.btnSiparisTamamla.Text = "SİPARİŞ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(18, 590);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(275, 60);
            this.btnSiparisEkle.TabIndex = 26;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // nmrupAdet
            // 
            this.nmrupAdet.Location = new System.Drawing.Point(94, 550);
            this.nmrupAdet.Name = "nmrupAdet";
            this.nmrupAdet.Size = new System.Drawing.Size(206, 22);
            this.nmrupAdet.TabIndex = 25;
            this.nmrupAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrupAdet.ValueChanged += new System.EventHandler(this.nmrupAdet_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "ADET";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Items.AddRange(new object[] {
            "Big King Menü",
            "Double King Chicken Menü",
            "Steakhouse Menü",
            "Whooper Menü",
            "Whooper Menü",
            "Whooper Jr.Menü",
            "Chicken Royal Menü"});
            this.cmbMenu.Location = new System.Drawing.Point(18, 226);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(434, 24);
            this.cmbMenu.TabIndex = 22;
            this.cmbMenu.SelectedIndexChanged += new System.EventHandler(this.cmbMenu_SelectedIndexChanged);
            this.cmbMenu.Click += new System.EventHandler(this.cmbMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // grpbxBoyut
            // 
            this.grpbxBoyut.Controls.Add(this.rdbBuyuk);
            this.grpbxBoyut.Controls.Add(this.rdbOrta);
            this.grpbxBoyut.Controls.Add(this.rdbKucuk);
            this.grpbxBoyut.Location = new System.Drawing.Point(21, 275);
            this.grpbxBoyut.Name = "grpbxBoyut";
            this.grpbxBoyut.Size = new System.Drawing.Size(434, 60);
            this.grpbxBoyut.TabIndex = 23;
            this.grpbxBoyut.TabStop = false;
            this.grpbxBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(235, 26);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(65, 20);
            this.rdbBuyuk.TabIndex = 2;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Büyük";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            this.rdbBuyuk.CheckedChanged += new System.EventHandler(this.BoyutSecimVeParaları);
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(134, 26);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(53, 20);
            this.rdbOrta.TabIndex = 1;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta";
            this.rdbOrta.UseVisualStyleBackColor = true;
            this.rdbOrta.CheckedChanged += new System.EventHandler(this.BoyutSecimVeParaları);
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Location = new System.Drawing.Point(19, 26);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(64, 20);
            this.rdbKucuk.TabIndex = 0;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Kücük";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            this.rdbKucuk.CheckedChanged += new System.EventHandler(this.BoyutSecimVeParaları);
            // 
            // btnMalzemeYenile
            // 
            this.btnMalzemeYenile.Location = new System.Drawing.Point(306, 550);
            this.btnMalzemeYenile.Name = "btnMalzemeYenile";
            this.btnMalzemeYenile.Size = new System.Drawing.Size(149, 22);
            this.btnMalzemeYenile.TabIndex = 12;
            this.btnMalzemeYenile.Text = "Malzeme Güncelle";
            this.btnMalzemeYenile.UseVisualStyleBackColor = true;
            this.btnMalzemeYenile.Click += new System.EventHandler(this.btnMalzemeYenile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 669);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMalzemeYenile);
            this.Controls.Add(this.grpbxBoyut);
            this.Controls.Add(this.grpbxMalzemeSec);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrupAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SiparisOlustur";
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.grpbxMalzemeSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrupAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxBoyut.ResumeLayout(false);
            this.grpbxBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxMalzemeSec;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown nmrupAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbxBoyut;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.FlowLayoutPanel flypnlMalzeme;
        private System.Windows.Forms.Button btnMalzemeYenile;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}