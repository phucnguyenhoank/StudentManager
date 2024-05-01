using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace StudentManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegister frmRegister = new FrmRegister();
                frmRegister.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[btnRegister_Click:{ex.Message}]");
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDAL accountDAL = new AccountDAL();
                bool haveAccount = accountDAL.HaveAccount(txtUsername.Text, txtPassword.Text);
                Account loginAccount = accountDAL.GetAccountByUsername(txtUsername.Text);

                if (haveAccount)
                {
                    if (loginAccount.IsAdmin)
                    {
                        lblNoticeLogin.Text = "Login successfully";
                        lblNoticeLogin.ForeColor = Color.Green;
                        AccountConst.account = loginAccount;
                        DialogResult = DialogResult.OK;
                    }
                    else if (rbtnStudent.Checked && accountDAL.GetAccountByUsername(txtUsername.Text).Type == AccountConst.Student)
                    {
                        lblNoticeLogin.Text = "Login successfully";
                        lblNoticeLogin.ForeColor = Color.Green;
                        AccountConst.account = loginAccount;
                        DialogResult = DialogResult.OK;
                    }
                    else if (rbtnHumResManager.Checked && accountDAL.GetAccountByUsername(txtUsername.Text).Type == AccountConst.HumanResources)
                    {
                        lblNoticeLogin.Text = "Login successfully";
                        lblNoticeLogin.ForeColor = Color.Green;
                        AccountConst.account = loginAccount;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        lblNoticeLogin.Text = "Login Rejected";
                        lblNoticeLogin.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblNoticeLogin.Text = "Invalid username or password";
                    lblNoticeLogin.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[btnLogin_Click:{ex.Message}]");
            }

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                FrmForgetPassword frmFgPassword = new FrmForgetPassword();
                frmFgPassword.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[btnForgetPassword_Click:{ex.Message}]");
            }
            

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            rbtnStudent.Checked = true;
        }
    }
}
