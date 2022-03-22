
namespace GroupProject
{
    partial class AddCustomer
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.submitLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(16, 111);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.nameTxtBox.TabIndex = 0;
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(16, 232);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(100, 22);
            this.IdTxtBox.TabIndex = 1;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(16, 172);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(100, 22);
            this.ageTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone # : ";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(8, 286);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(180, 61);
            this.addCustomerBtn.TabIndex = 8;
            this.addCustomerBtn.Text = "add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // submitLbl
            // 
            this.submitLbl.AutoSize = true;
            this.submitLbl.Location = new System.Drawing.Point(256, 192);
            this.submitLbl.Name = "submitLbl";
            this.submitLbl.Size = new System.Drawing.Size(0, 17);
            this.submitLbl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter customer information bellow :";
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitLbl);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "addCustomer";
            this.Text = "addCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Label submitLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}