using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Manager;
using SmallBusinessManagementSystem.Model;
namespace SmallBusinessManagementSystem.UI
{
    public partial class SupplierEntryUI : Form
    {
        public SupplierEntryUI()
        {
            InitializeComponent();
        }

        SupplierEntryManager _supplierEntryManager = new SupplierEntryManager();
        SupplierEntry _supplierEntry = new SupplierEntry();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(saveButton.Text == "Save")
            {
                // _suppliers.Count = 0;

                if (!String.IsNullOrEmpty(supplierCodeTextBox.Text) && !String.IsNullOrEmpty(supplierNameTextBox.Text) &&
                    !String.IsNullOrEmpty(supplierCodeTextBox.Text) && !String.IsNullOrEmpty(supplierContactTextBox.Text))
                {
                    if (supplierCodeTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Code Must be 4 digit ");
                        return;

                    }

                    _supplierEntry.Code = supplierCodeTextBox.Text;
                    _supplierEntry.Name = supplierNameTextBox.Text;
                    _supplierEntry.Address = supplierAddressTextBox.Text;
                    _supplierEntry.Email = supplierEmailTextBox.Text;
                    _supplierEntry.Contact = supplierContactTextBox.Text;
                    _supplierEntry.ContactPerson = supplierContactPersonTextBox.Text;


                }
                else
                {
                    MessageBox.Show("Code, Name, Email, and Contact Number Must be Required!!!");
                    return;
                }


                if (_supplierEntryManager.IsCodeExist(_supplierEntry))
                {
                    MessageBox.Show("Code " + supplierCodeTextBox.Text + " is  Already exist!!!");
                    return;
                }

                if (_supplierEntryManager.IsEmailExist(_supplierEntry))
                {
                    MessageBox.Show("Email " + supplierEmailTextBox.Text + " is Already exist!!!");
                    return;
                }

                if (_supplierEntryManager.IsContactExist(_supplierEntry))
                {
                    MessageBox.Show("Contact  " + supplierContactTextBox.Text + " is Already exist!!!");
                    return;
                }


                if (_supplierEntryManager.IsSaved(_supplierEntry))
                {
                    MessageBox.Show("Saved Successfully !!");

                    suppliersDataGridView.DataSource = _supplierEntryManager.ShowSuppliers();

                    supplierCodeTextBox.Clear();
                    supplierNameTextBox.Clear();
                    supplierAddressTextBox.Clear();
                    supplierEmailTextBox.Clear();
                    supplierContactTextBox.Clear();
                    supplierContactPersonTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Sorry Supplier Can't Saved ");
                }

                //suppliersDataGridView.DataSource = _suppliersManager.SearchBy(_suppliers);

            }

            else if (saveButton.Text == "Update")
            {
                if (!String.IsNullOrEmpty(supplierCodeTextBox.Text) && !String.IsNullOrEmpty(supplierNameTextBox.Text) &&
               !String.IsNullOrEmpty(supplierCodeTextBox.Text) && !String.IsNullOrEmpty(supplierContactTextBox.Text))
                {
                    if (supplierCodeTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Code Must be 4 digit ");
                        return;

                    }

                    _supplierEntry.Code = supplierCodeTextBox.Text;
                    _supplierEntry.Name = supplierNameTextBox.Text;
                    _supplierEntry.Address = supplierAddressTextBox.Text;
                    _supplierEntry.Email = supplierEmailTextBox.Text;
                    _supplierEntry.Contact = supplierContactTextBox.Text;
                    _supplierEntry.ContactPerson = supplierContactPersonTextBox.Text;



                    if (_supplierEntryManager.IsEditExist(_supplierEntry))
                    {
                        MessageBox.Show("You Want to Edit Item ????");
                        if (_supplierEntryManager.EditData(_supplierEntry))
                        {
                            MessageBox.Show("Edit Successful..");

                        }
                        else
                        {
                            MessageBox.Show("Sorry Can't Edited");

                        }
                    }
                    else
                    {
                        MessageBox.Show("All feild must be Required");

                    }
                    suppliersDataGridView.DataSource = _supplierEntryManager.ShowSuppliers();

                    supplierCodeTextBox.Clear();
                    supplierNameTextBox.Clear();
                    supplierAddressTextBox.Clear();
                    supplierEmailTextBox.Clear();
                    supplierContactTextBox.Clear();
                    supplierContactPersonTextBox.Clear();

                    saveButton.Text = "Save";
                }
            }
        }

        private void SupplierEntryUI_Load(object sender, EventArgs e)
        {
            suppliersDataGridView.DataSource = _supplierEntryManager.ShowSuppliers();
           // _supplierEntry.Count = supplierEntryBindingSource.Count;
        }

             

        private void suppliersDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
                supplierCodeTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                supplierNameTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                supplierAddressTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                supplierEmailTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                supplierContactTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                supplierContactPersonTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[6].Value.ToString();

                saveButton.Text = "Update";
            

        }

        private void suppliersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            suppliersDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
