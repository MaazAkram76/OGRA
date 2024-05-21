namespace ProjectDB
{
    partial class clientlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientlogin));
            this.welcomeBackPicBox = new System.Windows.Forms.PictureBox();
            this.logincloseButton = new System.Windows.Forms.Button();
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.clientregisterbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientresetLabel = new System.Windows.Forms.Label();
            this.clientloginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clientpasswordbox = new System.Windows.Forms.TextBox();
            this.clientemailbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBackPicBox
            // 
            this.welcomeBackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("welcomeBackPicBox.Image")));
            this.welcomeBackPicBox.Location = new System.Drawing.Point(-2, -20);
            this.welcomeBackPicBox.Name = "welcomeBackPicBox";
            this.welcomeBackPicBox.Size = new System.Drawing.Size(222, 452);
            this.welcomeBackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeBackPicBox.TabIndex = 3;
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
            this.logincloseButton.TabIndex = 39;
            this.logincloseButton.Text = "X";
            this.logincloseButton.UseVisualStyleBackColor = false;
            this.logincloseButton.Click += new System.EventHandler(this.logincloseButton_Click);
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAccountLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginAccountLabel.Location = new System.Drawing.Point(234, 139);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(131, 27);
            this.loginAccountLabel.TabIndex = 38;
            this.loginAccountLabel.Text = "Client Login";
            // 
            // clientregisterbtn
            // 
            this.clientregisterbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.clientregisterbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientregisterbtn.ForeColor = System.Drawing.Color.White;
            this.clientregisterbtn.Location = new System.Drawing.Point(452, 354);
            this.clientregisterbtn.Name = "clientregisterbtn";
            this.clientregisterbtn.Size = new System.Drawing.Size(79, 33);
            this.clientregisterbtn.TabIndex = 37;
            this.clientregisterbtn.Text = "Register";
            this.clientregisterbtn.UseVisualStyleBackColor = false;
            this.clientregisterbtn.Click += new System.EventHandler(this.clientregisterbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(323, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Oil and Gas Regulatory Authority";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // clientresetLabel
            // 
            this.clientresetLabel.AutoSize = true;
            this.clientresetLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientresetLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.clientresetLabel.Location = new System.Drawing.Point(378, 362);
            this.clientresetLabel.Name = "clientresetLabel";
            this.clientresetLabel.Size = new System.Drawing.Size(39, 16);
            this.clientresetLabel.TabIndex = 36;
            this.clientresetLabel.Text = "Reset";
            this.clientresetLabel.Click += new System.EventHandler(this.clientresetLabel_Click);
            // 
            // clientloginBtn
            // 
            this.clientloginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.clientloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientloginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientloginBtn.ForeColor = System.Drawing.Color.White;
            this.clientloginBtn.Location = new System.Drawing.Point(367, 301);
            this.clientloginBtn.Name = "clientloginBtn";
            this.clientloginBtn.Size = new System.Drawing.Size(123, 30);
            this.clientloginBtn.TabIndex = 35;
            this.clientloginBtn.Text = "LOGIN";
            this.clientloginBtn.UseVisualStyleBackColor = false;
            this.clientloginBtn.Click += new System.EventHandler(this.clientloginBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(236, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Password";
            // 
            // clientpasswordbox
            // 
            this.clientpasswordbox.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientpasswordbox.Location = new System.Drawing.Point(365, 256);
            this.clientpasswordbox.Name = "clientpasswordbox";
            this.clientpasswordbox.Size = new System.Drawing.Size(151, 20);
            this.clientpasswordbox.TabIndex = 33;
            // 
            // clientemailbox
            // 
            this.clientemailbox.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientemailbox.Location = new System.Drawing.Point(365, 212);
            this.clientemailbox.Name = "clientemailbox";
            this.clientemailbox.Size = new System.Drawing.Size(151, 20);
            this.clientemailbox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(239, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 64;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logincloseButton);
            this.Controls.Add(this.loginAccountLabel);
            this.Controls.Add(this.clientregisterbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientresetLabel);
            this.Controls.Add(this.clientloginBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientpasswordbox);
            this.Controls.Add(this.clientemailbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.welcomeBackPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientlogin";
            this.Text = "clientlogin";
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBackPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox welcomeBackPicBox;
        private System.Windows.Forms.Button logincloseButton;
        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.Button clientregisterbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clientresetLabel;
        private System.Windows.Forms.Button clientloginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientpasswordbox;
        private System.Windows.Forms.TextBox clientemailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}