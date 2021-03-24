using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PersonelAPP
{
    internal class DataAccesLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int sonuc = 0;
        public DataAccesLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

        }
        public void BaglantiAyarla()//baglantı durumuna göre sistemi aç veya kapat
        {
            if (connect.State==System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                connect.Close();
            }
        }
    }
}
