
namespace SimplePOS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTransaction = new System.Windows.Forms.TabPage();
            this.groupBoxTransactionOverview = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTransactionChange = new System.Windows.Forms.TextBox();
            this.textBoxTransactionTotal = new System.Windows.Forms.TextBox();
            this.labelTransactionTotal = new System.Windows.Forms.Label();
            this.labelTransactionCash = new System.Windows.Forms.Label();
            this.numericUpDownCash = new System.Windows.Forms.NumericUpDown();
            this.labelTransactionChange = new System.Windows.Forms.Label();
            this.labelTransactionDate = new System.Windows.Forms.Label();
            this.groupBoxTransactionCart = new System.Windows.Forms.GroupBox();
            this.dataGridViewTransactionProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.textBoxTransactionProductName = new System.Windows.Forms.TextBox();
            this.labelTransactionProductName = new System.Windows.Forms.Label();
            this.textBoxTransactionProductSubtotal = new System.Windows.Forms.TextBox();
            this.labelTransactionProductSubtotal = new System.Windows.Forms.Label();
            this.textBoxTransactionProductStock = new System.Windows.Forms.TextBox();
            this.labelTransactionProductStock = new System.Windows.Forms.Label();
            this.numericUpDownTransactionProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxTransactionProductPrice = new System.Windows.Forms.TextBox();
            this.numericUpDownTransactionProductId = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTransactionProductPrice = new System.Windows.Forms.Label();
            this.labelTransactionProductId = new System.Windows.Forms.Label();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.groupBoxProductsList = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProductEditorId = new System.Windows.Forms.Label();
            this.textBoxProductEditorId = new System.Windows.Forms.TextBox();
            this.numericUpDownProductEditorPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProductEditorStock = new System.Windows.Forms.NumericUpDown();
            this.labelProductStock = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductEditorName = new System.Windows.Forms.TextBox();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReportTransactionProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxReportTransactionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReportDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxReportChange = new System.Windows.Forms.TextBox();
            this.labelReportCash = new System.Windows.Forms.Label();
            this.numericUpDownReportCash = new System.Windows.Forms.NumericUpDown();
            this.textBoxReportTotal = new System.Windows.Forms.TextBox();
            this.labelReportChange = new System.Windows.Forms.Label();
            this.labelReportTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxTransactionsList = new System.Windows.Forms.GroupBox();
            this.buttonReportRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTransactionsList = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTransactionReset = new System.Windows.Forms.Button();
            this.buttonTransactionCheckout = new System.Windows.Forms.Button();
            this.buttonTransactionProductAdd = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.buttonProductEditorReset = new System.Windows.Forms.Button();
            this.buttonProductEditorSave = new System.Windows.Forms.Button();
            this.buttonReportDelete = new System.Windows.Forms.Button();
            this.buttonReportEdit = new System.Windows.Forms.Button();
            this.buttonProductsRefresh = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageTransaction.SuspendLayout();
            this.groupBoxTransactionOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).BeginInit();
            this.groupBoxTransactionCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionProducts)).BeginInit();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionProductId)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            this.groupBoxProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductEditorPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductEditorStock)).BeginInit();
            this.tabPageReport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportTransactionProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportCash)).BeginInit();
            this.groupBoxTransactionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageTransaction);
            this.tabControlMain.Controls.Add(this.tabPageProducts);
            this.tabControlMain.Controls.Add(this.tabPageReport);
            this.tabControlMain.Location = new System.Drawing.Point(12, 123);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(997, 614);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTransaction
            // 
            this.tabPageTransaction.Controls.Add(this.groupBoxTransactionOverview);
            this.tabPageTransaction.Controls.Add(this.groupBoxTransactionCart);
            this.tabPageTransaction.Controls.Add(this.groupBoxAddProduct);
            this.tabPageTransaction.Location = new System.Drawing.Point(4, 29);
            this.tabPageTransaction.Name = "tabPageTransaction";
            this.tabPageTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransaction.Size = new System.Drawing.Size(989, 581);
            this.tabPageTransaction.TabIndex = 1;
            this.tabPageTransaction.Text = "Transaction";
            this.tabPageTransaction.UseVisualStyleBackColor = true;
            // 
            // groupBoxTransactionOverview
            // 
            this.groupBoxTransactionOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransactionOverview.Controls.Add(this.buttonTransactionReset);
            this.groupBoxTransactionOverview.Controls.Add(this.dateTimePickerTransactionDate);
            this.groupBoxTransactionOverview.Controls.Add(this.textBoxTransactionChange);
            this.groupBoxTransactionOverview.Controls.Add(this.textBoxTransactionTotal);
            this.groupBoxTransactionOverview.Controls.Add(this.labelTransactionTotal);
            this.groupBoxTransactionOverview.Controls.Add(this.labelTransactionCash);
            this.groupBoxTransactionOverview.Controls.Add(this.numericUpDownCash);
            this.groupBoxTransactionOverview.Controls.Add(this.buttonTransactionCheckout);
            this.groupBoxTransactionOverview.Controls.Add(this.labelTransactionChange);
            this.groupBoxTransactionOverview.Controls.Add(this.labelTransactionDate);
            this.groupBoxTransactionOverview.Location = new System.Drawing.Point(602, 6);
            this.groupBoxTransactionOverview.Name = "groupBoxTransactionOverview";
            this.groupBoxTransactionOverview.Size = new System.Drawing.Size(375, 262);
            this.groupBoxTransactionOverview.TabIndex = 15;
            this.groupBoxTransactionOverview.TabStop = false;
            this.groupBoxTransactionOverview.Text = "Transaction Overview";
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(130, 74);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(220, 26);
            this.dateTimePickerTransactionDate.TabIndex = 15;
            // 
            // textBoxTransactionChange
            // 
            this.textBoxTransactionChange.Enabled = false;
            this.textBoxTransactionChange.Location = new System.Drawing.Point(130, 140);
            this.textBoxTransactionChange.Name = "textBoxTransactionChange";
            this.textBoxTransactionChange.Size = new System.Drawing.Size(220, 26);
            this.textBoxTransactionChange.TabIndex = 11;
            this.textBoxTransactionChange.Text = "0";
            // 
            // textBoxTransactionTotal
            // 
            this.textBoxTransactionTotal.Enabled = false;
            this.textBoxTransactionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionTotal.Location = new System.Drawing.Point(130, 26);
            this.textBoxTransactionTotal.Name = "textBoxTransactionTotal";
            this.textBoxTransactionTotal.Size = new System.Drawing.Size(220, 39);
            this.textBoxTransactionTotal.TabIndex = 2;
            this.textBoxTransactionTotal.Text = "0";
            // 
            // labelTransactionTotal
            // 
            this.labelTransactionTotal.AutoSize = true;
            this.labelTransactionTotal.Location = new System.Drawing.Point(6, 39);
            this.labelTransactionTotal.Name = "labelTransactionTotal";
            this.labelTransactionTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTransactionTotal.TabIndex = 3;
            this.labelTransactionTotal.Text = "Total";
            // 
            // labelTransactionCash
            // 
            this.labelTransactionCash.AutoSize = true;
            this.labelTransactionCash.Location = new System.Drawing.Point(6, 111);
            this.labelTransactionCash.Name = "labelTransactionCash";
            this.labelTransactionCash.Size = new System.Drawing.Size(46, 20);
            this.labelTransactionCash.TabIndex = 12;
            this.labelTransactionCash.Text = "Cash";
            // 
            // numericUpDownCash
            // 
            this.numericUpDownCash.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCash.Location = new System.Drawing.Point(130, 106);
            this.numericUpDownCash.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCash.Name = "numericUpDownCash";
            this.numericUpDownCash.Size = new System.Drawing.Size(220, 26);
            this.numericUpDownCash.TabIndex = 10;
            this.numericUpDownCash.ValueChanged += new System.EventHandler(this.numericUpDownCash_ValueChanged);
            // 
            // labelTransactionChange
            // 
            this.labelTransactionChange.AutoSize = true;
            this.labelTransactionChange.Location = new System.Drawing.Point(6, 143);
            this.labelTransactionChange.Name = "labelTransactionChange";
            this.labelTransactionChange.Size = new System.Drawing.Size(65, 20);
            this.labelTransactionChange.TabIndex = 5;
            this.labelTransactionChange.Text = "Change";
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.AutoSize = true;
            this.labelTransactionDate.Location = new System.Drawing.Point(7, 80);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(44, 20);
            this.labelTransactionDate.TabIndex = 1;
            this.labelTransactionDate.Text = "Date";
            // 
            // groupBoxTransactionCart
            // 
            this.groupBoxTransactionCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransactionCart.Controls.Add(this.dataGridViewTransactionProducts);
            this.groupBoxTransactionCart.Location = new System.Drawing.Point(6, 315);
            this.groupBoxTransactionCart.Name = "groupBoxTransactionCart";
            this.groupBoxTransactionCart.Size = new System.Drawing.Size(977, 260);
            this.groupBoxTransactionCart.TabIndex = 4;
            this.groupBoxTransactionCart.TabStop = false;
            this.groupBoxTransactionCart.Text = "Cart";
            // 
            // dataGridViewTransactionProducts
            // 
            this.dataGridViewTransactionProducts.AllowUserToAddRows = false;
            this.dataGridViewTransactionProducts.AllowUserToDeleteRows = false;
            this.dataGridViewTransactionProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransactionProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactionProducts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTransactionProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.subtotal,
            this.action});
            this.dataGridViewTransactionProducts.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewTransactionProducts.Name = "dataGridViewTransactionProducts";
            this.dataGridViewTransactionProducts.ReadOnly = true;
            this.dataGridViewTransactionProducts.RowHeadersVisible = false;
            this.dataGridViewTransactionProducts.RowHeadersWidth = 62;
            this.dataGridViewTransactionProducts.RowTemplate.Height = 28;
            this.dataGridViewTransactionProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactionProducts.Size = new System.Drawing.Size(965, 229);
            this.dataGridViewTransactionProducts.TabIndex = 0;
            this.dataGridViewTransactionProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactionProducts_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Product ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 8;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.MinimumWidth = 8;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.textBoxTransactionProductName);
            this.groupBoxAddProduct.Controls.Add(this.labelTransactionProductName);
            this.groupBoxAddProduct.Controls.Add(this.textBoxTransactionProductSubtotal);
            this.groupBoxAddProduct.Controls.Add(this.buttonTransactionProductAdd);
            this.groupBoxAddProduct.Controls.Add(this.labelTransactionProductSubtotal);
            this.groupBoxAddProduct.Controls.Add(this.buttonSearchProduct);
            this.groupBoxAddProduct.Controls.Add(this.textBoxTransactionProductStock);
            this.groupBoxAddProduct.Controls.Add(this.labelTransactionProductStock);
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownTransactionProductQuantity);
            this.groupBoxAddProduct.Controls.Add(this.textBoxTransactionProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownTransactionProductId);
            this.groupBoxAddProduct.Controls.Add(this.labelQuantity);
            this.groupBoxAddProduct.Controls.Add(this.labelTransactionProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.labelTransactionProductId);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(375, 303);
            this.groupBoxAddProduct.TabIndex = 3;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Add Product";
            // 
            // textBoxTransactionProductName
            // 
            this.textBoxTransactionProductName.Enabled = false;
            this.textBoxTransactionProductName.Location = new System.Drawing.Point(130, 60);
            this.textBoxTransactionProductName.Name = "textBoxTransactionProductName";
            this.textBoxTransactionProductName.Size = new System.Drawing.Size(220, 26);
            this.textBoxTransactionProductName.TabIndex = 15;
            // 
            // labelTransactionProductName
            // 
            this.labelTransactionProductName.AutoSize = true;
            this.labelTransactionProductName.Location = new System.Drawing.Point(7, 63);
            this.labelTransactionProductName.Name = "labelTransactionProductName";
            this.labelTransactionProductName.Size = new System.Drawing.Size(51, 20);
            this.labelTransactionProductName.TabIndex = 16;
            this.labelTransactionProductName.Text = "Name";
            // 
            // textBoxTransactionProductSubtotal
            // 
            this.textBoxTransactionProductSubtotal.Enabled = false;
            this.textBoxTransactionProductSubtotal.Location = new System.Drawing.Point(130, 188);
            this.textBoxTransactionProductSubtotal.Name = "textBoxTransactionProductSubtotal";
            this.textBoxTransactionProductSubtotal.Size = new System.Drawing.Size(220, 26);
            this.textBoxTransactionProductSubtotal.TabIndex = 13;
            // 
            // labelTransactionProductSubtotal
            // 
            this.labelTransactionProductSubtotal.AutoSize = true;
            this.labelTransactionProductSubtotal.Location = new System.Drawing.Point(7, 191);
            this.labelTransactionProductSubtotal.Name = "labelTransactionProductSubtotal";
            this.labelTransactionProductSubtotal.Size = new System.Drawing.Size(69, 20);
            this.labelTransactionProductSubtotal.TabIndex = 14;
            this.labelTransactionProductSubtotal.Text = "Subtotal";
            // 
            // textBoxTransactionProductStock
            // 
            this.textBoxTransactionProductStock.Enabled = false;
            this.textBoxTransactionProductStock.Location = new System.Drawing.Point(130, 124);
            this.textBoxTransactionProductStock.Name = "textBoxTransactionProductStock";
            this.textBoxTransactionProductStock.Size = new System.Drawing.Size(220, 26);
            this.textBoxTransactionProductStock.TabIndex = 11;
            // 
            // labelTransactionProductStock
            // 
            this.labelTransactionProductStock.AutoSize = true;
            this.labelTransactionProductStock.Location = new System.Drawing.Point(7, 127);
            this.labelTransactionProductStock.Name = "labelTransactionProductStock";
            this.labelTransactionProductStock.Size = new System.Drawing.Size(50, 20);
            this.labelTransactionProductStock.TabIndex = 12;
            this.labelTransactionProductStock.Text = "Stock";
            // 
            // numericUpDownTransactionProductQuantity
            // 
            this.numericUpDownTransactionProductQuantity.Location = new System.Drawing.Point(130, 156);
            this.numericUpDownTransactionProductQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTransactionProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTransactionProductQuantity.Name = "numericUpDownTransactionProductQuantity";
            this.numericUpDownTransactionProductQuantity.Size = new System.Drawing.Size(220, 26);
            this.numericUpDownTransactionProductQuantity.TabIndex = 10;
            this.numericUpDownTransactionProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTransactionProductQuantity.ValueChanged += new System.EventHandler(this.numericUpDownTransactionProductQuantity_ValueChanged);
            // 
            // textBoxTransactionProductPrice
            // 
            this.textBoxTransactionProductPrice.Enabled = false;
            this.textBoxTransactionProductPrice.Location = new System.Drawing.Point(130, 92);
            this.textBoxTransactionProductPrice.Name = "textBoxTransactionProductPrice";
            this.textBoxTransactionProductPrice.Size = new System.Drawing.Size(220, 26);
            this.textBoxTransactionProductPrice.TabIndex = 2;
            // 
            // numericUpDownTransactionProductId
            // 
            this.numericUpDownTransactionProductId.Location = new System.Drawing.Point(130, 24);
            this.numericUpDownTransactionProductId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTransactionProductId.Name = "numericUpDownTransactionProductId";
            this.numericUpDownTransactionProductId.Size = new System.Drawing.Size(158, 26);
            this.numericUpDownTransactionProductId.TabIndex = 1;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(7, 158);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelTransactionProductPrice
            // 
            this.labelTransactionProductPrice.AutoSize = true;
            this.labelTransactionProductPrice.Location = new System.Drawing.Point(7, 95);
            this.labelTransactionProductPrice.Name = "labelTransactionProductPrice";
            this.labelTransactionProductPrice.Size = new System.Drawing.Size(44, 20);
            this.labelTransactionProductPrice.TabIndex = 3;
            this.labelTransactionProductPrice.Text = "Price";
            // 
            // labelTransactionProductId
            // 
            this.labelTransactionProductId.AutoSize = true;
            this.labelTransactionProductId.Location = new System.Drawing.Point(7, 26);
            this.labelTransactionProductId.Name = "labelTransactionProductId";
            this.labelTransactionProductId.Size = new System.Drawing.Size(85, 20);
            this.labelTransactionProductId.TabIndex = 1;
            this.labelTransactionProductId.Text = "Product ID";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.groupBoxProductsList);
            this.tabPageProducts.Controls.Add(this.groupBox1);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(989, 581);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductsList
            // 
            this.groupBoxProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProductsList.Controls.Add(this.buttonProductsRefresh);
            this.groupBoxProductsList.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProductsList.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProductsList.Name = "groupBoxProductsList";
            this.groupBoxProductsList.Size = new System.Drawing.Size(592, 569);
            this.groupBoxProductsList.TabIndex = 2;
            this.groupBoxProductsList.TabStop = false;
            this.groupBoxProductsList.Text = "List";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProducts.ColumnHeadersHeight = 34;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.productStock,
            this.productEdit,
            this.productDelete});
            this.dataGridViewProducts.Location = new System.Drawing.Point(7, 23);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(579, 482);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // productId
            // 
            this.productId.HeaderText = "ID";
            this.productId.MinimumWidth = 8;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productStock
            // 
            this.productStock.HeaderText = "Stock";
            this.productStock.MinimumWidth = 8;
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            // 
            // productEdit
            // 
            this.productEdit.HeaderText = "Edit";
            this.productEdit.MinimumWidth = 8;
            this.productEdit.Name = "productEdit";
            this.productEdit.ReadOnly = true;
            // 
            // productDelete
            // 
            this.productDelete.HeaderText = "Delete";
            this.productDelete.MinimumWidth = 8;
            this.productDelete.Name = "productDelete";
            this.productDelete.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelProductEditorId);
            this.groupBox1.Controls.Add(this.textBoxProductEditorId);
            this.groupBox1.Controls.Add(this.buttonProductEditorReset);
            this.groupBox1.Controls.Add(this.numericUpDownProductEditorPrice);
            this.groupBox1.Controls.Add(this.numericUpDownProductEditorStock);
            this.groupBox1.Controls.Add(this.buttonProductEditorSave);
            this.groupBox1.Controls.Add(this.labelProductStock);
            this.groupBox1.Controls.Add(this.labelProductPrice);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.textBoxProductEditorName);
            this.groupBox1.Location = new System.Drawing.Point(608, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor";
            // 
            // labelProductEditorId
            // 
            this.labelProductEditorId.AutoSize = true;
            this.labelProductEditorId.Location = new System.Drawing.Point(7, 34);
            this.labelProductEditorId.Name = "labelProductEditorId";
            this.labelProductEditorId.Size = new System.Drawing.Size(85, 20);
            this.labelProductEditorId.TabIndex = 11;
            this.labelProductEditorId.Text = "Product ID";
            // 
            // textBoxProductEditorId
            // 
            this.textBoxProductEditorId.Enabled = false;
            this.textBoxProductEditorId.Location = new System.Drawing.Point(130, 31);
            this.textBoxProductEditorId.Name = "textBoxProductEditorId";
            this.textBoxProductEditorId.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductEditorId.TabIndex = 10;
            // 
            // numericUpDownProductEditorPrice
            // 
            this.numericUpDownProductEditorPrice.Location = new System.Drawing.Point(130, 95);
            this.numericUpDownProductEditorPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownProductEditorPrice.Name = "numericUpDownProductEditorPrice";
            this.numericUpDownProductEditorPrice.Size = new System.Drawing.Size(220, 26);
            this.numericUpDownProductEditorPrice.TabIndex = 1;
            // 
            // numericUpDownProductEditorStock
            // 
            this.numericUpDownProductEditorStock.Location = new System.Drawing.Point(130, 127);
            this.numericUpDownProductEditorStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownProductEditorStock.Name = "numericUpDownProductEditorStock";
            this.numericUpDownProductEditorStock.Size = new System.Drawing.Size(220, 26);
            this.numericUpDownProductEditorStock.TabIndex = 1;
            // 
            // labelProductStock
            // 
            this.labelProductStock.AutoSize = true;
            this.labelProductStock.Location = new System.Drawing.Point(7, 129);
            this.labelProductStock.Name = "labelProductStock";
            this.labelProductStock.Size = new System.Drawing.Size(50, 20);
            this.labelProductStock.TabIndex = 5;
            this.labelProductStock.Text = "Stock";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(7, 97);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(44, 20);
            this.labelProductPrice.TabIndex = 3;
            this.labelProductPrice.Text = "Price";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(7, 66);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(51, 20);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Name";
            // 
            // textBoxProductEditorName
            // 
            this.textBoxProductEditorName.Location = new System.Drawing.Point(130, 63);
            this.textBoxProductEditorName.Name = "textBoxProductEditorName";
            this.textBoxProductEditorName.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductEditorName.TabIndex = 0;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.groupBox3);
            this.tabPageReport.Controls.Add(this.groupBoxTransactionsList);
            this.tabPageReport.Location = new System.Drawing.Point(4, 29);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(989, 581);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(390, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 563);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridViewReportTransactionProducts);
            this.groupBox4.Location = new System.Drawing.Point(6, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 286);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Products";
            // 
            // dataGridViewReportTransactionProducts
            // 
            this.dataGridViewReportTransactionProducts.AllowUserToAddRows = false;
            this.dataGridViewReportTransactionProducts.AllowUserToDeleteRows = false;
            this.dataGridViewReportTransactionProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReportTransactionProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReportTransactionProducts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReportTransactionProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportTransactionProducts.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewReportTransactionProducts.Name = "dataGridViewReportTransactionProducts";
            this.dataGridViewReportTransactionProducts.ReadOnly = true;
            this.dataGridViewReportTransactionProducts.RowHeadersVisible = false;
            this.dataGridViewReportTransactionProducts.RowHeadersWidth = 62;
            this.dataGridViewReportTransactionProducts.RowTemplate.Height = 28;
            this.dataGridViewReportTransactionProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReportTransactionProducts.Size = new System.Drawing.Size(569, 255);
            this.dataGridViewReportTransactionProducts.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxReportTransactionId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonReportDelete);
            this.groupBox2.Controls.Add(this.dateTimePickerReportDate);
            this.groupBox2.Controls.Add(this.textBoxReportChange);
            this.groupBox2.Controls.Add(this.labelReportCash);
            this.groupBox2.Controls.Add(this.numericUpDownReportCash);
            this.groupBox2.Controls.Add(this.textBoxReportTotal);
            this.groupBox2.Controls.Add(this.buttonReportEdit);
            this.groupBox2.Controls.Add(this.labelReportChange);
            this.groupBox2.Controls.Add(this.labelReportTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 239);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Overview";
            // 
            // textBoxReportTransactionId
            // 
            this.textBoxReportTransactionId.Enabled = false;
            this.textBoxReportTransactionId.Location = new System.Drawing.Point(136, 35);
            this.textBoxReportTransactionId.Name = "textBoxReportTransactionId";
            this.textBoxReportTransactionId.Size = new System.Drawing.Size(220, 26);
            this.textBoxReportTransactionId.TabIndex = 17;
            this.textBoxReportTransactionId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Transaction ID";
            // 
            // dateTimePickerReportDate
            // 
            this.dateTimePickerReportDate.Enabled = false;
            this.dateTimePickerReportDate.Location = new System.Drawing.Point(136, 67);
            this.dateTimePickerReportDate.Name = "dateTimePickerReportDate";
            this.dateTimePickerReportDate.Size = new System.Drawing.Size(220, 26);
            this.dateTimePickerReportDate.TabIndex = 15;
            // 
            // textBoxReportChange
            // 
            this.textBoxReportChange.Enabled = false;
            this.textBoxReportChange.Location = new System.Drawing.Point(136, 166);
            this.textBoxReportChange.Name = "textBoxReportChange";
            this.textBoxReportChange.Size = new System.Drawing.Size(220, 26);
            this.textBoxReportChange.TabIndex = 11;
            this.textBoxReportChange.Text = "0";
            // 
            // labelReportCash
            // 
            this.labelReportCash.AutoSize = true;
            this.labelReportCash.Location = new System.Drawing.Point(12, 137);
            this.labelReportCash.Name = "labelReportCash";
            this.labelReportCash.Size = new System.Drawing.Size(46, 20);
            this.labelReportCash.TabIndex = 12;
            this.labelReportCash.Text = "Cash";
            // 
            // numericUpDownReportCash
            // 
            this.numericUpDownReportCash.Enabled = false;
            this.numericUpDownReportCash.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownReportCash.Location = new System.Drawing.Point(136, 132);
            this.numericUpDownReportCash.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownReportCash.Name = "numericUpDownReportCash";
            this.numericUpDownReportCash.Size = new System.Drawing.Size(220, 26);
            this.numericUpDownReportCash.TabIndex = 10;
            this.numericUpDownReportCash.ValueChanged += new System.EventHandler(this.numericUpDownReportCash_ValueChanged);
            // 
            // textBoxReportTotal
            // 
            this.textBoxReportTotal.Enabled = false;
            this.textBoxReportTotal.Location = new System.Drawing.Point(136, 102);
            this.textBoxReportTotal.Name = "textBoxReportTotal";
            this.textBoxReportTotal.Size = new System.Drawing.Size(220, 26);
            this.textBoxReportTotal.TabIndex = 2;
            this.textBoxReportTotal.Text = "0";
            // 
            // labelReportChange
            // 
            this.labelReportChange.AutoSize = true;
            this.labelReportChange.Location = new System.Drawing.Point(12, 169);
            this.labelReportChange.Name = "labelReportChange";
            this.labelReportChange.Size = new System.Drawing.Size(65, 20);
            this.labelReportChange.TabIndex = 5;
            this.labelReportChange.Text = "Change";
            // 
            // labelReportTotal
            // 
            this.labelReportTotal.AutoSize = true;
            this.labelReportTotal.Location = new System.Drawing.Point(13, 105);
            this.labelReportTotal.Name = "labelReportTotal";
            this.labelReportTotal.Size = new System.Drawing.Size(44, 20);
            this.labelReportTotal.TabIndex = 3;
            this.labelReportTotal.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // groupBoxTransactionsList
            // 
            this.groupBoxTransactionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransactionsList.Controls.Add(this.buttonReportRefresh);
            this.groupBoxTransactionsList.Controls.Add(this.dataGridViewTransactionsList);
            this.groupBoxTransactionsList.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTransactionsList.Name = "groupBoxTransactionsList";
            this.groupBoxTransactionsList.Size = new System.Drawing.Size(378, 569);
            this.groupBoxTransactionsList.TabIndex = 1;
            this.groupBoxTransactionsList.TabStop = false;
            this.groupBoxTransactionsList.Text = "Transactions List";
            // 
            // buttonReportRefresh
            // 
            this.buttonReportRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReportRefresh.Image = global::SimplePOS.Properties.Resources.refresh;
            this.buttonReportRefresh.Location = new System.Drawing.Point(7, 510);
            this.buttonReportRefresh.Name = "buttonReportRefresh";
            this.buttonReportRefresh.Size = new System.Drawing.Size(365, 52);
            this.buttonReportRefresh.TabIndex = 19;
            this.buttonReportRefresh.Text = "Refresh List";
            this.buttonReportRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReportRefresh.UseVisualStyleBackColor = false;
            this.buttonReportRefresh.Click += new System.EventHandler(this.buttonReportRefresh_Click);
            // 
            // dataGridViewTransactionsList
            // 
            this.dataGridViewTransactionsList.AllowUserToAddRows = false;
            this.dataGridViewTransactionsList.AllowUserToDeleteRows = false;
            this.dataGridViewTransactionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactionsList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionsList.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewTransactionsList.Name = "dataGridViewTransactionsList";
            this.dataGridViewTransactionsList.ReadOnly = true;
            this.dataGridViewTransactionsList.RowHeadersVisible = false;
            this.dataGridViewTransactionsList.RowHeadersWidth = 62;
            this.dataGridViewTransactionsList.RowTemplate.Height = 28;
            this.dataGridViewTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactionsList.Size = new System.Drawing.Size(365, 478);
            this.dataGridViewTransactionsList.TabIndex = 0;
            this.dataGridViewTransactionsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactionsList_CellClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(225, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "v0.9 Beta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimplePOS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTransactionReset
            // 
            this.buttonTransactionReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTransactionReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransactionReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionReset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonTransactionReset.Image = global::SimplePOS.Properties.Resources.reset;
            this.buttonTransactionReset.Location = new System.Drawing.Point(11, 188);
            this.buttonTransactionReset.Name = "buttonTransactionReset";
            this.buttonTransactionReset.Size = new System.Drawing.Size(109, 52);
            this.buttonTransactionReset.TabIndex = 16;
            this.buttonTransactionReset.Text = "Reset";
            this.buttonTransactionReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransactionReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTransactionReset.UseVisualStyleBackColor = false;
            this.buttonTransactionReset.Click += new System.EventHandler(this.buttonTransactionReset_Click);
            // 
            // buttonTransactionCheckout
            // 
            this.buttonTransactionCheckout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonTransactionCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransactionCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonTransactionCheckout.Image = ((System.Drawing.Image)(resources.GetObject("buttonTransactionCheckout.Image")));
            this.buttonTransactionCheckout.Location = new System.Drawing.Point(130, 188);
            this.buttonTransactionCheckout.Name = "buttonTransactionCheckout";
            this.buttonTransactionCheckout.Size = new System.Drawing.Size(220, 52);
            this.buttonTransactionCheckout.TabIndex = 6;
            this.buttonTransactionCheckout.Text = "Checkout";
            this.buttonTransactionCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransactionCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTransactionCheckout.UseVisualStyleBackColor = false;
            this.buttonTransactionCheckout.Click += new System.EventHandler(this.buttonTransactionCheckout_Click);
            // 
            // buttonTransactionProductAdd
            // 
            this.buttonTransactionProductAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonTransactionProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransactionProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionProductAdd.ForeColor = System.Drawing.Color.White;
            this.buttonTransactionProductAdd.Image = global::SimplePOS.Properties.Resources.shopping_cart;
            this.buttonTransactionProductAdd.Location = new System.Drawing.Point(130, 229);
            this.buttonTransactionProductAdd.Name = "buttonTransactionProductAdd";
            this.buttonTransactionProductAdd.Size = new System.Drawing.Size(220, 52);
            this.buttonTransactionProductAdd.TabIndex = 6;
            this.buttonTransactionProductAdd.Text = "Add to Cart";
            this.buttonTransactionProductAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransactionProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTransactionProductAdd.UseVisualStyleBackColor = false;
            this.buttonTransactionProductAdd.Click += new System.EventHandler(this.buttonTransactionProductAdd_Click);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchProduct.ForeColor = System.Drawing.Color.White;
            this.buttonSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchProduct.Image")));
            this.buttonSearchProduct.Location = new System.Drawing.Point(294, 19);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(56, 35);
            this.buttonSearchProduct.TabIndex = 5;
            this.buttonSearchProduct.UseVisualStyleBackColor = false;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // buttonProductEditorReset
            // 
            this.buttonProductEditorReset.BackColor = System.Drawing.Color.White;
            this.buttonProductEditorReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProductEditorReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonProductEditorReset.Image")));
            this.buttonProductEditorReset.Location = new System.Drawing.Point(11, 184);
            this.buttonProductEditorReset.Name = "buttonProductEditorReset";
            this.buttonProductEditorReset.Size = new System.Drawing.Size(113, 52);
            this.buttonProductEditorReset.TabIndex = 9;
            this.buttonProductEditorReset.Text = "Reset";
            this.buttonProductEditorReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProductEditorReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProductEditorReset.UseVisualStyleBackColor = false;
            this.buttonProductEditorReset.Click += new System.EventHandler(this.buttonProductEditorReset_Click);
            // 
            // buttonProductEditorSave
            // 
            this.buttonProductEditorSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonProductEditorSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProductEditorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductEditorSave.ForeColor = System.Drawing.Color.White;
            this.buttonProductEditorSave.Image = global::SimplePOS.Properties.Resources.save;
            this.buttonProductEditorSave.Location = new System.Drawing.Point(130, 184);
            this.buttonProductEditorSave.Name = "buttonProductEditorSave";
            this.buttonProductEditorSave.Size = new System.Drawing.Size(220, 52);
            this.buttonProductEditorSave.TabIndex = 6;
            this.buttonProductEditorSave.Text = "Save";
            this.buttonProductEditorSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProductEditorSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProductEditorSave.UseVisualStyleBackColor = false;
            this.buttonProductEditorSave.Click += new System.EventHandler(this.buttonProductSave_Click);
            // 
            // buttonReportDelete
            // 
            this.buttonReportDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonReportDelete.Enabled = false;
            this.buttonReportDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReportDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportDelete.ForeColor = System.Drawing.Color.White;
            this.buttonReportDelete.Image = global::SimplePOS.Properties.Resources.trash;
            this.buttonReportDelete.Location = new System.Drawing.Point(428, 76);
            this.buttonReportDelete.Name = "buttonReportDelete";
            this.buttonReportDelete.Size = new System.Drawing.Size(147, 52);
            this.buttonReportDelete.TabIndex = 16;
            this.buttonReportDelete.Text = "Delete";
            this.buttonReportDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReportDelete.UseVisualStyleBackColor = false;
            this.buttonReportDelete.Click += new System.EventHandler(this.buttonReportDelete_Click);
            // 
            // buttonReportEdit
            // 
            this.buttonReportEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonReportEdit.Enabled = false;
            this.buttonReportEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReportEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportEdit.ForeColor = System.Drawing.Color.White;
            this.buttonReportEdit.Image = global::SimplePOS.Properties.Resources.edit;
            this.buttonReportEdit.Location = new System.Drawing.Point(428, 18);
            this.buttonReportEdit.Name = "buttonReportEdit";
            this.buttonReportEdit.Size = new System.Drawing.Size(147, 52);
            this.buttonReportEdit.TabIndex = 6;
            this.buttonReportEdit.Text = "Edit";
            this.buttonReportEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReportEdit.UseVisualStyleBackColor = false;
            this.buttonReportEdit.Click += new System.EventHandler(this.buttonReportEdit_Click);
            // 
            // buttonProductsRefresh
            // 
            this.buttonProductsRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProductsRefresh.Image = global::SimplePOS.Properties.Resources.refresh;
            this.buttonProductsRefresh.Location = new System.Drawing.Point(7, 511);
            this.buttonProductsRefresh.Name = "buttonProductsRefresh";
            this.buttonProductsRefresh.Size = new System.Drawing.Size(579, 52);
            this.buttonProductsRefresh.TabIndex = 20;
            this.buttonProductsRefresh.Text = "Refresh List";
            this.buttonProductsRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProductsRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProductsRefresh.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 749);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1043, 805);
            this.Name = "Form1";
            this.Text = "SimplePOS";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTransaction.ResumeLayout(false);
            this.groupBoxTransactionOverview.ResumeLayout(false);
            this.groupBoxTransactionOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).EndInit();
            this.groupBoxTransactionCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionProducts)).EndInit();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionProductId)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.groupBoxProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductEditorPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductEditorStock)).EndInit();
            this.tabPageReport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportTransactionProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportCash)).EndInit();
            this.groupBoxTransactionsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageTransaction;
        private System.Windows.Forms.GroupBox groupBoxProductsList;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonProductEditorSave;
        private System.Windows.Forms.Label labelProductStock;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductEditorName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownProductEditorPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownProductEditorStock;
        private System.Windows.Forms.GroupBox groupBoxTransactionCart;
        private System.Windows.Forms.DataGridView dataGridViewTransactionProducts;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.TextBox textBoxTransactionProductPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownTransactionProductId;
        private System.Windows.Forms.Button buttonTransactionProductAdd;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTransactionProductPrice;
        private System.Windows.Forms.Label labelTransactionProductId;
        private System.Windows.Forms.NumericUpDown numericUpDownTransactionProductQuantity;
        private System.Windows.Forms.TextBox textBoxTransactionProductStock;
        private System.Windows.Forms.Label labelTransactionProductStock;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox textBoxTransactionProductSubtotal;
        private System.Windows.Forms.Label labelTransactionProductSubtotal;
        private System.Windows.Forms.GroupBox groupBoxTransactionOverview;
        private System.Windows.Forms.TextBox textBoxTransactionChange;
        private System.Windows.Forms.Label labelTransactionCash;
        private System.Windows.Forms.NumericUpDown numericUpDownCash;
        private System.Windows.Forms.Button buttonTransactionCheckout;
        private System.Windows.Forms.Label labelTransactionChange;
        private System.Windows.Forms.Label labelTransactionTotal;
        private System.Windows.Forms.Label labelTransactionDate;
        private System.Windows.Forms.TextBox textBoxTransactionProductName;
        private System.Windows.Forms.Label labelTransactionProductName;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.TextBox textBoxTransactionTotal;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.Button buttonTransactionReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxTransactionsList;
        private System.Windows.Forms.DataGridView dataGridViewTransactionsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonReportDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportDate;
        private System.Windows.Forms.TextBox textBoxReportChange;
        private System.Windows.Forms.Label labelReportCash;
        private System.Windows.Forms.NumericUpDown numericUpDownReportCash;
        private System.Windows.Forms.TextBox textBoxReportTotal;
        private System.Windows.Forms.Button buttonReportEdit;
        private System.Windows.Forms.Label labelReportChange;
        private System.Windows.Forms.Label labelReportTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewReportTransactionProducts;
        private System.Windows.Forms.TextBox textBoxReportTransactionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReportRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewButtonColumn productEdit;
        private System.Windows.Forms.DataGridViewButtonColumn productDelete;
        private System.Windows.Forms.Button buttonProductEditorReset;
        private System.Windows.Forms.Label labelProductEditorId;
        private System.Windows.Forms.TextBox textBoxProductEditorId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonProductsRefresh;
    }
}

