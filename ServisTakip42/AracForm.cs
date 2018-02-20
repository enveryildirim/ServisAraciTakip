using ServisTakip42.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip42
{
    public partial class AracForm : Form
    {
        public AracForm()
        {
            InitializeComponent();
        }
        static int durum = 0;
        static DataTable dt = null;
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            durum = 1;
            txt_aciklama.Text = txt_plaka.Text = txt_sofor.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Select("Plaka ='" + comboBox_Arac.SelectedItem.ToString() + "'")[0];
            txt_plaka.Text = dr["Plaka"].ToString();
            txt_sofor.Text = dr["Sofor"].ToString();
            txt_aciklama.Text = dr["Aciklama"].ToString();
            groupBox1.Enabled = true;
            durum = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(comboBox_Arac.SelectedItem.ToString() + "-Plakalı Arac Silinsin mi !", "Araç Silme", MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                Arac a = new Arac() { Plaka = txt_plaka.Text.Trim(), Aciklama = txt_aciklama.Text.Trim(), Sofor = txt_sofor.Text.Trim() };
                MessageBox.Show("  Araç Silindi!");
                Arac.Sil(a);
                txt_aciklama.Text = txt_plaka.Text = txt_sofor.Text = "";
                groupBox1.Enabled = false;
                comboBox_Arac.Text = "";
                VerileriYukle();
            }
        }

        private void AracForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            
        }

        private void comboBox_Arac_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRow dr = dt.Select("Plaka ='" + comboBox_Arac.SelectedItem.ToString() + "'")[0];
            txt_plaka.Text = dr["Plaka"].ToString();
            txt_sofor.Text = dr["Sofor"].ToString();
            txt_aciklama.Text = dr["Aciklama"].ToString();
            durum = 0;
            groupBox1.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DurumKontrol())
                return;
            Arac a = new Arac() { Plaka = txt_plaka.Text.Trim(), Aciklama = txt_aciklama.Text.Trim(), Sofor = txt_sofor.Text.Trim() };
            if (durum == 1)
            {
                Arac.Ekle(a);
                MessageBox.Show("Araç Eklendi !!!");
                VerileriYukle();
                durum = 0;
            }
            else if (durum == 2)
            {
                Arac.Guncelle(a, comboBox_Arac.SelectedItem.ToString());
                MessageBox.Show("Araç Güncellendi !!!");
                VerileriYukle();
                durum = 0;
            }
            groupBox1.Enabled = false;
        }
        void VerileriYukle()
        {
            comboBox_Arac.Items.Clear();
            dt = Arac.GetAll();
            if (dt.Rows.Count <= 0)
                MessageBox.Show("HİÇ ARAÇ EKLENMEMİŞ");
            foreach (DataRow item in dt.Rows)
            {
                comboBox_Arac.Items.Add(item["Plaka"].ToString());
            }
            if (comboBox_Arac.Items.Count > 0)
                comboBox_Arac.SelectedIndex = 0;
        }
        bool DurumKontrol()
        {
            int durum = 1;
            if (txt_plaka.Text.Trim() == "")
            {
                MessageBox.Show("Plaka Alanı Boş Bırakılamaz");
                durum = durum * 0;

            }


            var regex = new Regex("(?<İl>[0-8][0-9]) (?<A>[a-zA-Z]{1,3}) (?<N>[0-9]{2,5})");
            var match = regex.Match(txt_plaka.Text);
            if (!match.Success)
            {
                MessageBox.Show("Plaka Düzgün Giriniz !!!");
                durum = durum * 0;
            }


            return Convert.ToBoolean(durum);
        }
    }
}
