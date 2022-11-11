using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuildingAndFlatManagement
{
    public partial class FormTenant : Form
    {
        public FormTenant()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=Tenant;Integrated Security=True");
        private void btnTInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Tenant (Name,Phone,Email,Address,Gender,Rent,Block) values ('" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtGender.Text + "','"+txtRent.Text + "','" + txtBlock.Text + "')", sqlConnection);
            TenantClass tenantClass = new TenantClass();
            tenantClass.name = txtName.Text;
            tenantClass.phone = txtPhone.Text;
            tenantClass.email= txtEmail.Text;
            tenantClass.address= txtAddress.Text;
            tenantClass.gender= txtGender.Text;
            tenantClass.Rent = int.Parse(txtRent.Text);

            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Inserted successfully");
            }

        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Tenant set Name ='" + txtName.Text + "' where Block='" + txtBlock.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
        }

        private void btnTShow_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Tenant", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            ShowOwnerDetails.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Tenant where Block='" + txtBlock.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }

        private void btnTBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDASHBOARD().Show();

        }

        private void btnTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
