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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(@"Data Source=PERSONAL\SQLEXPRESS;Initial Catalog=LogIn;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from LogIn where username=@username and Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Username", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                FormDASHBOARD formDASHBOARD = new FormDASHBOARD();
                this.Hide();
                formDASHBOARD.Show();
                //formDASHBOARD.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Paasword or User Name");
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormSign_Up().Show();

        }
    }
}

       
