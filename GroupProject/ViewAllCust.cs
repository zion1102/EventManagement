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
    public partial class ViewAllCust : Form
    {
        EventCoordinator eCoord;
        public ViewAllCust()
        {

            InitializeComponent();
        }

        public ViewAllCust(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();

        }

        private void custListLbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewAllCust_Load(object sender, EventArgs e)
        {

           
                custListLbl.Text = eCoord.customerList();
            
            
            
        }
    }
}
