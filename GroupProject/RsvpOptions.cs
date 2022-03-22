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
	public partial class RsvpOptions : Form
	{

		EventCoordinator eCoord;
		public RsvpOptions()
		{
			InitializeComponent();
		}

		public RsvpOptions(EventCoordinator eCoordinator)
		{
			eCoord = eCoordinator;
			InitializeComponent();
		}

        private void rsvpOptions_Load(object sender, EventArgs e)
        {
			
        }

        private void addRsvpBtn_Click(object sender, EventArgs e)
        {
			AddRsvp addR = new AddRsvp(eCoord);
			addR.ShowDialog();
        }

        private void viewRsvpBtn_Click(object sender, EventArgs e)
        {
			ViewRsvps viewR = new ViewRsvps(eCoord);
			viewR.ShowDialog();
		}
    }
}
