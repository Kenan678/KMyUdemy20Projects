using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            int categoryCount = db.TblCategories.Count();
            lblCategoryCount.Text = categoryCount.ToString();


            int productCount = db.TblProducts.Count();
            lblProductCount.Text = productCount.ToString();

            int customerCount = db.TblCustomers.Count();
            lblCustomerCount.Text = customerCount.ToString();

            int orderCount = db.TblOrders.Count();
            lblOrderCount.Text = orderCount.ToString();

            var totalProductStockCount = db.TblProducts.Sum(x=>x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();

            var avarageProductPrice = db.TblProducts.Average(x => x.ProductPrice);
            lblProductAvaragePrice.Text = ((int)avarageProductPrice).ToString();

            var totalProductCountByCategoryIsFurit = db.TblProducts.Where(x=>x.CategoryId==1).Sum(y=>y.ProductStock);
            lblProductTotalFruitCount.Text=totalProductCountByCategoryIsFurit.ToString();


        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
