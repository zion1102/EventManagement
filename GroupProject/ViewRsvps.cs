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
    public partial class ViewRsvps : Form
    {
        EventCoordinator eCoord;
        public ViewRsvps()
        {
            InitializeComponent();
        }
        public ViewRsvps(EventCoordinator eCoordinator)
        {

            InitializeComponent();
            eCoord = eCoordinator;
        }

        private void viewRsvps_Load(object sender, EventArgs e)
        {
           rsvpListLbl.Text= eCoord.getRsvpInfo();
        }
    }
}
