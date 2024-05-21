namespace dashboardForm
{
    partial class adddptForm
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
            this.backBtn3 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.managernameLabel = new System.Windows.Forms.Label();
            this.dptnametextBox = new System.Windows.Forms.TextBox();
            this.dptnameLabel = new System.Windows.Forms.Label();
            this.managernametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn3
            // 
            this.backBtn3.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn3.ForeColor = System.Drawing.Color.White;
            this.backBtn3.Location = new System.Drawing.Point(293, 130);
            this.backBtn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn3.Name = "backBtn3";
            this.backBtn3.Size = new System.Drawing.Size(58, 23);
            this.backBtn3.TabIndex = 11;
            this.backBtn3.Text = "BACK";
            this.backBtn3.UseVisualStyleBackColor = false;
            this.backBtn3.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(185, 84);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(59, 24);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // managernameLabel
            // 
            this.managernameLabel.AutoSize = true;
            this.managernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managernameLabel.Location = new System.Drawing.Point(9, 54);
            this.managernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managernameLabel.Name = "managernameLabel";
            this.managernameLabel.Size = new System.Drawing.Size(116, 18);
            this.managernameLabel.TabIndex = 8;
            this.managernameLabel.Text = "Manager Name:";
            // 
            // dptnametextBox
            // 
            this.dptnametextBox.Location = new System.Drawing.Point(137, 18);
            this.dptnametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dptnametextBox.Name = "dptnametextBox";
            this.dptnametextBox.Size = new System.Drawing.Size(177, 20);
            this.dptnametextBox.TabIndex = 7;
            // 
            // dptnameLabel
            // 
            this.dptnameLabel.AutoSize = true;
            this.dptnameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptnameLabel.Location = new System.Drawing.Point(9, 18);
            this.dptnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dptnameLabel.Name = "dptnameLabel";
            this.dptnameLabel.Size = new System.Drawing.Size(136, 18);
            this.dptnameLabel.TabIndex = 6;
            this.dptnameLabel.Text = "Department Name:";
            // 
            // managernametextBox
            // 
            this.managernametextBox.Location = new System.Drawing.Point(137, 54);
            this.managernametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managernametextBox.Name = "managernametextBox";
            this.managernametextBox.Size = new System.Drawing.Size(177, 20);
            this.managernametextBox.TabIndex = 12;
            // 
            // adddptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 162);
            this.Controls.Add(this.managernametextBox);
            this.Controls.Add(this.backBtn3);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.managernameLabel);
            this.Controls.Add(this.dptnametextBox);
            this.Controls.Add(this.dptnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adddptForm";
            this.Text = "adddptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label managernameLabel;
        private System.Windows.Forms.TextBox dptnametextBox;
        private System.Windows.Forms.Label dptnameLabel;
        private System.Windows.Forms.TextBox managernametextBox;
    }
}