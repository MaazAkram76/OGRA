namespace ograforms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.welcomeBackPicBox = new System.Windows.Forms.PictureBox();
            this.logincloseButton = new System.Windows.Forms.Button();
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminresetLabel = new System.Windows.Forms.Label();
            this.adminloginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.adminpasswordbox = new System.Windows.Forms.TextBox();
            this.adminemailbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBackPicBox
            // 
            this.welcomeBackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("welcomeBackPicBox.Image")));
            this.welcomeBackPicBox.Location = new System.Drawing.Point(-10, 0);
            this.welcomeBackPicBox.Name = "welcomeBackPicBox";
            this.welcomeBackPicBox.Size = new System.Drawing.Size(234, 452);
            this.welcomeBackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeBackPicBox.TabIndex = 1;
            this.welcomeBackPicBox.TabStop = false;
            // 
            // logincloseButton
            // 
            this.logincloseButton.BackColor = System.Drawing.Color.Maroon;
            this.logincloseButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logincloseButton.ForeColor = System.Drawing.Color.White;
            this.logincloseButton.Location = new System.Drawing.Point(624, 12);
            this.logincloseButton.Name = "logincloseButton";
            this.logincloseButton.Size = new System.Drawing.Size(45, 25);
            this.logincloseButton.TabIndex = 61;
            this.logincloseButton.Text = "X";
            this.logincloseButton.UseVisualStyleBackColor = false;
            this.logincloseButton.Click += new System.EventHandler(this.logincloseButton_Click);
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAccountLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginAccountLabel.Location = new System.Drawing.Point(238, 129);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(140, 27);
            this.loginAccountLabel.TabIndex = 60;
            this.loginAccountLabel.Text = "Admin Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(327, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Oil and Gas Regulatory Authority";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // adminresetLabel
            // 
            this.adminresetLabel.AutoSize = true;
            this.adminresetLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminresetLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.adminresetLabel.Location = new System.Drawing.Point(423, 336);
            this.adminresetLabel.Name = "adminresetLabel";
            this.adminresetLabel.Size = new System.Drawing.Size(39, 16);
            this.adminresetLabel.TabIndex = 58;
            this.adminresetLabel.Text = "Reset";
            this.adminresetLabel.Click += new System.EventHandler(this.adminresetLabel_Click);
            // 
            // adminloginBtn
            // 
            this.adminloginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.adminloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminloginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginBtn.ForeColor = System.Drawing.Color.White;
            this.adminloginBtn.Location = new System.Drawing.Point(380, 291);
            this.adminloginBtn.Name = "adminloginBtn";
            this.adminloginBtn.Size = new System.Drawing.Size(123, 30);
            this.adminloginBtn.TabIndex = 57;
            this.adminloginBtn.Text = "LOGIN";
            this.adminloginBtn.UseVisualStyleBackColor = false;
            this.adminloginBtn.Click += new System.EventHandler(this.adminloginBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(245, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Password";
            // 
            // adminpasswordbox
            // 
            this.adminpasswordbox.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasswordbox.Location = new System.Drawing.Point(368, 246);
            this.adminpasswordbox.Name = "adminpasswordbox";
            this.adminpasswordbox.Size = new System.Drawing.Size(151, 20);
            this.adminpasswordbox.TabIndex = 55;
            this.adminpasswordbox.TextChanged += new System.EventHandler(this.adminpasswordbox_TextChanged);
            // 
            // adminemailbox
            // 
            this.adminemailbox.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemailbox.Location = new System.Drawing.Point(367, 202);
            this.adminemailbox.Name = "adminemailbox";
            this.adminemailbox.Size = new System.Drawing.Size(151, 20);
            this.adminemailbox.TabIndex = 54;
            this.adminemailbox.TextChanged += new System.EventHandler(this.adminemailbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(246, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 62;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logincloseButton);
            this.Controls.Add(this.loginAccountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminresetLabel);
            this.Controls.Add(this.adminloginBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminpasswordbox);
            this.Controls.Add(this.adminemailbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.welcomeBackPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox welcomeBackPicBox;
        private System.Windows.Forms.Button logincloseButton;
        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adminresetLabel;
        private System.Windows.Forms.Button adminloginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminpasswordbox;
        private System.Windows.Forms.TextBox adminemailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

