using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class ProductsInDatabase : Irepository
    {
        public void AddProductDetails(Iproduct product, int totalFare)
        {
            var time = DateTime.Now;
            Logging.Instance.AddLoggingDetails( product.ProductType + " Product is added to database at " + time);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAVDESK128; Initial Catalog=BookingProducts; User Id=sa; Password=test123!@#";
            con.Open();
            Console.WriteLine(con.State);
            string query = "insert into " + product.ProductType + " values (@ProductType,@ProductName,@ProductPrice,@IsBooked,@ProductFare)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.Add(new SqlParameter("@ProductType", product.ProductType));
            cmd.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
            cmd.Parameters.Add(new SqlParameter("@ProductPrice", product.ProductPrice));
            cmd.Parameters.Add(new SqlParameter("@IsBooked", product.IsBooked));
            cmd.Parameters.Add(new SqlParameter("@ProductFare", totalFare));

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
