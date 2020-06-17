namespace vtysBildiri
{
    partial class Form1
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
            this.bildiriler = new System.Windows.Forms.Button();
            this.kurumlar = new System.Windows.Forms.Button();
            this.katilimcilar = new System.Windows.Forms.Button();
            this.salonlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bildiriler
            // 
            this.bildiriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bildiriler.Location = new System.Drawing.Point(369, 262);
            this.bildiriler.Name = "bildiriler";
            this.bildiriler.Size = new System.Drawing.Size(174, 51);
            this.bildiriler.TabIndex = 3;
            this.bildiriler.Text = "bildiriler";
            this.bildiriler.UseVisualStyleBackColor = true;
            this.bildiriler.Click += new System.EventHandler(this.bildiriler_Click);
            // 
            // kurumlar
            // 
            this.kurumlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kurumlar.Location = new System.Drawing.Point(369, 37);
            this.kurumlar.Name = "kurumlar";
            this.kurumlar.Size = new System.Drawing.Size(174, 51);
            this.kurumlar.TabIndex = 4;
            this.kurumlar.Text = "kurumlar";
            this.kurumlar.UseVisualStyleBackColor = true;
            this.kurumlar.Click += new System.EventHandler(this.kurumlar_Click);
            // 
            // katilimcilar
            // 
            this.katilimcilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katilimcilar.Location = new System.Drawing.Point(369, 118);
            this.katilimcilar.Name = "katilimcilar";
            this.katilimcilar.Size = new System.Drawing.Size(174, 51);
            this.katilimcilar.TabIndex = 5;
            this.katilimcilar.Text = "katılımcılar";
            this.katilimcilar.UseVisualStyleBackColor = true;
            this.katilimcilar.Click += new System.EventHandler(this.katilimcilar_Click);
            // 
            // salonlar
            // 
            this.salonlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salonlar.Location = new System.Drawing.Point(369, 188);
            this.salonlar.Name = "salonlar";
            this.salonlar.Size = new System.Drawing.Size(174, 51);
            this.salonlar.TabIndex = 6;
            this.salonlar.Text = "salonlar";
            this.salonlar.UseVisualStyleBackColor = true;
            this.salonlar.Click += new System.EventHandler(this.salonlar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bildiri İzleyenler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salonlar);
            this.Controls.Add(this.katilimcilar);
            this.Controls.Add(this.kurumlar);
            this.Controls.Add(this.bildiriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bildiriler;
        private System.Windows.Forms.Button kurumlar;
        private System.Windows.Forms.Button katilimcilar;
        private System.Windows.Forms.Button salonlar;
        private System.Windows.Forms.Button button1;
    }
}