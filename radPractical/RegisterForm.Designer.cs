namespace radPractical
{
    partial class RegisterForm
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
            this.signup_showPwd = new System.Windows.Forms.CheckBox();
            this.signupReg_btn = new System.Windows.Forms.Button();
            this.signup_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_uname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginReg_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_showPwd
            // 
            this.signup_showPwd.AutoSize = true;
            this.signup_showPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_showPwd.Location = new System.Drawing.Point(431, 246);
            this.signup_showPwd.Name = "signup_showPwd";
            this.signup_showPwd.Size = new System.Drawing.Size(102, 17);
            this.signup_showPwd.TabIndex = 16;
            this.signup_showPwd.Text = "Show Password";
            this.signup_showPwd.UseVisualStyleBackColor = true;
            this.signup_showPwd.CheckedChanged += new System.EventHandler(this.signup_showPwd_CheckedChanged);
            // 
            // signupReg_btn
            // 
            this.signupReg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signupReg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupReg_btn.FlatAppearance.BorderSize = 0;
            this.signupReg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.signupReg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.signupReg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupReg_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupReg_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupReg_btn.Location = new System.Drawing.Point(283, 296);
            this.signupReg_btn.Name = "signupReg_btn";
            this.signupReg_btn.Size = new System.Drawing.Size(103, 39);
            this.signupReg_btn.TabIndex = 15;
            this.signupReg_btn.Text = "SIGNUP";
            this.signupReg_btn.UseVisualStyleBackColor = false;
            this.signupReg_btn.Click += new System.EventHandler(this.signupReg_btn_Click);
            // 
            // signup_pwd
            // 
            this.signup_pwd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pwd.Location = new System.Drawing.Point(283, 210);
            this.signup_pwd.Multiline = true;
            this.signup_pwd.Name = "signup_pwd";
            this.signup_pwd.PasswordChar = '*';
            this.signup_pwd.Size = new System.Drawing.Size(250, 30);
            this.signup_pwd.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password :";
            // 
            // signup_uname
            // 
            this.signup_uname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_uname.Location = new System.Drawing.Point(283, 131);
            this.signup_uname.Multiline = true;
            this.signup_uname.Name = "signup_uname";
            this.signup_uname.Size = new System.Drawing.Size(250, 30);
            this.signup_uname.TabIndex = 12;
            this.signup_uname.TextChanged += new System.EventHandler(this.signup_uname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(553, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.loginReg_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 400);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::radPractical.Properties.Resources.Employee100;
            this.pictureBox1.Location = new System.Drawing.Point(81, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Employee Managment System";
            // 
            // loginReg_btn
            // 
            this.loginReg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.loginReg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginReg_btn.FlatAppearance.BorderSize = 0;
            this.loginReg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.loginReg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.loginReg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginReg_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginReg_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginReg_btn.Location = new System.Drawing.Point(11, 348);
            this.loginReg_btn.Name = "loginReg_btn";
            this.loginReg_btn.Size = new System.Drawing.Size(229, 39);
            this.loginReg_btn.TabIndex = 8;
            this.loginReg_btn.Text = "SIGN IN";
            this.loginReg_btn.UseVisualStyleBackColor = false;
            this.loginReg_btn.Click += new System.EventHandler(this.loginReg_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(55, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aleady have a Account ?";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.signup_showPwd);
            this.Controls.Add(this.signupReg_btn);
            this.Controls.Add(this.signup_pwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_uname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox signup_showPwd;
        private System.Windows.Forms.Button signupReg_btn;
        private System.Windows.Forms.TextBox signup_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_uname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginReg_btn;
        private System.Windows.Forms.Label label5;
    }
}