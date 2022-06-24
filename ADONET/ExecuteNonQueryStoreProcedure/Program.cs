using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteNonQueryStoreProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri canan=new Musteri();
            canan.MusteriID = 54;
            canan.Isim = "Osmann";
            canan.Soyisim = "Guldur";

            SqlConnection can = new SqlConnection(@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=SQLFULL;Integrated Security=True; User Id=udemy; Password=1");
            SqlCommand command=new SqlCommand("sp_musterikayit",can);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@MusteriID", SqlDbType.Int).Value = canan.MusteriID;
            command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = canan.Isim;
            command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = canan.Soyisim;

            can.Open();
           int etkilenenkayit= command.ExecuteNonQuery();
            can.Close();

            Console.WriteLine($"Etklenen kayit sayisi : {etkilenenkayit}");
            Console.ReadLine();
        }
    }
}
