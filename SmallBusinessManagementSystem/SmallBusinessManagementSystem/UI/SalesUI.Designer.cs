namespace SmallBusinessManagementSystem.UI
{
    partial class SalesUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.totalMrpTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.loyaltyPointTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.productGroupBox.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesDataGridView);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.payableAmountTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.discountAmountTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.grandTotalTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 510);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.totalMrpDataGridViewTextBoxColumn,
            this.editDataGridViewTextBoxColumn,
            this.deleteDataGridViewTextBoxColumn});
            this.salesDataGridView.DataSource = this.productDetailsBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(11, 24);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(844, 210);
            this.salesDataGridView.TabIndex = 11;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(448, 439);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 34);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Location = new System.Drawing.Point(325, 364);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.ReadOnly = true;
            this.payableAmountTextBox.Size = new System.Drawing.Size(238, 29);
            this.payableAmountTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Payable Amount (Tk)";
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Location = new System.Drawing.Point(325, 329);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.ReadOnly = true;
            this.discountAmountTextBox.Size = new System.Drawing.Size(238, 29);
            this.discountAmountTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Discount Amount (Tk)";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(325, 294);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.Size = new System.Drawing.Size(238, 29);
            this.discountTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Discount (%)";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(325, 259);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(238, 29);
            this.grandTotalTextBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Grand Total (Tk)";
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.addButton);
            this.productGroupBox.Controls.Add(this.totalMrpTextBox);
            this.productGroupBox.Controls.Add(this.label9);
            this.productGroupBox.Controls.Add(this.mrpTextBox);
            this.productGroupBox.Controls.Add(this.label8);
            this.productGroupBox.Controls.Add(this.label7);
            this.productGroupBox.Controls.Add(this.availableQuantityTextBox);
            this.productGroupBox.Controls.Add(this.label4);
            this.productGroupBox.Controls.Add(this.label5);
            this.productGroupBox.Controls.Add(this.label6);
            this.productGroupBox.Controls.Add(this.quantityComboBox);
            this.productGroupBox.Controls.Add(this.productComboBox);
            this.productGroupBox.Controls.Add(this.categoryComboBox);
            this.productGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGroupBox.Location = new System.Drawing.Point(5, 258);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(468, 330);
            this.productGroupBox.TabIndex = 5;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(253, 276);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 34);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // totalMrpTextBox
            // 
            this.totalMrpTextBox.Location = new System.Drawing.Point(203, 225);
            this.totalMrpTextBox.Name = "totalMrpTextBox";
            this.totalMrpTextBox.ReadOnly = true;
            this.totalMrpTextBox.Size = new System.Drawing.Size(245, 29);
            this.totalMrpTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total MRP (Tk)";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(203, 190);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.ReadOnly = true;
            this.mrpTextBox.Size = new System.Drawing.Size(245, 29);
            this.mrpTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "MRP (Tk)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quantity";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(203, 117);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.ReadOnly = true;
            this.availableQuantityTextBox.Size = new System.Drawing.Size(245, 29);
            this.availableQuantityTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Available Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category";
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantityComboBox.FormattingEnabled = true;
            this.quantityComboBox.Location = new System.Drawing.Point(203, 152);
            this.quantityComboBox.MaxDropDownItems = 10;
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(245, 32);
            this.quantityComboBox.TabIndex = 0;
            this.quantityComboBox.SelectedValueChanged += new System.EventHandler(this.quantityComboBox_SelectedValueChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(203, 79);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(245, 32);
            this.productComboBox.TabIndex = 0;
            this.productComboBox.SelectedValueChanged += new System.EventHandler(this.ProductComboBox_SelectedValueChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.IntegralHeight = false;
            this.categoryComboBox.Location = new System.Drawing.Point(203, 41);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(245, 32);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.loyaltyPointTextBox);
            this.customerGroupBox.Controls.Add(this.dateDateTimePicker);
            this.customerGroupBox.Controls.Add(this.label3);
            this.customerGroupBox.Controls.Add(this.dateLabel);
            this.customerGroupBox.Controls.Add(this.label1);
            this.customerGroupBox.Controls.Add(this.customerComboBox);
            this.customerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox.Location = new System.Drawing.Point(5, 78);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(468, 174);
            this.customerGroupBox.TabIndex = 4;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // loyaltyPointTextBox
            // 
            this.loyaltyPointTextBox.Location = new System.Drawing.Point(203, 119);
            this.loyaltyPointTextBox.Name = "loyaltyPointTextBox";
            this.loyaltyPointTextBox.ReadOnly = true;
            this.loyaltyPointTextBox.Size = new System.Drawing.Size(245, 29);
            this.loyaltyPointTextBox.TabIndex = 1;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(203, 79);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(245, 29);
            this.dateDateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loyalty Point";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 83);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 24);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(203, 41);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(245, 32);
            this.customerComboBox.TabIndex = 0;
            this.customerComboBox.SelectedValueChanged += new System.EventHandler(this.CustomerComboBox_SelectedValueChanged);
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.ProductDetails);
            // 
            // productDetailsBindingSource2
            // 
            this.productDetailsBindingSource2.DataSource = typeof(SmallBusinessManagementSystem.Model.ProductDetails);
            // 
            // productDetailsBindingSource1
            // 
            this.productDetailsBindingSource1.DataSource = typeof(SmallBusinessManagementSystem.Model.ProductDetails);
            // 
            // sIDataGridViewTextBoxColumn
            // 
            this.sIDataGridViewTextBoxColumn.DataPropertyName = "SI";
            this.sIDataGridViewTextBoxColumn.HeaderText = "SI";
            this.sIDataGridViewTextBoxColumn.Name = "sIDataGridViewTextBoxColumn";
            this.sIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP (Tk)";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMrpDataGridViewTextBoxColumn
            // 
            this.totalMrpDataGridViewTextBoxColumn.DataPropertyName = "TotalMrp";
            this.totalMrpDataGridViewTextBoxColumn.HeaderText = "Total MRP (Tk)";
            this.totalMrpDataGridViewTextBoxColumn.Name = "totalMrpDataGridViewTextBoxColumn";
            this.totalMrpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editDataGridViewTextBoxColumn
            // 
            this.editDataGridViewTextBoxColumn.DataPropertyName = "Edit";
            this.editDataGridViewTextBoxColumn.HeaderText = "Edit";
            this.editDataGridViewTextBoxColumn.Name = "editDataGridViewTextBoxColumn";
            this.editDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteDataGridViewTextBoxColumn
            // 
            this.deleteDataGridViewTextBoxColumn.DataPropertyName = "Delete";
            this.deleteDataGridViewTextBoxColumn.HeaderText = "Delete";
            this.deleteDataGridViewTextBoxColumn.Name = "deleteDataGridViewTextBoxColumn";
            this.deleteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "SalesUI";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox totalMrpTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.TextBox loyaltyPointTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox quantityComboBox;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private System.Windows.Forms.BindingSource productDetailsBindingSource1;
        private System.Windows.Forms.BindingSource productDetailsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteDataGridViewTextBoxColumn;
    }
}