namespace dashboardForm
{
    partial class searchcomplaintForm
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
            this.searchcomplaintgridView = new System.Windows.Forms.DataGridView();
            this.backBtn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchcomplaintgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchcomplaintgridView
            // 
            this.searchcomplaintgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchcomplaintgridView.Location = new System.Drawing.Point(9, 10);
            this.searchcomplaintgridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchcomplaintgridView.Name = "searchcomplaintgridView";
            this.searchcomplaintgridView.RowHeadersWidth = 51;
            this.searchcomplaintgridView.RowTemplate.Height = 24;
            this.searchcomplaintgridView.Size = new System.Drawing.Size(562, 94);
            this.searchcomplaintgridView.TabIndex = 3;
            this.searchcomplaintgridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchcomplaintgridView_CellContentClick);
            // 
            // backBtn4
            // 
            this.backBtn4.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn4.ForeColor = System.Drawing.Color.White;
            this.backBtn4.Location = new System.Drawing.Point(266, 109);
            this.backBtn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn4.Name = "backBtn4";
            this.backBtn4.Size = new System.Drawing.Size(70, 30);
            this.backBtn4.TabIndex = 2;
            this.backBtn4.Text = "BACK";
            this.backBtn4.UseVisualStyleBackColor = false;
            this.backBtn4.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchcomplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 140);
            this.Controls.Add(this.searchcomplaintgridView);
            this.Controls.Add(this.backBtn4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchcomplaintForm";
            this.Text = "searchcomplaintForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchcomplaintgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchcomplaintgridView;
        private System.Windows.Forms.Button backBtn4;
    }
}