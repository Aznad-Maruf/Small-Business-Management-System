using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Manager;

namespace SmallBusinessManagementSystem.UI
{
    public partial class PurchaseUI : Form
    {
        private readonly PurchaseManager _purchaseManager = new PurchaseManager();
        private readonly PurchaseModel _purchaseModel = new PurchaseModel();
        private bool _isCategorySelected = false, _isProductSelected = false, _isSupplierSelected = false, _isQuantitySelected = false;

        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            supplierComboBox.DataSource = _purchaseManager.GetListForComboBox("Supplier");
            categoryComboBox.DataSource = _purchaseManager.GetListForComboBox("Category");
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }


        ------------ Copyy ---------------
        
        List<PurchaseDetails> pdList = new List<PurchaseDetails>();
        private double _loyaltyPoint;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!GetAllData()) return;

            //MessageBox.Show($"{_purchaseModel.Category}{Environment.NewLine}{_purchaseModel.Product}");

            string message = _purchaseManager.CanBeAdded(_purchaseModel);
            if (message.Equals("True"))
            {


                _purchaseManager.AddToCart(GetPurchaseDetails());


                //_purchaseManager.AddToPurchase(_purchaseModel);
                //MessageBox.Show(_purchaseManager.purchaseDetailsList.Count.ToString());


                purchaseDataGridView.DataSource = null;
                purchaseDataGridView.DataSource = _purchaseManager.purchaseDetailsList;

                FillTotalAndAll();

                ClearUI("product");

            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_purchaseManager.purchaseDetailsList.Count == 0)
            {
                MessageBox.Show("Add Item First");
                return;
            }
            _purchaseManager.AddListToPurchase();
            _purchaseManager.SetLoyaltyPoint(customerComboBox.Text, _loyaltyPoint);

            ClearUI("all");
        }

        // --------- Methods --------

        private void FillTotalAndAll()
        {
            _loyaltyPoint = _purchaseManager.GetNewLoyaltyPoint(customerComboBox.Text, loyaltyPointTextBox.Text);
            //MessageBox.Show(_loyaltyPoint.ToString());
            grandTotalTextBox.Text = _purchaseManager.GetInfo("grandTotal", _loyaltyPoint);
            discountTextBox.Text = _purchaseManager.GetInfo("discountPercentage", _loyaltyPoint);
            discountAmountTextBox.Text = _purchaseManager.GetInfo("discountAmount", _loyaltyPoint);
            payableAmountTextBox.Text = _purchaseManager.GetInfo("payableAmount", _loyaltyPoint);
        }

        private void ClearUI(string howMuch)
        {
            if(!howMuch.Equals("Category")||!howMuch.Equals("product"))categoryComboBox.SelectedIndex = -1;
            if (!howMuch.Equals("product")) productComboBox.SelectedIndex = -1;
            codeTextBox.Text = null;
            availableQuantityTextBox.Text = null;
            quantityTextBox.Text = null;
            unitPriceTextBox.Text = null;
            totalPriceTextBox.Text = null;
            previousUnitPriceTextBox.Text = null;
            previousMrpTextBox.Text = null;
            mrpTextBox.Text = null;
            remarksRichTextBox.Text = null;
        }

        private bool GetAllData()
        {
            _purchaseModel.InvoiceNo = invoiceNoTextBox.Text;
            _purchaseModel.Date = DateDateTimePicker.Text;
            _purchaseModel.Supplier = supplierComboBox.Text;
            _purchaseModel.Category = categoryComboBox.Text;
            _purchaseModel.Product = productComboBox.Text;
            _purchaseModel.ManufactureDate = manufactureDateDateTimePicker.Text;
            _purchaseModel.ExpireDate = exipreDateDateTimePicker.Text;
            try
            {
                _purchaseModel.Quantity = Convert.ToDouble(quantityTextBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Must enter a valid Quantity");
                return false;
            }
            try
            {
                _purchaseModel.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Must enter a valid UnitPrice");
                return false;
            }
            try
            {
                _purchaseModel.MRP = Convert.ToDouble(mrpTextBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Must enter a valid MRP");
                return false;
            }

            if (_purchaseModel.Quantity <= 0)
            {
                MessageBox.Show("Quantity Must be Positive");
                return false;
            }
            if (_purchaseModel.UnitPrice < 0)
            {
                MessageBox.Show("UnitPrice must be non negative");
                return false;
            }
            if (_purchaseModel.MRP < 0)
            {
                MessageBox.Show("MRP Must be Non negative");
                return false;
            }

            return true;
        }

        private PurchaseDetails GetPurchaseDetails()
        {
            PurchaseDetails purchaseDetails = new PurchaseDetails();

            purchaseDetails.ManufacturedDate = _purchaseModel.ManufactureDate;
            purchaseDetails.ExpiredDate = _purchaseModel.ExpireDate;
            purchaseDetails.MRP = _purchaseModel.MRP;
            purchaseDetails.Product = _purchaseModel.Product;
            purchaseDetails.Quantity = _purchaseModel.Quantity;
            purchaseDetails.UnitPrice = _purchaseModel.UnitPrice;
            purchaseDetails.TotalPrice = _purchaseModel.Quantity * _purchaseModel.UnitPrice;
            purchaseDetails.Remarks = _purchaseModel.Remarks;

            purchaseDetails.InvoiceNo = _purchaseModel.InvoiceNo;
            purchaseDetails.Category = _purchaseModel.Category;
            purchaseDetails.Supplier = _purchaseModel.Supplier;
            purchaseDetails.Date = _purchaseModel.Date;

            return purchaseDetails;
        }

        private void FillAvailableQuantity()
        {
            if (String.IsNullOrEmpty(productComboBox.Text) || String.IsNullOrEmpty(mrpTextBox.Text))
                totalMrpTextBox.Text = null;
            else
            {
                totalMrpTextBox.Text =
                    Convert.ToDouble(Convert.ToDouble(quantityComboBox.Text) * Convert.ToDouble(mrpTextBox.Text)).ToString();
            }
        }

        private void FillTheComboBoxes()
        {
            //productComboBox.SelectedIndex = -1;
            customerComboBox.DataSource = _purchaseManager.GetListForComboBox("Customer");
            categoryComboBox.DataSource = _purchaseManager.GetListForComboBox("Category");
            customerComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;


            customerComboBox.SelectedText = "-Select-";
            categoryComboBox.SelectedText = "-Select-";
            //productComboBox.SelectedText = "-Select";

        }

        private void invoiceNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            }

        private void ProductComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(productComboBox.SelectedIndex.ToString());
            if (productComboBox.SelectedIndex == -1) return;
            if (_isProductSelected)
            {
                codeTextBox.Text = _purchaseManager.GetProductCode()

                ClearUI("Product");
            }

            _isProductSelected = true;
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string si, column;
            DataGridViewRow row = purchaseDataGridView.Rows[e.RowIndex];

            try
            {
                column = purchaseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                si = purchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception exception)
            {
                return;
            }
            if (column.Equals("Edit"))
            {

            }

            if (column.Equals("Delete"))
            {
                _purchaseManager.DeleteFromCart(si);

            }


            if (_purchaseManager.purchaseDetailsList.Count == 0) ClearUI("purchaseDetails");
            else
            {
                purchaseDataGridView.DataSource = null;
                purchaseDataGridView.DataSource = _purchaseManager.purchaseDetailsList;
                FillTotalAndAll();
            }


        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //categoryComboBox.SelectedIndex = 0;
            //categoryComboBox.SelectedText = null;

            //MessageBox.Show(categoryComboBox.SelectedIndex.ToString());
            if (categoryComboBox.SelectedIndex == -1) return;
            if (_isCategorySelected)
            {
                //MessageBox.Show(categoryComboBox.Text);
                productComboBox.DataSource = _purchaseManager.GetListForComboBox("Product", categoryComboBox.Text);
                productComboBox.SelectedIndex = -1;
                productComboBox.SelectedText = "-Select-";

                ClearUI("Category");
            }

            _isCategorySelected = true;
        }

    }
}
