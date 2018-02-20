namespace ServisTakip42
{
    partial class AnaForm
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Sorgu = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_TahsilEdilen = new System.Windows.Forms.CheckBox();
            this.comboBox_Muhatap = new System.Windows.Forms.ComboBox();
            this.groupBox_Veri = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Arac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahsilTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muhatap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahsilTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox_SArac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_STahsilTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Bilgi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.lbl_ttarih = new System.Windows.Forms.Label();
            this.lbl_ttarihi_edildi = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_muhatap = new System.Windows.Forms.Label();
            this.lbl_ttutar = new System.Windows.Forms.Label();
            this.lbl_tturu = new System.Windows.Forms.Label();
            this.lbl_arac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Sorgu.SuspendLayout();
            this.groupBox_Veri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.araçlarToolStripMenuItem.Text = "Araç İşlemleri";
            this.araçlarToolStripMenuItem.Click += new System.EventHandler(this.araçlarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // groupBox_Sorgu
            // 
            this.groupBox_Sorgu.AutoSize = true;
            this.groupBox_Sorgu.Controls.Add(this.checkBox1);
            this.groupBox_Sorgu.Controls.Add(this.checkBox_TahsilEdilen);
            this.groupBox_Sorgu.Controls.Add(this.comboBox_Muhatap);
            this.groupBox_Sorgu.Controls.Add(this.groupBox_Veri);
            this.groupBox_Sorgu.Controls.Add(this.comboBox_SArac);
            this.groupBox_Sorgu.Controls.Add(this.label7);
            this.groupBox_Sorgu.Controls.Add(this.label9);
            this.groupBox_Sorgu.Controls.Add(this.dateTimePicker2);
            this.groupBox_Sorgu.Controls.Add(this.dateTimePicker1);
            this.groupBox_Sorgu.Controls.Add(this.button4);
            this.groupBox_Sorgu.Controls.Add(this.comboBox_STahsilTuru);
            this.groupBox_Sorgu.Controls.Add(this.label6);
            this.groupBox_Sorgu.Controls.Add(this.label10);
            this.groupBox_Sorgu.Location = new System.Drawing.Point(0, 155);
            this.groupBox_Sorgu.Name = "groupBox_Sorgu";
            this.groupBox_Sorgu.Size = new System.Drawing.Size(1103, 392);
            this.groupBox_Sorgu.TabIndex = 2;
            this.groupBox_Sorgu.TabStop = false;
            this.groupBox_Sorgu.Text = "Sorgulama";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(440, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Tarihleri Dahil Et";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox_TahsilEdilen
            // 
            this.checkBox_TahsilEdilen.AutoSize = true;
            this.checkBox_TahsilEdilen.Location = new System.Drawing.Point(443, 35);
            this.checkBox_TahsilEdilen.Name = "checkBox_TahsilEdilen";
            this.checkBox_TahsilEdilen.Size = new System.Drawing.Size(100, 17);
            this.checkBox_TahsilEdilen.TabIndex = 16;
            this.checkBox_TahsilEdilen.Text = "Tahsil Edilenler ";
            this.checkBox_TahsilEdilen.UseVisualStyleBackColor = true;
            // 
            // comboBox_Muhatap
            // 
            this.comboBox_Muhatap.FormattingEnabled = true;
            this.comboBox_Muhatap.Location = new System.Drawing.Point(304, 35);
            this.comboBox_Muhatap.Name = "comboBox_Muhatap";
            this.comboBox_Muhatap.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Muhatap.TabIndex = 2;
            // 
            // groupBox_Veri
            // 
            this.groupBox_Veri.Controls.Add(this.dataGridView1);
            this.groupBox_Veri.Location = new System.Drawing.Point(3, 88);
            this.groupBox_Veri.Name = "groupBox_Veri";
            this.groupBox_Veri.Size = new System.Drawing.Size(1094, 285);
            this.groupBox_Veri.TabIndex = 3;
            this.groupBox_Veri.TabStop = false;
            this.groupBox_Veri.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arac,
            this.TahsilTuru,
            this.Tutar,
            this.Muhatap,
            this.TahsilTarihi,
            this.a});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "--";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "Sec";
            dataGridViewCellStyle3.NullValue = "--";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Arac
            // 
            this.Arac.DataPropertyName = "Arac";
            this.Arac.HeaderText = "Araç";
            this.Arac.Name = "Arac";
            this.Arac.ReadOnly = true;
            // 
            // TahsilTuru
            // 
            this.TahsilTuru.DataPropertyName = "TahsilTuru";
            this.TahsilTuru.HeaderText = "Tahsil Türü";
            this.TahsilTuru.Name = "TahsilTuru";
            this.TahsilTuru.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // Muhatap
            // 
            this.Muhatap.DataPropertyName = "Muhatap";
            this.Muhatap.HeaderText = "Muhatap";
            this.Muhatap.Name = "Muhatap";
            this.Muhatap.ReadOnly = true;
            // 
            // TahsilTarihi
            // 
            this.TahsilTarihi.DataPropertyName = "TahsilTarihi";
            this.TahsilTarihi.HeaderText = "Tahsil Edilecek Tarih";
            this.TahsilTarihi.Name = "TahsilTarihi";
            this.TahsilTarihi.ReadOnly = true;
            // 
            // a
            // 
            this.a.DataPropertyName = "Durum";
            this.a.HeaderText = "Tahsil Yapıldı Mı";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comboBox_SArac
            // 
            this.comboBox_SArac.FormattingEnabled = true;
            this.comboBox_SArac.Location = new System.Drawing.Point(15, 35);
            this.comboBox_SArac.Name = "comboBox_SArac";
            this.comboBox_SArac.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SArac.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Arası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Araç";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(234, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_STahsilTuru
            // 
            this.comboBox_STahsilTuru.FormattingEnabled = true;
            this.comboBox_STahsilTuru.Items.AddRange(new object[] {
            "Hepsi",
            "Alacak",
            "Verecek"});
            this.comboBox_STahsilTuru.Location = new System.Drawing.Point(163, 35);
            this.comboBox_STahsilTuru.Name = "comboBox_STahsilTuru";
            this.comboBox_STahsilTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBox_STahsilTuru.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tahsil Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Muhatap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(753, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 106);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // lbl_Bilgi
            // 
            this.lbl_Bilgi.AutoSize = true;
            this.lbl_Bilgi.Location = new System.Drawing.Point(599, 28);
            this.lbl_Bilgi.Name = "lbl_Bilgi";
            this.lbl_Bilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_Bilgi.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_aciklama);
            this.groupBox2.Controls.Add(this.lbl_ttarih);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lbl_ttarihi_edildi);
            this.groupBox2.Controls.Add(this.lbl_durum);
            this.groupBox2.Controls.Add(this.lbl_muhatap);
            this.groupBox2.Controls.Add(this.lbl_ttutar);
            this.groupBox2.Controls.Add(this.lbl_tturu);
            this.groupBox2.Controls.Add(this.lbl_arac);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1116, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aciklama.Location = new System.Drawing.Point(80, 85);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(11, 15);
            this.lbl_aciklama.TabIndex = 1;
            this.lbl_aciklama.Text = "-";
            // 
            // lbl_ttarih
            // 
            this.lbl_ttarih.AutoSize = true;
            this.lbl_ttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ttarih.Location = new System.Drawing.Point(157, 54);
            this.lbl_ttarih.Name = "lbl_ttarih";
            this.lbl_ttarih.Size = new System.Drawing.Size(13, 17);
            this.lbl_ttarih.TabIndex = 1;
            this.lbl_ttarih.Text = "-";
            // 
            // lbl_ttarihi_edildi
            // 
            this.lbl_ttarihi_edildi.AutoSize = true;
            this.lbl_ttarihi_edildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ttarihi_edildi.Location = new System.Drawing.Point(495, 54);
            this.lbl_ttarihi_edildi.Name = "lbl_ttarihi_edildi";
            this.lbl_ttarihi_edildi.Size = new System.Drawing.Size(13, 17);
            this.lbl_ttarihi_edildi.TabIndex = 1;
            this.lbl_ttarihi_edildi.Text = "-";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_durum.Location = new System.Drawing.Point(690, 21);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(13, 17);
            this.lbl_durum.TabIndex = 1;
            this.lbl_durum.Text = "-";
            // 
            // lbl_muhatap
            // 
            this.lbl_muhatap.AutoSize = true;
            this.lbl_muhatap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_muhatap.Location = new System.Drawing.Point(525, 21);
            this.lbl_muhatap.Name = "lbl_muhatap";
            this.lbl_muhatap.Size = new System.Drawing.Size(13, 17);
            this.lbl_muhatap.TabIndex = 1;
            this.lbl_muhatap.Text = "-";
            // 
            // lbl_ttutar
            // 
            this.lbl_ttutar.AutoSize = true;
            this.lbl_ttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ttutar.Location = new System.Drawing.Point(353, 21);
            this.lbl_ttutar.Name = "lbl_ttutar";
            this.lbl_ttutar.Size = new System.Drawing.Size(13, 17);
            this.lbl_ttutar.TabIndex = 1;
            this.lbl_ttutar.Text = "-";
            // 
            // lbl_tturu
            // 
            this.lbl_tturu.AutoSize = true;
            this.lbl_tturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tturu.Location = new System.Drawing.Point(216, 21);
            this.lbl_tturu.Name = "lbl_tturu";
            this.lbl_tturu.Size = new System.Drawing.Size(13, 17);
            this.lbl_tturu.TabIndex = 1;
            this.lbl_tturu.Text = "-";
            // 
            // lbl_arac
            // 
            this.lbl_arac.AutoSize = true;
            this.lbl_arac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_arac.Location = new System.Drawing.Point(54, 21);
            this.lbl_arac.Name = "lbl_arac";
            this.lbl_arac.Size = new System.Drawing.Size(13, 17);
            this.lbl_arac.TabIndex = 1;
            this.lbl_arac.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(301, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(452, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Muhatap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(133, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tahsil Türü:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(632, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(353, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tahsil Edildiği Tarih:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tahsil Edileceği Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç:";
            // 
            // button1
            // 
            this.button1.Image = global::ServisTakip42.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yeni Kaydet";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Image = global::ServisTakip42.Properties.Resources.onay;
            this.button6.Location = new System.Drawing.Point(6, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "Tahsil Et";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ServisTakip42.Properties.Resources.edit;
            this.button2.Location = new System.Drawing.Point(125, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Güncelle";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ServisTakip42.Properties.Resources.delete;
            this.button3.Location = new System.Drawing.Point(237, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sil";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1116, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Bilgi);
            this.Controls.Add(this.groupBox_Sorgu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaTakip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.SizeChanged += new System.EventHandler(this.AnaForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Sorgu.ResumeLayout(false);
            this.groupBox_Sorgu.PerformLayout();
            this.groupBox_Veri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_Sorgu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_STahsilTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_Veri;
        private System.Windows.Forms.ComboBox comboBox_SArac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Muhatap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_TahsilEdilen;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Bilgi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label lbl_muhatap;
        private System.Windows.Forms.Label lbl_ttutar;
        private System.Windows.Forms.Label lbl_tturu;
        private System.Windows.Forms.Label lbl_arac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ttarih;
        private System.Windows.Forms.Label lbl_ttarihi_edildi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahsilTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muhatap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahsilTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}