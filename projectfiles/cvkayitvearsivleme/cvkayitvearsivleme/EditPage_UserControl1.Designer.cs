namespace cvkayitvearsivleme
{
    partial class EditPage_UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dogumYeri = new System.Windows.Forms.ComboBox();
            this.dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.medeniHal = new System.Windows.Forms.ComboBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dogumYeri
            // 
            this.dogumYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dogumYeri.FormattingEnabled = true;
            this.dogumYeri.Location = new System.Drawing.Point(166, 278);
            this.dogumYeri.Name = "dogumYeri";
            this.dogumYeri.Size = new System.Drawing.Size(307, 24);
            this.dogumYeri.TabIndex = 31;
            this.dogumYeri.Click += new System.EventHandler(this.dogumYeri_Click);
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.CustomFormat = "dd/MM/yyyy";
            this.dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumTarihi.Location = new System.Drawing.Point(166, 230);
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.Size = new System.Drawing.Size(307, 22);
            this.dogumTarihi.TabIndex = 30;
            // 
            // medeniHal
            // 
            this.medeniHal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medeniHal.FormattingEnabled = true;
            this.medeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.medeniHal.Location = new System.Drawing.Point(166, 323);
            this.medeniHal.Name = "medeniHal";
            this.medeniHal.Size = new System.Drawing.Size(307, 24);
            this.medeniHal.TabIndex = 29;
            // 
            // cinsiyet
            // 
            this.cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(166, 177);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(307, 24);
            this.cinsiyet.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(25, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Medeni Hali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(25, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Doğum Yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(25, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dogum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cinsiyet";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(166, 133);
            this.soyad.MaxLength = 50;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(307, 22);
            this.soyad.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyad";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(166, 88);
            this.ad.MaxLength = 50;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(307, 22);
            this.ad.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ad";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(166, 40);
            this.tc.MaxLength = 11;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(307, 22);
            this.tc.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "T.C. Kimlik No";
            // 
            // EditPage_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dogumYeri);
            this.Controls.Add(this.dogumTarihi);
            this.Controls.Add(this.medeniHal);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label1);
            this.Name = "EditPage_UserControl1";
            this.Size = new System.Drawing.Size(536, 490);
            this.Load += new System.EventHandler(this.EditPage_UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dogumTarihi;
        private System.Windows.Forms.ComboBox medeniHal;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dogumYeri;
    }
}
