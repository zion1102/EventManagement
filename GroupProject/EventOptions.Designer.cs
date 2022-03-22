
namespace GroupProject
{
    partial class EventOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.viewEventsBtn = new System.Windows.Forms.Button();
            this.eventDetailsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteEventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Options ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please choose from one of the options bellow :";
            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(17, 166);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(143, 36);
            this.addEventBtn.TabIndex = 2;
            this.addEventBtn.Text = "Add Event";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // viewEventsBtn
            // 
            this.viewEventsBtn.Location = new System.Drawing.Point(17, 225);
            this.viewEventsBtn.Name = "viewEventsBtn";
            this.viewEventsBtn.Size = new System.Drawing.Size(143, 36);
            this.viewEventsBtn.TabIndex = 3;
            this.viewEventsBtn.Text = "View Events";
            this.viewEventsBtn.UseVisualStyleBackColor = true;
            this.viewEventsBtn.Click += new System.EventHandler(this.viewEventsBtn_Click);
            // 
            // eventDetailsBtn
            // 
            this.eventDetailsBtn.Location = new System.Drawing.Point(17, 294);
            this.eventDetailsBtn.Name = "eventDetailsBtn";
            this.eventDetailsBtn.Size = new System.Drawing.Size(143, 36);
            this.eventDetailsBtn.TabIndex = 4;
            this.eventDetailsBtn.Text = "View Event Detials";
            this.eventDetailsBtn.UseVisualStyleBackColor = true;
            this.eventDetailsBtn.Click += new System.EventHandler(this.eventDetailsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "GBC Event Management Limited";
            // 
            // deleteEventBtn
            // 
            this.deleteEventBtn.Location = new System.Drawing.Point(17, 359);
            this.deleteEventBtn.Name = "deleteEventBtn";
            this.deleteEventBtn.Size = new System.Drawing.Size(143, 33);
            this.deleteEventBtn.TabIndex = 9;
            this.deleteEventBtn.Text = "Delete Event";
            this.deleteEventBtn.UseVisualStyleBackColor = true;
            this.deleteEventBtn.Click += new System.EventHandler(this.deleteEventBtn_Click_1);
            // 
            // EventOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteEventBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventDetailsBtn);
            this.Controls.Add(this.viewEventsBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventOptions";
            this.Text = "eventOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button viewEventsBtn;
        private System.Windows.Forms.Button eventDetailsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteEventBtn;
    }
}