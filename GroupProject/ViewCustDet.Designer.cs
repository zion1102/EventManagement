
namespace GroupProject
{
    partial class ViewCustDet
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.sexLbl = new System.Windows.Forms.Label();
            this.searchID = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(253, 94);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(253, 135);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(0, 17);
            this.idLbl.TabIndex = 1;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(253, 182);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(0, 17);
            this.ageLbl.TabIndex = 2;
            // 
            // sexLbl
            // 
            this.sexLbl.AutoSize = true;
            this.sexLbl.Location = new System.Drawing.Point(253, 223);
            this.sexLbl.Name = "sexLbl";
            this.sexLbl.Size = new System.Drawing.Size(0, 17);
            this.sexLbl.TabIndex = 3;
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(12, 103);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(100, 22);
            this.searchID.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 145);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 41);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search ";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter customer id bellow :";
            // 
            // viewCustDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.sexLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "viewCustDet";
            this.Text = "viewCustDet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label sexLbl;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}