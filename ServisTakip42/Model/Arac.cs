using ServisTakip42.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakip42.Model
{
    public class Arac
    {
        public string Plaka { get; set; }
        public string Aciklama { get; set; }
        public string Sofor { get; set; }
        
        
        public static DataTable GetAll()
        {
            string sorgu = "select * from Arac";
            return DB.ExecuteCommandReturnTable(sorgu, null);
        }

        public static void Ekle(Arac a)
        {
            string sorgu = "insert into Arac(Plaka,Aciklama,Sofor) values(@p,@a,@s)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@p", a.Plaka);
            param.Add("@a", a.Aciklama);
            param.Add("@s", a.Sofor);
            DB.ExecuteCommand(sorgu, param);
        }
        public static void Guncelle(Arac a, string eskiplaka)
        {
            string sorgu = "update Arac set Plaka=@p,Aciklama=@a,Sofor=@s where Plaka=@ep";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@p", a.Plaka);
            param.Add("@a", a.Aciklama);
            param.Add("@s", a.Sofor);
            param.Add("@ep", eskiplaka);
            DB.ExecuteCommand(sorgu, param);
        }
        public static void Sil(Arac a)
        {
            string sorgu = "delete from Arac where Plaka=@p";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@p", a.Plaka);
            DB.ExecuteCommand(sorgu, param);
        }

    }
}
