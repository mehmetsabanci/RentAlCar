using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAlCar
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=MEHMET\SQLEXPRESS;Initial Catalog=RentAlCar;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
