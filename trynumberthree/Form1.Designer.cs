namespace trynumberthree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBakery = new System.Windows.Forms.TabPage();
            this.buttonDelRowBakery = new System.Windows.Forms.Button();
            this.buttonSaveBakery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bKCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKADRSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKHOLDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.holdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new trynumberthree.myDataSet();
            this.bakeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.buttonEmplDel = new System.Windows.Forms.Button();
            this.buttonEmplSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMBKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.myDataSet1 = new trynumberthree.myDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.buttonProdDel = new System.Windows.Forms.Button();
            this.buttonProdSave = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryTableAdapter = new trynumberthree.myDataSetTableAdapters.bakeryTableAdapter();
            this.holdersTableAdapter = new trynumberthree.myDataSetTableAdapters.holdersTableAdapter();
            this.employeeTableAdapter = new trynumberthree.myDataSetTableAdapters.employeeTableAdapter();
            this.positionsTableAdapter = new trynumberthree.myDataSetTableAdapters.positionsTableAdapter();
            this.productTableAdapter = new trynumberthree.myDataSetTableAdapters.productTableAdapter();
            this.categoriesTableAdapter = new trynumberthree.myDataSetTableAdapters.categoriesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageBakery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBakery);
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBakery
            // 
            this.tabPageBakery.Controls.Add(this.buttonDelRowBakery);
            this.tabPageBakery.Controls.Add(this.buttonSaveBakery);
            this.tabPageBakery.Controls.Add(this.dataGridView1);
            this.tabPageBakery.Location = new System.Drawing.Point(4, 29);
            this.tabPageBakery.Name = "tabPageBakery";
            this.tabPageBakery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBakery.Size = new System.Drawing.Size(812, 555);
            this.tabPageBakery.TabIndex = 0;
            this.tabPageBakery.Text = "Пекарни";
            this.tabPageBakery.UseVisualStyleBackColor = true;
            // 
            // buttonDelRowBakery
            // 
            this.buttonDelRowBakery.Location = new System.Drawing.Point(210, 510);
            this.buttonDelRowBakery.Name = "buttonDelRowBakery";
            this.buttonDelRowBakery.Size = new System.Drawing.Size(155, 40);
            this.buttonDelRowBakery.TabIndex = 2;
            this.buttonDelRowBakery.Text = "Удалить";
            this.buttonDelRowBakery.UseVisualStyleBackColor = true;
            this.buttonDelRowBakery.Click += new System.EventHandler(this.buttonDelRowBakery_Click);
            // 
            // buttonSaveBakery
            // 
            this.buttonSaveBakery.Location = new System.Drawing.Point(6, 510);
            this.buttonSaveBakery.Name = "buttonSaveBakery";
            this.buttonSaveBakery.Size = new System.Drawing.Size(155, 40);
            this.buttonSaveBakery.TabIndex = 1;
            this.buttonSaveBakery.Text = "Сохранить";
            this.buttonSaveBakery.UseVisualStyleBackColor = true;
            this.buttonSaveBakery.Click += new System.EventHandler(this.buttonSaveBakery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bKCITYDataGridViewTextBoxColumn,
            this.bKADRSDataGridViewTextBoxColumn,
            this.bKHOLDERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bakeryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // bKCITYDataGridViewTextBoxColumn
            // 
            this.bKCITYDataGridViewTextBoxColumn.DataPropertyName = "BK_CITY";
            this.bKCITYDataGridViewTextBoxColumn.HeaderText = "Город";
            this.bKCITYDataGridViewTextBoxColumn.Name = "bKCITYDataGridViewTextBoxColumn";
            // 
            // bKADRSDataGridViewTextBoxColumn
            // 
            this.bKADRSDataGridViewTextBoxColumn.DataPropertyName = "BK_ADRS";
            this.bKADRSDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.bKADRSDataGridViewTextBoxColumn.Name = "bKADRSDataGridViewTextBoxColumn";
            this.bKADRSDataGridViewTextBoxColumn.Width = 150;
            // 
            // bKHOLDERDataGridViewTextBoxColumn
            // 
            this.bKHOLDERDataGridViewTextBoxColumn.DataPropertyName = "BK_HOLDER";
            this.bKHOLDERDataGridViewTextBoxColumn.DataSource = this.holdersBindingSource;
            this.bKHOLDERDataGridViewTextBoxColumn.DisplayMember = "H_NAME";
            this.bKHOLDERDataGridViewTextBoxColumn.HeaderText = "Директор";
            this.bKHOLDERDataGridViewTextBoxColumn.Name = "bKHOLDERDataGridViewTextBoxColumn";
            this.bKHOLDERDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bKHOLDERDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bKHOLDERDataGridViewTextBoxColumn.ValueMember = "H_ID";
            this.bKHOLDERDataGridViewTextBoxColumn.Width = 150;
            // 
            // holdersBindingSource
            // 
            this.holdersBindingSource.DataMember = "holders";
            this.holdersBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakeryBindingSource
            // 
            this.bakeryBindingSource.DataMember = "bakery";
            this.bakeryBindingSource.DataSource = this.myDataSet;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.buttonEmplDel);
            this.tabPageEmployee.Controls.Add(this.buttonEmplSave);
            this.tabPageEmployee.Controls.Add(this.dataGridView2);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(812, 555);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Сотрудники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonEmplDel
            // 
            this.buttonEmplDel.Location = new System.Drawing.Point(210, 510);
            this.buttonEmplDel.Name = "buttonEmplDel";
            this.buttonEmplDel.Size = new System.Drawing.Size(155, 40);
            this.buttonEmplDel.TabIndex = 2;
            this.buttonEmplDel.Text = "Удалить";
            this.buttonEmplDel.UseVisualStyleBackColor = true;
            this.buttonEmplDel.Click += new System.EventHandler(this.buttonEmplDel_Click);
            // 
            // buttonEmplSave
            // 
            this.buttonEmplSave.Location = new System.Drawing.Point(21, 512);
            this.buttonEmplSave.Name = "buttonEmplSave";
            this.buttonEmplSave.Size = new System.Drawing.Size(155, 40);
            this.buttonEmplSave.TabIndex = 1;
            this.buttonEmplSave.Text = "Сохранить";
            this.buttonEmplSave.UseVisualStyleBackColor = true;
            this.buttonEmplSave.Click += new System.EventHandler(this.buttonEmplSave_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMNAMEDataGridViewTextBoxColumn,
            this.eMSURNAMEDataGridViewTextBoxColumn,
            this.eMBKDataGridViewTextBoxColumn,
            this.eMPDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.employeeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(800, 500);
            this.dataGridView2.TabIndex = 0;
            // 
            // eMNAMEDataGridViewTextBoxColumn
            // 
            this.eMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_NAME";
            this.eMNAMEDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.eMNAMEDataGridViewTextBoxColumn.Name = "eMNAMEDataGridViewTextBoxColumn";
            // 
            // eMSURNAMEDataGridViewTextBoxColumn
            // 
            this.eMSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_SURNAME";
            this.eMSURNAMEDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.eMSURNAMEDataGridViewTextBoxColumn.Name = "eMSURNAMEDataGridViewTextBoxColumn";
            // 
            // eMBKDataGridViewTextBoxColumn
            // 
            this.eMBKDataGridViewTextBoxColumn.DataPropertyName = "EM_BK";
            this.eMBKDataGridViewTextBoxColumn.DataSource = this.bakeryBindingSource;
            this.eMBKDataGridViewTextBoxColumn.DisplayMember = "BK_CITY";
            this.eMBKDataGridViewTextBoxColumn.HeaderText = "Пекарня";
            this.eMBKDataGridViewTextBoxColumn.Name = "eMBKDataGridViewTextBoxColumn";
            this.eMBKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMBKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMBKDataGridViewTextBoxColumn.ValueMember = "BK_ID";
            // 
            // eMPDataGridViewTextBoxColumn
            // 
            this.eMPDataGridViewTextBoxColumn.DataPropertyName = "EM_P";
            this.eMPDataGridViewTextBoxColumn.DataSource = this.positionsBindingSource;
            this.eMPDataGridViewTextBoxColumn.DisplayMember = "POS_NAME";
            this.eMPDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.eMPDataGridViewTextBoxColumn.Name = "eMPDataGridViewTextBoxColumn";
            this.eMPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPDataGridViewTextBoxColumn.ValueMember = "POS_ID";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet1
            // 
            //this.myDataSet1.DataSetName = "myDataSet";
            //this.myDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.myDataSet;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.buttonProdDel);
            this.tabPageProducts.Controls.Add(this.buttonProdSave);
            this.tabPageProducts.Controls.Add(this.dataGridView3);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(812, 557);
            this.tabPageProducts.TabIndex = 2;
            this.tabPageProducts.Text = "Продукция";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // buttonProdDel
            // 
            this.buttonProdDel.Location = new System.Drawing.Point(210, 510);
            this.buttonProdDel.Name = "buttonProdDel";
            this.buttonProdDel.Size = new System.Drawing.Size(155, 40);
            this.buttonProdDel.TabIndex = 2;
            this.buttonProdDel.Text = "Удалить";
            this.buttonProdDel.UseVisualStyleBackColor = true;
            this.buttonProdDel.Click += new System.EventHandler(this.buttonProdDel_Click);
            // 
            // buttonProdSave
            // 
            this.buttonProdSave.Location = new System.Drawing.Point(6, 510);
            this.buttonProdSave.Name = "buttonProdSave";
            this.buttonProdSave.Size = new System.Drawing.Size(155, 40);
            this.buttonProdSave.TabIndex = 1;
            this.buttonProdSave.Text = "Сохранить";
            this.buttonProdSave.UseVisualStyleBackColor = true;
            this.buttonProdSave.Click += new System.EventHandler(this.buttonProdSave_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRNAMEDataGridViewTextBoxColumn,
            this.pRCOSTDataGridViewTextBoxColumn,
            this.pRCATDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.productBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(800, 500);
            this.dataGridView3.TabIndex = 0;
            // 
            // pRNAMEDataGridViewTextBoxColumn
            // 
            this.pRNAMEDataGridViewTextBoxColumn.DataPropertyName = "PR_NAME";
            this.pRNAMEDataGridViewTextBoxColumn.HeaderText = "Название";
            this.pRNAMEDataGridViewTextBoxColumn.Name = "pRNAMEDataGridViewTextBoxColumn";
            this.pRNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRCOSTDataGridViewTextBoxColumn
            // 
            this.pRCOSTDataGridViewTextBoxColumn.DataPropertyName = "PR_COST";
            this.pRCOSTDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.pRCOSTDataGridViewTextBoxColumn.Name = "pRCOSTDataGridViewTextBoxColumn";
            this.pRCOSTDataGridViewTextBoxColumn.Width = 70;
            // 
            // pRCATDataGridViewTextBoxColumn
            // 
            this.pRCATDataGridViewTextBoxColumn.DataPropertyName = "PR_CAT";
            this.pRCATDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.pRCATDataGridViewTextBoxColumn.DisplayMember = "CT_NAME";
            this.pRCATDataGridViewTextBoxColumn.HeaderText = "Категория товара";
            this.pRCATDataGridViewTextBoxColumn.Name = "pRCATDataGridViewTextBoxColumn";
            this.pRCATDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRCATDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pRCATDataGridViewTextBoxColumn.ValueMember = "CT_ID";
            this.pRCATDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.myDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.myDataSet;
            // 
            // bakeryTableAdapter
            // 
            this.bakeryTableAdapter.ClearBeforeFill = true;
            // 
            // holdersTableAdapter
            // 
            this.holdersTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBakery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBakery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource bakeryBindingSource;
        private myDataSetTableAdapters.bakeryTableAdapter bakeryTableAdapter;
        private System.Windows.Forms.BindingSource holdersBindingSource;
        private myDataSetTableAdapters.holdersTableAdapter holdersTableAdapter;
        private System.Windows.Forms.Button buttonSaveBakery;
        private System.Windows.Forms.Button buttonDelRowBakery;
        private System.Windows.Forms.Button buttonEmplDel;
        private System.Windows.Forms.Button buttonEmplSave;
        private System.Windows.Forms.DataGridView dataGridView2;
        //private myDataSet myDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private myDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private myDataSetTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKADRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bKHOLDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMBKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private myDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private myDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button buttonProdDel;
        private System.Windows.Forms.Button buttonProdSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRCATDataGridViewTextBoxColumn;
    }
}

