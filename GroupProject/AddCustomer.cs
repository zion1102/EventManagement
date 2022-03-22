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
    public partial class AddCustomer : Form
    {
        EventCoordinator eCoord;

        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBox.Text;
            string age = ageTxtBox.Text;
            string id = IdTxtBox.Text;
            

            if(eCoord.addCustomer(name, age, id) == true)
            {
                string message = "The customer was added";
                MessageBox.Show(message);
                this.CleartextBoxes();
            }
            else
            {
                string message = "The database cant hold anymore customers";
                MessageBox.Show(message);
            }

        }
        public void CleartextBoxes()

        {

            foreach (Control Cleartext in this.Controls)

            {

                if (Cleartext is TextBox)

                {

                    ((TextBox)Cleartext).Text = string.Empty;

                }

            }

        }
    }
}
