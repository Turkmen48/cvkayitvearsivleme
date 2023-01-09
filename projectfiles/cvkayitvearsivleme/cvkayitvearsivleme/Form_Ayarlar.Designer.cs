namespace cvkayitvearsivleme
{
    partial class Form_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ayarlar));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kullaniciAyarlari = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sabitleriDuzenle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::cvkayitvearsivleme.Properties.Resources.profilesettings;
            this.pictureBox2.Location = new System.Drawing.Point(25, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // kullaniciAyarlari
            // 
            this.kullaniciAyarlari.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAyarlari.ForeColor = System.Drawing.Color.Crimson;
            this.kullaniciAyarlari.Location = new System.Drawing.Point(124, 43);
            this.kullaniciAyarlari.Name = "kullaniciAyarlari";
            this.kullaniciAyarlari.Size = new System.Drawing.Size(196, 85);
            this.kullaniciAyarlari.TabIndex = 5;
            this.kullaniciAyarlari.Text = "Kullanıcı Ayarları";
            this.kullaniciAyarlari.UseVisualStyleBackColor = false;
            this.kullaniciAyarlari.Click += new System.EventHandler(this.kullaniciAyarlari_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::cvkayitvearsivleme.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(25, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // sabitleriDuzenle
            // 
            this.sabitleriDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.sabitleriDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sabitleriDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sabitleriDuzenle.ForeColor = System.Drawing.Color.Pink;
            this.sabitleriDuzenle.Location = new System.Drawing.Point(124, 209);
            this.sabitleriDuzenle.Name = "sabitleriDuzenle";
            this.sabitleriDuzenle.Size = new System.Drawing.Size(196, 85);
            this.sabitleriDuzenle.TabIndex = 7;
            this.sabitleriDuzenle.Text = "Log Kayıtları";
            this.sabitleriDuzenle.UseVisualStyleBackColor = false;
            this.sabitleriDuzenle.Click += new System.EventHandler(this.sabitleriDuzenle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 333);
            this.panel1.TabIndex = 9;
            // 
            // Form_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cvkayitvearsivleme.Properties.Resources.bgfireempty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sabitleriDuzenle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kullaniciAyarlari);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Form_Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button kullaniciAyarlari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sabitleriDuzenle;
        private System.Windows.Forms.Panel panel1;
    }
}