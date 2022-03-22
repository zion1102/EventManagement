
namespace GroupProject
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSVPToEventToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rSVPOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custOptBtn = new System.Windows.Forms.Button();
            this.eventOptBtn = new System.Windows.Forms.Button();
            this.rsvpOptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.customerOptionsToolStripMenuItem1,
            this.eventOptionsToolStripMenuItem1,
            this.rSVPToEventToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.navigationToolStripMenuItem.Text = "Main Menu";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.mainMenuToolStripMenuItem.Text = "RSVP to event ";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // customerOptionsToolStripMenuItem
            // 
            this.customerOptionsToolStripMenuItem.Name = "customerOptionsToolStripMenuItem";
            this.customerOptionsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.customerOptionsToolStripMenuItem.Text = "Customer options";
            this.customerOptionsToolStripMenuItem.Click += new System.EventHandler(this.customerOptionsToolStripMenuItem_Click);
            // 
            // eventOptionsToolStripMenuItem
            // 
            this.eventOptionsToolStripMenuItem.Name = "eventOptionsToolStripMenuItem";
            this.eventOptionsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.eventOptionsToolStripMenuItem.Text = "Event options";
            this.eventOptionsToolStripMenuItem.Click += new System.EventHandler(this.eventOptionsToolStripMenuItem_Click);
            // 
            // customerOptionsToolStripMenuItem1
            // 
            this.customerOptionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOptionsToolStripMenuItem2,
            this.addCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem,
            this.viewCustomerDetailsToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.customerOptionsToolStripMenuItem1.Name = "customerOptionsToolStripMenuItem1";
            this.customerOptionsToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.customerOptionsToolStripMenuItem1.Text = "Customer Options";
            this.customerOptionsToolStripMenuItem1.DoubleClick += new System.EventHandler(this.customerOptionsToolStripMenuItem1_DoubleClick);
            // 
            // customerOptionsToolStripMenuItem2
            // 
            this.customerOptionsToolStripMenuItem2.Name = "customerOptionsToolStripMenuItem2";
            this.customerOptionsToolStripMenuItem2.Size = new System.Drawing.Size(241, 26);
            this.customerOptionsToolStripMenuItem2.Text = "Customer Options";
            this.customerOptionsToolStripMenuItem2.Click += new System.EventHandler(this.customerOptionsToolStripMenuItem2_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // viewCustomerDetailsToolStripMenuItem
            // 
            this.viewCustomerDetailsToolStripMenuItem.Name = "viewCustomerDetailsToolStripMenuItem";
            this.viewCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.viewCustomerDetailsToolStripMenuItem.Text = "View Customer Details";
            this.viewCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerDetailsToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // eventOptionsToolStripMenuItem1
            // 
            this.eventOptionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventOptionsToolStripMenuItem2,
            this.addEventToolStripMenuItem,
            this.viewEventsToolStripMenuItem,
            this.viewEventDetailsToolStripMenuItem});
            this.eventOptionsToolStripMenuItem1.Name = "eventOptionsToolStripMenuItem1";
            this.eventOptionsToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.eventOptionsToolStripMenuItem1.Text = "Event Options";
            this.eventOptionsToolStripMenuItem1.Click += new System.EventHandler(this.eventOptionsToolStripMenuItem1_Click);
            // 
            // eventOptionsToolStripMenuItem2
            // 
            this.eventOptionsToolStripMenuItem2.Name = "eventOptionsToolStripMenuItem2";
            this.eventOptionsToolStripMenuItem2.Size = new System.Drawing.Size(214, 26);
            this.eventOptionsToolStripMenuItem2.Text = "Event Options";
            this.eventOptionsToolStripMenuItem2.Click += new System.EventHandler(this.eventOptionsToolStripMenuItem2_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // viewEventsToolStripMenuItem
            // 
            this.viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            this.viewEventsToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.viewEventsToolStripMenuItem.Text = "View Events";
            this.viewEventsToolStripMenuItem.Click += new System.EventHandler(this.viewEventsToolStripMenuItem_Click);
            // 
            // viewEventDetailsToolStripMenuItem
            // 
            this.viewEventDetailsToolStripMenuItem.Name = "viewEventDetailsToolStripMenuItem";
            this.viewEventDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.viewEventDetailsToolStripMenuItem.Text = "View Event Details";
            this.viewEventDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewEventDetailsToolStripMenuItem_Click);
            // 
            // rSVPToEventToolStripMenuItem1
            // 
            this.rSVPToEventToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSVPOptionsToolStripMenuItem,
            this.addRSVPToolStripMenuItem,
            this.viewRSVPToolStripMenuItem});
            this.rSVPToEventToolStripMenuItem1.Name = "rSVPToEventToolStripMenuItem1";
            this.rSVPToEventToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.rSVPToEventToolStripMenuItem1.Text = "RSVP to Event ";
            this.rSVPToEventToolStripMenuItem1.Click += new System.EventHandler(this.rSVPToEventToolStripMenuItem1_Click);
            // 
            // rSVPOptionsToolStripMenuItem
            // 
            this.rSVPOptionsToolStripMenuItem.Name = "rSVPOptionsToolStripMenuItem";
            this.rSVPOptionsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.rSVPOptionsToolStripMenuItem.Text = "RSVP Options";
            this.rSVPOptionsToolStripMenuItem.Click += new System.EventHandler(this.rSVPOptionsToolStripMenuItem_Click);
            // 
            // addRSVPToolStripMenuItem
            // 
            this.addRSVPToolStripMenuItem.Name = "addRSVPToolStripMenuItem";
            this.addRSVPToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.addRSVPToolStripMenuItem.Text = "Add RSVP";
            this.addRSVPToolStripMenuItem.Click += new System.EventHandler(this.addRSVPToolStripMenuItem_Click);
            // 
            // viewRSVPToolStripMenuItem
            // 
            this.viewRSVPToolStripMenuItem.Name = "viewRSVPToolStripMenuItem";
            this.viewRSVPToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.viewRSVPToolStripMenuItem.Text = "View RSVP";
            this.viewRSVPToolStripMenuItem.Click += new System.EventHandler(this.viewRSVPToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(17, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use the menu bar at the top or the buttons below to navigate :";
            // 
            // custOptBtn
            // 
            this.custOptBtn.Location = new System.Drawing.Point(21, 206);
            this.custOptBtn.Name = "custOptBtn";
            this.custOptBtn.Size = new System.Drawing.Size(184, 34);
            this.custOptBtn.TabIndex = 4;
            this.custOptBtn.Text = "Customer Options";
            this.custOptBtn.UseVisualStyleBackColor = true;
            this.custOptBtn.Click += new System.EventHandler(this.custOptBtn_Click);
            // 
            // eventOptBtn
            // 
            this.eventOptBtn.Location = new System.Drawing.Point(21, 269);
            this.eventOptBtn.Name = "eventOptBtn";
            this.eventOptBtn.Size = new System.Drawing.Size(184, 34);
            this.eventOptBtn.TabIndex = 5;
            this.eventOptBtn.Text = "Event Options";
            this.eventOptBtn.UseVisualStyleBackColor = true;
            this.eventOptBtn.Click += new System.EventHandler(this.eventOptBtn_Click);
            // 
            // rsvpOptBtn
            // 
            this.rsvpOptBtn.Location = new System.Drawing.Point(21, 333);
            this.rsvpOptBtn.Name = "rsvpOptBtn";
            this.rsvpOptBtn.Size = new System.Drawing.Size(184, 34);
            this.rsvpOptBtn.TabIndex = 6;
            this.rsvpOptBtn.Text = "RSVP to event";
            this.rsvpOptBtn.UseVisualStyleBackColor = true;
            this.rsvpOptBtn.Click += new System.EventHandler(this.rsvpOptBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "GBC Event Management Limited";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rsvpOptBtn);
            this.Controls.Add(this.eventOptBtn);
            this.Controls.Add(this.custOptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainMenu";
            this.Text = " ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rSVPToEventToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRSVPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRSVPToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button custOptBtn;
        private System.Windows.Forms.Button eventOptBtn;
        private System.Windows.Forms.Button rsvpOptBtn;
        private System.Windows.Forms.ToolStripMenuItem rSVPOptionsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

