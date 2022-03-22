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
    public partial class EventOptions : Form
    {
        EventCoordinator eCoord;
        public EventOptions()
        {
            InitializeComponent();
        }
        public EventOptions(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            AddEvent addE = new AddEvent(eCoord);
            addE.ShowDialog();
        }

        private void viewEventsBtn_Click(object sender, EventArgs e)
        {
            ViewAllEvents vEvents = new ViewAllEvents(eCoord);
            vEvents.ShowDialog();
        }

        private void eventDetailsBtn_Click(object sender, EventArgs e)
        {
            ViewEvent vEvent = new ViewEvent(eCoord);
            vEvent.ShowDialog();

        }

        private void deleteEventBtn_Click(object sender, EventArgs e)
        {
            DeleteEvent delE = new DeleteEvent(eCoord);
            delE.ShowDialog();
        }

       
    }
}
