namespace PrioriteaCsharpsharp
{
    partial class LogIn
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
            this.LogInCheckbtn = new System.Windows.Forms.Button();
            this.Useless = new System.Windows.Forms.Label();
            this.Useless2 = new System.Windows.Forms.Label();
            this.Useless1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.newuser = new System.Windows.Forms.TextBox();
            this.newuserlbl = new System.Windows.Forms.Label();
            this.olduser = new System.Windows.Forms.TextBox();
            this.lastuserlbl = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.newpasslbl = new System.Windows.Forms.Label();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.lastpasslbl = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SecretCodeField = new System.Windows.Forms.TextBox();
            this.secretcodelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInCheckbtn
            // 
            this.LogInCheckbtn.Location = new System.Drawing.Point(90, 364);
            this.LogInCheckbtn.Name = "LogInCheckbtn";
            this.LogInCheckbtn.Size = new System.Drawing.Size(70, 32);
            this.LogInCheckbtn.TabIndex = 4;
            this.LogInCheckbtn.Text = "Log In";
            this.LogInCheckbtn.UseVisualStyleBackColor = true;
            this.LogInCheckbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Useless
            // 
            this.Useless.AutoSize = true;
            this.Useless.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useless.Location = new System.Drawing.Point(31, 136);
            this.Useless.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Useless.Name = "Useless";
            this.Useless.Size = new System.Drawing.Size(259, 24);
            this.Useless.TabIndex = 4;
            this.Useless.Text = "Prioritea Point-Of-Sale System";
            this.Useless.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Useless2
            // 
            this.Useless2.AutoSize = true;
            this.Useless2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Useless2.Location = new System.Drawing.Point(135, 218);
            this.Useless2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Useless2.Name = "Useless2";
            this.Useless2.Size = new System.Drawing.Size(53, 13);
            this.Useless2.TabIndex = 9;
            this.Useless2.Text = "Password";
            // 
            // Useless1
            // 
            this.Useless1.AutoSize = true;
            this.Useless1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Useless1.Location = new System.Drawing.Point(135, 181);
            this.Useless1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Useless1.Name = "Useless1";
            this.Useless1.Size = new System.Drawing.Size(55, 13);
            this.Useless1.TabIndex = 7;
            this.Useless1.Text = "Username";
            // 
            // exitbtn
            // 
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(113, 463);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(93, 32);
            this.exitbtn.TabIndex = 12;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(107, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Credentials";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // newuser
            // 
            this.newuser.Location = new System.Drawing.Point(163, 216);
            this.newuser.Name = "newuser";
            this.newuser.Size = new System.Drawing.Size(145, 20);
            this.newuser.TabIndex = 8;
            this.newuser.Visible = false;
            // 
            // newuserlbl
            // 
            this.newuserlbl.AutoSize = true;
            this.newuserlbl.Location = new System.Drawing.Point(191, 200);
            this.newuserlbl.Name = "newuserlbl";
            this.newuserlbl.Size = new System.Drawing.Size(83, 13);
            this.newuserlbl.TabIndex = 24;
            this.newuserlbl.Text = "New Username:";
            this.newuserlbl.Visible = false;
            // 
            // olduser
            // 
            this.olduser.Location = new System.Drawing.Point(164, 178);
            this.olduser.Name = "olduser";
            this.olduser.Size = new System.Drawing.Size(145, 20);
            this.olduser.TabIndex = 7;
            this.olduser.Visible = false;
            // 
            // lastuserlbl
            // 
            this.lastuserlbl.AutoSize = true;
            this.lastuserlbl.Location = new System.Drawing.Point(194, 162);
            this.lastuserlbl.Name = "lastuserlbl";
            this.lastuserlbl.Size = new System.Drawing.Size(77, 13);
            this.lastuserlbl.TabIndex = 22;
            this.lastuserlbl.Text = "Old Username:";
            this.lastuserlbl.Visible = false;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(164, 291);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(145, 20);
            this.newpass.TabIndex = 10;
            this.newpass.Visible = false;
            // 
            // newpasslbl
            // 
            this.newpasslbl.AutoSize = true;
            this.newpasslbl.Location = new System.Drawing.Point(193, 275);
            this.newpasslbl.Name = "newpasslbl";
            this.newpasslbl.Size = new System.Drawing.Size(81, 13);
            this.newpasslbl.TabIndex = 20;
            this.newpasslbl.Text = "New Password:";
            this.newpasslbl.Visible = false;
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(164, 252);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(145, 20);
            this.oldpass.TabIndex = 9;
            this.oldpass.Visible = false;
            // 
            // lastpasslbl
            // 
            this.lastpasslbl.AutoSize = true;
            this.lastpasslbl.Location = new System.Drawing.Point(195, 237);
            this.lastpasslbl.Name = "lastpasslbl";
            this.lastpasslbl.Size = new System.Drawing.Size(78, 13);
            this.lastpasslbl.TabIndex = 18;
            this.lastpasslbl.Text = "Old Password: ";
            this.lastpasslbl.Visible = false;
            // 
            // enterbtn
            // 
            this.enterbtn.Location = new System.Drawing.Point(178, 364);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(112, 32);
            this.enterbtn.TabIndex = 11;
            this.enterbtn.Text = "Change Password";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Visible = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(35, 325);
            this.error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(255, 36);
            this.error.TabIndex = 28;
            this.error.Text = "Username/Password is incorrect\r\nPlease try again!";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error.Visible = false;
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(90, 197);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(145, 20);
            this.UsernameField.TabIndex = 1;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(90, 234);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(145, 20);
            this.PasswordField.TabIndex = 2;
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(165, 364);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(70, 32);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // SecretCodeField
            // 
            this.SecretCodeField.Location = new System.Drawing.Point(88, 271);
            this.SecretCodeField.Name = "SecretCodeField";
            this.SecretCodeField.Size = new System.Drawing.Size(145, 20);
            this.SecretCodeField.TabIndex = 3;
            // 
            // secretcodelbl
            // 
            this.secretcodelbl.AutoSize = true;
            this.secretcodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.secretcodelbl.Location = new System.Drawing.Point(107, 257);
            this.secretcodelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secretcodelbl.Name = "secretcodelbl";
            this.secretcodelbl.Size = new System.Drawing.Size(107, 13);
            this.secretcodelbl.TabIndex = 35;
            this.secretcodelbl.Text = "Prioritea Secret Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrioriteaCsharpsharp.Properties.Resources.PrioriteLogoClear;
            this.pictureBox1.Location = new System.Drawing.Point(104, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(321, 496);
            this.ControlBox = false;
            this.Controls.Add(this.SecretCodeField);
            this.Controls.Add(this.secretcodelbl);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.error);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.newuser);
            this.Controls.Add(this.newuserlbl);
            this.Controls.Add(this.olduser);
            this.Controls.Add(this.lastuserlbl);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.newpasslbl);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.lastpasslbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Useless2);
            this.Controls.Add(this.Useless1);
            this.Controls.Add(this.Useless);
            this.Controls.Add(this.LogInCheckbtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 535);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIORITEA - Logging in...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInCheckbtn;
        internal System.Windows.Forms.Label Useless;
        internal System.Windows.Forms.Label Useless2;
        internal System.Windows.Forms.Label Useless1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox newuser;
        private System.Windows.Forms.Label newuserlbl;
        public System.Windows.Forms.TextBox olduser;
        private System.Windows.Forms.Label lastuserlbl;
        public System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label newpasslbl;
        public System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Label lastpasslbl;
        private System.Windows.Forms.Button enterbtn;
        internal System.Windows.Forms.Label error;
        public System.Windows.Forms.TextBox UsernameField;
        public System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button signupbtn;
        public System.Windows.Forms.TextBox SecretCodeField;
        internal System.Windows.Forms.Label secretcodelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

