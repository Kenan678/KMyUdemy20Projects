using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomerr
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=AZLOTO_217\\SQLEXPRESS;initial catalog=DbCustomer;" +
     "integrated security=true");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerBalance," +
                "CustumerStatus,CityName  From TblCustomer\r\nInner Join TblCity on " +
                " TblCity.CityId=TblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "CityName";
            cmbCity.DataSource = dataTable;



        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert Into TblCustomer(CustomerName,CustomerSurname,CustomerCity,CustomerBalance," +
             "CustumerStatus) values(@customerName,@customerSurname,@customerCity,@customerBalance,@custumerStatus)", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurName", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@custumerStatus", true);
            }
            if (rdbPassiv.Checked)
            {
                command.Parameters.AddWithValue("@custumerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müştəri əlavə edildi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From tblCustomer Where CustomerId = @customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müştəri uğurla silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer Set " +
                "CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity,CustomerBalance=@customerBalance" +
                "," + "CustumerStatus=@custumerStatus where CustomerId=@customerId ", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurName", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@custumerStatus", true);
            }
            if (rdbPassiv.Checked)
            {
                command.Parameters.AddWithValue("@custumerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müştəri güncəlləndi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            SqlCommand command = new SqlCommand("Select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerBalance," +
                "CustumerStatus,CityName  From TblCustomer\r\nInner Join TblCity on " +
                " TblCity.CityId=TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}




