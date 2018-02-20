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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }
        public Kayit temp { get; set; }
        public DataTable dt_Arac { get; set; }
        public List<string> list_muhatap { get; set; }
        private void Kayit_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            if (temp != null)
            {
                comboBox_Arac.SelectedItem = temp.Arac;
                comboBox_Tahsilturu.SelectedItem = temp.TahsilTuru;
                txt_aciklama.Text = temp.Aciklama;
                txt_muhatap.Text = temp.Muhatap;
                txt_tutar.Text = temp.Tutar.ToString();
                dateTimePicker_TahsilTarihi.Value = temp.TahsilTarihi;
                button5.Text = "Guncelle";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
                return;

            Kayit k = new Kayit()
            {
                ID = lbl_id.Text.Length <= 0 ? 0 : Convert.ToInt32(lbl_id.Text),
                Arac = comboBox_Arac.SelectedItem.ToString(),
                TahsilTuru = comboBox_Tahsilturu.SelectedItem.ToString(),
                TahsilTarihi = dateTimePicker_TahsilTarihi.Value,
                Tutar = Convert.ToDouble(txt_tutar.Text),
                Aciklama = txt_aciklama.Text,
                Muhatap = txt_muhatap.Text,
                Durum = true,
                SilMi = false
            };
            if (temp == null)
            {

                Kayit.Ekle(k);
                MessageBox.Show("Eklendi !!");
            }
            else
            {
                Kayit.Guncelle(k);
                MessageBox.Show("Güncellendi !!");
            }

            this.Close();

        }
        void VerileriYukle()
        {
            foreach (DataRow item in dt_Arac.Rows)
            {
                comboBox_Arac.Items.Add(item["Plaka"].ToString());
            }
            txt_muhatap.AutoCompleteCustomSource.AddRange(list_muhatap.ToArray());

            if (comboBox_Arac.Items.Count > 0)
                comboBox_Arac.SelectedIndex = 0;

            if (comboBox_Tahsilturu.Items.Count > 0)
                comboBox_Tahsilturu.SelectedIndex = 0;
        }
        bool KontrolEt()
        {
            int durum = 1;

            //tutar sadece para olacak

            if (dateTimePicker_TahsilTarihi.Value < DateTime.Now)
            {
                MessageBox.Show("Tahsil Tarihi Bugünden Küçük");
                durum = durum * 0;
            }

            if (txt_tutar.Text == "")
            {
                MessageBox.Show("Tutar Boş Alan Bırakmayınız");
                durum = durum * 0;
            }

            return Convert.ToBoolean(durum);
        }
    }
}
