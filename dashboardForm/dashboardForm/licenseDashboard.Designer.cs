﻿namespace dashboardForm
{
    partial class licenseDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(licenseDashboard));
            this.addLicenseBtn = new System.Windows.Forms.Button();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.OGRAlogo = new System.Windows.Forms.PictureBox();
            this.priceBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.CompanyBtn = new System.Windows.Forms.Button();
            this.complaintBtn = new System.Windows.Forms.Button();
            this.departmentBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchLicBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OGRAlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addLicenseBtn
            // 
            this.addLicenseBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addLicenseBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLicenseBtn.ForeColor = System.Drawing.Color.White;
            this.addLicenseBtn.Location = new System.Drawing.Point(572, 46);
            this.addLicenseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addLicenseBtn.Name = "addLicenseBtn";
            this.addLicenseBtn.Size = new System.Drawing.Size(154, 48);
            this.addLicenseBtn.TabIndex = 15;
            this.addLicenseBtn.Text = "Add License";
            this.addLicenseBtn.UseVisualStyleBackColor = false;
            this.addLicenseBtn.Click += new System.EventHandler(this.addLicenseBtn_Click);
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.licenseLabel.Location = new System.Drawing.Point(360, 131);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(98, 29);
            this.licenseLabel.TabIndex = 13;
            this.licenseLabel.Text = "LICENSE";
            this.licenseLabel.Click += new System.EventHandler(this.licenseLabel_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Maroon;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(689, 10);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 22);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // OGRAlogo
            // 
            this.OGRAlogo.Image = ((System.Drawing.Image)(resources.GetObject("OGRAlogo.Image")));
            this.OGRAlogo.Location = new System.Drawing.Point(9, 10);
            this.OGRAlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OGRAlogo.Name = "OGRAlogo";
            this.OGRAlogo.Size = new System.Drawing.Size(152, 150);
            this.OGRAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OGRAlogo.TabIndex = 24;
            this.OGRAlogo.TabStop = false;
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.priceBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBtn.ForeColor = System.Drawing.Color.White;
            this.priceBtn.Location = new System.Drawing.Point(2, 420);
            this.priceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(178, 44);
            this.priceBtn.TabIndex = 23;
            this.priceBtn.Text = "PRICE";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.employeeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.ForeColor = System.Drawing.Color.White;
            this.employeeBtn.Location = new System.Drawing.Point(2, 371);
            this.employeeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(178, 44);
            this.employeeBtn.TabIndex = 22;
            this.employeeBtn.Text = "EMPLOYEE";
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // CompanyBtn
            // 
            this.CompanyBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.CompanyBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyBtn.ForeColor = System.Drawing.Color.White;
            this.CompanyBtn.Location = new System.Drawing.Point(2, 323);
            this.CompanyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanyBtn.Name = "CompanyBtn";
            this.CompanyBtn.Size = new System.Drawing.Size(178, 44);
            this.CompanyBtn.TabIndex = 21;
            this.CompanyBtn.Text = "COMPANY";
            this.CompanyBtn.UseVisualStyleBackColor = false;
            this.CompanyBtn.Click += new System.EventHandler(this.CompanyBtn_Click);
            // 
            // complaintBtn
            // 
            this.complaintBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.complaintBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintBtn.ForeColor = System.Drawing.Color.White;
            this.complaintBtn.Location = new System.Drawing.Point(2, 270);
            this.complaintBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.complaintBtn.Name = "complaintBtn";
            this.complaintBtn.Size = new System.Drawing.Size(178, 48);
            this.complaintBtn.TabIndex = 20;
            this.complaintBtn.Text = "COMPLAINT";
            this.complaintBtn.UseVisualStyleBackColor = false;
            this.complaintBtn.Click += new System.EventHandler(this.complaintBtn_Click);
            // 
            // departmentBtn
            // 
            this.departmentBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.departmentBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBtn.ForeColor = System.Drawing.Color.White;
            this.departmentBtn.Location = new System.Drawing.Point(2, 221);
            this.departmentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentBtn.Name = "departmentBtn";
            this.departmentBtn.Size = new System.Drawing.Size(178, 44);
            this.departmentBtn.TabIndex = 19;
            this.departmentBtn.Text = "DEPARTMENT";
            this.departmentBtn.UseVisualStyleBackColor = false;
            this.departmentBtn.Click += new System.EventHandler(this.departmentBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(2, 172);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(178, 44);
            this.homeBtn.TabIndex = 18;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click_1);
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.Color.White;
            this.searchTextbox.Location = new System.Drawing.Point(309, 28);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(170, 20);
            this.searchTextbox.TabIndex = 27;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.White;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(168, 26);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(146, 21);
            this.searchLbl.TabIndex = 26;
            this.searchLbl.Text = "Search License ID:";
            // 
            // searchLicBtn
            // 
            this.searchLicBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.searchLicBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLicBtn.ForeColor = System.Drawing.Color.White;
            this.searchLicBtn.Location = new System.Drawing.Point(483, 24);
            this.searchLicBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchLicBtn.Name = "searchLicBtn";
            this.searchLicBtn.Size = new System.Drawing.Size(88, 27);
            this.searchLicBtn.TabIndex = 25;
            this.searchLicBtn.Text = "SEARCH";
            this.searchLicBtn.UseCompatibleTextRendering = true;
            this.searchLicBtn.UseVisualStyleBackColor = false;
            this.searchLicBtn.Click += new System.EventHandler(this.searchLicBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 292);
            this.dataGridView1.TabIndex = 28;
            // 
            // licenseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchLicBtn);
            this.Controls.Add(this.OGRAlogo);
            this.Controls.Add(this.priceBtn);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.CompanyBtn);
            this.Controls.Add(this.complaintBtn);
            this.Controls.Add(this.departmentBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.addLicenseBtn);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "licenseDashboard";
            this.Text = "license";
            this.Load += new System.EventHandler(this.licenseDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OGRAlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addLicenseBtn;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox OGRAlogo;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button CompanyBtn;
        private System.Windows.Forms.Button complaintBtn;
        private System.Windows.Forms.Button departmentBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button searchLicBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}