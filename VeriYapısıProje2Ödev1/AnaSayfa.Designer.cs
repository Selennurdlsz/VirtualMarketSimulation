namespace VeriYapısıProje2Ödev1
{
    partial class AnaSayfa
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
            this.btnPersonelGirisi = new System.Windows.Forms.Button();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelGirisi
            // 
            this.btnPersonelGirisi.BackColor = System.Drawing.Color.Lavender;
            this.btnPersonelGirisi.Location = new System.Drawing.Point(112, 73);
            this.btnPersonelGirisi.Name = "btnPersonelGirisi";
            this.btnPersonelGirisi.Size = new System.Drawing.Size(161, 60);
            this.btnPersonelGirisi.TabIndex = 0;
            this.btnPersonelGirisi.Text = "PERSONEL";
            this.btnPersonelGirisi.UseVisualStyleBackColor = false;
            this.btnPersonelGirisi.Click += new System.EventHandler(this.btnPersonelGirisi_Click);
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMusteriGirisi.Location = new System.Drawing.Point(112, 149);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(161, 57);
            this.btnMusteriGirisi.TabIndex = 1;
            this.btnMusteriGirisi.Text = "MÜŞTERİ";
            this.btnMusteriGirisi.UseVisualStyleBackColor = false;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Controls.Add(this.btnPersonelGirisi);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelGirisi;
        private System.Windows.Forms.Button btnMusteriGirisi;
    }
}

