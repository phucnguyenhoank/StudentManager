namespace StudentManager
{
    partial class FrmResetPassword
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
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnCancelResetPasswordForm = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVerifyNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProviderResetPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderResetPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Green;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(58, 400);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(184, 36);
            this.btnResetPassword.TabIndex = 34;
            this.btnResetPassword.Text = "Reset password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnCancelResetPasswordForm
            // 
            this.btnCancelResetPasswordForm.BackColor = System.Drawing.Color.Gray;
            this.btnCancelResetPasswordForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelResetPasswordForm.FlatAppearance.BorderSize = 0;
            this.btnCancelResetPasswordForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelResetPasswordForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelResetPasswordForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelResetPasswordForm.Location = new System.Drawing.Point(312, 400);
            this.btnCancelResetPasswordForm.Name = "btnCancelResetPasswordForm";
            this.btnCancelResetPasswordForm.Size = new System.Drawing.Size(135, 36);
            this.btnCancelResetPasswordForm.TabIndex = 31;
            this.btnCancelResetPasswordForm.Text = "Cancel";
            this.btnCancelResetPasswordForm.UseVisualStyleBackColor = false;
            this.btnCancelResetPasswordForm.Click += new System.EventHandler(this.btnCancelResetPasswordForm_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(63, 202);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(389, 31);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Your new password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(165, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 54);
            this.label1.TabIndex = 29;
            this.label1.Text = "Reset Your Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManager.Properties.Resources.LOGO_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(546, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtVerifyNewPassword
            // 
            this.txtVerifyNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyNewPassword.Location = new System.Drawing.Point(63, 314);
            this.txtVerifyNewPassword.Name = "txtVerifyNewPassword";
            this.txtVerifyNewPassword.PasswordChar = '*';
            this.txtVerifyNewPassword.Size = new System.Drawing.Size(384, 31);
            this.txtVerifyNewPassword.TabIndex = 35;
            this.txtVerifyNewPassword.TextChanged += new System.EventHandler(this.txtVerifyNewPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(59, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Verify your new password";
            // 
            // errorProviderResetPassword
            // 
            this.errorProviderResetPassword.ContainerControl = this;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 532);
            this.Controls.Add(this.txtVerifyNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnCancelResetPasswordForm);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmResetPassword";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.frmResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderResetPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnCancelResetPasswordForm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVerifyNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProviderResetPassword;
    }
}