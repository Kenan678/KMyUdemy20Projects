using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

            var totalProductStockCount = db.TblProducts.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();

            var avarageProductPrice = db.TblProducts.Average(x => x.ProductPrice);
            lblProductAvaragePrice.Text = ((int)avarageProductPrice).ToString();

            var totalProductCountByCategoryIsFurit = db.TblProducts.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lblProductTotalFruitCount.Text = totalProductCountByCategoryIsFurit.ToString();
            //sprite umumi
            var totalStockBySprite = db.TblProducts.Where(x => x.ProductName == "Sprite").Select(y => y.ProductStock).FirstOrDefault();
            var totalPriceSprite = db.TblProducts.Where(x => x.ProductName == "Sprite").Select(y => y.ProductPrice).FirstOrDefault();
            var totalPriceBySpriteforTotalStock = totalStockBySprite * totalPriceSprite;
            lblTotalPriceBySprite.Text = totalPriceBySpriteforTotalStock.ToString();
            //product stock <100
            var productStocksmaller100 = db.TblProducts.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmaller100.Text = productStocksmaller100.ToString();

            // kategoro goy ve status true
            var productGoyAndStausTrue = db.TblProducts.Where(x => x.CategoryId == 2 &&
            x.ProductStatus == true).Sum(y => y.ProductStock);
            lblgoy.Text = productGoyAndStausTrue.ToString();
            //Azerbeycannan edilen sifarisler

            var customerId = db.Database.SqlQuery<int>("select count(*) from TblOrder where CustomerId in\r\n(select CustomerID " +
               "from TblCustomer where CustomerCountry='Azerbaycan')").FirstOrDefault();

            lblOrderCountFromTurkey.Text = customerId.ToString();
            //Turkiyeden edilen sifarisler
            var Customer2Id = db.TblCustomers.Where(x => x.CustomerCountry == "Turkiye").Select(y => y.CustomerID).ToList();
            var orderCountfromTurkey = db.TblOrders.Count(z => Customer2Id.Contains(z.CustomerId.Value));
            lblOrderByTurkey.Text = orderCountfromTurkey.ToString();
            //Meyvelerden elde edilen gelir

            var allFruitPrice = db.TblCategories
                .Where(x => x.CategoryName == "Meyve")
                .Select(y => y.CategoryId)
                .ToList();

            var fruitProducts = db.TblProducts
                .Where(x => x.CategoryId.HasValue && allFruitPrice.Contains(x.CategoryId.Value))
                .ToList();

            var fruitProductIds = fruitProducts.Select(x => x.ProductId).ToList();

            var totalFruitRevenue = db.TblOrders
                .Where(order => order.ProductId.HasValue && fruitProductIds.Contains(order.ProductId.Value))
                .Sum(order => (order.Count ?? 0) * (order.UnitPrice ?? 0));
            var fruitProductNames = string.Join(", ", fruitProducts.Select(p => p.ProductName));

            lblAllFruitPrice.Text = $"{totalFruitRevenue.ToString("C")}";


            //en son elave olunan product

            var lastProductName = db.TblProducts.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
            lblEndOfProduct.Text = lastProductName.ToString();

            // Id si 5 olan  product
            var IDis5Product = db.TblProducts.Where(x => x.ProductId == 5).Select(y => y.ProductName).FirstOrDefault();
            lblIdEqual5.Text = IDis5Product.ToString();


            // ilk elave olunanin kategoriyasi
            var firstProductCategoryId = db.TblProducts.OrderBy(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var firstProductCategoryName = db.TblCategories.Where(z => z.CategoryId == firstProductCategoryId).Select(d => d.CategoryName).FirstOrDefault();
            lblFirstProductCategoryName.Text = firstProductCategoryName.ToString();

            // Aktiv Product sayi
            var activeProductCount = db.TblProducts.Where(x => x.ProductStatus == true).Count();
            lblAcitveProductCount.Text = activeProductCount.ToString();

            //Stockdaki kola  amountu
            var totalColaStockAmount = db.TblProducts.Where(x => x.ProductName == "Kola").Select(z => z.ProductPrice * z.ProductStock).Sum();
            lblTotalPriceWithStockCola.Text = totalColaStockAmount.ToString();
            //son  sifaris veren musteri adi
            var lastCustomerId = db.TblOrders.OrderByDescending(x => x.CustomerId).Select(z => z.CustomerId).FirstOrDefault();
            var lastOrderCustomerName = db.TblCustomers.Where(x => x.CustomerID == lastCustomerId).Select(z => z.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastOrderCustomerName.ToString();
            //nece ferqli olkeden musteri var
            var countryDiffrenetCount = db.TblCustomers.Select(x => x.CustomerCountry).Distinct().Count();
            lblCountryDiffrenetCount.Text = countryDiffrenetCount.ToString();
             

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

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void lblAllFruitPrice_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
