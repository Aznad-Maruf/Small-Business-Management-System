using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{
    public class PurchaseManager
    {
        private readonly PurchaseRepository _purchaseRepository = new PurchaseRepository();
        public List<PurchaseDetails> PurchaseDetailsList = new List<PurchaseDetails>();

        public List<string> GetListForComboBox(string tableName, string category = "-Select-")
        {
            category = ExtractCode(category);
            return _purchaseRepository.GetListForComboBox(tableName, category);
        }

        public string CanBeAdded(PurchaseModel purchaseModel)
        {
            if (!IsSelected(purchaseModel.Category)) return "Select Category";
            if (!IsSelected(purchaseModel.Customer)) return "Select Customer";
            if (!IsSelected(purchaseModel.Product)) return "Select Product";
            if (purchaseModel.Quantity == 0) return "Out of stock.";

            return "True";
        }

        public void AddToPurchase(PurchaseModel purchaseModel)
        {
            purchaseModel.Category = ExtractCode(purchaseModel.Category);
            purchaseModel.Customer = ExtractCode(purchaseModel.Customer);
            purchaseModel.Product = ExtractCode(purchaseModel.Product);
            _purchaseRepository.AddToPurchase(purchaseModel);
        }

        /*------- Methods ------*/
        private bool IsSelected(string str)
        {
            return !(str.Equals("-Selceted-") || String.IsNullOrEmpty(str));
        }

        internal double GetAvailableQuantity(string category, string product)
        {
            category = ExtractCode(category); product = ExtractCode(product);
            double quantity = _purchaseRepository.GetAvailableQuantity(category, product);
            foreach (ProductDetails productDetails in productDetailsList)
            {
                if (ExtractCode(productDetails.Category).Equals(category) && ExtractCode(productDetails.Product).Equals(product))
                    quantity -= productDetails.Quantity;
            }

            return quantity;
        }

        private string ExtractCode(string str)
        {
            if (str != "-Select-") str = str.Substring(str.Length - 5, 4);
            return str;
        }

        public string GetLoyaltyPoint(string customer)
        {
            return _purchaseRepository.GetLoyaltyPoint(ExtractCode(customer));
        }

        public string GetMrp(string category, string product)
        {
            category = ExtractCode(category);
            product = ExtractCode(product);
            return _purchaseRepository.GetMrp(category, product);
        }

        public void AddToCart(ProductDetails productDetails)
        {
            productDetails.SI = productDetailsList.Count;
            productDetails.Edit = "Edit";
            productDetails.Delete = "Delete";
            productDetailsList.Add(productDetails);
        }

        public string GetInfo(string whichInfo, double loyaltyPoint, string customer = "(1000)")
        {
            double total = 0;

            foreach (ProductDetails productDetails in productDetailsList)
            {
                total += productDetails.TotalMrp;
            }

            if (whichInfo.Equals("grandTotal")) return total.ToString();
            if (whichInfo.Equals("discountPercentage"))
            {
                //_purchaseRepository.SetLoyaltyPoint(ExtractCode(customer), (loyaltyPoint-loyaltyPoint/10.0).ToString());

                return (loyaltyPoint / 10.0).ToString();
            }

            if (whichInfo.Equals("discountAmount")) return (total * loyaltyPoint / 1000.0).ToString();
            if (whichInfo.Equals("payableAmount")) return (total - (total * loyaltyPoint / 1000.0)).ToString();
            return null;
        }

        public double GetNewLoyaltyPoint(string customer, string loyaltyPointText)
        {
            customer = ExtractCode(customer);
            double loyaltyPoint = Convert.ToDouble(loyaltyPointText);
            loyaltyPoint += Convert.ToDouble(GetInfo("grandTotal", loyaltyPoint)) / 1000;

            //_purchaseRepository.SetLoyaltyPoint(customer, loyaltyPoint.ToString());

            return Math.Min(loyaltyPoint, 1000);
        }

        public void AddListToPurchase()
        {
            PurchaseModel purchaseModel = new PurchaseModel();
            foreach (ProductDetails productDetails in productDetailsList)
            {
                AddToPurchase(productDetails.PurchaseModel);
            }

            productDetailsList.Clear();
        }

        public void SetLoyaltyPoint(string customer, double loyaltyPoint)
        {
            _purchaseRepository.SetLoyaltyPoint(ExtractCode(customer), loyaltyPoint.ToString());
        }

        public void DeleteFromCart(string si)
        {
            for (int a_i = 0; a_i < productDetailsList.Count; a_i++)
            {
                if (productDetailsList[a_i].SI.ToString().Equals(si)) productDetailsList.RemoveAt(a_i);
            }
        }
    }
}
