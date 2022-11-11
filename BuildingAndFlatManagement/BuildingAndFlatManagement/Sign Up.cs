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
    public partial class FormSign_Up : Form
    {
        public FormSign_Up()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=LogIn;Integrated Security=True");
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text )
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into LogIn (Username,Password) values('" + txtEmail.Text + "','" + txtPassword.Text + "')", sqlConnection);
                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (check > 0)
                {
                    MessageBox.Show("Sign Up Successfully. Now Log In");
                    this.Hide();
                    new Form1().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Password Not Match . Try Again");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
