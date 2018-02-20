using ServisTakip42.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip42
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        //fields
        static DataTable dt_kayit = new DataTable();
        static List<string> dt_muhatap = new List<string>();
        static DataTable dt_Arac = new DataTable();
        static int durum = 0;
        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracForm a = new AracForm();
            a.ShowDialog();
            VerileriYukle();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            try
            {
                VerileriYukle();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

            KayitForm kf = new KayitForm();
            kf.temp = null;
            kf.dt_Arac = dt_Arac;
            kf.list_muhatap = dt_muhatap;
            kf.ShowDialog();
            VerileriYukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index + 1 == dataGridView1.Rows.Count)
                return;
            DataRow r = dt_kayit.Rows[dataGridView1.SelectedRows[0].Index];
            Kayit k = new Kayit()
            {
                ID = Convert.ToInt32(r["ID"].ToString()),
                Arac = r["Arac"].ToString(),
                TahsilTuru = r["TahsilTuru"].ToString(),
                TahsilTarihi = Convert.ToDateTime(r["TahsilTarihi"].ToString()),
                Tutar = Convert.ToDouble(r["Tutar"].ToString()),
                Aciklama = r["Aciklama"].ToString(),
                Muhatap = r["Muhatap"].ToString(),
                Durum = Convert.ToBoolean(r["Durum"].ToString()),
                SilMi = Convert.ToBoolean(r["Sil"].ToString())
            };
            KayitForm kf = new KayitForm();
            kf.temp = k;
            kf.dt_Arac = dt_Arac;
            kf.list_muhatap = dt_muhatap;
            kf.ShowDialog();
            VerileriYukle();

        }





        //fonksiyonlar
        void VerileriYukle()
        {
            comboBox_SArac.Items.Clear();
            comboBox_SArac.Items.Clear();
            comboBox_Muhatap.Items.Clear();


            comboBox_SArac.Items.Add("Hepsi");
            comboBox_Muhatap.Items.Add("Hepsi");

            dt_Arac = Model.Arac.GetAll();
            if (dt_Arac.Rows.Count <= 0)
                MessageBox.Show("HİÇ ARAÇ EKLENMEMİŞ");
            foreach (DataRow item in dt_Arac.Rows)
            {

                comboBox_SArac.Items.Add(item["Plaka"].ToString());
            }

            dt_kayit = Kayit.GetAll();
            dataGridView1.DataSource = dt_kayit;
            dataGridView1.Columns["Sil"].Visible = false;
            dataGridView1.Columns["Aciklama"].Visible = false;
            dataGridView1.Columns["IslemTarihi"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            int tutar_alacak = 0, tutar_verecek = 0;
            foreach (DataRow item in dt_kayit.Rows)
            {

                if (comboBox_Muhatap.Items.Contains(item["Muhatap"].ToString()))
                    continue;
                comboBox_Muhatap.Items.Add(item["Muhatap"].ToString());
                dt_muhatap.Add(item["Muhatap"].ToString());
            }


            if (comboBox_SArac.Items.Count > 0)
                comboBox_SArac.SelectedIndex = 0;

            comboBox_STahsilTuru.SelectedIndex = 0;

            if (comboBox_Muhatap.Items.Count > 0)
                comboBox_Muhatap.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                DataRow r = dt_kayit.Rows[dataGridView1.SelectedRows[0].Index];
                int id = Convert.ToInt32(r["ID"].ToString());
                Kayit.Sil(id.ToString());
                VerileriYukle();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index + 1 == dataGridView1.Rows.Count)
                return;
            DataRow r = dt_kayit.Rows[e.RowIndex];
            string id = r["ID"].ToString();
            string arac = r["Arac"].ToString();
            string tturu = r["TahsilTuru"].ToString();
            string ttarihi = Convert.ToDateTime(r["TahsilTarihi"]).ToLongDateString();
            string ttarihi_edildi = r["IslemTarihi"].ToString() == "" ? "--" : Convert.ToDateTime(r["IslemTarihi"].ToString()).ToLongDateString();
            string aciklama = r["Aciklama"].ToString();
            string muhatap = r["Muhatap"].ToString();
            string tutar = r["Tutar"].ToString();
            string durum = r["Durum"].ToString() == "False" ? "Yapılmadı" : "Yapıldı";

            lbl_arac.Text = arac;
            lbl_aciklama.Text = aciklama;
            lbl_durum.Text = durum;
            lbl_muhatap.Text = muhatap;
            lbl_tturu.Text = tturu;
            lbl_ttutar.Text = tutar;
            lbl_ttarih.Text = ttarihi;
            lbl_ttarihi_edildi.Text = ttarihi_edildi;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> sorgular = new List<string>();

            string sorgu = "";
            if (comboBox_SArac.SelectedIndex != 0)
            {
                sorgu = "Arac='" + comboBox_SArac.SelectedItem.ToString() + "'";
                sorgular.Add(sorgu);
            }
            if (comboBox_STahsilTuru.SelectedIndex != 0)
            {
                sorgu = " TahsilTuru='" + comboBox_STahsilTuru.SelectedItem.ToString() + "'";
                sorgular.Add(sorgu);
            }

            if (comboBox_Muhatap.SelectedIndex != 0)
            {
                sorgu = " Muhatap='" + comboBox_Muhatap.SelectedItem.ToString() + "'";
                sorgular.Add(sorgu);
            }
            if (checkBox_TahsilEdilen.Checked)
            {
                sorgu = " Durum=True ";
                sorgular.Add(sorgu);
            }

            if (checkBox1.Checked)
            {
                // dt.Select("DATE1 <= '" + date1+ "' AND DATE2 >= '" + date1+ '"');
                sorgu = "TahsilTarihi >='" + dateTimePicker1.Value.ToString() + "' and TahsilTarihi<='" + dateTimePicker2.Value.ToString() + "'";
                sorgular.Add(sorgu);
            }

            if (sorgular.Count > 1)
            {
                sorgu = "";
                for (int i = 0; i < sorgular.Count; i++)
                {
                    if (i == sorgular.Count - 1)
                        sorgu += sorgular[i];
                    else
                        sorgu += sorgular[i] + " and ";
                }
            }
            try
            {
                dataGridView1.DataSource = dt_kayit.Select(sorgu).CopyToDataTable();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Aranan Kritere Uygun Kayit Bulanamadı !!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index + 1 == dataGridView1.Rows.Count)
                return;
            Kayit.TahsilEt(Convert.ToInt32(dt_kayit.Rows[dataGridView1.SelectedRows[0].Index]["ID"].ToString()));
            MessageBox.Show("Tahsil Edildi !");
            VerileriYukle();
        }
        public static void GridNumaralandir(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    string sayi = (count + 1).ToString().PadLeft(dataGridView.Rows.Count.ToString().Length, '0');
                    dataGridView.Rows[count].HeaderCell.Value = sayi;
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridNumaralandir(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            if (dataGridView1.SelectedRows[0].Index + 1 == dataGridView1.Rows.Count)
                return;
            DataRow r = dt_kayit.Rows[dataGridView1.SelectedRows[0].Index];
            string id = r["ID"].ToString();
            string arac = r["Arac"].ToString();
            string tturu = r["TahsilTuru"].ToString();
            string ttarihi = Convert.ToDateTime(r["TahsilTarihi"]).ToLongDateString();
            string ttarihi_edildi = r["IslemTarihi"].ToString() == "" ? "--" : Convert.ToDateTime(r["IslemTarihi"].ToString()).ToLongDateString();
            string aciklama = r["Aciklama"].ToString();
            string muhatap = r["Muhatap"].ToString();
            string tutar = r["Tutar"].ToString();
            string durum = r["Durum"].ToString() == "False" ? "Yapılmadı" : "Yapıldı";

            lbl_arac.Text = arac;
            lbl_aciklama.Text = aciklama;
            lbl_durum.Text = durum;
            lbl_muhatap.Text = muhatap;
            lbl_tturu.Text = tturu;
            lbl_ttutar.Text = tutar;
            lbl_ttarih.Text = ttarihi;
            lbl_ttarihi_edildi.Text = ttarihi_edildi;
        }

        private void AnaForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Height > 500)
            {
                groupBox_Veri.Height += this.Height - groupBox_Sorgu.Height - 200;
            }
            if (this.Width > 1100)
            {
                groupBox_Sorgu.Width = this.Width;
                groupBox_Veri.Width = this.Width;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
