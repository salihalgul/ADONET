using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteScaler
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection can = new SqlConnection(@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=SQLFULL;Integrated Security=True; User Id=udemy; Password=1");
            SqlCommand command=new SqlCommand("select Isim from Musterim where MusteriID = 4",can);

            can.Open();
            string isim= command.ExecuteScalar().ToString();
            can.Close();

            Console.WriteLine($"Müşteri tablosundan dönen değer : {isim}");
            Console.ReadLine();
        }
    }
}
