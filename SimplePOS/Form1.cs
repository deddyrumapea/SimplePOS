using System;
using System.Data;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class Form1 : Form
    {
        private Product product;
        private Transaction transaction;

        public Form1()
        {
            InitializeComponent();

            this.product = new Product();
            this.transaction = new Transaction();

            InitializeProductTab();
            InitializeTransactionTab();
        }

        private void InitializeProductTab()
        {
            RefreshProductsList();
        }

        private bool IsProductEditorFormValid()
        {
            if (textBoxProductEditorName.Text == "")
            {
                MessageBox.Show("Insert a valid product name!");
                return false;
            }
            return true;
        }

        private void RefreshProductsList()
        {
            ResetProductEditor();
            dataGridViewProducts.Rows.Clear();
            DataTable dataTable = product.FindAll();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                dataGridViewProducts.Rows.Add();
                DataGridViewRow dataGridViewRow = dataGridViewProducts.Rows[i];

                dataGridViewRow.Cells[0].Value = Convert.ToInt32(dataRow["id"]);
                dataGridViewRow.Cells[1].Value = dataRow["name"].ToString();
                dataGridViewRow.Cells[2].Value = Convert.ToInt32(dataRow["price"]);
                dataGridViewRow.Cells[3].Value = Convert.ToInt32(dataRow["stock"]);
                dataGridViewRow.Cells[4].Value = "Edit";
                dataGridViewRow.Cells[5].Value = "Delete";
            }
        }

        private void ResetProductEditor()
        {
            textBoxProductEditorId.Text = product.GenerateFreshId().ToString();
            textBoxProductEditorName.Text = "";
            numericUpDownProductEditorPrice.Value = 0;
            numericUpDownProductEditorStock.Value = 0;
        }

        private void EditProduct(int id)
        {
            Product data = product.Find(id);
            textBoxProductEditorId.Text = data.id.ToString();
            textBoxProductEditorName.Text = data.name;
            numericUpDownProductEditorPrice.Value = data.price;
            numericUpDownProductEditorStock.Value = data.stock;
        }

        private void DeleteProduct(int id)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Delete product", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = product.Delete(id);
                RefreshProductsList();
                MessageBox.Show((result == "") ? "Product deleted successfully" : result);
            }
        }

        private void buttonProductSave_Click(object sender, EventArgs e)
        {
            if (!IsProductEditorFormValid()) return;

            int id = int.Parse(textBoxProductEditorId.Text);
            string name = textBoxProductEditorName.Text;
            int price = Convert.ToInt32(numericUpDownProductEditorStock.Value);
            int stock = Convert.ToInt32(numericUpDownProductEditorPrice.Value);

            string result;
            if (id == product.GenerateFreshId())
            {
                result = product.Insert(name, price, stock);
            }
            else
            {
                result = product.Update(id, name, price, stock);
            }

            RefreshProductsList();
            MessageBox.Show((result == "") ? "Product saved successfully" : result);

        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridView senderGrid = (DataGridView)sender;
            int id = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);

            switch (e.ColumnIndex)
            {
                case 4:
                    EditProduct(id);
                    break;
                case 5:
                    DeleteProduct(id);
                    break;
            }
        }

        private void InitializeTransactionTab()
        {
            RefreshTransactionsList();
            PopulateTransactionDetail();
        }

        private void ResetTransactionProductForms()
        {
            numericUpDownTransactionProductId.Value = 0;
            numericUpDownTransactionProductQuantity.Value = 1;
            textBoxTransactionProductName.Text = "";
            textBoxTransactionProductPrice.Text = "";
            textBoxTransactionProductStock.Text = "";
            textBoxTransactionProductSubtotal.Text = "";
        }

        private void RefreshTransactionSubtotal()
        {
            if (textBoxTransactionProductName.Text == "") return;
            int price = int.Parse(textBoxTransactionProductPrice.Text);
            int quantity = Convert.ToInt32(numericUpDownTransactionProductQuantity.Value);
            double subtotal = price * quantity;
            textBoxTransactionProductSubtotal.Text = subtotal.ToString();
        }

        private void RefreshTransactionTotal()
        {
            int total = 0;
            DataGridViewRowCollection rows = dataGridViewTransactionProducts.Rows;
            foreach (DataGridViewRow row in rows)
            {
                total += Convert.ToInt32(row.Cells["subtotal"].Value);
            }
            textBoxTransactionTotal.Text = total.ToString();
            RefreshTransactionChangeAmount();
        }

        private void RefreshTransactionChangeAmount()
        {
            int cash = Convert.ToInt32(numericUpDownCash.Value);
            int total = int.Parse(textBoxTransactionTotal.Text);
            int change = cash - total;
            textBoxTransactionChange.Text = change.ToString();
        }

        private void numericUpDownTransactionProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            RefreshTransactionSubtotal();
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDownTransactionProductId.Value);
            Product result = product.Find(id);
            if (result != null)
            {
                textBoxTransactionProductName.Text = result.name;
                textBoxTransactionProductPrice.Text = result.price.ToString();
                textBoxTransactionProductStock.Text = result.stock.ToString();
                numericUpDownTransactionProductQuantity.Maximum = result.stock;
                RefreshTransactionSubtotal();
            }
            else
            {
                MessageBox.Show($"We couldn't find any product with id '{id}'");
            }

        }

        private void buttonTransactionProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(numericUpDownTransactionProductId.Value);
                string name = textBoxTransactionProductName.Text;
                int price = int.Parse(textBoxTransactionProductPrice.Text);
                int quantity = Convert.ToInt32(numericUpDownTransactionProductQuantity.Value);
                if (quantity < 1) return;
                int subtotal = int.Parse(textBoxTransactionProductSubtotal.Text);

                dataGridViewTransactionProducts.Rows.Add(id, name, price, quantity, subtotal, "Remove");

                ResetTransactionProductForms();
                RefreshTransactionTotal();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void numericUpDownCash_ValueChanged(object sender, EventArgs e)
        {
            RefreshTransactionChangeAmount();
        }

        private void dataGridViewTransactionProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dataGridViewTransactionProducts.Rows.RemoveAt(e.RowIndex);
                RefreshTransactionTotal();
            }
        }

        private void buttonTransactionCheckout_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerTransactionDate.Value.ToString("yyyy-MM-dd");
            int total = int.Parse(textBoxTransactionTotal.Text);
            int cash = Convert.ToInt32(numericUpDownCash.Value);
            int change = int.Parse(textBoxTransactionChange.Text);
            int productsCount = dataGridViewTransactionProducts.Rows.Count;

            if (change < 0)
            {
                MessageBox.Show("The amount of cash is not sufficient to checkout the transaction");
                return;
            }
            else if (productsCount <= 0)
            {
                MessageBox.Show("You must at least add one product to the transaction");
                return;
            }

            string error = null;

            string transactionResult = transaction.Insert(date, total, cash, change);
            if (transactionResult != "") error = "Unable to save transaction data";

            int transactionId = transaction.LastInsertedId();
            if (transactionId == 0) error = "Unable to find transaction ID";

            if (error == null)
            {
                foreach (DataGridViewRow row in dataGridViewTransactionProducts.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells["id"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    string productResult = product.InsertToTransaction(transactionId, productId, quantity);
                    if (productResult != "") error = productResult;
                }
            }

            if (error == null)
            {
                ResetTransactionProductForms();
                ResetTransactionOverviewForms();
                MessageBox.Show("Transaction is successfully checked out");
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void ResetTransactionOverviewForms()
        {
            dateTimePickerTransactionDate.Value = DateTime.Now;
            textBoxTransactionTotal.Text = "0";
            textBoxTransactionChange.Text = "0";
            numericUpDownCash.Value = 0;
            dataGridViewTransactionProducts.Rows.Clear();
        }

        private void buttonTransactionReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard your changes?", "Cancel transaction", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ResetTransactionOverviewForms();
                ResetTransactionProductForms();
            }
        }

        private void RefreshTransactionsList()
        {
            dataGridViewTransactionsList.DataSource = transaction.FindAll();
        }

        private DataGridViewRow GetSelectedTransactionRow()
        {
            try
            {
                int index = dataGridViewTransactionsList.SelectedCells[0].RowIndex;
                return dataGridViewTransactionsList.Rows[index];
            }
            catch
            {
                return null;
            }
        }

        private void PopulateTransactionDetail()
        {
            if (GetSelectedTransactionRow() == null) return;
            DataGridViewRow row = GetSelectedTransactionRow();
            row.Selected = true;
            int id = Convert.ToInt32(row.Cells["id"].Value);
            Transaction data = transaction.Find(id);

            dateTimePickerReportDate.Value = DateTime.Parse(data.date);
            textBoxReportTransactionId.Text = data.id.ToString();
            textBoxReportTotal.Text = data.total.ToString();
            numericUpDownReportCash.Minimum = data.total;
            numericUpDownReportCash.Value = data.cash;
            textBoxReportChange.Text = data.change.ToString();
            buttonReportEdit.Enabled = true;
            buttonReportDelete.Enabled = true;

            dataGridViewReportTransactionProducts.DataSource = product.FindFromTransaction(id);
        }

        private void dataGridViewTransactionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateTransactionDetail();
        }

        private void buttonReportEdit_Click(object sender, EventArgs e)
        {
            bool isEditMode = buttonReportEdit.Text == "Edit";
            if (isEditMode)
            {
                buttonReportEdit.Text = "Save";
                dateTimePickerReportDate.Enabled = true;
                numericUpDownReportCash.Enabled = true;
            }
            else
            {
                int id = int.Parse(textBoxReportTransactionId.Text);
                string date = dateTimePickerReportDate.Value.ToString("yyyy-MM-dd");
                int total = int.Parse(textBoxReportTotal.Text);
                int cash = Convert.ToInt32(numericUpDownReportCash.Value);
                int change = int.Parse(textBoxReportChange.Text);

                string result = transaction.Update(new Transaction(id, date, total, cash, change));

                if (result == "")
                {
                    buttonReportEdit.Text = "Edit";
                    dateTimePickerReportDate.Enabled = false;
                    numericUpDownReportCash.Enabled = false;
                    MessageBox.Show("Transaction is successfully updated");
                }
                else
                {
                    MessageBox.Show(result);
                }

            }
        }

        private void numericUpDownReportCash_ValueChanged(object sender, EventArgs e)
        {
            int total = int.Parse(textBoxReportTotal.Text);
            int cash = Convert.ToInt32(numericUpDownReportCash.Value);
            textBoxReportChange.Text = (cash - total).ToString();
        }

        private void buttonReportRefresh_Click(object sender, EventArgs e)
        {
            RefreshTransactionsList();
        }

        private void buttonReportDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete transaction", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                int id = int.Parse(textBoxReportTransactionId.Text);
                string result = transaction.Delete(id);
                RefreshTransactionsList();
                MessageBox.Show((result == "") ? "Transaction deleted successfully" : result);
            }
        }

        private void buttonProductEditorReset_Click(object sender, EventArgs e)
        {
            ResetProductEditor();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string about =
                "SimplePOS v0.9 Beta" +
                "\nCreated by Deddy Romnan Rumapea" +
                "\nIcon made by iconixar from www.flaticon.com";
            MessageBox.Show(about);
        }
    }
}
