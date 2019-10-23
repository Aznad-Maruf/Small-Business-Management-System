namespace SmallBusinessManagementSystem.UI
{
    partial class CategoryUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categorySearchTextBox = new System.Windows.Forms.TextBox();
            this.categorySaveButton = new System.Windows.Forms.Button();
            this.categorySearchButton = new System.Windows.Forms.Button();
            this.showCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // categoryCodeTextBox
            // 
            this.categoryCodeTextBox.Location = new System.Drawing.Point(356, 67);
            this.categoryCodeTextBox.Name = "categoryCodeTextBox";
            this.categoryCodeTextBox.Size = new System.Drawing.Size(127, 20);
            this.categoryCodeTextBox.TabIndex = 2;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(356, 119);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.categoryNameTextBox.TabIndex = 3;
            // 
            // categorySearchTextBox
            // 
            this.categorySearchTextBox.Location = new System.Drawing.Point(615, 67);
            this.categorySearchTextBox.Name = "categorySearchTextBox";
            this.categorySearchTextBox.Size = new System.Drawing.Size(143, 20);
            this.categorySearchTextBox.TabIndex = 4;
            // 
            // categorySaveButton
            // 
            this.categorySaveButton.Location = new System.Drawing.Point(408, 174);
            this.categorySaveButton.Name = "categorySaveButton";
            this.categorySaveButton.Size = new System.Drawing.Size(75, 23);
            this.categorySaveButton.TabIndex = 5;
            this.categorySaveButton.Text = "Save";
            this.categorySaveButton.UseVisualStyleBackColor = true;
            this.categorySaveButton.Click += new System.EventHandler(this.categorySaveButton_Click);
            // 
            // categorySearchButton
            // 
            this.categorySearchButton.Location = new System.Drawing.Point(683, 109);
            this.categorySearchButton.Name = "categorySearchButton";
            this.categorySearchButton.Size = new System.Drawing.Size(75, 23);
            this.categorySearchButton.TabIndex = 6;
            this.categorySearchButton.Text = "Search";
            this.categorySearchButton.UseVisualStyleBackColor = true;
            this.categorySearchButton.Click += new System.EventHandler(this.categorySearchButton_Click);
            // 
            // showCategoryDataGridView
            // 
            this.showCategoryDataGridView.AutoGenerateColumns = false;
            this.showCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Action});
            this.showCategoryDataGridView.DataSource = this.categoryModelBindingSource;
            this.showCategoryDataGridView.Location = new System.Drawing.Point(189, 233);
            this.showCategoryDataGridView.Name = "showCategoryDataGridView";
            this.showCategoryDataGridView.Size = new System.Drawing.Size(446, 150);
            this.showCategoryDataGridView.TabIndex = 7;
            this.showCategoryDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCategoryDataGridView_CellDoubleClick);
            this.showCategoryDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showCategoryDataGridView_RowPostPaint);
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.CategoryModel);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // CategoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showCategoryDataGridView);
            this.Controls.Add(this.categorySearchButton);
            this.Controls.Add(this.categorySaveButton);
            this.Controls.Add(this.categorySearchTextBox);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CategoryUI";
            this.Text = "CategoryUI";
            this.Load += new System.EventHandler(this.CategoryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryCodeTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox categorySearchTextBox;
        private System.Windows.Forms.Button categorySaveButton;
        private System.Windows.Forms.Button categorySearchButton;
        private System.Windows.Forms.DataGridView showCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
    }
}