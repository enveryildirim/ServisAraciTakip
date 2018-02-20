using ServisTakip42.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakip42.Model
{
    public class Kayit
    {
        public int ID { get; set; }
        public string Arac { get; set; }
        public string TahsilTuru { get; set; }
        public DateTime TahsilTarihi { get; set; }
        public double Tutar { get; set; }
        public string Muhatap { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime IslemTarihi { get; set; }
        public bool SilMi { get; set; }


        public static void Ekle(Kayit k)
        {
            string sorgu = "insert into Kayitlar" +
                "(Arac,TahsilTuru,TahsilTarihi,Tutar,Aciklama,Muhatap,Durum,Sil) values" +
                "(@arac,@tturu,@ttarihi,@tutar,@aciklama,@muhatap,@durum,@sil)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@arac", k.Arac);
            param.Add("@tturu", k.TahsilTuru);
            param.Add("@ttarihi", k.TahsilTarihi);
            param.Add("@tutar", k.Tutar);
            param.Add("@aciklama", k.Aciklama);
            param.Add("@muhatap", k.Muhatap);
            param.Add("@durum", false);
            param.Add("@sil", false);

            DB.ExecuteCommand(sorgu, param);
        }
        public static void Guncelle(Kayit k)
        {
            string sorgu = "update Kayitlar set " +
               " Arac=@arac,TahsilTuru=@tturu,TahsilTarihi=@ttarihi,Tutar=@tutar,Aciklama=@aciklama,Muhatap=@muhatap " +
               " where ID=@id";
            Dictionary<string, object> param = new Dictionary<string, object>();

            param.Add("@arac", k.Arac);
            param.Add("@tturu", k.TahsilTuru);
            param.Add("@ttarihi", k.TahsilTarihi);
            param.Add("@tutar", k.Tutar);
            param.Add("@aciklama", k.Aciklama);
            param.Add("@muhatap", k.Muhatap);
            param.Add("@id", k.ID);

            DB.ExecuteCommand(sorgu, param);
        }
        public static void Sil(string id)
        {
            string sorgu = "delete from Kayitlar where ID=@id";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@id", id);
            DB.ExecuteCommand(sorgu, param);
        }
        public static DataTable GetAll()
        {
            //!!!!!!!!!!!!!!!! Sil Ekelenecek !!!!!!!!!!!!!!!!!!!!!!!!!!
            string sorgu = "select * from Kayitlar";
            return DB.ExecuteCommandReturnTable(sorgu, null);
        }
        public static void TahsilEt(int id)
        {
            string sorgu = "update Kayitlar set Durum=True , IslemTarihi=@t where ID=@id";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@id", id);
            param.Add("@t", DateTime.Now);
            DB.ExecuteCommand(sorgu, param);
        }
    }
}
