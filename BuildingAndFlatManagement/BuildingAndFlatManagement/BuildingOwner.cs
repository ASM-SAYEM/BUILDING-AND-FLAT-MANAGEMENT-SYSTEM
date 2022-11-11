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
    public partial class FormBuildingOwner : Form
    {
        public FormBuildingOwner()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDASHBOARD().ShowDialog();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=BuildingOwner;Integrated Security=True");
        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into BuuildingOwner(SN,Name,Phone,Email,Address,Geender) values ('" + txtSN.Text+ "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtGender.Text + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Inserted successfully");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update BuuildingOwner set Name='" + txtName + "'where SN='" + txtSN.Text + "'", sqlConnection);

            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("delete from BuuildingOwner where SN='" + txtSN.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from BuuildingOwner", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            ShowOwnerDetails.DataSource = dataTable;
            sqlConnection.Close();

        }
    }
}
