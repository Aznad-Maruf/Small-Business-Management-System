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
    public class PurchaseRepository
    {
        private readonly ConnectionRepository _connectionRepository = new ConnectionRepository();
        private SqlDataReader _sqlDataReader;
        private string _commandString;

        public List<string> GetListForComboBox(string tableName, string category = "-Select-")
        {
            List<string> list = new List<string>();

            _commandString = $"SELECT Code, Name FROM {tableName}";
            if (tableName.Equals("Product") && category != "-Select")
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

            return list.Count > 0 ? list : null;
        }

        internal double GetAvailableQuantity(string category, string product)
        {
            _commandString = $"SELECT Quantity FROM Available WHERE Category = {category} AND Product = {product};";
            //_commandString = $"SELECT * FROM Available;";
            ExecuteQuery();
            double quantity = 0;
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

        public void SetLoyaltyPoint(string customer, string loyaltyPoint)
        {
            _commandString = $"UPDATE Customer SET LoyalityPoint = '{loyaltyPoint}' Where Code = '{customer}';";
            ExecuteNonQuery();
        }

        public void FillUpPurchaseInfo(PurchaseModel purchaseModel)
        {
            purchaseModel.AvailableQuantity = GetAvailableQuantity(purchaseModel.Category, purchaseModel.Product).ToString();

            _commandString = $"SELECT UnitPrice, MRP FROM Purchase WHERE PurchaseCode IN (SELECT MAX(PurchaseCode) FROM Purchase WHERE Category = '{purchaseModel.Category}' AND Product = '{purchaseModel.Product}'); ";
            ExecuteQuery();
            while (_sqlDataReader.Read())
            {
                purchaseModel.PreviousUnitPrice = _sqlDataReader["UnitPrice"].ToString();
                purchaseModel.PreviousMRP = _sqlDataReader["MRP"].ToString();
            }
        }

        public List<SupplierModel> GetSupplierList()
        {
            List<SupplierModel> list = new List<SupplierModel>();
            string tableName = "Supplier";
            _commandString = $"SELECT Code, Name FROM {tableName}";
            ExecuteQuery();

            while (_sqlDataReader.Read())
            {
                SupplierModel supplierModel = new SupplierModel();
                supplierModel.Code = _sqlDataReader["Code"].ToString();
                supplierModel.Name = _sqlDataReader["Name"].ToString();
                list.Add(supplierModel);
            }

            CloseConnection();

            return list.Count > 0 ? list : null;
        }

        public List<CategoryModel> GetCategoryList()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            string tableName = "Category";
            _commandString = $"SELECT Code, Name FROM {tableName}";
            ExecuteQuery();

            while (_sqlDataReader.Read())
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.Code = _sqlDataReader["Code"].ToString();
                categoryModel.Name = _sqlDataReader["Name"].ToString();
                list.Add(categoryModel);
            }

            CloseConnection();

            return list.Count > 0 ? list : null;
        }

        public List<ProductModel> GetProductList(string category)
        {
            List<ProductModel> list = new List<ProductModel>();
            string tableName = "Product";
            _commandString = $"SELECT Code, Name FROM {tableName} WHERE Category = {category}";

            ExecuteQuery();

            while (_sqlDataReader.Read())
            {
                ProductModel productModel = new ProductModel();
                productModel.Code = _sqlDataReader["Code"].ToString();
                productModel.Name = _sqlDataReader["Name"].ToString();
                list.Add(productModel);
            }

            CloseConnection();

            return list.Count > 0 ? list : null;
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

        public bool IsUniqueInvoiceNo(string invoiceNo)
        {
            bool isUnique = true;
            _commandString = $"SELECT InvoiceNo FROM Purchase;";
            ExecuteQuery();
            while (_sqlDataReader.Read())
            {
                if (_sqlDataReader["InvoiceNo"].ToString().Equals(invoiceNo)) isUnique = false;
            }
            CloseConnection();

            return isUnique;
        }

        public void AddToPurchase(PurchaseModel purchaseModel)
        {
            _commandString =
                $"INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, ExpireDate, Quantity, UnitPrice, MRP, Remarks) VALUES('{purchaseModel.InvoiceNo}', '{purchaseModel.Date}', '{purchaseModel.Supplier}', '{purchaseModel.Category}', '{purchaseModel.Product}', '{purchaseModel.ManufactureDate}', '{purchaseModel.ExpireDate}', '{purchaseModel.Quantity}', '{purchaseModel.UnitPrice}', '{purchaseModel.MRP}', '{purchaseModel.Remarks}');";
            ExecuteNonQuery();
        }
    }
}
