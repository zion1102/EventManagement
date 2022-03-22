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
    public partial class AddRsvp : Form
    {
        EventCoordinator eCoord;
        public AddRsvp()
        {
            InitializeComponent();
        }
        public AddRsvp(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void addRsvp_Load(object sender, EventArgs e)
        {
            customerListLbl.Text = eCoord.customerList();
            eventListLbl.Text = eCoord.eventList();
        }

        private void addRsvpBtn_Click(object sender, EventArgs e)
        {
            int cusID = Convert.ToInt32(custemrIdTxt.Text);
            int eventId = Convert.ToInt32(eventIdTxt.Text);

            if(eCoord.addRsvp(cusID, eventId) == true)
            {
                string message = "The RSVP was added.";
                MessageBox.Show(message);
                this.CleartextBoxes();
            }
            else
            {
                string message = "The RSVP already exist.";
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
