namespace StudentManager
{
    partial class FrmForgetPassword
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
            this.btnCancelForgerPasswordForm = new System.Windows.Forms.Button();
            this.txtUserOTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForgetPasswordEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderForgetPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForgetPasswordNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForgetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelForgerPasswordForm
            // 
            this.btnCancelForgerPasswordForm.BackColor = System.Drawing.Color.Gray;
            this.btnCancelForgerPasswordForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelForgerPasswordForm.FlatAppearance.BorderSize = 0;
            this.btnCancelForgerPasswordForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelForgerPasswordForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForgerPasswordForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelForgerPasswordForm.Location = new System.Drawing.Point(228, 404);
            this.btnCancelForgerPasswordForm.Name = "btnCancelForgerPasswordForm";
            this.btnCancelForgerPasswordForm.Size = new System.Drawing.Size(135, 36);
            this.btnCancelForgerPasswordForm.TabIndex = 22;
            this.btnCancelForgerPasswordForm.Text = "Cancel";
            this.btnCancelForgerPasswordForm.UseVisualStyleBackColor = false;
            this.btnCancelForgerPasswordForm.Click += new System.EventHandler(this.btnCancelForgerPasswordForm_Click);
            // 
            // txtUserOTP
            // 
            this.txtUserOTP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserOTP.Location = new System.Drawing.Point(64, 278);
            this.txtUserOTP.Name = "txtUserOTP";
            this.txtUserOTP.Size = new System.Drawing.Size(267, 31);
            this.txtUserOTP.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(67, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "OTP code";
            // 
            // txtForgetPasswordEmail
            // 
            this.txtForgetPasswordEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgetPasswordEmail.Location = new System.Drawing.Point(64, 193);
            this.txtForgetPasswordEmail.Name = "txtForgetPasswordEmail";
            this.txtForgetPasswordEmail.Size = new System.Drawing.Size(267, 31);
            this.txtForgetPasswordEmail.TabIndex = 15;
            this.txtForgetPasswordEmail.TextChanged += new System.EventHandler(this.txtForgetPasswordEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(114, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Forget Password";
            // 
            // errorProviderForgetPassword
            // 
            this.errorProviderForgetPassword.ContainerControl = this;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Green;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(379, 192);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(135, 31);
            this.btnSendCode.TabIndex = 24;
            this.btnSendCode.Text = "Send code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.BackColor = System.Drawing.Color.Green;
            this.btnVerifyOTP.FlatAppearance.BorderSize = 0;
            this.btnVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyOTP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyOTP.ForeColor = System.Drawing.Color.White;
            this.btnVerifyOTP.Location = new System.Drawing.Point(379, 278);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(135, 31);
            this.btnVerifyOTP.TabIndex = 25;
            this.btnVerifyOTP.Text = "Verify";
            this.btnVerifyOTP.UseVisualStyleBackColor = false;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManager.Properties.Resources.LOGO_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(631, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblForgetPasswordNotice
            // 
            this.lblForgetPasswordNotice.AutoSize = true;
            this.lblForgetPasswordNotice.Location = new System.Drawing.Point(68, 332);
            this.lblForgetPasswordNotice.Name = "lblForgetPasswordNotice";
            this.lblForgetPasswordNotice.Size = new System.Drawing.Size(147, 16);
            this.lblForgetPasswordNotice.TabIndex = 26;
            this.lblForgetPasswordNotice.Text = "Forget password notice";
            // 
            // FrmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 519);
            this.Controls.Add(this.lblForgetPasswordNotice);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.btnCancelForgerPasswordForm);
            this.Controls.Add(this.txtUserOTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtForgetPasswordEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmForgetPassword";
            this.Text = "Forget password";
            this.Load += new System.EventHandler(this.frmForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForgetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelForgerPasswordForm;
        private System.Windows.Forms.TextBox txtUserOTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForgetPasswordEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderForgetPassword;
        private System.Windows.Forms.Button btnVerifyOTP;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblForgetPasswordNotice;
    }
}