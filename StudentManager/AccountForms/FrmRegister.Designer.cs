namespace StudentManager
{
    partial class FrmRegister
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
            this.components = new System.ComponentModel.Container();
            this.btnLoginOfRegisterForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegisterOfRegisterForm = new System.Windows.Forms.Button();
            this.btnCancelOfRegisterForm = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNoticeRegister = new System.Windows.Forms.Label();
            this.errorProviderRegister = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblForgetPasswordNotice = new System.Windows.Forms.Label();
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.txtUserOTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistedEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginOfRegisterForm
            // 
            this.btnLoginOfRegisterForm.FlatAppearance.BorderSize = 0;
            this.btnLoginOfRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginOfRegisterForm.Font = new System.Drawing.Font("Calibri Light", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginOfRegisterForm.Location = new System.Drawing.Point(611, 629);
            this.btnLoginOfRegisterForm.Name = "btnLoginOfRegisterForm";
            this.btnLoginOfRegisterForm.Size = new System.Drawing.Size(78, 32);
            this.btnLoginOfRegisterForm.TabIndex = 4;
            this.btnLoginOfRegisterForm.Text = "Login";
            this.btnLoginOfRegisterForm.UseVisualStyleBackColor = true;
            this.btnLoginOfRegisterForm.Click += new System.EventHandler(this.btnLoginOfRegisterForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Already have an account?";
            // 
            // btnRegisterOfRegisterForm
            // 
            this.btnRegisterOfRegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnRegisterOfRegisterForm.FlatAppearance.BorderSize = 0;
            this.btnRegisterOfRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterOfRegisterForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterOfRegisterForm.ForeColor = System.Drawing.Color.White;
            this.btnRegisterOfRegisterForm.Location = new System.Drawing.Point(363, 716);
            this.btnRegisterOfRegisterForm.Name = "btnRegisterOfRegisterForm";
            this.btnRegisterOfRegisterForm.Size = new System.Drawing.Size(145, 56);
            this.btnRegisterOfRegisterForm.TabIndex = 3;
            this.btnRegisterOfRegisterForm.Text = "Register";
            this.btnRegisterOfRegisterForm.UseVisualStyleBackColor = false;
            this.btnRegisterOfRegisterForm.Click += new System.EventHandler(this.btnRegisterOfRegisterForm_Click);
            // 
            // btnCancelOfRegisterForm
            // 
            this.btnCancelOfRegisterForm.BackColor = System.Drawing.Color.Gray;
            this.btnCancelOfRegisterForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelOfRegisterForm.FlatAppearance.BorderSize = 0;
            this.btnCancelOfRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOfRegisterForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOfRegisterForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelOfRegisterForm.Location = new System.Drawing.Point(595, 716);
            this.btnCancelOfRegisterForm.Name = "btnCancelOfRegisterForm";
            this.btnCancelOfRegisterForm.Size = new System.Drawing.Size(145, 56);
            this.btnCancelOfRegisterForm.TabIndex = 5;
            this.btnCancelOfRegisterForm.Text = "Cancel";
            this.btnCancelOfRegisterForm.UseVisualStyleBackColor = false;
            this.btnCancelOfRegisterForm.Click += new System.EventHandler(this.btnCancelOfRegisterForm_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(678, 457);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(377, 31);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(674, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter password";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.Location = new System.Drawing.Point(678, 368);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(377, 31);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(674, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(467, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManager.Properties.Resources.LOGO_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(450, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyPassword.Location = new System.Drawing.Point(678, 551);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '*';
            this.txtVerifyPassword.Size = new System.Drawing.Size(377, 31);
            this.txtVerifyPassword.TabIndex = 2;
            this.txtVerifyPassword.TextChanged += new System.EventHandler(this.txtVerifyPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(674, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Verify your password";
            // 
            // lblNoticeRegister
            // 
            this.lblNoticeRegister.AutoSize = true;
            this.lblNoticeRegister.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeRegister.Location = new System.Drawing.Point(43, 801);
            this.lblNoticeRegister.Name = "lblNoticeRegister";
            this.lblNoticeRegister.Size = new System.Drawing.Size(0, 21);
            this.lblNoticeRegister.TabIndex = 0;
            // 
            // errorProviderRegister
            // 
            this.errorProviderRegister.ContainerControl = this;
            // 
            // lblForgetPasswordNotice
            // 
            this.lblForgetPasswordNotice.AutoSize = true;
            this.lblForgetPasswordNotice.Location = new System.Drawing.Point(72, 507);
            this.lblForgetPasswordNotice.Name = "lblForgetPasswordNotice";
            this.lblForgetPasswordNotice.Size = new System.Drawing.Size(147, 16);
            this.lblForgetPasswordNotice.TabIndex = 33;
            this.lblForgetPasswordNotice.Text = "Forget password notice";
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.BackColor = System.Drawing.Color.Green;
            this.btnVerifyOTP.FlatAppearance.BorderSize = 0;
            this.btnVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyOTP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyOTP.ForeColor = System.Drawing.Color.White;
            this.btnVerifyOTP.Location = new System.Drawing.Point(441, 454);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(135, 31);
            this.btnVerifyOTP.TabIndex = 32;
            this.btnVerifyOTP.Text = "Verify";
            this.btnVerifyOTP.UseVisualStyleBackColor = false;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Green;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(441, 368);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(135, 31);
            this.btnSendCode.TabIndex = 31;
            this.btnSendCode.Text = "Send code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtUserOTP
            // 
            this.txtUserOTP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserOTP.Location = new System.Drawing.Point(68, 453);
            this.txtUserOTP.Name = "txtUserOTP";
            this.txtUserOTP.Size = new System.Drawing.Size(318, 31);
            this.txtUserOTP.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(71, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "OTP code";
            // 
            // txtRegistedEmail
            // 
            this.txtRegistedEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistedEmail.Location = new System.Drawing.Point(68, 368);
            this.txtRegistedEmail.Name = "txtRegistedEmail";
            this.txtRegistedEmail.Size = new System.Drawing.Size(318, 31);
            this.txtRegistedEmail.TabIndex = 0;
            this.txtRegistedEmail.TextChanged += new System.EventHandler(this.txtForgetPasswordEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(64, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Your email";
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegisterOfRegisterForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelOfRegisterForm;
            this.ClientSize = new System.Drawing.Size(1162, 803);
            this.Controls.Add(this.lblForgetPasswordNotice);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtUserOTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRegistedEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNoticeRegister);
            this.Controls.Add(this.txtVerifyPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoginOfRegisterForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegisterOfRegisterForm);
            this.Controls.Add(this.btnCancelOfRegisterForm);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginOfRegisterForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterOfRegisterForm;
        private System.Windows.Forms.Button btnCancelOfRegisterForm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNoticeRegister;
        private System.Windows.Forms.ErrorProvider errorProviderRegister;
        private System.Windows.Forms.Label lblForgetPasswordNotice;
        private System.Windows.Forms.Button btnVerifyOTP;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox txtUserOTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistedEmail;
        private System.Windows.Forms.Label label7;
    }
}