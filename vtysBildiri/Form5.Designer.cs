namespace vtysBildiri
{
    partial class Form5
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
            this.bildiriNoText = new System.Windows.Forms.TextBox();
            this.bildiriAdiText = new System.Windows.Forms.TextBox();
            this.bildiriGunText = new System.Windows.Forms.TextBox();
            this.bildiriSaatText = new System.Windows.Forms.TextBox();
            this.bildiriNo = new System.Windows.Forms.Label();
            this.bildiriAdi = new System.Windows.Forms.Label();
            this.bildiriGun = new System.Windows.Forms.Label();
            this.bildiriSaat = new System.Windows.Forms.Label();
            this.bildiriSil = new System.Windows.Forms.Button();
            this.bildiriEkle = new System.Windows.Forms.Button();
            this.bildiriGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewBildiri = new System.Windows.Forms.DataGridView();
            this.bildiriNoEski = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBildiri)).BeginInit();
            this.SuspendLayout();
            // 
            // bildiriNoText
            // 
            this.bildiriNoText.Location = new System.Drawing.Point(202, 278);
            this.bildiriNoText.Name = "bildiriNoText";
            this.bildiriNoText.Size = new System.Drawing.Size(100, 20);
            this.bildiriNoText.TabIndex = 1;
            // 
            // bildiriAdiText
            // 
            this.bildiriAdiText.Location = new System.Drawing.Point(202, 308);
            this.bildiriAdiText.Name = "bildiriAdiText";
            this.bildiriAdiText.Size = new System.Drawing.Size(100, 20);
            this.bildiriAdiText.TabIndex = 2;
            // 
            // bildiriGunText
            // 
            this.bildiriGunText.Location = new System.Drawing.Point(202, 334);
            this.bildiriGunText.Name = "bildiriGunText";
            this.bildiriGunText.Size = new System.Drawing.Size(100, 20);
            this.bildiriGunText.TabIndex = 3;
            // 
            // bildiriSaatText
            // 
            this.bildiriSaatText.Location = new System.Drawing.Point(202, 360);
            this.bildiriSaatText.Name = "bildiriSaatText";
            this.bildiriSaatText.Size = new System.Drawing.Size(100, 20);
            this.bildiriSaatText.TabIndex = 4;
            // 
            // bildiriNo
            // 
            this.bildiriNo.AutoSize = true;
            this.bildiriNo.Location = new System.Drawing.Point(152, 285);
            this.bildiriNo.Name = "bildiriNo";
            this.bildiriNo.Size = new System.Drawing.Size(44, 13);
            this.bildiriNo.TabIndex = 5;
            this.bildiriNo.Text = "bildiriNo";
            // 
            // bildiriAdi
            // 
            this.bildiriAdi.AutoSize = true;
            this.bildiriAdi.Location = new System.Drawing.Point(151, 315);
            this.bildiriAdi.Name = "bildiriAdi";
            this.bildiriAdi.Size = new System.Drawing.Size(45, 13);
            this.bildiriAdi.TabIndex = 6;
            this.bildiriAdi.Text = "bildiriAdı";
            // 
            // bildiriGun
            // 
            this.bildiriGun.AutoSize = true;
            this.bildiriGun.Location = new System.Drawing.Point(171, 337);
            this.bildiriGun.Name = "bildiriGun";
            this.bildiriGun.Size = new System.Drawing.Size(25, 13);
            this.bildiriGun.TabIndex = 7;
            this.bildiriGun.Text = "gün";
            // 
            // bildiriSaat
            // 
            this.bildiriSaat.AutoSize = true;
            this.bildiriSaat.Location = new System.Drawing.Point(169, 363);
            this.bildiriSaat.Name = "bildiriSaat";
            this.bildiriSaat.Size = new System.Drawing.Size(27, 13);
            this.bildiriSaat.TabIndex = 8;
            this.bildiriSaat.Text = "saat";
            // 
            // bildiriSil
            // 
            this.bildiriSil.Location = new System.Drawing.Point(339, 276);
            this.bildiriSil.Name = "bildiriSil";
            this.bildiriSil.Size = new System.Drawing.Size(75, 23);
            this.bildiriSil.TabIndex = 9;
            this.bildiriSil.Text = "sil";
            this.bildiriSil.UseVisualStyleBackColor = true;
            this.bildiriSil.Click += new System.EventHandler(this.bildiriSil_Click);
            // 
            // bildiriEkle
            // 
            this.bildiriEkle.Location = new System.Drawing.Point(202, 404);
            this.bildiriEkle.Name = "bildiriEkle";
            this.bildiriEkle.Size = new System.Drawing.Size(75, 23);
            this.bildiriEkle.TabIndex = 10;
            this.bildiriEkle.Text = "ekle";
            this.bildiriEkle.UseVisualStyleBackColor = true;
            this.bildiriEkle.Click += new System.EventHandler(this.bildiriEkle_Click);
            // 
            // bildiriGuncelle
            // 
            this.bildiriGuncelle.Location = new System.Drawing.Point(339, 403);
            this.bildiriGuncelle.Name = "bildiriGuncelle";
            this.bildiriGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bildiriGuncelle.TabIndex = 11;
            this.bildiriGuncelle.Text = "güncelle";
            this.bildiriGuncelle.UseVisualStyleBackColor = true;
            this.bildiriGuncelle.Click += new System.EventHandler(this.bildiriGuncelle_Click);
            // 
            // dataGridViewBildiri
            // 
            this.dataGridViewBildiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBildiri.Location = new System.Drawing.Point(202, 12);
            this.dataGridViewBildiri.Name = "dataGridViewBildiri";
            this.dataGridViewBildiri.Size = new System.Drawing.Size(359, 201);
            this.dataGridViewBildiri.TabIndex = 12;
            // 
            // bildiriNoEski
            // 
            this.bildiriNoEski.Location = new System.Drawing.Point(202, 252);
            this.bildiriNoEski.Name = "bildiriNoEski";
            this.bildiriNoEski.Size = new System.Drawing.Size(100, 20);
            this.bildiriNoEski.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eski Bildiri No";
            
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bildiriNoEski);
            this.Controls.Add(this.dataGridViewBildiri);
            this.Controls.Add(this.bildiriGuncelle);
            this.Controls.Add(this.bildiriEkle);
            this.Controls.Add(this.bildiriSil);
            this.Controls.Add(this.bildiriSaat);
            this.Controls.Add(this.bildiriGun);
            this.Controls.Add(this.bildiriAdi);
            this.Controls.Add(this.bildiriNo);
            this.Controls.Add(this.bildiriSaatText);
            this.Controls.Add(this.bildiriGunText);
            this.Controls.Add(this.bildiriAdiText);
            this.Controls.Add(this.bildiriNoText);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBildiri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bildiriNoText;
        private System.Windows.Forms.TextBox bildiriAdiText;
        private System.Windows.Forms.TextBox bildiriGunText;
        private System.Windows.Forms.TextBox bildiriSaatText;
        private System.Windows.Forms.Label bildiriNo;
        private System.Windows.Forms.Label bildiriAdi;
        private System.Windows.Forms.Label bildiriGun;
        private System.Windows.Forms.Label bildiriSaat;
        private System.Windows.Forms.Button bildiriSil;
        private System.Windows.Forms.Button bildiriEkle;
        private System.Windows.Forms.Button bildiriGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewBildiri;
        private System.Windows.Forms.TextBox bildiriNoEski;
        private System.Windows.Forms.Label label1;
    }
}