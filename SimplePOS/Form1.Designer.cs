
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.groupBoxProductsList = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonProductSubmit = new System.Windows.Forms.Button();
            this.labelProductStock = new System.Windows.Forms.Label();
            this.textBoxProductStock = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonProductsListRefresh = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.groupBoxProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProducts);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1131, 535);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.groupBoxProductsList);
            this.tabPageProducts.Controls.Add(this.groupBox1);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1123, 502);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductsList
            // 
            this.groupBoxProductsList.Controls.Add(this.buttonProductsListRefresh);
            this.groupBoxProductsList.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProductsList.Location = new System.Drawing.Point(387, 6);
            this.groupBoxProductsList.Name = "groupBoxProductsList";
            this.groupBoxProductsList.Size = new System.Drawing.Size(730, 490);
            this.groupBoxProductsList.TabIndex = 2;
            this.groupBoxProductsList.TabStop = false;
            this.groupBoxProductsList.Text = "List";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(7, 77);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(717, 407);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonProductSubmit);
            this.groupBox1.Controls.Add(this.labelProductStock);
            this.groupBox1.Controls.Add(this.textBoxProductStock);
            this.groupBox1.Controls.Add(this.labelProductPrice);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor";
            // 
            // buttonProductSubmit
            // 
            this.buttonProductSubmit.Location = new System.Drawing.Point(6, 182);
            this.buttonProductSubmit.Name = "buttonProductSubmit";
            this.buttonProductSubmit.Size = new System.Drawing.Size(363, 52);
            this.buttonProductSubmit.TabIndex = 6;
            this.buttonProductSubmit.Text = "Save";
            this.buttonProductSubmit.UseVisualStyleBackColor = true;
            this.buttonProductSubmit.Click += new System.EventHandler(this.buttonProductSubmit_Click);
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
            // textBoxProductStock
            // 
            this.textBoxProductStock.Location = new System.Drawing.Point(130, 126);
            this.textBoxProductStock.Name = "textBoxProductStock";
            this.textBoxProductStock.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductStock.TabIndex = 4;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(7, 77);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(44, 20);
            this.labelProductPrice.TabIndex = 3;
            this.labelProductPrice.Text = "Price";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(130, 74);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductPrice.TabIndex = 2;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(7, 26);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(51, 20);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(130, 23);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonProductsListRefresh
            // 
            this.buttonProductsListRefresh.Location = new System.Drawing.Point(605, 22);
            this.buttonProductsListRefresh.Name = "buttonProductsListRefresh";
            this.buttonProductsListRefresh.Size = new System.Drawing.Size(119, 49);
            this.buttonProductsListRefresh.TabIndex = 1;
            this.buttonProductsListRefresh.Text = "Refresh";
            this.buttonProductsListRefresh.UseVisualStyleBackColor = true;
            this.buttonProductsListRefresh.Click += new System.EventHandler(this.buttonProductsListRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 559);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.groupBoxProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxProductsList;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonProductSubmit;
        private System.Windows.Forms.Label labelProductStock;
        private System.Windows.Forms.TextBox textBoxProductStock;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonProductsListRefresh;
    }
}

