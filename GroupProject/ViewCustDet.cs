using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class ViewCustDet : Form
    { 

        EventCoordinator eCoord;
    public ViewCustDet()
        {
            InitializeComponent();
        }
        public ViewCustDet(EventCoordinator eCoordinator)
        {

            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(searchID.Text);
            nameLbl.Text = Convert.ToString(eCoord.getCustomerInfoById(id));
       
        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
