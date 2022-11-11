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
    public partial class FormFlatSold : Form
    {
        public FormFlatSold()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=FlatSoldDB;Integrated Security=True");
        private void btnTInsert_Click(object sender, EventArgs e)
        {
           
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into FlatSold  (Name,Phone,Email,Address,Gender,Block) values('" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtGender.Text + "','" + txtBlock.Text + "')", sqlConnection);

                FS fs = new FS();
                fs.name = txtName.Text;
                fs.phone = txtPhone.Text;
                fs.email = txtEmail.Text;
                fs.address = txtAddress.Text;
                fs.gender = txtGender.Text;
                fs.block = txtBlock.Text;



                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (check >0)
                {
                    MessageBox.Show("Inserted successfully");
                }
            
            

        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
           
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from FlatSold where Phone='" + txtBlock.Text + "'", sqlConnection);
                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (check > 0)
                {
                    MessageBox.Show("Deleted successfully");
                }
            
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update FlatSold set Name ='" + txtName.Text + "' where Phone='" + txtPhone.Text +  "'", sqlConnection);
            //SqlCommand sqlCommand = new SqlCommand("Update FlatSold set Name ='" + txtName.Text + "where Phone='" + txtPhone.Text + "' set Email='" + txtEmail.Text + "set Address='"+txtAddress.Text +"set Gender'"+txtGender.Text+"set Block='"+txtBlock.Text+"'", sqlConnection);

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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from FlatSold", sqlConnection);
                
               
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DataGridViewFlatSold.DataSource = dataTable;
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
