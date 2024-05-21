namespace dashboardForm
{
    partial class searchempForm
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
            this.backBtn2 = new System.Windows.Forms.Button();
            this.searchempgridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchempgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn2
            // 
            this.backBtn2.BackColor = System.Drawing.Color.ForestGreen;
            this.backBtn2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn2.ForeColor = System.Drawing.Color.White;
            this.backBtn2.Location = new System.Drawing.Point(276, 109);
            this.backBtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(70, 30);
            this.backBtn2.TabIndex = 0;
            this.backBtn2.Text = "BACK";
            this.backBtn2.UseVisualStyleBackColor = false;
            this.backBtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchempgridView
            // 
            this.searchempgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchempgridView.Location = new System.Drawing.Point(1, 10);
            this.searchempgridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchempgridView.Name = "searchempgridView";
            this.searchempgridView.RowHeadersWidth = 51;
            this.searchempgridView.RowTemplate.Height = 24;
            this.searchempgridView.Size = new System.Drawing.Size(605, 94);
            this.searchempgridView.TabIndex = 1;
            // 
            // searchempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 140);
            this.Controls.Add(this.searchempgridView);
            this.Controls.Add(this.backBtn2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchempForm";
            this.Text = "searchempForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchempgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.DataGridView searchempgridView;
    }
}