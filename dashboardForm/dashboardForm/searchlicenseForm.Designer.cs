namespace dashboardForm
{
    partial class searchlicenseForm
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
            this.searchlicpgridView = new System.Windows.Forms.DataGridView();
            this.backBtn6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchlicpgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchlicpgridView
            // 
            this.searchlicpgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchlicpgridView.Location = new System.Drawing.Point(16, 10);
            this.searchlicpgridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchlicpgridView.Name = "searchlicpgridView";
            this.searchlicpgridView.RowHeadersWidth = 51;
            this.searchlicpgridView.RowTemplate.Height = 24;
            this.searchlicpgridView.Size = new System.Drawing.Size(605, 94);
            this.searchlicpgridView.TabIndex = 3;
            // 
            // backBtn6
            // 
            this.backBtn6.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn6.ForeColor = System.Drawing.Color.White;
            this.backBtn6.Location = new System.Drawing.Point(291, 109);
            this.backBtn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn6.Name = "backBtn6";
            this.backBtn6.Size = new System.Drawing.Size(70, 30);
            this.backBtn6.TabIndex = 2;
            this.backBtn6.Text = "BACK";
            this.backBtn6.UseVisualStyleBackColor = false;
            this.backBtn6.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchlicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 142);
            this.Controls.Add(this.searchlicpgridView);
            this.Controls.Add(this.backBtn6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchlicenseForm";
            this.Text = "searchlicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchlicpgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchlicpgridView;
        private System.Windows.Forms.Button backBtn6;
    }
}