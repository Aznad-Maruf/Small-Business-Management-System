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
    public partial class SalesUI : Form
    {
        private readonly SalesManager _salesManager = new SalesManager();
        private readonly SalesModel _salesModel = new SalesModel();
        private bool _isCategorySelected = false, _isProductSelected = false, _isCustomerSelected = false, _isQuantitySelected = false;
        List<ProductDetails> pdList = new List<ProductDetails>();
        private double _loyaltyPoint;

        public SalesUI()
        {
            InitializeComponent();
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            FillTheComboBoxes();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GetAllData();

            //MessageBox.Show($"{_salesModel.Category}{Environment.NewLine}{_salesModel.Product}");

            string message = _salesManager.CanBeAdded(_salesModel);
            if (message.Equals("True"))
            {

                
               _salesManager.AddToCart(GetProductDetails());


                //_salesManager.AddToSales(_salesModel);
                //MessageBox.Show(_salesManager.productDetailsList.Count.ToString());
                

                salesDataGridView.DataSource = null;
                salesDataGridView.DataSource = _salesManager.productDetailsList;

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
            if (_salesManager.productDetailsList.Count == 0)
            {
                MessageBox.Show("Add Item First");
                return;
            }
            _salesManager.AddListToSales();
            _salesManager.SetLoyaltyPoint(customerComboBox.Text, _loyaltyPoint);

            ClearUI("all");
        }

        // --------- Methods --------

        private void FillTotalAndAll()
        {
            _loyaltyPoint = _salesManager.GetNewLoyaltyPoint(customerComboBox.Text, loyaltyPointTextBox.Text);
            //MessageBox.Show(_loyaltyPoint.ToString());
            grandTotalTextBox.Text = _salesManager.GetInfo("grandTotal", _loyaltyPoint);
            discountTextBox.Text = _salesManager.GetInfo("discountPercentage", _loyaltyPoint);
            discountAmountTextBox.Text = _salesManager.GetInfo("discountAmount", _loyaltyPoint);
            payableAmountTextBox.Text = _salesManager.GetInfo("payableAmount", _loyaltyPoint);
        }

        private void ClearUI(string howMuch)
        {
            if(howMuch.Equals("product")||howMuch.Equals("all"))
            {
                categoryComboBox.SelectedIndex = -1;
                productComboBox.SelectedIndex = -1;
                availableQuantityTextBox.Text = null;
                mrpTextBox.Text = null;
                totalMrpTextBox.Text = null;
                quantityComboBox.SelectedIndex = -1;
            }
            if(howMuch.Equals("productDetails") || howMuch.Equals("all"))
            {
                grandTotalTextBox.Text = null;
                discountTextBox.Text = null;
                discountAmountTextBox.Text = null;
                payableAmountTextBox.Text = null;

                salesDataGridView.DataSource = null;
            }

            if (howMuch.Equals("all"))
            {
                customerComboBox.SelectedIndex = -1;
                loyaltyPointTextBox.Text = null;

            }
        }

        private void GetAllData()
        {
            //SalesModel _salesModel = new SalesModel();
            _salesModel.Category = ((CategoryModel)categoryComboBox.SelectedItem).Code;
            _salesModel.Customer = ((CustomerModel)customerComboBox.SelectedItem).Code;
            _salesModel.Date = dateDateTimePicker.Text;
            _salesModel.Product = ((ProductModel)productComboBox.SelectedItem).Code;
            try
            {
                _salesModel.MRP = Convert.ToDouble(mrpTextBox.Text);
                _salesModel.Quantity = Convert.ToDouble(quantityComboBox.Text);
            }
            catch (Exception e)
            {
                _salesModel.Quantity = 0;
            }
        }

        private ProductDetails GetProductDetails()
        {
            ProductDetails productDetails = new ProductDetails();
            productDetails.Category = categoryComboBox.Text;
            productDetails.Product = productComboBox.Text;
            productDetails.Quantity = Convert.ToDouble(quantityComboBox.Text);
            productDetails.MRP = Convert.ToDouble(mrpTextBox.Text);
            productDetails.TotalMrp = Convert.ToDouble(totalMrpTextBox.Text);
            SalesModel salesModel = new SalesModel();

            salesModel.Category = _salesModel.Category;
            salesModel.Customer = _salesModel.Customer;
            salesModel.Date = _salesModel.Date;
            salesModel.Product = _salesModel.Product;
            try
            {
                salesModel.Quantity = Convert.ToDouble(quantityComboBox.Text);
            }
            catch (Exception e)
            {
                salesModel.Quantity = 0;
            }

            productDetails.SalesModel = salesModel;
            return productDetails;
        }

        private void FillTotalMrp()
        {
            if (String.IsNullOrEmpty(quantityComboBox.Text) || String.IsNullOrEmpty(mrpTextBox.Text))
                totalMrpTextBox.Text = null;
            else
            {
                totalMrpTextBox.Text =
                    Convert.ToDouble(Convert.ToDouble(quantityComboBox.Text) * Convert.ToDouble(mrpTextBox.Text)).ToString();
            }
        }

        private void FillTheComboBoxes()
        {
            customerComboBox.DataSource = _salesManager.GetCustomerList();
            categoryComboBox.DataSource = _salesManager.GetCategoryList();


            customerComboBox.ValueMember = "Code";
            customerComboBox.DisplayMember = "Code";
            categoryComboBox.ValueMember = "Code";
            categoryComboBox.DisplayMember = "Name";

            customerComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;

        }

        private void ProductComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(productComboBox.SelectedIndex.ToString());
            if (productComboBox.SelectedIndex != 0) _isProductSelected = true;
            if (productComboBox.SelectedIndex == -1) return;
            if (_isProductSelected)
            {
                //MessageBox.Show("Inside");
                _salesModel.Category = ((CategoryModel)categoryComboBox.SelectedItem).Code;
                _salesModel.Customer = ((CustomerModel)customerComboBox.SelectedItem).Code;
                _salesModel.Product = ((ProductModel)productComboBox.SelectedItem).Code;

                double availableQuantity = _salesManager.GetAvailableQuantity(_salesModel.Category, _salesModel.Product);


                List<int> list = new List<int>();
                for (int a_i = 1; a_i <= availableQuantity; a_i++) list.Add(a_i);
                quantityComboBox.DataSource = list;
                availableQuantityTextBox.Text = availableQuantity.ToString();
                mrpTextBox.Text = _salesManager.GetMrp(_salesModel.Category, _salesModel.Product);
                FillTotalMrp();
                if (availableQuantity == 0)
                {
                    //MessageBox.Show("In");
                    mrpTextBox.Text = null;
                }

                _isQuantitySelected = false;
            }

            //_isProductSelected = true;
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string si, column;
            DataGridViewRow row = salesDataGridView.Rows[e.RowIndex];
            
            try
            {
                column = salesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                si = salesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception exception)
            {
                return;
            }
            if (column.Equals("Edit"))
            {

                _salesManager.DeleteFromCart(si);
            }

            if (column.Equals("Delete"))
            {
                _salesManager.DeleteFromCart(si);

            }


            if(_salesManager.productDetailsList.Count == 0 ) ClearUI("productDetails");
            else
            {
                salesDataGridView.DataSource = null;
                salesDataGridView.DataSource = _salesManager.productDetailsList;
                FillTotalAndAll();
            }


        }

        private void gotoPurchaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PurchaseUI purchaseUi = new PurchaseUI();
            purchaseUi.Closed += (s, args) => this.Close();
            purchaseUi.Show();
            //this.Close();
        }

        private void quantityComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (quantityComboBox.SelectedIndex != 0) _isQuantitySelected = true;
            if (quantityComboBox.SelectedIndex == -1) return;
            if (_isQuantitySelected)
            {
                FillTotalMrp();
            }

            //_isQuantitySelected = true;
        }

        private void CustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex != 0) _isCustomerSelected = true;
            if (customerComboBox.SelectedIndex == -1) return;
            if (_isCustomerSelected)
            {
                loyaltyPointTextBox.Text = _salesManager.GetLoyaltyPoint(((CustomerModel)customerComboBox.SelectedItem).Code);
            }

            //_isCustomerSelected = true;
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //categoryComboBox.SelectedIndex = 0;
            //categoryComboBox.SelectedText = null;

            //MessageBox.Show(categoryComboBox.SelectedIndex.ToString());
            if (categoryComboBox.SelectedIndex != 0) _isCategorySelected = true;
            if (categoryComboBox.SelectedIndex==-1) return;
            if(_isCategorySelected)
            {
                //MessageBox.Show(categoryComboBox.Text);
                //productComboBox.DataSource = null;
                productComboBox.DataSource = _salesManager.GetProductList(((CategoryModel)categoryComboBox.SelectedItem).Code.ToString());
                productComboBox.ValueMember = "Code";
                productComboBox.DisplayMember = "Name";
                productComboBox.SelectedIndex = -1;
                productComboBox.SelectedText = "-Select-";

                quantityComboBox.DataSource = null;
                quantityComboBox.SelectedIndex = -1;
                availableQuantityTextBox.Text = null;
                FillTotalMrp();
                mrpTextBox.Text = null;
                _isProductSelected = false;
            }

            //_isCategorySelected = true;
        }



    }
}
