using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakip42.Utils
{
    public static class Logger
    {
        public static void Yaz(string deger)
        {
            string sorgu = "insert into Log(Aciklama) values(@deger)";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@deger", deger);
            DB.ExecuteCommand(sorgu, param);
        }
    }
}
