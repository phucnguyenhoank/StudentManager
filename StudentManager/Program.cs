using StudentManager.ContactForms;
using StudentManager.DepartmentForms;
using StudentManager.StudentForms;
using StudentManager.TeachForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*


CẦN SỬA:

- STUDENT
- nút export trong student list: ngày sinh dính giờ, SĐT mất số 0 ở đầu
- 


 */

namespace StudentManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            while (true)
            {
                FrmLogin loginForm = new FrmLogin();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    break;
                }

                if (AccountConst.account.IsAdmin)
                {
                    FrmFunctionSelector functionSelectorForm = new FrmFunctionSelector();
                    functionSelectorForm.ShowDialog();
                }
                else
                {
                    switch (AccountConst.account.Type)
                    {
                        case AccountConst.Student:
                            FrmStudentSelector studentSelectorForm = new FrmStudentSelector();
                            studentSelectorForm.ShowDialog();
                            break;
                        case AccountConst.HumanResources:
                            FrmHumanResourcesManagerSelector frmHumanResourcesManagerSelector = new FrmHumanResourcesManagerSelector();
                            frmHumanResourcesManagerSelector.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Unexpected Type of Account");
                            break;
                    }
                }
            }
            



        }
    }
}
