using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Configuration;


namespace ProWPF_C.Ch19_Databinding.Classes
{
    public class StoreDb
    {
        private string connectionString = ConfigurationManager.AppSettings.Get(
            "defualtConnectionString");

        public Product GetProduct(int ID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetProductByID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", ID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Create a product object that wraps the current object
                    Product product = new Product(
                        (string)reader["ModelNumber"],
                        (string)reader["ModelName"],
                        (decimal)reader["UnitCost"],
                        (string)reader["Description"],
                        (string)reader["ProductImage"]);
                    return product;
                }
                else { return null; }
            }
            catch (Exception) { return null; }
            finally { con.Close(); }
        } // End Product GetProduct(int ID)


        public ICollection<Product> GetProducts()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetProducts", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ObservableCollection<Product> products = new ObservableCollection<Product>();
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Create a Product object that wraps the 
                    // current record.
                    Product product = new Product((string)reader["ModelNumber"],
                        (string)reader["ModelName"], (decimal)reader["UnitCost"],
                        (string)reader["Description"], (int)reader["CategoryID"],
                        (string)reader["CategoryName"], (string)reader["ProductImage"]);
                    // Add to collection
                    products.Add(product);
                }
            }
            finally
            {
                con.Close();
            }

            return products;
        }

        public ICollection<Product> GetProductsFilteredWithLinq(decimal minimumCost)
        {
            // Get the full list of products.
            ICollection<Product> products = GetProducts();

            // Create a second collection with matching products.
            IEnumerable<Product> matches = from product in products
                                           where product.UnitCost >= minimumCost
                                           select product;

            return new ObservableCollection<Product>(matches.ToList());
        }

        public ICollection<Product> GetProductsSlow()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            return GetProducts();
        }


        public bool UpdateProduct(Product product, int ID, int CatID = -1)
        {
            string sql = "";
            sql = "Update Products ";
            sql += " Set ModelNumber=@ModelNum,";
            if (CatID != -1) { sql += " CategoryID=@CatID,"; }
            sql += " ModelName=@ModelName,";
            sql += " ProductImage=@ProdImage,";
            sql += " UnitCost=@UnitCost,";
            sql += " Description=@Desc";
            sql += " Where ProductID=@ProductID";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductID", ID);
            if (CatID != -1) { cmd.Parameters.AddWithValue("@CatID", ID); }
            cmd.Parameters.AddWithValue("@ModelNum", product.ModelNumber);
            cmd.Parameters.AddWithValue("@ModelName", product.ModelName);
            cmd.Parameters.AddWithValue("@ProdImage", product.ProductImagePath);
            cmd.Parameters.AddWithValue("@UnitCost", product.UnitCost);
            cmd.Parameters.AddWithValue("@Desc", product.Description);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { con.Close(); }
            return true;
        }













    } // End Class
}  // End Namespace
