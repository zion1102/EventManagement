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
    public partial class CustomerOptions : Form
    {
        EventCoordinator eCoord;
        public CustomerOptions()
        {
            InitializeComponent();
        }
        public CustomerOptions(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void customerOptions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer(eCoord);

            addCust.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllCust viewAll = new ViewAllCust(eCoord);
            viewAll.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustDet viewCust = new ViewCustDet(eCoord);
            viewCust.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCust delCust = new DeleteCust(eCoord);
            delCust.ShowDialog();
        }
    }
}
