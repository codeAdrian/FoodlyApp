namespace FoodlyApp
{
    partial class foodlyLogin
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
            this.b_exit = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.Button();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.group_account = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_loginLoading = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pbx_loginLogo = new System.Windows.Forms.PictureBox();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.group_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loginLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_exit.ForeColor = System.Drawing.Color.Black;
            this.b_exit.Location = new System.Drawing.Point(179, 314);
            this.b_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(93, 35);
            this.b_exit.TabIndex = 0;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_login
            // 
            this.b_login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_login.ForeColor = System.Drawing.Color.Black;
            this.b_login.Location = new System.Drawing.Point(127, 147);
            this.b_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(106, 38);
            this.b_login.TabIndex = 1;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_username.Location = new System.Drawing.Point(26, 47);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(207, 27);
            this.tbx_username.TabIndex = 2;
            this.tbx_username.Text = "mojRestoran";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_password.Location = new System.Drawing.Point(24, 109);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '●';
            this.tbx_password.Size = new System.Drawing.Size(207, 27);
            this.tbx_password.TabIndex = 3;
            this.tbx_password.Text = "mojRestoran";
            // 
            // group_account
            // 
            this.group_account.BackColor = System.Drawing.Color.Orange;
            this.group_account.Controls.Add(this.label1);
            this.group_account.Controls.Add(this.pbx_loginLoading);
            this.group_account.Controls.Add(this.lbl_username);
            this.group_account.Controls.Add(this.tbx_username);
            this.group_account.Controls.Add(this.b_login);
            this.group_account.Controls.Add(this.tbx_password);
            this.group_account.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.group_account.ForeColor = System.Drawing.Color.Maroon;
            this.group_account.Location = new System.Drawing.Point(12, 103);
            this.group_account.Name = "group_account";
            this.group_account.Size = new System.Drawing.Size(260, 191);
            this.group_account.TabIndex = 4;
            this.group_account.TabStop = false;
            this.group_account.Text = "Foodly Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // pbx_loginLoading
            // 
            this.pbx_loginLoading.Location = new System.Drawing.Point(24, 160);
            this.pbx_loginLoading.Name = "pbx_loginLoading";
            this.pbx_loginLoading.Size = new System.Drawing.Size(92, 22);
            this.pbx_loginLoading.TabIndex = 6;
            this.pbx_loginLoading.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(21, 27);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(78, 20);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // pbx_loginLogo
            // 
            this.pbx_loginLogo.BackgroundImage = global::FoodlyApp.foodlyImages.foodly_banner;
            this.pbx_loginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_loginLogo.Location = new System.Drawing.Point(12, 12);
            this.pbx_loginLogo.Name = "pbx_loginLogo";
            this.pbx_loginLogo.Size = new System.Drawing.Size(260, 80);
            this.pbx_loginLogo.TabIndex = 5;
            this.pbx_loginLogo.TabStop = false;
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_instructions.Location = new System.Drawing.Point(9, 314);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(164, 34);
            this.lbl_instructions.TabIndex = 7;
            this.lbl_instructions.Text = "Use your Foodly Account\r\nto log in to your database.";
            // 
            // foodlyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.pbx_loginLogo);
            this.Controls.Add(this.group_account);
            this.Controls.Add(this.b_exit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "foodlyLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foodly - Log in";
            this.group_account.ResumeLayout(false);
            this.group_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loginLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.GroupBox group_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pbx_loginLogo;
        private System.Windows.Forms.PictureBox pbx_loginLoading;
        private System.Windows.Forms.Label lbl_instructions;
    }
}

