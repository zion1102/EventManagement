
namespace GroupProject
{
    partial class AddRsvp
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
            this.label3 = new System.Windows.Forms.Label();
            this.eventListLbl = new System.Windows.Forms.Label();
            this.customerListLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.custemrIdTxt = new System.Windows.Forms.TextBox();
            this.eventIdTxt = new System.Windows.Forms.TextBox();
            this.addRsvpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add RSVP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event List";
            // 
            // eventListLbl
            // 
            this.eventListLbl.AutoSize = true;
            this.eventListLbl.Location = new System.Drawing.Point(476, 135);
            this.eventListLbl.Name = "eventListLbl";
            this.eventListLbl.Size = new System.Drawing.Size(0, 17);
            this.eventListLbl.TabIndex = 3;
            // 
            // customerListLbl
            // 
            this.customerListLbl.AutoSize = true;
            this.customerListLbl.Location = new System.Drawing.Point(18, 135);
            this.customerListLbl.Name = "customerListLbl";
            this.customerListLbl.Size = new System.Drawing.Size(0, 17);
            this.customerListLbl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Customer Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter event Id : ";
            // 
            // custemrIdTxt
            // 
            this.custemrIdTxt.Location = new System.Drawing.Point(24, 316);
            this.custemrIdTxt.Name = "custemrIdTxt";
            this.custemrIdTxt.Size = new System.Drawing.Size(100, 22);
            this.custemrIdTxt.TabIndex = 7;
            // 
            // eventIdTxt
            // 
            this.eventIdTxt.Location = new System.Drawing.Point(482, 316);
            this.eventIdTxt.Name = "eventIdTxt";
            this.eventIdTxt.Size = new System.Drawing.Size(100, 22);
            this.eventIdTxt.TabIndex = 8;
            // 
            // addRsvpBtn
            // 
            this.addRsvpBtn.Location = new System.Drawing.Point(265, 363);
            this.addRsvpBtn.Name = "addRsvpBtn";
            this.addRsvpBtn.Size = new System.Drawing.Size(135, 50);
            this.addRsvpBtn.TabIndex = 9;
            this.addRsvpBtn.Text = "Add Rsvp";
            this.addRsvpBtn.UseVisualStyleBackColor = true;
            this.addRsvpBtn.Click += new System.EventHandler(this.addRsvpBtn_Click);
            // 
            // addRsvp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRsvpBtn);
            this.Controls.Add(this.eventIdTxt);
            this.Controls.Add(this.custemrIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerListLbl);
            this.Controls.Add(this.eventListLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addRsvp";
            this.Text = "addRsvp";
            this.Load += new System.EventHandler(this.addRsvp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eventListLbl;
        private System.Windows.Forms.Label customerListLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custemrIdTxt;
        private System.Windows.Forms.TextBox eventIdTxt;
        private System.Windows.Forms.Button addRsvpBtn;
    }
}