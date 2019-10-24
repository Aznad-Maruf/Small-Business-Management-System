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
            supplierComboBox.DataSource = _purchaseManager.GetSupplierList();
            categoryComboBox.DataSource = _purchaseManager.GetCategoryList();

            
            supplierComboBox.ValueMember = "Code";
            supplierComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Code";
            categoryComboBox.DisplayMember = "Name";

            supplierComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;

        }


        /*------------ Copyy ---------------*/

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!GetAllData()) return;

            //MessageBox.Show(_purchaseModel.ManufactureDate);

            //string message = _purchaseManager.CanBeAdded(_purchaseModel);
            //if (message.Equals("True"))
            //{


            _purchaseManager.AddToCart(GetPurchaseModel());


            //_purchaseManager.AddToPurchase(_purchaseModel);
            //    //MessageBox.Show(_purchaseManager.purchaseModelList.Count.ToString());


            purchaseDataGridView.DataSource = null;
            purchaseDataGridView.DataSource = _purchaseManager.PurchaseModelList;

            //    FillTotalAndAll();

                ClearUi("product");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_purchaseManager.PurchaseModelList.Count == 0)
            {
                MessageBox.Show("Add Item First");
                return;
            }
            _purchaseManager.AddListToPurchase();
            purchaseDataGridView.DataSource = null;
            purchaseDataGridView.DataSource = _purchaseManager.PurchaseModelList;
            ClearUi("all");
        }

        // --------- Methods --------

        private void PopulateComboBox(ComboBox comboBox, string name)
        {
                comboBox.DataSource = _purchaseManager.GetListForComboBox(name);
                comboBox.ValueMember = "Code";
                comboBox.DisplayMember = "Name";
        }

        private void ClearUi(string howMuch)
        {
            if(!howMuch.Equals("Category")&&!howMuch.Equals("Product"))categoryComboBox.SelectedIndex = -1;
            if (!howMuch.Equals("Product")) productComboBox.SelectedIndex = -1;
            if (howMuch.Equals("all"))
            {
                invoiceNoTextBox.Text = null;
                supplierComboBox.SelectedIndex = -1;
            }
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
            if (String.IsNullOrEmpty(invoiceNoTextBox.Text))
            {
                MessageBox.Show("InvoiceNo can't be Empty");
                return false;
            }

            if (!_purchaseManager.IsUniqueInvoiceNo(_purchaseModel.InvoiceNo))
            {
                MessageBox.Show("InvoiceNo is Used Before");
                return false;
            }
            _purchaseModel.Date = DateDateTimePicker.Text;
            try
            {
                _purchaseModel.Supplier = ((SupplierModel)supplierComboBox.SelectedItem).Code;
            }
            catch (Exception e)
            {
                MessageBox.Show("Select a Supplier");
                return false;
            }

            try
            {
                _purchaseModel.Category = ((CategoryModel)categoryComboBox.SelectedItem).Code;
            }
            catch (Exception e)
            {
                MessageBox.Show("Select Category");
                return false;
            }

            try
            {
                _purchaseModel.Product = ((ProductModel)productComboBox.SelectedItem).Code;
            }
            catch (Exception e)
            {
                MessageBox.Show("Select Product");
                return false;
            }
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

            _purchaseModel.ManufactureDate = manufactureDateDateTimePicker.Text;
            _purchaseModel.ExpireDate = exipreDateDateTimePicker.Text;
            _purchaseModel.Remarks = remarksRichTextBox.Text;

            return true;
        }

        private PurchaseModel GetPurchaseModel()
        {
            PurchaseModel purchaseModel = new PurchaseModel();

            purchaseModel.ManufactureDate = _purchaseModel.ManufactureDate;
            purchaseModel.ExpireDate = _purchaseModel.ExpireDate;
            purchaseModel.MRP = _purchaseModel.MRP;
            purchaseModel.Product = _purchaseModel.Product;
            purchaseModel.Quantity = _purchaseModel.Quantity;
            purchaseModel.UnitPrice = _purchaseModel.UnitPrice;
            purchaseModel.TotalPrice = _purchaseModel.Quantity * _purchaseModel.UnitPrice;
            purchaseModel.Remarks = _purchaseModel.Remarks;

            purchaseModel.InvoiceNo = _purchaseModel.InvoiceNo;
            purchaseModel.Category = _purchaseModel.Category;
            purchaseModel.Supplier = _purchaseModel.Supplier;
            purchaseModel.Date = _purchaseModel.Date;
            //MessageBox.Show(purchaseModel.ManufactureDate);
            return purchaseModel;
        }

        private void FillAvailableQuantity()
        {
            //if (String.IsNullOrEmpty(productComboBox.Text) || String.IsNullOrEmpty(mrpTextBox.Text))
            //    totalMrpTextBox.Text = null;
            //else
            //{
            //    totalMrpTextBox.Text =
            //        Convert.ToDouble(Convert.ToDouble(quantityComboBox.Text) * Convert.ToDouble(mrpTextBox.Text)).ToString();
            //}
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                totalPriceTextBox.Text = null;
                return;
            }
            try
            {
                _purchaseModel.Quantity = Convert.ToDouble(quantityTextBox.Text);
                if (!String.IsNullOrEmpty(unitPriceTextBox.Text))
                {
                    totalPriceTextBox.Text = (_purchaseModel.Quantity * _purchaseModel.UnitPrice).ToString();
                }
            }
            catch (Exception ee)
            {
                quantityTextBox.Text = null;
                totalPriceTextBox.Text = null;
                MessageBox.Show("Must enter a valid Quantity");
            }

        }

        private void UnitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = null;
                return;
            }
            try
            {
                _purchaseModel.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                if (!String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    totalPriceTextBox.Text = (_purchaseModel.Quantity * _purchaseModel.UnitPrice).ToString();
                }
            }
            catch (Exception ee)
            {
                unitPriceTextBox.Text = null;
                totalPriceTextBox.Text = null;
                MessageBox.Show("Must enter a valid UnitPrice");
            }
        }

        private void gotoSalesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SalesUI salesUi = new SalesUI();
            salesUi.Closed += (s, args) => this.Close();
            salesUi.Show();
            //this.Close();
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string si, column;
            //DataGridViewRow row = purchaseDataGridView.Rows[e.RowIndex];
            //MessageBox.Show(si);
            try
            {
                column = purchaseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                si = purchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            catch (Exception ee)
            {
                return;
            }
            if (column.Equals("Edit"))
            {
                PurchaseModel purchaseModel = _purchaseManager.GetPurchaseModel(si);
                DateDateTimePicker.Text = purchaseModel.Date;
                invoiceNoTextBox.Text = purchaseModel.InvoiceNo;
                supplierComboBox.SelectedValue = purchaseModel.Supplier;
                categoryComboBox.SelectedValue = purchaseModel.Category;
                productComboBox.SelectedValue = purchaseModel.Product;
                //codeTextBox.Text = purchaseModel.Product;
                //availableQuantityTextBox.Text = purchaseModel.AvailableQuantity;
                manufactureDateDateTimePicker.Text = purchaseModel.ManufactureDate;
                exipreDateDateTimePicker.Text = purchaseModel.ExpireDate;
                quantityTextBox.Text = purchaseModel.Quantity.ToString();
                unitPriceTextBox.Text = purchaseModel.UnitPrice.ToString();
                //totalPriceTextBox.Text = (purchaseModel.Quantity * purchaseModel.UnitPrice).ToString();
                //previousUnitPriceTextBox.Text = purchaseModel.PreviousUnitPrice.ToString();
                //previousMrpTextBox.Text = purchaseModel.PreviousMRP.ToString();
                mrpTextBox.Text = purchaseModel.MRP.ToString();
                _purchaseManager.DeleteFromCart(si);

            }

            if (column.Equals("Delete"))
            {
                _purchaseManager.DeleteFromCart(si);

            }


            //if (_purchaseManager.PurchaseModelList.Count == 0) ClearUi("purchasedetails");
            purchaseDataGridView.DataSource = null;
            purchaseDataGridView.DataSource = _purchaseManager.PurchaseModelList;
        }

        private void ProductComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(productComboBox.SelectedIndex.ToString());
            if (productComboBox.SelectedIndex != 0) _isProductSelected = true;
            if (productComboBox.SelectedIndex == -1) return;
            if (_isProductSelected)
            {
                //MessageBox.Show(productComboBox.SelectedIndex.ToString());

                //_purchaseModel.Supplier = ((SupplierModel)supplierComboBox.SelectedItem).Code;
                _purchaseModel.Category = ((CategoryModel)categoryComboBox.SelectedItem).Code;
                _purchaseModel.Product = ((ProductModel)productComboBox.SelectedItem).Code;
                _purchaseModel.Code = _purchaseModel.Product;

                //MessageBox.Show("IN");
                _purchaseManager.FillUpPurchaseInfo(_purchaseModel);
                codeTextBox.Text = _purchaseModel.Code;
                availableQuantityTextBox.Text = _purchaseManager.GetAvailableQuantity(_purchaseModel).ToString();
                previousUnitPriceTextBox.Text = _purchaseModel.PreviousUnitPrice;
                previousMrpTextBox.Text = _purchaseModel.PreviousMRP;


                //ClearUi("Product");
            }

        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != 0) _isCategorySelected = true;

            //MessageBox.Show(categoryComboBox.SelectedIndex.ToString());
            if (categoryComboBox.SelectedIndex == -1) return;
            if (_isCategorySelected)
            {
                //MessageBox.Show(categoryComboBox.Text);
                productComboBox.DataSource =
                    _purchaseManager.GetProductList(((CategoryModel)categoryComboBox.SelectedItem).Code.ToString());
                productComboBox.ValueMember = "Code";
                productComboBox.DisplayMember = "Name";
                _isProductSelected = false;
                //productComboBox.SelectedIndex = -1;
                //productComboBox.SelectedText = "-Select-";

                ClearUi("Category");
            }
        }

    }
}
