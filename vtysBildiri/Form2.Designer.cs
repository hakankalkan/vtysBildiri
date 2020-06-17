namespace vtysBildiri
{
    partial class Form2
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
            this.kurumNoText = new System.Windows.Forms.TextBox();
            this.kurumAdiText = new System.Windows.Forms.TextBox();
            this.kurumNo = new System.Windows.Forms.Label();
            this.kurumAdi = new System.Windows.Forms.Label();
            this.kurumSil = new System.Windows.Forms.Button();
            this.kurumEkle = new System.Windows.Forms.Button();
            this.kurumGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewKurum = new System.Windows.Forms.DataGridView();
            this.kurumNoEski = new System.Windows.Forms.Label();
            this.kurumNoEskiText = new System.Windows.Forms.TextBox();
            this.comboBoxKatilimci = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurum)).BeginInit();
            this.SuspendLayout();
            // 
            // kurumNoText
            // 
            this.kurumNoText.Location = new System.Drawing.Point(209, 334);
            this.kurumNoText.Name = "kurumNoText";
            this.kurumNoText.Size = new System.Drawing.Size(100, 20);
            this.kurumNoText.TabIndex = 1;
            // 
            // kurumAdiText
            // 
            this.kurumAdiText.Location = new System.Drawing.Point(209, 369);
            this.kurumAdiText.Name = "kurumAdiText";
            this.kurumAdiText.Size = new System.Drawing.Size(100, 20);
            this.kurumAdiText.TabIndex = 2;
            // 
            // kurumNo
            // 
            this.kurumNo.AutoSize = true;
            this.kurumNo.Location = new System.Drawing.Point(153, 337);
            this.kurumNo.Name = "kurumNo";
            this.kurumNo.Size = new System.Drawing.Size(50, 13);
            this.kurumNo.TabIndex = 3;
            this.kurumNo.Text = "kurumNo";
            // 
            // kurumAdi
            // 
            this.kurumAdi.AutoSize = true;
            this.kurumAdi.Location = new System.Drawing.Point(152, 372);
            this.kurumAdi.Name = "kurumAdi";
            this.kurumAdi.Size = new System.Drawing.Size(51, 13);
            this.kurumAdi.TabIndex = 4;
            this.kurumAdi.Text = "kurumAdı";
            // 
            // kurumSil
            // 
            this.kurumSil.Location = new System.Drawing.Point(361, 322);
            this.kurumSil.Name = "kurumSil";
            this.kurumSil.Size = new System.Drawing.Size(75, 23);
            this.kurumSil.TabIndex = 5;
            this.kurumSil.Text = "sil";
            this.kurumSil.UseVisualStyleBackColor = true;
            this.kurumSil.Click += new System.EventHandler(this.kurumSil_Click);
            // 
            // kurumEkle
            // 
            this.kurumEkle.Location = new System.Drawing.Point(209, 404);
            this.kurumEkle.Name = "kurumEkle";
            this.kurumEkle.Size = new System.Drawing.Size(75, 23);
            this.kurumEkle.TabIndex = 6;
            this.kurumEkle.Text = "ekle";
            this.kurumEkle.UseVisualStyleBackColor = true;
            this.kurumEkle.Click += new System.EventHandler(this.kurumEkle_Click);
            // 
            // kurumGuncelle
            // 
            this.kurumGuncelle.Location = new System.Drawing.Point(361, 404);
            this.kurumGuncelle.Name = "kurumGuncelle";
            this.kurumGuncelle.Size = new System.Drawing.Size(75, 23);
            this.kurumGuncelle.TabIndex = 7;
            this.kurumGuncelle.Text = "güncelle";
            this.kurumGuncelle.UseVisualStyleBackColor = true;
            this.kurumGuncelle.Click += new System.EventHandler(this.kurumGuncelle_Click);
            // 
            // dataGridViewKurum
            // 
            this.dataGridViewKurum.AllowUserToOrderColumns = true;
            this.dataGridViewKurum.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewKurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKurum.Location = new System.Drawing.Point(209, 12);
            this.dataGridViewKurum.Name = "dataGridViewKurum";
            this.dataGridViewKurum.Size = new System.Drawing.Size(420, 247);
            this.dataGridViewKurum.TabIndex = 8;
            // 
            // kurumNoEski
            // 
            this.kurumNoEski.AutoSize = true;
            this.kurumNoEski.Location = new System.Drawing.Point(133, 302);
            this.kurumNoEski.Name = "kurumNoEski";
            this.kurumNoEski.Size = new System.Drawing.Size(70, 13);
            this.kurumNoEski.TabIndex = 9;
            this.kurumNoEski.Text = "kurumNoEski";
            // 
            // kurumNoEskiText
            // 
            this.kurumNoEskiText.Location = new System.Drawing.Point(209, 299);
            this.kurumNoEskiText.Name = "kurumNoEskiText";
            this.kurumNoEskiText.Size = new System.Drawing.Size(100, 20);
            this.kurumNoEskiText.TabIndex = 10;
            // 
            // comboBoxKatilimci
            // 
            this.comboBoxKatilimci.FormattingEnabled = true;
            this.comboBoxKatilimci.Location = new System.Drawing.Point(209, 265);
            this.comboBoxKatilimci.Name = "comboBoxKatilimci";
            this.comboBoxKatilimci.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKatilimci.TabIndex = 11;
            this.comboBoxKatilimci.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxKatilimci);
            this.Controls.Add(this.kurumNoEskiText);
            this.Controls.Add(this.kurumNoEski);
            this.Controls.Add(this.dataGridViewKurum);
            this.Controls.Add(this.kurumGuncelle);
            this.Controls.Add(this.kurumEkle);
            this.Controls.Add(this.kurumSil);
            this.Controls.Add(this.kurumAdi);
            this.Controls.Add(this.kurumNo);
            this.Controls.Add(this.kurumAdiText);
            this.Controls.Add(this.kurumNoText);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kurumNoText;
        private System.Windows.Forms.TextBox kurumAdiText;
        private System.Windows.Forms.Label kurumNo;
        private System.Windows.Forms.Label kurumAdi;
        private System.Windows.Forms.Button kurumSil;
        private System.Windows.Forms.Button kurumEkle;
        private System.Windows.Forms.Button kurumGuncelle;
        private System.Windows.Forms.Label kurumNoEski;
        private System.Windows.Forms.TextBox kurumNoEskiText;
        public System.Windows.Forms.DataGridView dataGridViewKurum;
        private System.Windows.Forms.ComboBox comboBoxKatilimci;
    }
}