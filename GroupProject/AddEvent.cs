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
    public partial class AddEvent : Form
    {

        EventCoordinator eCoord;
        
        public AddEvent()
        {
            InitializeComponent();
        }

        public AddEvent(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string venue = venueTxt.Text;
            int maxAtt = Convert.ToInt32(maxTxt.Text);
            int day = Convert.ToInt32(dayTxt.Text);
            int month = Convert.ToInt32(monthTxt.Text);
            int year = Convert.ToInt32(yearTxt.Text);
            int hour = Convert.ToInt32(hourTxt.Text);
            int minute = Convert.ToInt32(minuteTxt.Text);

            Date eventDate = new Date(day, month, year, hour, minute);
            if (eCoord.addEvent(name, venue,eventDate , maxAtt) == true)
            {
                string message = "The event was added";
                MessageBox.Show(message);
                this.CleartextBoxes();
            }
            else
            {
                string message = "There is already an event in that location at that time";
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

       
    

