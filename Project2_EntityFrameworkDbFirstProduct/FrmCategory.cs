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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        Db2Project20Entities db = new Db2Project20Entities();

        void CategoryList()
        {
            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;  
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList(); 
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TblCategory tblCategory = new TblCategory();    
            tblCategory.CategoryName=txtCategoryName.Text;  
            db.TblCategories.Add(tblCategory);  
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             int id = Convert.ToInt32(txtCategorId.Text);
            var value = db.TblCategories.Find(id);
            db.TblCategories.Remove(value); 
            db.SaveChanges();
            CategoryList(); 

        }

        private void textCategorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategorId.Text);
            var value = db.TblCategories.Find(id);
            value.CategoryName = txtCategoryName.Text;
            db.SaveChanges();
            CategoryList();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategorId.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
