namespace dashboardForm
{
    partial class updatePriceForm
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
            this.backBtn8 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dptcomboBox = new System.Windows.Forms.ComboBox();
            this.newPriceLbl = new System.Windows.Forms.Label();
            this.empidtextBox = new System.Windows.Forms.TextBox();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn8
            // 
            this.backBtn8.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn8.ForeColor = System.Drawing.Color.White;
            this.backBtn8.Location = new System.Drawing.Point(254, 119);
            this.backBtn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn8.Name = "backBtn8";
            this.backBtn8.Size = new System.Drawing.Size(63, 23);
            this.backBtn8.TabIndex = 11;
            this.backBtn8.Text = "BACK";
            this.backBtn8.UseVisualStyleBackColor = false;
            this.backBtn8.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(166, 99);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(70, 24);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // dptcomboBox
            // 
            this.dptcomboBox.FormattingEnabled = true;
            this.dptcomboBox.Items.AddRange(new object[] {
            "Finance",
            "HR",
            "Oil",
            "Gas",
            "Complaint",
            "Administration",
            "Registrar",
            "Worker"});
            this.dptcomboBox.Location = new System.Drawing.Point(130, 63);
            this.dptcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dptcomboBox.Name = "dptcomboBox";
            this.dptcomboBox.Size = new System.Drawing.Size(173, 21);
            this.dptcomboBox.TabIndex = 9;
            // 
            // newPriceLbl
            // 
            this.newPriceLbl.AutoSize = true;
            this.newPriceLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPriceLbl.Location = new System.Drawing.Point(18, 63);
            this.newPriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPriceLbl.Name = "newPriceLbl";
            this.newPriceLbl.Size = new System.Drawing.Size(80, 18);
            this.newPriceLbl.TabIndex = 8;
            this.newPriceLbl.Text = "New Price:";
            // 
            // empidtextBox
            // 
            this.empidtextBox.Location = new System.Drawing.Point(130, 28);
            this.empidtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empidtextBox.Name = "empidtextBox";
            this.empidtextBox.Size = new System.Drawing.Size(173, 20);
            this.empidtextBox.TabIndex = 7;
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameLbl.Location = new System.Drawing.Point(18, 28);
            this.prodNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(109, 18);
            this.prodNameLbl.TabIndex = 6;
            this.prodNameLbl.Text = "Product Name:";
            // 
            // updatePriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 158);
            this.Controls.Add(this.backBtn8);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dptcomboBox);
            this.Controls.Add(this.newPriceLbl);
            this.Controls.Add(this.empidtextBox);
            this.Controls.Add(this.prodNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "updatePriceForm";
            this.Text = "updatePriceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn8;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox dptcomboBox;
        private System.Windows.Forms.Label newPriceLbl;
        private System.Windows.Forms.TextBox empidtextBox;
        private System.Windows.Forms.Label prodNameLbl;
    }
}