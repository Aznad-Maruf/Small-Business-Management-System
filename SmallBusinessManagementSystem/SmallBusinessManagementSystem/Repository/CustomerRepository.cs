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
    public class CustomerRepository
    {
        public bool Save(CustomerModel customerModel)
        {
            bool isAdded = false;
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string CommandString = @"INSERT INTO Customer ( Code, Name , Address, Email, Contact, LoyalityPoint) VALUES('" + customerModel.Code + "','" + customerModel.Name + "', '" + customerModel.Address + "', '" + customerModel.Email + "', '" + customerModel.Contact + "', " + customerModel.LoyalityPoint + ")";

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

        public bool IsExists(CustomerModel customerModel)
        {
            bool exists = false;

            try
            {
                //connection
                string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(conn);

                //command
                string search = @"SELECT * FROM Customer WHERE Code = '" + customerModel.Code + "' OR Email = '" + customerModel.Email + "' OR Contact = '" + customerModel.Contact + "'";
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

        public List<CustomerModel> ShowAll()
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);

            //command
            string show = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(show, sqlConnection);

            //open
            sqlConnection.Open();

            //Execution
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<CustomerModel> customerModels = new List<CustomerModel>();
            while (sqlDataReader.Read())
            {
                CustomerModel customerModel = new CustomerModel();
                customerModel.Code = sqlDataReader["Code"].ToString();
                customerModel.Name = sqlDataReader["Name"].ToString();
                customerModel.Address = sqlDataReader["Address"].ToString();
                customerModel.Email = sqlDataReader["Email"].ToString();
                customerModel.Contact = sqlDataReader["Contact"].ToString();
                customerModel.LoyalityPoint = Convert.ToInt32(sqlDataReader["LoyalityPoint"]);

                customerModels.Add(customerModel);
            }

            //close
            sqlConnection.Close();
            return customerModels;
        }

        public bool UpdateCustomer(CustomerModel customerModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string update = @"UPDATE Customer SET Code = '" + customerModel.Code + "', Name = '" + customerModel.Name + "', Address = '" + customerModel.Address + "', Email = '" + customerModel.Email + "', Contact ='" + customerModel.Contact + "', LoyalityPoint = " + customerModel.LoyalityPoint + " WHERE Code = '" + customerModel.Code + "' ";

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

        public DataTable SearchCustomer(CustomerModel customerModel)
        {
            //connection
            string conn = @"Server=DESKTOP-QMNU0HM\RAIHANPLAYGROUND;DataBase=Project1DB;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            //command
            string search = @"SELECT * FROM Customer WHERE Name = '" + customerModel.Name + "' OR Email = '" + customerModel.Email + "' OR Contact = '" + customerModel.Contact + "' ";

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
