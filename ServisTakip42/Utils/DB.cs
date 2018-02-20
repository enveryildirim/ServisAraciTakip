using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip42.Utils
{
    public static class DB
    {
        //static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase );
        // static string path = Application.StartupPath;
        // private static OleDbConnection baglan = new OleDbConnection(@"Microsoft.ACE.OLEDB.12.0; Data Source=" + path + "\\database.mdb;");
        /* static void Open()
         {
             if (baglan.State != ConnectionState.Open)
                 baglan.Open();
         }
         static void Close()
         {
             if (baglan.State != ConnectionState.Closed)
                 baglan.Close();
         }*/
        public static DataTable ExecuteCommandReturnTable(string sorgu, Dictionary<string, object> param)
        {
            string path = Application.StartupPath;
            string a = path + "\\veriler.accdb;";

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + a);
            try
            {

                using (DataTable dt = new DataTable())
                {
                    //Open();
                    baglan.Open();
                    OleDbCommand cmd = new OleDbCommand(sorgu, baglan);
                    if (param != null && param.Count > 0)
                        foreach (var item in param)
                            cmd.Parameters.AddWithValue(item.Key, item.Value);

                    OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                    adap.Fill(dt);
                    return dt;

                }
            }
            catch (Exception ex)
            {
                Logger.Yaz(ex.Message);
                return null;
                throw ex;
            }
            finally
            {
                baglan.Close();
                //Close();
            }


        }
        public static void ExecuteCommand(string sorgu, Dictionary<string, object> param)
        {
            string path = Application.StartupPath;
            string a = path + "\\veriler.accdb;";

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + a);
            try
            {

                // Open();
                baglan.Open();
                OleDbCommand cmd = new OleDbCommand(sorgu, baglan);
                if (param != null && param.Count > 0)
                    foreach (var item in param)
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Logger.Yaz(ex.Message);
                throw ex;
            }
            finally
            {
                baglan.Close();
                // Close();
            }
        }
    }
}
