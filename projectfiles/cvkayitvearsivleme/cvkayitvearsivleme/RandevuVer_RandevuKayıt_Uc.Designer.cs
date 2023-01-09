namespace cvkayitvearsivleme
{
    partial class RandevuVer_RandevuKayıt_Uc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nots = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randevuVer = new System.Windows.Forms.Button();
            this.saat = new DevExpress.XtraEditors.TimeSpanEdit();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.textBox_Tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nots);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.randevuVer);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.textBox_Tc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 741);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Ver";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nots
            // 
            this.nots.Location = new System.Drawing.Point(162, 239);
            this.nots.Name = "nots";
            this.nots.Size = new System.Drawing.Size(281, 149);
            this.nots.TabIndex = 10;
            this.nots.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Not (varsa):";
            // 
            // randevuVer
            // 
            this.randevuVer.BackColor = System.Drawing.Color.Transparent;
            this.randevuVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevuVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuVer.ForeColor = System.Drawing.Color.PaleGreen;
            this.randevuVer.Location = new System.Drawing.Point(152, 655);
            this.randevuVer.Name = "randevuVer";
            this.randevuVer.Size = new System.Drawing.Size(281, 60);
            this.randevuVer.TabIndex = 8;
            this.randevuVer.Text = "Randevu Ver";
            this.randevuVer.UseVisualStyleBackColor = false;
            this.randevuVer.Click += new System.EventHandler(this.randevuVer_Click);
            // 
            // saat
            // 
            this.saat.EditValue = System.TimeSpan.Parse("00:00:00");
            this.saat.Location = new System.Drawing.Point(162, 172);
            this.saat.Name = "saat";
            this.saat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.saat.Properties.MaskSettings.Set("mask", "hh:mm");
            this.saat.Properties.UseMaskAsDisplayFormat = true;
            this.saat.Size = new System.Drawing.Size(283, 22);
            this.saat.TabIndex = 6;
            // 
            // tarih
            // 
            this.tarih.CustomFormat = "dd/MM/yyyy";
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarih.Location = new System.Drawing.Point(162, 111);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(281, 22);
            this.tarih.TabIndex = 4;
            // 
            // textBox_Tc
            // 
            this.textBox_Tc.Location = new System.Drawing.Point(162, 58);
            this.textBox_Tc.MaxLength = 11;
            this.textBox_Tc.Name = "textBox_Tc";
            this.textBox_Tc.Size = new System.Drawing.Size(281, 22);
            this.textBox_Tc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik No:";
            // 
            // RandevuVer_RandevuKayıt_Uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RandevuVer_RandevuKayıt_Uc";
            this.Size = new System.Drawing.Size(635, 759);
            this.Load += new System.EventHandler(this.RandevuVer_RandevuKayıt_Uc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button randevuVer;
        private DevExpress.XtraEditors.TimeSpanEdit saat;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox textBox_Tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox nots;
    }
}
