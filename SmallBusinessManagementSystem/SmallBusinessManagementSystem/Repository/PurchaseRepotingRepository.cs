using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;


namespace SmallBusinessManagementSystem.Repository
{
    class PurchaseRepotingRepository
    {
        public List<PurchaseRepotingModel> SearchValue(PurchaseRepotingModel purchaseRepotingModel)
        {
            string connectionString = @"Server=DESKTOP-SQHOV9J\SANJAY;DataBase=Project1DB;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM PurchaseReport WHERE Date BETWEEN '" + purchaseRepotingModel.Date + "'AND '" + purchaseRepotingModel.Date2 + "' ";
            

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<PurchaseRepotingModel> purchaseRepotingModels = new List<PurchaseRepotingModel>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                PurchaseRepotingModel _purchaseRepotingModel = new PurchaseRepotingModel();

                _purchaseRepotingModel.Code = Convert.ToString(sqlDataReader["Code"]);
                _purchaseRepotingModel.Product = Convert.ToString(sqlDataReader["ProductName"]);
                _purchaseRepotingModel.Category = Convert.ToString(sqlDataReader["CategoryName"]);
                _purchaseRepotingModel.Quantity = Convert.ToDouble(sqlDataReader["Quantity"]);
                _purchaseRepotingModel.UnitPrice = Convert.ToDouble(sqlDataReader["TotalPrice"]);
                _purchaseRepotingModel.MRP = Convert.ToDouble(sqlDataReader["TotalMRP"]);
                _purchaseRepotingModel.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                purchaseRepotingModels.Add(_purchaseRepotingModel);
            }

            sqlConnection.Close();

            return purchaseRepotingModels;




        }
    }
}
