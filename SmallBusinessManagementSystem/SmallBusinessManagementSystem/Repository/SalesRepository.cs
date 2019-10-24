using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using System.Data;
using System.Data.SqlClient;

namespace SmallBusinessManagementSystem.Repository
{
    public class SalesRepository
    {
        private readonly ConnectionRepository _connectionRepository = new ConnectionRepository();
        private SqlDataReader _sqlDataReader;
        private string _commandString;

        public List<string> GetListForComboBox(string tableName, string category="-Select-")
        {
            List<string> list = new List<string> ();

            _commandString = $"SELECT Name + '(' + Code + ')' AS {tableName} FROM {tableName}";
            if (tableName.Equals("Product")&&category!="-Select")
            {
                list.Clear();
                _commandString += $" WHERE Category = {category}";
            }
            ExecuteQuery();

            while (_sqlDataReader.Read())
            {
                list.Add(_sqlDataReader[$"{tableName}"].ToString());
            }

            CloseConnection();

            return list;
        }

        internal double GetAvailableQuantity(string category, string product)
        {
            _commandString = $"SELECT Quantity FROM Available WHERE Category = {category} AND Product = {product};";
            //_commandString = $"SELECT * FROM Available;";
            ExecuteQuery();
            double quantity=0;
            while (_sqlDataReader.Read())
            {
                quantity = Convert.ToDouble(_sqlDataReader["Quantity"].ToString());
            }
            CloseConnection();

            return quantity;
        }

        public void AddToSales(SalesModel salesModel)
        {
            _commandString = $"INSERT INTO Sales(Date, Customer, Category, Product, Quantity) VALUES ('{salesModel.Date}', '{salesModel.Customer}', '{salesModel.Category}', '{salesModel.Product}', '{salesModel.Quantity}');";
            ExecuteNonQuery();
        }

        public string GetLoyaltyPoint(string customerCode)
        {
            _commandString = $"SELECT LoyalityPoint FROM Customer WHERE Code = '{customerCode}';";
            ExecuteQuery();
            string loyaltyPoint = "0";
            while (_sqlDataReader.Read())
            {
                loyaltyPoint = _sqlDataReader["LoyalityPoint"].ToString();
            }
            CloseConnection();

            return loyaltyPoint;
        }

        public string GetMrp(string category, string product)
        {
            _commandString = $"SELECT MRP FROM Purchase WHERE Category = '{category}' AND Product = '{product}';";

            ExecuteQuery();
            string mrp = "0";
            while (_sqlDataReader.Read())
            {
                mrp = _sqlDataReader["MRP"].ToString();
            }
            CloseConnection();

            return mrp;
        }

        /*---- Data Methods --------*/
        private void ExecuteQuery()
        {
           _sqlDataReader = _connectionRepository.ExecuteQueryAndGetSqlDataReader(_commandString);
        }

        private void ExecuteNonQuery()
        {
            _connectionRepository.ExecuteNonQuery(_commandString);
        }


        private void CloseConnection()
        {
            _connectionRepository.CloseConnection();
        }

        public void SetLoyaltyPoint(string customer, string loyaltyPoint)
        {
            _commandString = $"UPDATE Customer SET LoyalityPoint = '{loyaltyPoint}' Where Code = '{customer}';";
            ExecuteNonQuery();
        }
    }
}
