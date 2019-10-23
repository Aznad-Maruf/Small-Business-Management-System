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
    public class CategoryRepository
    {
        public bool Save(CategoryModel categoryModel)
        {
            bool isAdded = false;
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string CommandString = @"INSERT INTO Category ( Code, Name) VALUES('" + categoryModel.Code + "','" + categoryModel.Name + "')";

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

        public bool IsExists(CategoryModel categoryModel)
        {
            bool exists = false;

            try
            {
                //connection
                string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(conn);

                //command
                string search = @"SELECT * FROM Category WHERE Code = '" + categoryModel.Code + "' OR Name = '" + categoryModel.Name + "'";
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

        public List<CategoryModel> ShowAll()
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);

            //command
            string show = @"SELECT * FROM Category";
            SqlCommand sqlCommand = new SqlCommand(show, sqlConnection);

            //open
            sqlConnection.Open();

            //Execution
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<CategoryModel> categoryModels = new List<CategoryModel>();
            while (sqlDataReader.Read())
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.Code = sqlDataReader["Code"].ToString();
                categoryModel.Name = sqlDataReader["Name"].ToString();

                categoryModels.Add(categoryModel);
            }

            //close
            sqlConnection.Close();
            return categoryModels;
        }

        public DataTable SearchCategory(CategoryModel categoryModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string search = @"SELECT * FROM Category WHERE Code = '" + categoryModel.Code + "' OR Name = '" + categoryModel.Name + "'";

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

        public bool UpdateCategory(CategoryModel categoryModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string search = @"UPDATE Category SET Code = '" + categoryModel.Code + "', Name = '" + categoryModel.Name + "' WHERE Code = '" + categoryModel.Code + "' ";

            SqlCommand sqlCommand = new SqlCommand(search, sqlConnection);

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
    }
}
