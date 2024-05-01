
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace StudentManager
{
    public partial class FrmRegister : Form
    {
        private EmailVerificationService evs;

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnCancelOfRegisterForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterOfRegisterForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorProviderHaveError(errorProviderRegister))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ", "Lỗi dữ liệu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AccountDAL accountDAL = new AccountDAL();
                Account account = new Account(txtNewUsername.Text, accountDAL.HashPassword(txtNewPassword.Text), txtRegistedEmail.Text, false, "student");

                accountDAL.AddAccount(account);
                MessageBox.Show("Register successfully", "Message", MessageBoxButtons.OK);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"btnRegisterOfRegisterForm_Click:{ex.Message}");
            }

        }

        private void btnLoginOfRegisterForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool ErrorProviderHaveError(ErrorProvider checkedEP)
        {
            bool hasErrors = false;

            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(checkedEP.GetError(control))) 
                {
                    hasErrors = true;
                    break;
                }
            }

            return hasErrors;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtUserOTP.ReadOnly = true;
            btnVerifyOTP.Enabled = false;
            txtNewUsername.ReadOnly = true;
            txtNewPassword.ReadOnly = true;
            txtVerifyPassword.ReadOnly = true;
            btnRegisterOfRegisterForm.Enabled = false;

            txtForgetPasswordEmail_TextChanged(sender, e);
            txtNewUsername_TextChanged(sender, e);
            txtNewPassword_TextChanged(sender, e);
            txtVerifyPassword_TextChanged(sender, e);
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(errorProviderRegister.GetError(txtRegistedEmail)))
            {
                MessageBox.Show("Invalid email", "Message", MessageBoxButtons.OK);
                return;
            }
            txtRegistedEmail.ReadOnly = true;
            btnSendCode.Enabled = false;

            lblForgetPasswordNotice.Text = "Sending...";
            lblForgetPasswordNotice.ForeColor = System.Drawing.Color.Yellow;

            evs = new EmailVerificationService();
            if (await Task.Run(() => evs.SendOTP(txtRegistedEmail.Text)))
            {
                lblForgetPasswordNotice.Text = "Send OTP successfully";
                lblForgetPasswordNotice.ForeColor = System.Drawing.Color.Green;

                txtUserOTP.ReadOnly = false;
                btnVerifyOTP.Enabled = true;
            }
            else
            {
                lblForgetPasswordNotice.Text = "Send OTP fail";
                lblForgetPasswordNotice.ForeColor = System.Drawing.Color.Red;
                txtRegistedEmail.ReadOnly = false;
            }

            btnSendCode.Enabled = true;
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            if (evs.VerifyOTP(txtUserOTP.Text))
            {
                lblForgetPasswordNotice.Text = "Verify successfully";
                lblForgetPasswordNotice.ForeColor = System.Drawing.Color.Green;

                txtRegistedEmail.ReadOnly = true;
                btnSendCode.Enabled = false;
                txtUserOTP.ReadOnly = true;
                btnVerifyOTP.Enabled = false;

                txtNewUsername.ReadOnly = false;
                txtNewPassword.ReadOnly = false;
                txtVerifyPassword.ReadOnly = false;
                btnRegisterOfRegisterForm.Enabled = true;

            }
            else
            {
                lblForgetPasswordNotice.Text = "Verify failed";
                lblForgetPasswordNotice.ForeColor = System.Drawing.Color.Red;
                txtUserOTP.ReadOnly = true;
                btnVerifyOTP.Enabled = false;
            }
        }

        private void txtForgetPasswordEmail_TextChanged(object sender, EventArgs e)
        {
            this.btnSendCode.Enabled = false;
            AccountDAL accountDAL = new AccountDAL();

            if (String.IsNullOrEmpty(txtRegistedEmail.Text))
            {
                errorProviderRegister.SetError(txtRegistedEmail, "do not let empty");
            }
            else if (accountDAL.HaveEmail(txtRegistedEmail.Text))
            {
                errorProviderRegister.SetError(txtRegistedEmail, "this email is already used for registration");
            }
            else
            {
                errorProviderRegister.SetError(txtRegistedEmail, "");
                this.btnSendCode.Enabled = true;
            }
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            AccountDAL accountDAL = new AccountDAL();

            if (String.IsNullOrEmpty(txtNewUsername.Text))
            {
                errorProviderRegister.SetError(txtNewUsername, "do not let empty");
            }
            else if (accountDAL.HaveUsername(txtNewUsername.Text))
            {
                errorProviderRegister.SetError(txtNewUsername, "the account is already existed");
            }
            else if (txtNewUsername.Text.Length < 6)
            {
                errorProviderRegister.SetError(txtNewUsername, "user name must at least 6 characters");
            }
            else
            {
                errorProviderRegister.SetError(txtNewUsername, "");
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProviderRegister.SetError(txtNewPassword, "do not let empty");
            }
            else if (txtNewPassword.Text.Length < 6)
            {
                errorProviderRegister.SetError(txtNewPassword, "password must at least 6 characters");
            }
            else
            {
                errorProviderRegister.SetError(txtNewPassword, "");
            }
        }

        private void txtVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtVerifyPassword.Text))
            {
                errorProviderRegister.SetError(txtVerifyPassword, "do not let empty");
            }
            else if (!txtVerifyPassword.Text.Equals(txtNewPassword.Text))
            {
                errorProviderRegister.SetError(txtVerifyPassword, "not match");
            }
            else
            {
                errorProviderRegister.SetError(txtVerifyPassword, "");
            }
        }
    }
}
