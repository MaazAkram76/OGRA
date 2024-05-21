namespace dashboardForm
{
    partial class searchcompanyForm
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
            this.searchcompanygridView = new System.Windows.Forms.DataGridView();
            this.backBtn5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchcompanygridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchcompanygridView
            // 
            this.searchcompanygridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchcompanygridView.Location = new System.Drawing.Point(9, 9);
            this.searchcompanygridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchcompanygridView.Name = "searchcompanygridView";
            this.searchcompanygridView.RowHeadersWidth = 51;
            this.searchcompanygridView.RowTemplate.Height = 24;
            this.searchcompanygridView.Size = new System.Drawing.Size(562, 94);
            this.searchcompanygridView.TabIndex = 5;
            // 
            // backBtn5
            // 
            this.backBtn5.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn5.ForeColor = System.Drawing.Color.White;
            this.backBtn5.Location = new System.Drawing.Point(272, 108);
            this.backBtn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn5.Name = "backBtn5";
            this.backBtn5.Size = new System.Drawing.Size(70, 30);
            this.backBtn5.TabIndex = 4;
            this.backBtn5.Text = "BACK";
            this.backBtn5.UseVisualStyleBackColor = false;
            this.backBtn5.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchcompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 148);
            this.Controls.Add(this.searchcompanygridView);
            this.Controls.Add(this.backBtn5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchcompanyForm";
            this.Text = "searchcompanyForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchcompanygridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchcompanygridView;
        private System.Windows.Forms.Button backBtn5;
    }
}