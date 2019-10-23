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
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        CustomerManager _customerManager = new CustomerManager();
        public CustomerModel customer;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text == "Save")
            {
                customer = new CustomerModel();
                if (String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(contactTextBox.Text) || String.IsNullOrEmpty(addressTextBox.Text))
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

                    customer.Code = codeTextBox.Text;
                    customer.Email = emailTextBox.Text;
                    customer.Contact = contactTextBox.Text;

                    if (_customerManager.IsExists(customer))
                    {
                        MessageBox.Show(" Already Exists!!!");
                        return;
                    }
                    customer.Name = nameTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    if (String.IsNullOrEmpty(loyalityPointTextBox.Text))
                    {
                        customer.LoyalityPoint = 0;
                    }
                    else
                    {
                        customer.LoyalityPoint = Convert.ToInt32(loyalityPointTextBox.Text);
                    }

                    bool isExecute = _customerManager.Save(customer);
                    if (isExecute)
                    {
                        MessageBox.Show("Saved!!");
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        addressTextBox.Clear();
                        emailTextBox.Clear();
                        contactTextBox.Clear();
                        loyalityPointTextBox.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Not Saved!!");
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        addressTextBox.Clear();
                        emailTextBox.Clear();
                        contactTextBox.Clear();
                        loyalityPointTextBox.Text = "0";
                    }
                }
                showDataGridView.DataSource = _customerManager.ShowAll();
            }
            else if (saveButton.Text == "Update")
            {
                if (!String.IsNullOrEmpty(codeTextBox.Text) && !String.IsNullOrEmpty(nameTextBox.Text) && !String.IsNullOrEmpty(emailTextBox.Text) && !String.IsNullOrEmpty(contactTextBox.Text) && !String.IsNullOrEmpty(addressTextBox.Text))
                {
                    customer = new CustomerModel();
                    customer.Code = codeTextBox.Text;
                    customer.Name = nameTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    customer.Email = emailTextBox.Text;
                    customer.Contact = contactTextBox.Text;
                    customer.LoyalityPoint = Convert.ToInt32(loyalityPointTextBox.Text);
                    if (_customerManager.UpdateCustomer(customer))
                    {
                        MessageBox.Show("Customer Updated");
                        saveButton.Text = "Save";
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        addressTextBox.Clear();
                        emailTextBox.Clear();
                        contactTextBox.Clear();
                        loyalityPointTextBox.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Updated");
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        addressTextBox.Clear();
                        emailTextBox.Clear();
                        contactTextBox.Clear();
                        loyalityPointTextBox.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("No field can be empty!!!!");
                    return;
                }
                showDataGridView.DataSource = _customerManager.ShowAll();
            }
        }

        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                loyalityPointTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                saveButton.Text = "Update";
            }
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            showDataGridView.Rows[e.RowIndex].Cells[7].Value = "Edit";
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.ShowAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            customer = new CustomerModel();
            customer.Name = searchTextBox.Text;
            customer.Email = searchTextBox.Text;
            customer.Contact = searchTextBox.Text;
            DataTable showData = _customerManager.SearchCustomer(customer);
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
