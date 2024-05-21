namespace dashboardForm
{
    partial class employeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeDashboard));
            this.employeeLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchEmpBtn = new System.Windows.Forms.Button();
            this.departmentBtn = new System.Windows.Forms.Button();
            this.complaintBtn = new System.Windows.Forms.Button();
            this.CompanyBtn = new System.Windows.Forms.Button();
            this.licenseBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.OGRAlogo = new System.Windows.Forms.PictureBox();
            this.alotdptBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OGRAlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.employeeLabel.Location = new System.Drawing.Point(542, 161);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(156, 35);
            this.employeeLabel.TabIndex = 9;
            this.employeeLabel.Text = "EMPLOYEE";
            this.employeeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Maroon;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(919, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(49, 27);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(3, 212);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(238, 54);
            this.homeBtn.TabIndex = 10;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // searchEmpBtn
            // 
            this.searchEmpBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.searchEmpBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmpBtn.ForeColor = System.Drawing.Color.White;
            this.searchEmpBtn.Location = new System.Drawing.Point(581, 16);
            this.searchEmpBtn.Name = "searchEmpBtn";
            this.searchEmpBtn.Size = new System.Drawing.Size(117, 33);
            this.searchEmpBtn.TabIndex = 11;
            this.searchEmpBtn.Text = "SEARCH";
            this.searchEmpBtn.UseCompatibleTextRendering = true;
            this.searchEmpBtn.UseVisualStyleBackColor = false;
            this.searchEmpBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // departmentBtn
            // 
            this.departmentBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.departmentBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBtn.ForeColor = System.Drawing.Color.White;
            this.departmentBtn.Location = new System.Drawing.Point(3, 272);
            this.departmentBtn.Name = "departmentBtn";
            this.departmentBtn.Size = new System.Drawing.Size(238, 54);
            this.departmentBtn.TabIndex = 12;
            this.departmentBtn.Text = "DEPARTMENT";
            this.departmentBtn.UseVisualStyleBackColor = false;
            this.departmentBtn.Click += new System.EventHandler(this.departmentBtn_Click);
            // 
            // complaintBtn
            // 
            this.complaintBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.complaintBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintBtn.ForeColor = System.Drawing.Color.White;
            this.complaintBtn.Location = new System.Drawing.Point(3, 332);
            this.complaintBtn.Name = "complaintBtn";
            this.complaintBtn.Size = new System.Drawing.Size(238, 59);
            this.complaintBtn.TabIndex = 13;
            this.complaintBtn.Text = "COMPLAINT";
            this.complaintBtn.UseVisualStyleBackColor = false;
            this.complaintBtn.Click += new System.EventHandler(this.complaintBtn_Click);
            // 
            // CompanyBtn
            // 
            this.CompanyBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.CompanyBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyBtn.ForeColor = System.Drawing.Color.White;
            this.CompanyBtn.Location = new System.Drawing.Point(3, 397);
            this.CompanyBtn.Name = "CompanyBtn";
            this.CompanyBtn.Size = new System.Drawing.Size(238, 54);
            this.CompanyBtn.TabIndex = 14;
            this.CompanyBtn.Text = "COMPANY";
            this.CompanyBtn.UseVisualStyleBackColor = false;
            this.CompanyBtn.Click += new System.EventHandler(this.CompanyBtn_Click);
            // 
            // licenseBtn
            // 
            this.licenseBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.licenseBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseBtn.ForeColor = System.Drawing.Color.White;
            this.licenseBtn.Location = new System.Drawing.Point(3, 457);
            this.licenseBtn.Name = "licenseBtn";
            this.licenseBtn.Size = new System.Drawing.Size(238, 54);
            this.licenseBtn.TabIndex = 15;
            this.licenseBtn.Text = "LICENSE";
            this.licenseBtn.UseVisualStyleBackColor = false;
            this.licenseBtn.Click += new System.EventHandler(this.licenseBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.priceBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBtn.ForeColor = System.Drawing.Color.White;
            this.priceBtn.Location = new System.Drawing.Point(3, 517);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(238, 54);
            this.priceBtn.TabIndex = 16;
            this.priceBtn.Text = "PRICE";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // OGRAlogo
            // 
            this.OGRAlogo.Image = ((System.Drawing.Image)(resources.GetObject("OGRAlogo.Image")));
            this.OGRAlogo.Location = new System.Drawing.Point(12, 12);
            this.OGRAlogo.Name = "OGRAlogo";
            this.OGRAlogo.Size = new System.Drawing.Size(202, 184);
            this.OGRAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OGRAlogo.TabIndex = 17;
            this.OGRAlogo.TabStop = false;
            // 
            // alotdptBtn
            // 
            this.alotdptBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.alotdptBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alotdptBtn.ForeColor = System.Drawing.Color.White;
            this.alotdptBtn.Location = new System.Drawing.Point(746, 45);
            this.alotdptBtn.Name = "alotdptBtn";
            this.alotdptBtn.Size = new System.Drawing.Size(233, 60);
            this.alotdptBtn.TabIndex = 18;
            this.alotdptBtn.Text = "ALOT DEPARTMENT";
            this.alotdptBtn.UseVisualStyleBackColor = false;
            this.alotdptBtn.Click += new System.EventHandler(this.alotdptBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.White;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(236, 22);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(107, 26);
            this.searchLbl.TabIndex = 19;
            this.searchLbl.Text = "Search ID:";
            this.searchLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.Color.White;
            this.searchTextbox.Location = new System.Drawing.Point(349, 22);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(226, 22);
            this.searchTextbox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 359);
            this.dataGridView1.TabIndex = 21;
            // 
            // employeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 619);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.alotdptBtn);
            this.Controls.Add(this.OGRAlogo);
            this.Controls.Add(this.priceBtn);
            this.Controls.Add(this.licenseBtn);
            this.Controls.Add(this.CompanyBtn);
            this.Controls.Add(this.complaintBtn);
            this.Controls.Add(this.departmentBtn);
            this.Controls.Add(this.searchEmpBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeDashboard";
            this.Text = "employeeDashboard";
            this.Load += new System.EventHandler(this.employeeDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OGRAlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button searchEmpBtn;
        private System.Windows.Forms.Button departmentBtn;
        private System.Windows.Forms.Button complaintBtn;
        private System.Windows.Forms.Button CompanyBtn;
        private System.Windows.Forms.Button licenseBtn;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.PictureBox OGRAlogo;
        private System.Windows.Forms.Button alotdptBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}