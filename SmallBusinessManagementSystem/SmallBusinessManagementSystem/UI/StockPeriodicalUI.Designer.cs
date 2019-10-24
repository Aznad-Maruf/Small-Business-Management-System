namespace SmallBusinessManagementSystem.UI
{
    partial class StockPeriodicalUI
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
            this.Product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stockProductTextBox = new System.Windows.Forms.TextBox();
            this.stockCategoryTextBox = new System.Windows.Forms.TextBox();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.reorderLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.damageCheckBox = new System.Windows.Forms.CheckBox();
            this.lostCheckBox = new System.Windows.Forms.CheckBox();
            this.searchStockButton = new System.Windows.Forms.Button();
            this.stockSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.stockSearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(74, 61);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(44, 13);
            this.Product.TabIndex = 0;
            this.Product.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            // 
            // stockProductTextBox
            // 
            this.stockProductTextBox.Location = new System.Drawing.Point(136, 61);
            this.stockProductTextBox.Name = "stockProductTextBox";
            this.stockProductTextBox.Size = new System.Drawing.Size(162, 20);
            this.stockProductTextBox.TabIndex = 1;
            // 
            // stockCategoryTextBox
            // 
            this.stockCategoryTextBox.Location = new System.Drawing.Point(136, 100);
            this.stockCategoryTextBox.Name = "stockCategoryTextBox";
            this.stockCategoryTextBox.Size = new System.Drawing.Size(162, 20);
            this.stockCategoryTextBox.TabIndex = 1;
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.Location = new System.Drawing.Point(262, 156);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(64, 17);
            this.expiredCheckBox.TabIndex = 2;
            this.expiredCheckBox.Text = "Expired ";
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // reorderLevelCheckBox
            // 
            this.reorderLevelCheckBox.AutoSize = true;
            this.reorderLevelCheckBox.Location = new System.Drawing.Point(136, 156);
            this.reorderLevelCheckBox.Name = "reorderLevelCheckBox";
            this.reorderLevelCheckBox.Size = new System.Drawing.Size(98, 17);
            this.reorderLevelCheckBox.TabIndex = 2;
            this.reorderLevelCheckBox.Text = "Re-Order Lavel";
            this.reorderLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // damageCheckBox
            // 
            this.damageCheckBox.AutoSize = true;
            this.damageCheckBox.Location = new System.Drawing.Point(406, 156);
            this.damageCheckBox.Name = "damageCheckBox";
            this.damageCheckBox.Size = new System.Drawing.Size(66, 17);
            this.damageCheckBox.TabIndex = 2;
            this.damageCheckBox.Text = "Damage";
            this.damageCheckBox.UseVisualStyleBackColor = true;
            // 
            // lostCheckBox
            // 
            this.lostCheckBox.AutoSize = true;
            this.lostCheckBox.Location = new System.Drawing.Point(551, 156);
            this.lostCheckBox.Name = "lostCheckBox";
            this.lostCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lostCheckBox.TabIndex = 2;
            this.lostCheckBox.Text = "Lost";
            this.lostCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchStockButton
            // 
            this.searchStockButton.Location = new System.Drawing.Point(577, 195);
            this.searchStockButton.Name = "searchStockButton";
            this.searchStockButton.Size = new System.Drawing.Size(75, 23);
            this.searchStockButton.TabIndex = 3;
            this.searchStockButton.Text = "Search";
            this.searchStockButton.UseVisualStyleBackColor = true;
            // 
            // stockSearchDataGridView
            // 
            this.stockSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockSearchDataGridView.Location = new System.Drawing.Point(12, 235);
            this.stockSearchDataGridView.Name = "stockSearchDataGridView";
            this.stockSearchDataGridView.Size = new System.Drawing.Size(776, 215);
            this.stockSearchDataGridView.TabIndex = 4;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(480, 58);
            this.startDateTimePicker.MaxDate = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            this.startDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 5;
            this.startDateTimePicker.Value = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(480, 107);
            this.endDateTimePicker.MaxDate = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 5;
            this.endDateTimePicker.Value = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            // 
            // StockPeriodicalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.stockSearchDataGridView);
            this.Controls.Add(this.searchStockButton);
            this.Controls.Add(this.reorderLevelCheckBox);
            this.Controls.Add(this.lostCheckBox);
            this.Controls.Add(this.damageCheckBox);
            this.Controls.Add(this.expiredCheckBox);
            this.Controls.Add(this.stockCategoryTextBox);
            this.Controls.Add(this.stockProductTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Product);
            this.Name = "StockPeriodicalUI";
            this.Text = "StockPeriodicalUI";
            ((System.ComponentModel.ISupportInitialize)(this.stockSearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockProductTextBox;
        private System.Windows.Forms.TextBox stockCategoryTextBox;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.CheckBox reorderLevelCheckBox;
        private System.Windows.Forms.CheckBox damageCheckBox;
        private System.Windows.Forms.CheckBox lostCheckBox;
        private System.Windows.Forms.Button searchStockButton;
        private System.Windows.Forms.DataGridView stockSearchDataGridView;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
    }
}