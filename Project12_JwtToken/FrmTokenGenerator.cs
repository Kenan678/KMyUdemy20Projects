using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmTokenGenerator : Form
    {
        public FrmTokenGenerator()
        {
            InitializeComponent();
            btnCreateToken.MouseEnter += new EventHandler(btnLogin_MouseEnter);
            btnCreateToken.MouseLeave += new EventHandler(btnLogin_MouseLeave);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnCreateToken.BackColor = Color.Red;

        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnCreateToken.BackColor = Color.White; 
        }

        private void FrmTokenGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
