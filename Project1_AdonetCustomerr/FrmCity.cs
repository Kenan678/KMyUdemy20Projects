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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=AZLOTO_217\\SQLEXPRESS;initial catalog=DbCustomer;" +
     "integrated security=true");

        private void btnList_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCity (CityName,CityCountry) values" +
                "(@cityName,@cityCountry) ", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.ExecuteNonQuery();  // like SaveChanges 
            sqlConnection.Close();
            MessageBox.Show("Şəhər uğurla əlavə  edildi");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From tblCity Where CityId = @cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityİd.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şəhər uğurla silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCity Set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.Parameters.AddWithValue("@cityId", txtCityİd.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şəhər uğurla güncəlləndi ", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCity Where CityName=@cityName", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();



        }
    }
}
