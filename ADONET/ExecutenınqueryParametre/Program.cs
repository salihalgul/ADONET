using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutenınqueryParametre
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri canan=new Musteri();
            canan.MusteriID = 4;
            canan.Isim = "Canan";
            canan.Soyisim="Canlı";

            SqlConnection can = new SqlConnection(@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=SQLFULL;Integrated Security=True; User Id=udemy; Password=1");
            SqlCommand command=new SqlCommand("insert into Musterim values (@ID,@Isim,@Soyisim)",can);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = canan.MusteriID;
            command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = canan.Isim;
            command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = canan.Soyisim;

            can.Open();
            int degisiklikvarmi= command.ExecuteNonQuery();
            can.Close();

            Console.WriteLine($"Etkilenen kayit sayisi {degisiklikvarmi}");
            Console.ReadLine();

        }
    }
}
