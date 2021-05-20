using System;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProductSubmit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            string name = textBoxProductName.Text;
            int price = int.Parse(textBoxProductPrice.Text);
            int stock = int.Parse(textBoxProductStock.Text);
            string result = product.Insert(name, price, stock);
            MessageBox.Show((result == "") ? "Product saved successfully" : result);
        }

        private void buttonProductsListRefresh_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            dataGridViewProducts.DataSource = product.FindAll();
        }
    }
}
