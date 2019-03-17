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
            this.BK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKADRSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKHOLDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.holdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new trynumberthree.myDataSet();
            this.bakeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.comboBoxPos = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBakery = new System.Windows.Forms.ComboBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmplDel = new System.Windows.Forms.Button();
            this.buttonEmplSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMBKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.buttonProdDefault = new System.Windows.Forms.Button();
            this.buttonProdSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProdCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxProdPriceTo = new System.Windows.Forms.TextBox();
            this.textBoxProdPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.checkBoxProdCateg = new System.Windows.Forms.CheckBox();
            this.checkBoxProdPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxProdName = new System.Windows.Forms.CheckBox();
            this.buttonProdDel = new System.Windows.Forms.Button();
            this.buttonProdSave = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.buttonDelCat = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 588);
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
            this.tabPageBakery.Size = new System.Drawing.Size(1037, 555);
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
            this.BK_ID,
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
            // BK_ID
            // 
            this.BK_ID.DataPropertyName = "BK_ID";
            this.BK_ID.HeaderText = "BK_ID";
            this.BK_ID.Name = "BK_ID";
            this.BK_ID.ReadOnly = true;
            this.BK_ID.Visible = false;
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
            this.tabPageEmployee.Controls.Add(this.groupBox1);
            this.tabPageEmployee.Controls.Add(this.buttonEmplDel);
            this.tabPageEmployee.Controls.Add(this.buttonEmplSave);
            this.tabPageEmployee.Controls.Add(this.dataGridView2);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1037, 555);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Сотрудники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddEmployee);
            this.groupBox1.Controls.Add(this.comboBoxPos);
            this.groupBox1.Controls.Add(this.comboBoxBakery);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(721, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 500);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление сотрудника";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(87, 307);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(133, 47);
            this.buttonAddEmployee.TabIndex = 8;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // comboBoxPos
            // 
            this.comboBoxPos.DataSource = this.positionsBindingSource;
            this.comboBoxPos.DisplayMember = "POS_NAME";
            this.comboBoxPos.FormattingEnabled = true;
            this.comboBoxPos.Location = new System.Drawing.Point(151, 229);
            this.comboBoxPos.Name = "comboBoxPos";
            this.comboBoxPos.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPos.TabIndex = 7;
            this.comboBoxPos.ValueMember = "POS_ID";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.myDataSet;
            // 
            // comboBoxBakery
            // 
            this.comboBoxBakery.DataSource = this.bakeryBindingSource;
            this.comboBoxBakery.DisplayMember = "BK_CITY";
            this.comboBoxBakery.FormattingEnabled = true;
            this.comboBoxBakery.Location = new System.Drawing.Point(151, 170);
            this.comboBoxBakery.Name = "comboBoxBakery";
            this.comboBoxBakery.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBakery.TabIndex = 6;
            this.comboBoxBakery.ValueMember = "BK_ID";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(151, 113);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 26);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пекарня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
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
            this.buttonEmplSave.Location = new System.Drawing.Point(7, 510);
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
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(705, 500);
            this.dataGridView2.TabIndex = 0;
            // 
            // eMNAMEDataGridViewTextBoxColumn
            // 
            this.eMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_NAME";
            this.eMNAMEDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.eMNAMEDataGridViewTextBoxColumn.Name = "eMNAMEDataGridViewTextBoxColumn";
            this.eMNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMSURNAMEDataGridViewTextBoxColumn
            // 
            this.eMSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_SURNAME";
            this.eMSURNAMEDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.eMSURNAMEDataGridViewTextBoxColumn.Name = "eMSURNAMEDataGridViewTextBoxColumn";
            this.eMSURNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMBKDataGridViewTextBoxColumn
            // 
            this.eMBKDataGridViewTextBoxColumn.DataPropertyName = "EM_BK";
            this.eMBKDataGridViewTextBoxColumn.DataSource = this.bakeryBindingSource;
            this.eMBKDataGridViewTextBoxColumn.DisplayMember = "BK_CITY";
            this.eMBKDataGridViewTextBoxColumn.HeaderText = "Пекарня";
            this.eMBKDataGridViewTextBoxColumn.Name = "eMBKDataGridViewTextBoxColumn";
            this.eMBKDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.eMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPDataGridViewTextBoxColumn.ValueMember = "POS_ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.myDataSet;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.buttonProdDefault);
            this.tabPageProducts.Controls.Add(this.buttonProdSearch);
            this.tabPageProducts.Controls.Add(this.label5);
            this.tabPageProducts.Controls.Add(this.comboBoxProdCategory);
            this.tabPageProducts.Controls.Add(this.textBoxProdPriceTo);
            this.tabPageProducts.Controls.Add(this.textBoxProdPriceFrom);
            this.tabPageProducts.Controls.Add(this.textBoxProdName);
            this.tabPageProducts.Controls.Add(this.checkBoxProdCateg);
            this.tabPageProducts.Controls.Add(this.checkBoxProdPrice);
            this.tabPageProducts.Controls.Add(this.checkBoxProdName);
            this.tabPageProducts.Controls.Add(this.buttonProdDel);
            this.tabPageProducts.Controls.Add(this.buttonProdSave);
            this.tabPageProducts.Controls.Add(this.dataGridView3);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1037, 555);
            this.tabPageProducts.TabIndex = 2;
            this.tabPageProducts.Text = "Продукция";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // buttonProdDefault
            // 
            this.buttonProdDefault.Location = new System.Drawing.Point(770, 315);
            this.buttonProdDefault.Name = "buttonProdDefault";
            this.buttonProdDefault.Size = new System.Drawing.Size(147, 46);
            this.buttonProdDefault.TabIndex = 12;
            this.buttonProdDefault.Text = "Вся продукция";
            this.buttonProdDefault.UseVisualStyleBackColor = true;
            this.buttonProdDefault.Click += new System.EventHandler(this.buttonProdDefault_Click);
            // 
            // buttonProdSearch
            // 
            this.buttonProdSearch.Location = new System.Drawing.Point(770, 223);
            this.buttonProdSearch.Name = "buttonProdSearch";
            this.buttonProdSearch.Size = new System.Drawing.Size(147, 45);
            this.buttonProdSearch.TabIndex = 11;
            this.buttonProdSearch.Text = "Поиск";
            this.buttonProdSearch.UseVisualStyleBackColor = true;
            this.buttonProdSearch.Click += new System.EventHandler(this.buttonProdSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(922, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // comboBoxProdCategory
            // 
            this.comboBoxProdCategory.DataSource = this.categoriesBindingSource;
            this.comboBoxProdCategory.DisplayMember = "CT_NAME";
            this.comboBoxProdCategory.FormattingEnabled = true;
            this.comboBoxProdCategory.Location = new System.Drawing.Point(856, 150);
            this.comboBoxProdCategory.Name = "comboBoxProdCategory";
            this.comboBoxProdCategory.Size = new System.Drawing.Size(147, 28);
            this.comboBoxProdCategory.TabIndex = 9;
            this.comboBoxProdCategory.ValueMember = "CT_ID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.myDataSet;
            // 
            // textBoxProdPriceTo
            // 
            this.textBoxProdPriceTo.Location = new System.Drawing.Point(942, 89);
            this.textBoxProdPriceTo.Name = "textBoxProdPriceTo";
            this.textBoxProdPriceTo.Size = new System.Drawing.Size(61, 26);
            this.textBoxProdPriceTo.TabIndex = 8;
            // 
            // textBoxProdPriceFrom
            // 
            this.textBoxProdPriceFrom.Location = new System.Drawing.Point(856, 89);
            this.textBoxProdPriceFrom.Name = "textBoxProdPriceFrom";
            this.textBoxProdPriceFrom.Size = new System.Drawing.Size(61, 26);
            this.textBoxProdPriceFrom.TabIndex = 7;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(856, 27);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(147, 26);
            this.textBoxProdName.TabIndex = 6;
            // 
            // checkBoxProdCateg
            // 
            this.checkBoxProdCateg.AutoSize = true;
            this.checkBoxProdCateg.Location = new System.Drawing.Point(699, 152);
            this.checkBoxProdCateg.Name = "checkBoxProdCateg";
            this.checkBoxProdCateg.Size = new System.Drawing.Size(115, 24);
            this.checkBoxProdCateg.TabIndex = 5;
            this.checkBoxProdCateg.Text = "Категория";
            this.checkBoxProdCateg.UseVisualStyleBackColor = true;
            // 
            // checkBoxProdPrice
            // 
            this.checkBoxProdPrice.AutoSize = true;
            this.checkBoxProdPrice.Location = new System.Drawing.Point(699, 91);
            this.checkBoxProdPrice.Name = "checkBoxProdPrice";
            this.checkBoxProdPrice.Size = new System.Drawing.Size(74, 24);
            this.checkBoxProdPrice.TabIndex = 4;
            this.checkBoxProdPrice.Text = "Цена";
            this.checkBoxProdPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxProdName
            // 
            this.checkBoxProdName.AutoSize = true;
            this.checkBoxProdName.Location = new System.Drawing.Point(699, 29);
            this.checkBoxProdName.Name = "checkBoxProdName";
            this.checkBoxProdName.Size = new System.Drawing.Size(109, 24);
            this.checkBoxProdName.TabIndex = 3;
            this.checkBoxProdName.Text = "Название";
            this.checkBoxProdName.UseVisualStyleBackColor = true;
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
            this.dataGridView3.Size = new System.Drawing.Size(654, 500);
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.myDataSet;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.buttonDelCat);
            this.tabPageCategories.Controls.Add(this.dataGridView4);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Size = new System.Drawing.Size(1037, 555);
            this.tabPageCategories.TabIndex = 3;
            this.tabPageCategories.Text = "Категории ";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // buttonDelCat
            // 
            this.buttonDelCat.Location = new System.Drawing.Point(7, 508);
            this.buttonDelCat.Name = "buttonDelCat";
            this.buttonDelCat.Size = new System.Drawing.Size(157, 44);
            this.buttonDelCat.TabIndex = 1;
            this.buttonDelCat.Text = "Удалить ";
            this.buttonDelCat.UseVisualStyleBackColor = true;
            this.buttonDelCat.Click += new System.EventHandler(this.buttonDelCat_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTNAMEDataGridViewTextBoxColumn,
            this.CT_ID});
            this.dataGridView4.DataSource = this.categoriesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(271, 499);
            this.dataGridView4.TabIndex = 0;
            // 
            // cTNAMEDataGridViewTextBoxColumn
            // 
            this.cTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CT_NAME";
            this.cTNAMEDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.cTNAMEDataGridViewTextBoxColumn.Name = "cTNAMEDataGridViewTextBoxColumn";
            // 
            // CT_ID
            // 
            this.CT_ID.DataPropertyName = "CT_ID";
            this.CT_ID.HeaderText = "CT_ID";
            this.CT_ID.Name = "CT_ID";
            this.CT_ID.ReadOnly = true;
            this.CT_ID.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(1057, 594);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKADRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bKHOLDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxPos;
        private System.Windows.Forms.ComboBox comboBoxBakery;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMBKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_ID;
        private System.Windows.Forms.Button buttonDelCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProdCategory;
        private System.Windows.Forms.TextBox textBoxProdPriceTo;
        private System.Windows.Forms.TextBox textBoxProdPriceFrom;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.CheckBox checkBoxProdCateg;
        private System.Windows.Forms.CheckBox checkBoxProdPrice;
        private System.Windows.Forms.CheckBox checkBoxProdName;
        private System.Windows.Forms.Button buttonProdDefault;
        private System.Windows.Forms.Button buttonProdSearch;
    }
}

