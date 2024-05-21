namespace dashboardForm
{
    partial class alotdptDashboard
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
            this.alotdptLabel = new System.Windows.Forms.Label();
            this.empidtextBox = new System.Windows.Forms.TextBox();
            this.selectdptLabel = new System.Windows.Forms.Label();
            this.dptcomboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alotdptLabel
            // 
            this.alotdptLabel.AutoSize = true;
            this.alotdptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alotdptLabel.Location = new System.Drawing.Point(20, 25);
            this.alotdptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alotdptLabel.Name = "alotdptLabel";
            this.alotdptLabel.Size = new System.Drawing.Size(96, 18);
            this.alotdptLabel.TabIndex = 0;
            this.alotdptLabel.Text = "Employee ID:";
            // 
            // empidtextBox
            // 
            this.empidtextBox.Location = new System.Drawing.Point(112, 25);
            this.empidtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empidtextBox.Name = "empidtextBox";
            this.empidtextBox.Size = new System.Drawing.Size(173, 20);
            this.empidtextBox.TabIndex = 1;
            // 
            // selectdptLabel
            // 
            this.selectdptLabel.AutoSize = true;
            this.selectdptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectdptLabel.Location = new System.Drawing.Point(22, 61);
            this.selectdptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectdptLabel.Name = "selectdptLabel";
            this.selectdptLabel.Size = new System.Drawing.Size(92, 18);
            this.selectdptLabel.TabIndex = 2;
            this.selectdptLabel.Text = "Department:";
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
            this.dptcomboBox.Location = new System.Drawing.Point(112, 59);
            this.dptcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dptcomboBox.Name = "dptcomboBox";
            this.dptcomboBox.Size = new System.Drawing.Size(173, 21);
            this.dptcomboBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(161, 84);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(59, 24);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn1
            // 
            this.backBtn1.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn1.ForeColor = System.Drawing.Color.White;
            this.backBtn1.Location = new System.Drawing.Point(236, 115);
            this.backBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(64, 23);
            this.backBtn1.TabIndex = 5;
            this.backBtn1.Text = "BACK";
            this.backBtn1.UseVisualStyleBackColor = false;
            this.backBtn1.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // alotdptDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 148);
            this.Controls.Add(this.backBtn1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dptcomboBox);
            this.Controls.Add(this.selectdptLabel);
            this.Controls.Add(this.empidtextBox);
            this.Controls.Add(this.alotdptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "alotdptDashboard";
            this.Load += new System.EventHandler(this.alotdptDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alotdptLabel;
        private System.Windows.Forms.TextBox empidtextBox;
        private System.Windows.Forms.Label selectdptLabel;
        private System.Windows.Forms.ComboBox dptcomboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn1;
    }
}