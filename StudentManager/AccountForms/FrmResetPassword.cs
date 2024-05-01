using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmResetPassword : Form
    {
        private string accountEmail;
        public FrmResetPassword(string accountEmail)
        {
            InitializeComponent();
            this.accountEmail = accountEmail;
        }

        private void btnCancelResetPasswordForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (ErrorProviderHaveError(this.errorProviderResetPassword))
            {
                MessageBox.Show("Please enter valid information");
                return;
            }

            try
            {
                AccountDAL accountDAL = new AccountDAL();
                accountDAL.UpdatePassword(accountEmail, txtNewPassword.Text);
                MessageBox.Show("Reset password successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnResetPassword_Click:{ex.Message}");
            }

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProviderResetPassword.SetError(txtNewPassword, "do not let empty");
            }
            else if (txtNewPassword.Text.Length < 6)
            {
                errorProviderResetPassword.SetError(txtNewPassword, "number of character must at least 6");
            }
            else
            {
                errorProviderResetPassword.SetError(txtNewPassword, "");
            }
        }

        private void txtVerifyNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVerifyNewPassword.Text))
            {
                errorProviderResetPassword.SetError(txtVerifyNewPassword, "do not let empty");
            }
            else if (!txtVerifyNewPassword.Text.Equals(txtNewPassword.Text))
            {
                errorProviderResetPassword.SetError(txtVerifyNewPassword, "not match");
            }
            else
            {
                errorProviderResetPassword.SetError(txtVerifyNewPassword, "");
            }
        }

        private bool ErrorProviderHaveError(ErrorProvider checkedEP)
        {
            bool hasErrors = false;

            foreach (Control control in this.Controls) // Duyệt qua tất cả các control trong form
            {
                if (!string.IsNullOrEmpty(checkedEP.GetError(control))) // Kiểm tra xem có lỗi được báo không
                {
                    hasErrors = true;
                    break; // Nếu tìm thấy lỗi, thoát khỏi vòng lặp
                }
            }

            return hasErrors;
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword_TextChanged(sender, e);
            txtVerifyNewPassword_TextChanged(sender, e);
        }
    }
}
