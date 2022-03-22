﻿using System;
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
    public partial class ViewAllEvents : Form
    {

        EventCoordinator eCoord;
        public ViewAllEvents()
        {
            InitializeComponent();
        }
        public ViewAllEvents(EventCoordinator eCoordinator)
        {
            eCoord = eCoordinator;
            InitializeComponent();
        }

        private void viewAllEvents_Load(object sender, EventArgs e)
        {
            customerListLbl.Text = eCoord.eventList();
        }
    }
}
