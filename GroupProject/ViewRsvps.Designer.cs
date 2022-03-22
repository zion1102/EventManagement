
namespace GroupProject
{
    partial class ViewRsvps
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
            this.rsvpListLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View RSVP\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Below is a list of all the RSVP\'s :";
            // 
            // rsvpListLbl
            // 
            this.rsvpListLbl.AutoSize = true;
            this.rsvpListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rsvpListLbl.Location = new System.Drawing.Point(22, 115);
            this.rsvpListLbl.Name = "rsvpListLbl";
            this.rsvpListLbl.Size = new System.Drawing.Size(0, 20);
            this.rsvpListLbl.TabIndex = 2;
            // 
            // viewRsvps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rsvpListLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "viewRsvps";
            this.Text = "viewRsvps";
            this.Load += new System.EventHandler(this.viewRsvps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rsvpListLbl;
    }
}