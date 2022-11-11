using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingAndFlatManagement
{
    public partial class FormDASHBOARD : Form
    {
        public FormDASHBOARD()
        {
            InitializeComponent();
        }

        private void btnBOwner_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBuildingOwner().Show();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTenant().Show();
        }

        private void btnFSold_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFlatSold().Show();
        }

        private void btnFDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBuildingDetails().Show();
        }

        //private void btnEarning_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new FormEARNING_FROM_BUILDING().Show();
        //}
    }
}
