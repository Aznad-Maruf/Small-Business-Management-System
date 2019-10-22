namespace SmallBusinessManagementSystem.UI
{
    partial class SupplierEntryUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.supplierCodeTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierAddressTextBox = new System.Windows.Forms.TextBox();
            this.supplierEmailTextBox = new System.Windows.Forms.TextBox();
            this.supplierContactTextBox = new System.Windows.Forms.TextBox();
            this.supplierContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact Person";
            // 
            // supplierCodeTextBox
            // 
            this.supplierCodeTextBox.Location = new System.Drawing.Point(210, 57);
            this.supplierCodeTextBox.Name = "supplierCodeTextBox";
            this.supplierCodeTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierCodeTextBox.TabIndex = 1;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Location = new System.Drawing.Point(210, 92);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierNameTextBox.TabIndex = 1;
            // 
            // supplierAddressTextBox
            // 
            this.supplierAddressTextBox.Location = new System.Drawing.Point(210, 131);
            this.supplierAddressTextBox.Name = "supplierAddressTextBox";
            this.supplierAddressTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierAddressTextBox.TabIndex = 1;
            // 
            // supplierEmailTextBox
            // 
            this.supplierEmailTextBox.Location = new System.Drawing.Point(210, 165);
            this.supplierEmailTextBox.Name = "supplierEmailTextBox";
            this.supplierEmailTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierEmailTextBox.TabIndex = 1;
            // 
            // supplierContactTextBox
            // 
            this.supplierContactTextBox.Location = new System.Drawing.Point(210, 204);
            this.supplierContactTextBox.Name = "supplierContactTextBox";
            this.supplierContactTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierContactTextBox.TabIndex = 1;
            // 
            // supplierContactPersonTextBox
            // 
            this.supplierContactPersonTextBox.Location = new System.Drawing.Point(210, 235);
            this.supplierContactPersonTextBox.Name = "supplierContactPersonTextBox";
            this.supplierContactPersonTextBox.Size = new System.Drawing.Size(195, 20);
            this.supplierContactPersonTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(330, 277);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Location = new System.Drawing.Point(29, 320);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.Size = new System.Drawing.Size(727, 150);
            this.suppliersDataGridView.TabIndex = 3;
            this.suppliersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellContentClick);
            this.suppliersDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.suppliersDataGridView_RowPostPaint);
            this.suppliersDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.suppliersDataGridView_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(131, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(152, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(139, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "*";
            // 
            // SupplierEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.suppliersDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.supplierContactPersonTextBox);
            this.Controls.Add(this.supplierContactTextBox);
            this.Controls.Add(this.supplierEmailTextBox);
            this.Controls.Add(this.supplierAddressTextBox);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.supplierCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplierEntryUI";
            this.Text = "SuppliersUI";
            this.Load += new System.EventHandler(this.SupplierEntryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supplierCodeTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox supplierAddressTextBox;
        private System.Windows.Forms.TextBox supplierEmailTextBox;
        private System.Windows.Forms.TextBox supplierContactTextBox;
        private System.Windows.Forms.TextBox supplierContactPersonTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}