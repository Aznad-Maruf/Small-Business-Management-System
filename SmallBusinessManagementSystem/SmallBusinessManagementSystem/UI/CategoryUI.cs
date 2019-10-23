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
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }

        CategoryManager _categoryManager = new CategoryManager();
        public CategoryModel category;

        private void categorySaveButton_Click(object sender, EventArgs e)
        {
            if (categorySaveButton.Text == "Save")
            {
                category = new CategoryModel();
                if (String.IsNullOrEmpty(categoryCodeTextBox.Text) && String.IsNullOrEmpty(categoryNameTextBox.Text))
                {
                    MessageBox.Show("Code and Name Can not Be Empty!!!");
                    return;
                }
                else
                {
                    if (categoryCodeTextBox.Text.Count() != 4)
                    {
                        MessageBox.Show("Code Must be 4 length!!!");
                        categoryCodeTextBox.Clear();
                        return;
                    }
                    category.Code = categoryCodeTextBox.Text;
                    category.Name = categoryNameTextBox.Text;
                    if (_categoryManager.IsExists(category))
                    {
                        MessageBox.Show(" Already Exists!!!");
                        return;
                    }

                    bool isExecute = _categoryManager.Save(category);
                    if (isExecute)
                    {
                        MessageBox.Show("Saved!!");
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Not Saved!!");
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                    }

                    showCategoryDataGridView.DataSource = _categoryManager.ShowAll();
                }
            }
            else if (categorySaveButton.Text == "Update")
            {
                if (!String.IsNullOrEmpty(categoryCodeTextBox.Text) && !String.IsNullOrEmpty(categoryNameTextBox.Text))
                {
                    category = new CategoryModel();
                    category.Code = categoryCodeTextBox.Text;
                    category.Name = categoryNameTextBox.Text;
                    if (_categoryManager.UpdateCategory(category))
                    {
                        MessageBox.Show("Category Updated");
                        categorySaveButton.Text = "Save";
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Category Not Updated");
                        categorySaveButton.Text = "Save";
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                    }

                    showCategoryDataGridView.DataSource = _categoryManager.ShowAll();
                }
                else
                {
                    MessageBox.Show(" Code and Text can not Be Empty!!!!");
                }
            }
        }

        private void showCategoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showCategoryDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            showCategoryDataGridView.Rows[e.RowIndex].Cells[3].Value = "Edit";
        }

        private void CategoryUI_Load(object sender, EventArgs e)
        {
            showCategoryDataGridView.DataSource = _categoryManager.ShowAll();
        }

        private void categorySearchButton_Click(object sender, EventArgs e)
        {
            category = new CategoryModel();
            category.Code = categorySearchTextBox.Text;
            category.Name = categorySearchTextBox.Text;
            DataTable showData = _categoryManager.SearchCategory(category);

            if (showData.Rows.Count > 0)
            {
                showCategoryDataGridView.DataSource = showData;
            }
            else
            {
                MessageBox.Show("No Data Matched!!!");
            }
        }

        private void showCategoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                categoryCodeTextBox.Text = showCategoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryNameTextBox.Text = showCategoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                categorySaveButton.Text = "Update";
            }
        }
    }
}
