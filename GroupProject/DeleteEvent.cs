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
    public partial class DeleteEvent : Form
    {
        EventCoordinator eCoord;
        public DeleteEvent()
        {
            InitializeComponent();
        }

        public DeleteEvent(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void custIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(eventIdTxt.Text);

            eCoord.deleteEvent(id);
        }
    }
}
