
namespace GroupProject
{
    partial class ViewEvent
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
            this.eventIdTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.viewLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Event ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the event ID bellow : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event ID : ";
            // 
            // eventIdTxt
            // 
            this.eventIdTxt.Location = new System.Drawing.Point(18, 129);
            this.eventIdTxt.Name = "eventIdTxt";
            this.eventIdTxt.Size = new System.Drawing.Size(100, 22);
            this.eventIdTxt.TabIndex = 3;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(18, 199);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(100, 32);
            this.viewBtn.TabIndex = 4;
            this.viewBtn.Text = "View ";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // viewLbl
            // 
            this.viewLbl.AutoSize = true;
            this.viewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.viewLbl.Location = new System.Drawing.Point(305, 108);
            this.viewLbl.Name = "viewLbl";
            this.viewLbl.Size = new System.Drawing.Size(0, 18);
            this.viewLbl.TabIndex = 5;
            // 
            // viewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewLbl);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.eventIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "viewEvent";
            this.Text = "viewEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventIdTxt;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label viewLbl;
    }
}