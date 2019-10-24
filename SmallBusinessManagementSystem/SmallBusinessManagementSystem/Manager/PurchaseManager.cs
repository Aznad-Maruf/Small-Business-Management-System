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
        public List<PurchaseModel> PurchaseModelList = new List<PurchaseModel>();

        public List<string> GetListForComboBox(string tableName, string category = "-Select-")
        {
            return _purchaseRepository.GetListForComboBox(tableName, category);
        }

        //public string CanBeAdded(PurchaseModel purchaseModel)
        //{
        //    if (!IsSelected(purchaseModel.Category)) return "Select Category";
        //    if (!IsSelected(purchaseModel.Customer)) return "Select Customer";
        //    if (!IsSelected(purchaseModel.Product)) return "Select Product";
        //    if (purchaseModel.Quantity == 0) return "Out of stock.";

        //    return "True";
        //}

        public void AddToPurchase(PurchaseModel purchaseModel)
        {
            _purchaseRepository.AddToPurchase(purchaseModel);
        }

        public void AddToCart(PurchaseModel purchaseModel)
        {
            purchaseModel.SI = (PurchaseModelList.Count + 1).ToString();
            PurchaseModelList.Add(purchaseModel);
        }

        ///*------- Methods ------*/
        //private bool IsSelected(string str)
        //{
        //    return !(str.Equals("-Selceted-") || String.IsNullOrEmpty(str));
        //}

        internal double GetAvailableQuantity(PurchaseModel purchaseModel)
        {
            double quantity = _purchaseRepository.GetAvailableQuantity(purchaseModel.Category, purchaseModel.Code);
            foreach (PurchaseModel cuPurchaseModel in PurchaseModelList)
            {
                if (cuPurchaseModel.Category.Equals(purchaseModel.Category) &&
                    cuPurchaseModel.Product.Equals(purchaseModel.Code)) quantity += cuPurchaseModel.Quantity;
            }

            return quantity;
        }

        //private string ExtractCode(string str)
        //{
        //    if (str != "-Select-") str = str.Substring(str.Length - 5, 4);
        //    return str;
        //}

        //public string GetLoyaltyPoint(string customer)
        //{
        //    return _purchaseRepository.GetLoyaltyPoint(ExtractCode(customer));
        //}

        //public string GetMrp(string category, string product)
        //{
        //    category = ExtractCode(category);
        //    product = ExtractCode(product);
        //    return _purchaseRepository.GetMrp(category, product);
        //}


        //public string GetInfo(string whichInfo, double loyaltyPoint, string customer = "(1000)")
        //{
        //    double total = 0;

        //    foreach (ProductDetails productDetails in productDetailsList)
        //    {
        //        total += productDetails.TotalMrp;
        //    }

        //    if (whichInfo.Equals("grandTotal")) return total.ToString();
        //    if (whichInfo.Equals("discountPercentage"))
        //    {
        //        //_purchaseRepository.SetLoyaltyPoint(ExtractCode(customer), (loyaltyPoint-loyaltyPoint/10.0).ToString());

        //        return (loyaltyPoint / 10.0).ToString();
        //    }

        //    if (whichInfo.Equals("discountAmount")) return (total * loyaltyPoint / 1000.0).ToString();
        //    if (whichInfo.Equals("payableAmount")) return (total - (total * loyaltyPoint / 1000.0)).ToString();
        //    return null;
        //}

        //public double GetNewLoyaltyPoint(string customer, string loyaltyPointText)
        //{
        //    customer = ExtractCode(customer);
        //    double loyaltyPoint = Convert.ToDouble(loyaltyPointText);
        //    loyaltyPoint += Convert.ToDouble(GetInfo("grandTotal", loyaltyPoint)) / 1000;

        //    //_purchaseRepository.SetLoyaltyPoint(customer, loyaltyPoint.ToString());

        //    return Math.Min(loyaltyPoint, 1000);
        //}

        public void AddListToPurchase()
        {
            foreach (PurchaseModel purchaseModel in PurchaseModelList)
            {
                AddToPurchase(purchaseModel);
            }

            PurchaseModelList.Clear();
        }

        //public void SetLoyaltyPoint(string customer, double loyaltyPoint)
        //{
        //    _purchaseRepository.SetLoyaltyPoint(ExtractCode(customer), loyaltyPoint.ToString());
        //}

        public void DeleteFromCart( string si)
        {
            for (int a_i = 0; a_i < PurchaseModelList.Count; a_i++)
            {
                if (PurchaseModelList[a_i].SI.ToString().Equals(si)) PurchaseModelList.RemoveAt(a_i);
            }
        }

        public void FillUpPurchaseInfo(PurchaseModel purchaseModel)
        {
            _purchaseRepository.FillUpPurchaseInfo(purchaseModel);
        }

        public List<SupplierModel> GetSupplierList()
        {
            return _purchaseRepository.GetSupplierList();
        }

        public List<CategoryModel> GetCategoryList()
        {
            return _purchaseRepository.GetCategoryList();
        }

        public List<ProductModel> GetProductList(string category)
        {
            return _purchaseRepository.GetProductList(category);
        }

        public bool IsUniqueInvoiceNo(string invoiceNo)
        {
            return _purchaseRepository.IsUniqueInvoiceNo(invoiceNo);
        }

        public PurchaseModel GetPurchaseModel(string si)
        {
            foreach (PurchaseModel purchaseModel in PurchaseModelList)
            {
                if (purchaseModel.SI.Equals(si)) return purchaseModel;
            }

            return PurchaseModelList[0];
        }
    }
}
