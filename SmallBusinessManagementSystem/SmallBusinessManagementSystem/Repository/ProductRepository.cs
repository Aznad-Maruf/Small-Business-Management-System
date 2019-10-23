using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Repository
{
    public class ProductRepository
    {
        public DataTable LoadCategory(ProductModel productModel)
        {
            string connectionString = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT Name FROM Category";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            DataRow row = dataTable.NewRow();
            row[0] = 0;
            row[0] = "--select--";
            dataTable.Rows.InsertAt(row, 0);


            sqlConnection.Close();
            return dataTable;

            // return dataTable;


        }

        public bool Save(ProductModel productModel)
        {
            bool isAdded = false;
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string CommandString = @"INSERT INTO Product ( Code, Name , Category, ReorderLevel, Description) VALUES('" + productModel.Code + "','" + productModel.Name + "', '" + productModel.Category + "', " + productModel.ReorderLevel + ", '" + productModel.Description + "') ";

                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return isAdded = true;
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return isAdded;
        }

        public bool IsExists(ProductModel productModel)
        {
            bool exists = false;

            try
            {
                //connection
                string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(conn);

                //command
                string search = @"SELECT * FROM Product WHERE Code = '" + productModel.Code + "' OR Name = '" + productModel.Name + "'";
                SqlCommand sqlCommand = new SqlCommand(search, sqlConnection);

                //open
                sqlConnection.Open();

                //execution
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }

                //close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return exists;
        }

        public List<ProductModel> ShowAll()
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);

            //command
            string show = @"SELECT * FROM Product";
            SqlCommand sqlCommand = new SqlCommand(show, sqlConnection);

            //open
            sqlConnection.Open();

            //Execution
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ProductModel> productModels = new List<ProductModel>();
            while (sqlDataReader.Read())
            {
                ProductModel productModel = new ProductModel();
                productModel.Code = sqlDataReader["Code"].ToString();
                productModel.Name = sqlDataReader["Name"].ToString();
                productModel.Category = sqlDataReader["Category"].ToString();
                productModel.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                productModel.Description = sqlDataReader["Description"].ToString();

                productModels.Add(productModel);
            }

            //close
            sqlConnection.Close();
            return productModels;
        }

        public bool UpdateProduct(ProductModel productModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string update = @"UPDATE Product SET Code = '" + productModel.Code + "', Name = '" + productModel.Name + "', ReorderLevel = " + productModel.ReorderLevel + ", Description = '" + productModel.Description + "' WHERE Code = '" + productModel.Code + "' ";

            SqlCommand sqlCommand = new SqlCommand(update, sqlConnection);

            //open
            sqlConnection.Open();

            int updated = sqlCommand.ExecuteNonQuery();
            if (updated > 0)
            {
                return true;
            }


            //close
            sqlConnection.Close();
            return false;
        }

        public DataTable SearchProduct(ProductModel productModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string search = @"SELECT * FROM Product WHERE Category = '" + productModel.Category + "' OR Name = '" + productModel.Name + "' OR Code = '" + productModel.Code + "' ";

            SqlCommand sqlCommand = new SqlCommand(search, sqlConnection);

            //open
            sqlConnection.Open();

            //execution
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable;
            }

            //close
            sqlConnection.Close();

            return dataTable;
        }
    }
}
