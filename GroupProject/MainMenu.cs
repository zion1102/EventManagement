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
    public partial class MainMenu : Form
    {
        EventCoordinator eCoord;
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(EventCoordinator eCoordinator)
        {

            eCoord = eCoordinator;
            InitializeComponent();
        }


        private void customerOptionsToolStripMenuItem1_DoubleClick(object sender, EventArgs e)
        {


           

           
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventOptionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rSVPToEventToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer custAdd = new AddCustomer(eCoord);
            custAdd.ShowDialog();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllCust viewCust = new ViewAllCust(eCoord);
            viewCust.ShowDialog();
        }

        private void viewCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustDet custDet = new ViewCustDet(eCoord);
            custDet.ShowDialog();
                
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCust custDel = new DeleteCust(eCoord);
            custDel.ShowDialog();
        }

        private void customerOptionsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerOptions custOpt = new CustomerOptions(eCoord);

            custOpt.ShowDialog();
        }

        private void customerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOptions custOpt = new CustomerOptions(eCoord);

            custOpt.ShowDialog();
        }

        private void eventOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventOptions eventOpt = new EventOptions(eCoord);
            eventOpt.ShowDialog();
                

        }

		private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
            RsvpOptions rsvpOpt = new RsvpOptions(eCoord);
            rsvpOpt.ShowDialog();
		}

        private void eventOptionsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EventOptions eventOpt = new EventOptions(eCoord);
            eventOpt.ShowDialog();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent addE = new AddEvent(eCoord);
            addE.Show();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllEvents viewEs = new ViewAllEvents(eCoord);
            viewEs.ShowDialog();
        }

        private void viewEventDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEvent viewE = new ViewEvent(eCoord);
            viewE.ShowDialog();
        }

        private void addRSVPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRsvp addR = new AddRsvp(eCoord);
            addR.ShowDialog();
        }

        private void viewRSVPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRsvps viewR = new ViewRsvps(eCoord);
            viewR.ShowDialog();
        }

        private void custOptBtn_Click(object sender, EventArgs e)
        {
            CustomerOptions custOpt = new CustomerOptions(eCoord);

            custOpt.ShowDialog();
        }

        private void eventOptBtn_Click(object sender, EventArgs e)
        {
            EventOptions eventOpt = new EventOptions(eCoord);
            eventOpt.ShowDialog();
        }

        private void rsvpOptBtn_Click(object sender, EventArgs e)
        {
            RsvpOptions rsvpOpt = new RsvpOptions(eCoord);
            rsvpOpt.ShowDialog();
        }

        private void rSVPOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RsvpOptions rsvpOpt = new RsvpOptions(eCoord);
            rsvpOpt.ShowDialog();
        }
    }
}
