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

namespace SmallBusinessManagementSystem.Model
{
    public partial class ProductUI : Form
    {
        public ProductUI()
        {
            InitializeComponent();
        }

        ProductManager _productManager = new ProductManager();
        public ProductModel productModel;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text == "Save")
            {
                productModel = new ProductModel();
                if (string.IsNullOrEmpty(categoryComboBox.Text) || categoryComboBox.Text == "--select--")
                {
                    MessageBox.Show("No Category is Selected");
                    return;
                }
                else
                {
                    if (String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(descriptionRichTextBox.Text))
                    {
                        MessageBox.Show("No field can be empty!!!!");
                        return;
                    }
                    if (codeTextBox.Text.Count() != 4)
                    {
                        MessageBox.Show("Code Must be 4 length!!!");
                        codeTextBox.Clear();
                        return;
                    }
                    productModel.Category = categoryComboBox.Text;
                    productModel.Code = codeTextBox.Text;
                    productModel.Name = nameTextBox.Text;
                    if (String.IsNullOrEmpty(reorderLevelTextBox.Text))
                    {
                        productModel.ReorderLevel = 10;
                    }
                    else
                    {
                        productModel.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                    }
                    productModel.Description = descriptionRichTextBox.Text;

                    if (_productManager.IsExists(productModel))
                    {
                        MessageBox.Show(" Already Exists!!!");
                        return;
                    }

                    bool isExecute = _productManager.Save(productModel);
                    if (isExecute)
                    {
                        MessageBox.Show("Saved!!");
                        categoryComboBox.DataSource = _productManager.LoadCategory(productModel);
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        descriptionRichTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Not Saved!!");
                        categoryComboBox.DataSource = _productManager.LoadCategory(productModel);
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        descriptionRichTextBox.Clear();
                    }
                    showDataGridView.DataSource = _productManager.ShowAll();
                }
            }
            else if (saveButton.Text == "Update")
            {
                if (String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(reorderLevelTextBox.Text) || String.IsNullOrEmpty(descriptionRichTextBox.Text))
                {
                    MessageBox.Show("No field can be empty!!!!");
                    return;
                }
                else
                {
                    if (codeTextBox.Text.Count() != 4)
                    {
                        MessageBox.Show("Code Must be 4 length!!!");
                        codeTextBox.Clear();
                        return;
                    }
                    productModel = new ProductModel();
                    productModel.Code = codeTextBox.Text;
                    productModel.Name = nameTextBox.Text;
                    productModel.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                    productModel.Description = descriptionRichTextBox.Text;
                    if (_productManager.UpdateProduct(productModel))
                    {
                        MessageBox.Show("Product Updated");
                        categoryComboBox.DataSource = _productManager.LoadCategory(productModel);
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        descriptionRichTextBox.Clear();
                        saveButton.Text = "Save";
                    }
                    else
                    {
                        MessageBox.Show("Product Not Updated");
                        categoryComboBox.DataSource = _productManager.LoadCategory(productModel);
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        descriptionRichTextBox.Clear();
                        saveButton.Text = "Save";
                    }
                    showDataGridView.DataSource = _productManager.ShowAll();
                }
            }
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            productModel = new ProductModel();

            categoryComboBox.DataSource = _productManager.LoadCategory(productModel);
            showDataGridView.DataSource = _productManager.ShowAll();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            showDataGridView.Rows[e.RowIndex].Cells[6].Value = "Edit";
        }

        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                categoryComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                reorderLevelTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                descriptionRichTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                saveButton.Text = "Update";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            productModel = new ProductModel();
            productModel.Category = searchTextBox.Text;
            productModel.Code = searchTextBox.Text;
            productModel.Name = searchTextBox.Text;

            DataTable showData = _productManager.SearchProduct(productModel);
            if (showData.Rows.Count > 0)
            {
                showDataGridView.DataSource = showData;
            }
            else
            {
                MessageBox.Show("No Data Matched!!!");
            }
        }
    }
}
