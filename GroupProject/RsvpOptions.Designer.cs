
namespace GroupProject
{
	partial class RsvpOptions
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
            this.addRsvpBtn = new System.Windows.Forms.Button();
            this.viewRsvpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRsvpBtn
            // 
            this.addRsvpBtn.Location = new System.Drawing.Point(22, 151);
            this.addRsvpBtn.Name = "addRsvpBtn";
            this.addRsvpBtn.Size = new System.Drawing.Size(200, 49);
            this.addRsvpBtn.TabIndex = 0;
            this.addRsvpBtn.Text = "Add Rsvp ";
            this.addRsvpBtn.UseVisualStyleBackColor = true;
            this.addRsvpBtn.Click += new System.EventHandler(this.addRsvpBtn_Click);
            // 
            // viewRsvpBtn
            // 
            this.viewRsvpBtn.Location = new System.Drawing.Point(22, 271);
            this.viewRsvpBtn.Name = "viewRsvpBtn";
            this.viewRsvpBtn.Size = new System.Drawing.Size(200, 50);
            this.viewRsvpBtn.TabIndex = 1;
            this.viewRsvpBtn.Text = "View Rsvp\'s";
            this.viewRsvpBtn.UseVisualStyleBackColor = true;
            this.viewRsvpBtn.Click += new System.EventHandler(this.viewRsvpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "RSVP Option\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please choose from the options below : ";
            // 
            // rsvpOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewRsvpBtn);
            this.Controls.Add(this.addRsvpBtn);
            this.Name = "rsvpOptions";
            this.Text = "rsvpOptions";
            this.Load += new System.EventHandler(this.rsvpOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button addRsvpBtn;
        private System.Windows.Forms.Button viewRsvpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}