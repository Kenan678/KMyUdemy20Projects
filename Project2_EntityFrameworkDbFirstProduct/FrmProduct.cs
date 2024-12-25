using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = db.TblProducts.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProducts.Find(int.Parse(txtProductId.Text));
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProducts.Find(int.Parse(txtProductId.Text));
            db.TblProducts.Remove(value);
            db.SaveChanges();
            ProductList();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductPrice = decimal.Parse(txtProductPrice.Text);
            tblProduct.ProductName = txtProductName.Text;
            tblProduct.ProductStock = int.Parse(txtProductStock.Text);
            tblProduct.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.TblProducts.Add(tblProduct);
            db.SaveChanges();
            ProductList();


        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCategorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Db2Project20Entities db = new Db2Project20Entities();
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProducts.ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategories.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.TblProducts.
                Join(db.TblCategories,
                product=>product.CategoryId,
                category => category.CategoryId,
                (product,category)=>new
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    ProductStock = product.ProductStock,
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,


                }  )
                .ToList();
            dataGridView1 .DataSource = values;

           ig
        }
    }
}
