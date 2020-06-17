namespace vtysBildiri
{
    partial class Form4
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
            this.salonNoText = new System.Windows.Forms.TextBox();
            this.salonAdiText = new System.Windows.Forms.TextBox();
            this.salonBulunduguKatText = new System.Windows.Forms.TextBox();
            this.salonNo = new System.Windows.Forms.Label();
            this.salonAdi = new System.Windows.Forms.Label();
            this.salonBulunduguKat = new System.Windows.Forms.Label();
            this.salonSil = new System.Windows.Forms.Button();
            this.salonEkle = new System.Windows.Forms.Button();
            this.salonGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewSalon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.salonNoEski = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // salonNoText
            // 
            this.salonNoText.Location = new System.Drawing.Point(184, 266);
            this.salonNoText.Name = "salonNoText";
            this.salonNoText.Size = new System.Drawing.Size(100, 20);
            this.salonNoText.TabIndex = 1;
            // 
            // salonAdiText
            // 
            this.salonAdiText.Location = new System.Drawing.Point(184, 309);
            this.salonAdiText.Name = "salonAdiText";
            this.salonAdiText.Size = new System.Drawing.Size(100, 20);
            this.salonAdiText.TabIndex = 2;
            // 
            // salonBulunduguKatText
            // 
            this.salonBulunduguKatText.Location = new System.Drawing.Point(184, 365);
            this.salonBulunduguKatText.Name = "salonBulunduguKatText";
            this.salonBulunduguKatText.Size = new System.Drawing.Size(100, 20);
            this.salonBulunduguKatText.TabIndex = 3;
            // 
            // salonNo
            // 
            this.salonNo.AutoSize = true;
            this.salonNo.Location = new System.Drawing.Point(132, 269);
            this.salonNo.Name = "salonNo";
            this.salonNo.Size = new System.Drawing.Size(46, 13);
            this.salonNo.TabIndex = 4;
            this.salonNo.Text = "salonNo";
            // 
            // salonAdi
            // 
            this.salonAdi.AutoSize = true;
            this.salonAdi.Location = new System.Drawing.Point(135, 312);
            this.salonAdi.Name = "salonAdi";
            this.salonAdi.Size = new System.Drawing.Size(47, 13);
            this.salonAdi.TabIndex = 5;
            this.salonAdi.Text = "salonAdı";
            // 
            // salonBulunduguKat
            // 
            this.salonBulunduguKat.AutoSize = true;
            this.salonBulunduguKat.Location = new System.Drawing.Point(105, 368);
            this.salonBulunduguKat.Name = "salonBulunduguKat";
            this.salonBulunduguKat.Size = new System.Drawing.Size(73, 13);
            this.salonBulunduguKat.TabIndex = 6;
            this.salonBulunduguKat.Text = "bulunduğuKat";
            // 
            // salonSil
            // 
            this.salonSil.Location = new System.Drawing.Point(363, 264);
            this.salonSil.Name = "salonSil";
            this.salonSil.Size = new System.Drawing.Size(75, 23);
            this.salonSil.TabIndex = 7;
            this.salonSil.Text = "sil";
            this.salonSil.UseVisualStyleBackColor = true;
            this.salonSil.Click += new System.EventHandler(this.salonSil_Click);
            // 
            // salonEkle
            // 
            this.salonEkle.Location = new System.Drawing.Point(184, 411);
            this.salonEkle.Name = "salonEkle";
            this.salonEkle.Size = new System.Drawing.Size(75, 23);
            this.salonEkle.TabIndex = 8;
            this.salonEkle.Text = "ekle";
            this.salonEkle.UseVisualStyleBackColor = true;
            this.salonEkle.Click += new System.EventHandler(this.salonEkle_Click);
            // 
            // salonGuncelle
            // 
            this.salonGuncelle.Location = new System.Drawing.Point(318, 411);
            this.salonGuncelle.Name = "salonGuncelle";
            this.salonGuncelle.Size = new System.Drawing.Size(75, 23);
            this.salonGuncelle.TabIndex = 9;
            this.salonGuncelle.Text = "güncelle";
            this.salonGuncelle.UseVisualStyleBackColor = true;
            this.salonGuncelle.Click += new System.EventHandler(this.salonGuncelle_Click);
            // 
            // dataGridViewSalon
            // 
            this.dataGridViewSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalon.Location = new System.Drawing.Point(212, 12);
            this.dataGridViewSalon.Name = "dataGridViewSalon";
            this.dataGridViewSalon.Size = new System.Drawing.Size(304, 190);
            this.dataGridViewSalon.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eski Salon No";
            
            // 
            // salonNoEski
            // 
            this.salonNoEski.Location = new System.Drawing.Point(184, 224);
            this.salonNoEski.Name = "salonNoEski";
            this.salonNoEski.Size = new System.Drawing.Size(100, 20);
            this.salonNoEski.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salonNoEski);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSalon);
            this.Controls.Add(this.salonGuncelle);
            this.Controls.Add(this.salonEkle);
            this.Controls.Add(this.salonSil);
            this.Controls.Add(this.salonBulunduguKat);
            this.Controls.Add(this.salonAdi);
            this.Controls.Add(this.salonNo);
            this.Controls.Add(this.salonBulunduguKatText);
            this.Controls.Add(this.salonAdiText);
            this.Controls.Add(this.salonNoText);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox salonNoText;
        private System.Windows.Forms.TextBox salonAdiText;
        private System.Windows.Forms.TextBox salonBulunduguKatText;
        private System.Windows.Forms.Label salonNo;
        private System.Windows.Forms.Label salonAdi;
        private System.Windows.Forms.Label salonBulunduguKat;
        private System.Windows.Forms.Button salonSil;
        private System.Windows.Forms.Button salonEkle;
        private System.Windows.Forms.Button salonGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salonNoEski;
    }
}