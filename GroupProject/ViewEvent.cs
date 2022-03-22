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
    public partial class ViewEvent : Form
    {
        EventCoordinator eCoord;
        public ViewEvent()
        {
            InitializeComponent();
        }

        public ViewEvent(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eventIdTxt.Text);
            viewLbl.Text = eCoord.getEventInfoById(id);
        }
    }
}
