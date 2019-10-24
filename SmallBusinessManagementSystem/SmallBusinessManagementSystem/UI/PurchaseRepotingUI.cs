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
    public partial class PurchaseRepotingUI : Form
    {
        public PurchaseRepotingUI()
        {
            InitializeComponent();
        }
        PurchaseRepotingManager _purchaserepotingManager = new PurchaseRepotingManager();
        private void searchButton_Click(object sender, EventArgs e)
        {
            showdataGridView.DataSource = null;

            PurchaseRepotingModel purchaserepotingModel = new PurchaseRepotingModel();

            if (startDateTimePicker.Text == " " && startDateTimePicker.Text == " ")
            {
                MessageBox.Show("please insert date");
                return;

            }
            purchaserepotingModel.Date = startDateTimePicker.Text;
            purchaserepotingModel.Date2 = endDateTimePicker.Text;

            bool ishas = !_purchaserepotingManager.SearchValue(purchaserepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showdataGridView.DataSource = _purchaserepotingManager.SearchValue(purchaserepotingModel);
            }
        }

        private void showdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showdataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            SaleRepotingUI newForm = new SaleRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
