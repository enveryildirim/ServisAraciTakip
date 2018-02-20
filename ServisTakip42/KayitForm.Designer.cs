namespace ServisTakip42
{
    partial class KayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitForm));
            this.groupBox_Kayit = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox_Arac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_muhatap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_TahsilTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Tahsilturu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Kayit
            // 
            this.groupBox_Kayit.Controls.Add(this.lbl_id);
            this.groupBox_Kayit.Controls.Add(this.button5);
            this.groupBox_Kayit.Controls.Add(this.comboBox_Arac);
            this.groupBox_Kayit.Controls.Add(this.label8);
            this.groupBox_Kayit.Controls.Add(this.txt_aciklama);
            this.groupBox_Kayit.Controls.Add(this.label5);
            this.groupBox_Kayit.Controls.Add(this.txt_muhatap);
            this.groupBox_Kayit.Controls.Add(this.label4);
            this.groupBox_Kayit.Controls.Add(this.txt_tutar);
            this.groupBox_Kayit.Controls.Add(this.label3);
            this.groupBox_Kayit.Controls.Add(this.dateTimePicker_TahsilTarihi);
            this.groupBox_Kayit.Controls.Add(this.label2);
            this.groupBox_Kayit.Controls.Add(this.comboBox_Tahsilturu);
            this.groupBox_Kayit.Controls.Add(this.label1);
            this.groupBox_Kayit.Location = new System.Drawing.Point(3, 12);
            this.groupBox_Kayit.Name = "groupBox_Kayit";
            this.groupBox_Kayit.Size = new System.Drawing.Size(580, 230);
            this.groupBox_Kayit.TabIndex = 2;
            this.groupBox_Kayit.TabStop = false;
            this.groupBox_Kayit.Text = "Kayıt Bilgileri";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(358, 104);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kaydet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox_Arac
            // 
            this.comboBox_Arac.FormattingEnabled = true;
            this.comboBox_Arac.Location = new System.Drawing.Point(333, 76);
            this.comboBox_Arac.Name = "comboBox_Arac";
            this.comboBox_Arac.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Arac.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Araç";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(10, 75);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(269, 71);
            this.txt_aciklama.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama";
            // 
            // txt_muhatap
            // 
            this.txt_muhatap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_muhatap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_muhatap.Location = new System.Drawing.Point(443, 36);
            this.txt_muhatap.Name = "txt_muhatap";
            this.txt_muhatap.Size = new System.Drawing.Size(122, 20);
            this.txt_muhatap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Muhatap";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(333, 37);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_tutar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar";
            // 
            // dateTimePicker_TahsilTarihi
            // 
            this.dateTimePicker_TahsilTarihi.Location = new System.Drawing.Point(160, 37);
            this.dateTimePicker_TahsilTarihi.Name = "dateTimePicker_TahsilTarihi";
            this.dateTimePicker_TahsilTarihi.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker_TahsilTarihi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahsil Tarihi";
            // 
            // comboBox_Tahsilturu
            // 
            this.comboBox_Tahsilturu.FormattingEnabled = true;
            this.comboBox_Tahsilturu.Items.AddRange(new object[] {
            "Alacak",
            "Verecek"});
            this.comboBox_Tahsilturu.Location = new System.Drawing.Point(13, 37);
            this.comboBox_Tahsilturu.Name = "comboBox_Tahsilturu";
            this.comboBox_Tahsilturu.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Tahsilturu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahsil Türü";
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(599, 251);
            this.Controls.Add(this.groupBox_Kayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitForm";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.groupBox_Kayit.ResumeLayout(false);
            this.groupBox_Kayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Kayit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox_Arac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_muhatap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TahsilTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Tahsilturu;
        private System.Windows.Forms.Label label1;
    }
}