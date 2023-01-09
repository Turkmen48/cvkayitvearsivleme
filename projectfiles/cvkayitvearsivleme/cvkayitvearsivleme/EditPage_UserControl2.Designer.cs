namespace cvkayitvearsivleme
{
    partial class EditPage_UserControl2
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
            this.askerlik = new System.Windows.Forms.ComboBox();
            this.egitim = new System.Windows.Forms.ComboBox();
            this.calismaDurumu = new System.Windows.Forms.ComboBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.isTecrubesi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // askerlik
            // 
            this.askerlik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.askerlik.FormattingEnabled = true;
            this.askerlik.Items.AddRange(new object[] {
            "Tecilli",
            "Yaptı",
            "Yapmadı",
            "Muaf"});
            this.askerlik.Location = new System.Drawing.Point(188, 125);
            this.askerlik.Name = "askerlik";
            this.askerlik.Size = new System.Drawing.Size(307, 24);
            this.askerlik.TabIndex = 44;
            // 
            // egitim
            // 
            this.egitim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.egitim.FormattingEnabled = true;
            this.egitim.Items.AddRange(new object[] {
            "Lise Mezunu",
            "Ön Lisans",
            "Lisans",
            "Yüksek Lisans"});
            this.egitim.Location = new System.Drawing.Point(191, 174);
            this.egitim.Name = "egitim";
            this.egitim.Size = new System.Drawing.Size(304, 24);
            this.egitim.TabIndex = 43;
            // 
            // calismaDurumu
            // 
            this.calismaDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calismaDurumu.FormattingEnabled = true;
            this.calismaDurumu.Items.AddRange(new object[] {
            "Çalışıyor",
            "Çalışmıyor"});
            this.calismaDurumu.Location = new System.Drawing.Point(188, 271);
            this.calismaDurumu.Name = "calismaDurumu";
            this.calismaDurumu.Size = new System.Drawing.Size(307, 24);
            this.calismaDurumu.TabIndex = 42;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(188, 315);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(307, 89);
            this.adres.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(34, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Açık Adresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(34, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Çalışma Durumu";
            // 
            // isTecrubesi
            // 
            this.isTecrubesi.Location = new System.Drawing.Point(188, 222);
            this.isTecrubesi.MaxLength = 2;
            this.isTecrubesi.Name = "isTecrubesi";
            this.isTecrubesi.Size = new System.Drawing.Size(307, 22);
            this.isTecrubesi.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(34, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "İş Tecrübesi (Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Eğitim Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(34, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Askerlik Durumu";
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(188, 80);
            this.eposta.MaxLength = 100;
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(307, 22);
            this.eposta.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "E-Posta";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(188, 32);
            this.telefon.MaxLength = 11;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(307, 22);
            this.telefon.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Telefon";
            // 
            // EditPage_UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.askerlik);
            this.Controls.Add(this.egitim);
            this.Controls.Add(this.calismaDurumu);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isTecrubesi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label1);
            this.Name = "EditPage_UserControl2";
            this.Size = new System.Drawing.Size(669, 611);
            this.Load += new System.EventHandler(this.EditPage_UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox askerlik;
        private System.Windows.Forms.ComboBox egitim;
        private System.Windows.Forms.ComboBox calismaDurumu;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox isTecrubesi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label1;
    }
}
