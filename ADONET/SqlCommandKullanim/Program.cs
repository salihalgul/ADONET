using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection can=new SqlConnection(@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=SQLFULL;Integrated Security=True; User Id=udemy; Password=1");
            SqlCommand command=new SqlCommand("insert into Musterim values (1,'Can','Boz')",can);

            can.Open();
            int kackayit=command.ExecuteNonQuery();
            can.Close();

            Console.WriteLine($"Etkilenen kayit sayisi : {kackayit}");
            Console.ReadLine();
        }
    }
}
