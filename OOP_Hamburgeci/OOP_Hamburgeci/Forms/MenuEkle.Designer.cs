namespace OOP_Hamburgeci.Forms
{
    partial class MenuEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrupYeniMenuFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtYeniMenu = new System.Windows.Forms.TextBox();
            this.btnYeniMenuKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupYeniMenuFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmrupYeniMenuFiyat);
            this.groupBox1.Controls.Add(this.txtYeniMenu);
            this.groupBox1.Controls.Add(this.btnYeniMenuKaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(511, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // lblHata
            // 
            this.lblHata.Location = new System.Drawing.Point(9, 156);
            this.lblHata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(159, 81);
            this.lblHata.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // nmrupYeniMenuFiyat
            // 
            this.nmrupYeniMenuFiyat.Location = new System.Drawing.Point(201, 112);
            this.nmrupYeniMenuFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmrupYeniMenuFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrupYeniMenuFiyat.Name = "nmrupYeniMenuFiyat";
            this.nmrupYeniMenuFiyat.Size = new System.Drawing.Size(215, 27);
            this.nmrupYeniMenuFiyat.TabIndex = 4;
            // 
            // txtYeniMenu
            // 
            this.txtYeniMenu.Location = new System.Drawing.Point(200, 58);
            this.txtYeniMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYeniMenu.Name = "txtYeniMenu";
            this.txtYeniMenu.Size = new System.Drawing.Size(215, 27);
            this.txtYeniMenu.TabIndex = 3;
            // 
            // btnYeniMenuKaydet
            // 
            this.btnYeniMenuKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYeniMenuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMenuKaydet.Location = new System.Drawing.Point(201, 188);
            this.btnYeniMenuKaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYeniMenuKaydet.Name = "btnYeniMenuKaydet";
            this.btnYeniMenuKaydet.Size = new System.Drawing.Size(216, 81);
            this.btnYeniMenuKaydet.TabIndex = 2;
            this.btnYeniMenuKaydet.Text = "Menü Kaydet";
            this.btnYeniMenuKaydet.UseVisualStyleBackColor = false;
            this.btnYeniMenuKaydet.Click += new System.EventHandler(this.btnYeniMenuKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Adı";
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 363);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEkle";
            this.Load += new System.EventHandler(this.MenuEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupYeniMenuFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrupYeniMenuFiyat;
        private System.Windows.Forms.TextBox txtYeniMenu;
        private System.Windows.Forms.Button btnYeniMenuKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHata;
    }
}