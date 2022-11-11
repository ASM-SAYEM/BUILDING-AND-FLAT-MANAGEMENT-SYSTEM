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
    public partial class FormBuildingDetails : Form
    {
        public FormBuildingDetails()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=BuildingDetailsDB;Integrated Security=True");
        private void btnTInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
    
            SqlCommand sqlCommand = new SqlCommand("Insert into BuildingDetailsDB  (BuildingName,Place,TotalFloor,TotalArea,BuildingAzimuthOrientation,BuildingNumber) values('" + txtBuildingName.Text + "','" + txtPlace.Text + "','" + txtTotalFloor.Text + "','" + txtTotalArea.Text + "','" + txtBAO.Text + "','" + txtBuildingNumber.Text + "')", sqlConnection);

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
            SqlCommand sqlCommand = new SqlCommand("Update into BuildingDetailsDB set BuildingName='" + txtBuildingName+ "'where BuildingNumber='" + txtBuildingNumber.Text  + "')", sqlConnection);

            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
         //   SqlCommand sqlCommand = new SqlCommand("Delete from BuildingDetailsDB where BuildingNumber='" + txtBuildingNumber  + "'", sqlConnection);
            SqlCommand sqlCommand=new SqlCommand("delete from BuildingDetailsDB where BuildingNumber='" + txtBuildingNumber.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }

        private void btnTShow_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from BuildingDetailsDB", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DataGridViewBuildingDetails.DataSource = dataTable;
            sqlConnection.Close();
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
