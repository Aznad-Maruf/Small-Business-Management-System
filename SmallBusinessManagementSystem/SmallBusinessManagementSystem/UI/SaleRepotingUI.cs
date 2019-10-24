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
    public partial class SaleRepotingUI : Form
    {
        public SaleRepotingUI()
        {
            InitializeComponent();
        }
        SaleRepotingManager _salerepotingManager = new SaleRepotingManager();
        private void searchButton_Click(object sender, EventArgs e)
        {
            showdataGridView.DataSource = null;
            
            SaleRepotingModel salerepotingModel = new SaleRepotingModel();

            if (startDateTimePicker.Text == " " && startDateTimePicker.Text == " ")
            {
                MessageBox.Show("please insert date");
                return;

            }
            salerepotingModel.Date = startDateTimePicker.Text;
            salerepotingModel.Date2 = endDateTimePicker.Text;
           
            bool ishas = !_salerepotingManager.SearchValue(salerepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _salerepotingManager.SearchValue(salerepotingModel);
            }
        }

        private void showdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showdataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            PurchaseRepotingUI newForm = new PurchaseRepotingUI();
            newForm.Show();
            this.Hide();
        }
    }
    
}
