namespace cvkayitvearsivleme
{
    partial class Form_Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Randevu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Eposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Tc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decline = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1369, 621);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Eposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Soyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Ad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Tel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Tc);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(38, 681);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::cvkayitvearsivleme.Properties.Resources.refresh;
            this.pictureBox5.Location = new System.Drawing.Point(1149, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refresh.ForeColor = System.Drawing.Color.Aqua;
            this.refresh.Location = new System.Drawing.Point(1228, 24);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(107, 60);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Yenile";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(625, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-Posta:";
            // 
            // textBox_Eposta
            // 
            this.textBox_Eposta.Location = new System.Drawing.Point(724, 29);
            this.textBox_Eposta.MaxLength = 100;
            this.textBox_Eposta.Name = "textBox_Eposta";
            this.textBox_Eposta.Size = new System.Drawing.Size(135, 22);
            this.textBox_Eposta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(301, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad:";
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(426, 66);
            this.textBox_Soyad.MaxLength = 50;
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(135, 22);
            this.textBox_Soyad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad:";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(108, 66);
            this.textBox_Ad.MaxLength = 50;
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(135, 22);
            this.textBox_Ad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(301, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon No:";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(426, 26);
            this.textBox_Tel.MaxLength = 11;
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(135, 22);
            this.textBox_Tel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. No:";
            // 
            // textBox_Tc
            // 
            this.textBox_Tc.Location = new System.Drawing.Point(108, 26);
            this.textBox_Tc.MaxLength = 11;
            this.textBox_Tc.Name = "textBox_Tc";
            this.textBox_Tc.Size = new System.Drawing.Size(135, 22);
            this.textBox_Tc.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::cvkayitvearsivleme.Properties.Resources.decline;
            this.pictureBox1.Location = new System.Drawing.Point(35, 821);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // decline
            // 
            this.decline.BackColor = System.Drawing.Color.Transparent;
            this.decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decline.ForeColor = System.Drawing.Color.Red;
            this.decline.Location = new System.Drawing.Point(99, 821);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(196, 60);
            this.decline.TabIndex = 11;
            this.decline.Text = "Vazgeç";
            this.decline.UseVisualStyleBackColor = false;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::cvkayitvearsivleme.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(394, 837);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.Color.Transparent;
            this.delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_Button.ForeColor = System.Drawing.Color.Red;
            this.delete_Button.Location = new System.Drawing.Point(464, 837);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(66, 44);
            this.delete_Button.TabIndex = 13;
            this.delete_Button.Text = "Sil";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::cvkayitvearsivleme.Properties.Resources.searchwhite;
            this.pictureBox2.Location = new System.Drawing.Point(1137, 813);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Transparent;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accept.ForeColor = System.Drawing.Color.Lime;
            this.accept.Location = new System.Drawing.Point(1204, 813);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(196, 60);
            this.accept.TabIndex = 17;
            this.accept.Text = "Ara";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // Form_Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cvkayitvearsivleme.Properties.Resources.bgfireempty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 978);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.Form_Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Eposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Tc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button accept;
    }
}