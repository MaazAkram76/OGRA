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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.welcomeBackPicBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.loginAccountLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.resetLabel);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.loginEmailTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(192, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 465);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Maroon;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(388, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 25);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAccountLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginAccountLabel.Location = new System.Drawing.Point(47, 137);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(156, 27);
            this.loginAccountLabel.TabIndex = 16;
            this.loginAccountLabel.Text = "Login Account";
            this.loginAccountLabel.Click += new System.EventHandler(this.LoginAccountLabel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(265, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(95, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oil and Gas Regulatory Authority";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.resetLabel.Location = new System.Drawing.Point(191, 360);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(40, 16);
            this.resetLabel.TabIndex = 8;
            this.resetLabel.Text = "Reset";
            this.resetLabel.Click += new System.EventHandler(this.Label7_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(180, 299);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(123, 30);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(49, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(178, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailTextBox.Location = new System.Drawing.Point(178, 210);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(151, 20);
            this.loginEmailTextBox.TabIndex = 3;
            this.loginEmailTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(52, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // welcomeBackPicBox
            // 
            this.welcomeBackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("welcomeBackPicBox.Image")));
            this.welcomeBackPicBox.Location = new System.Drawing.Point(-10, 0);
            this.welcomeBackPicBox.Name = "welcomeBackPicBox";
            this.welcomeBackPicBox.Size = new System.Drawing.Size(207, 464);
            this.welcomeBackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeBackPicBox.TabIndex = 1;
            this.welcomeBackPicBox.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 461);
            this.Controls.Add(this.welcomeBackPicBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox loginEmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.PictureBox welcomeBackPicBox;
        private System.Windows.Forms.Button closeButton;
    }
}

