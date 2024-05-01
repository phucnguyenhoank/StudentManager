using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManager.TeachForms
{
    public partial class FrmAddTeach : Form
    {
        public FrmAddTeach()
        {
            InitializeComponent();
        }

        private void LoadDataToComboBox()
        {
            ContactDAL contactDAL = new ContactDAL();
            cbContactID.Items.Clear();
            cbContactID.DataSource = contactDAL.GetContactsAsDataTable();
            cbContactID.DisplayMember = "contactID";
            cbContactID.ValueMember = "contactID";
            cbContactID.SelectedIndex = 0;


            CourseDAL courseDAL = new CourseDAL();
            cbCourseID.Items.Clear();
            cbCourseID.DataSource = courseDAL.GetCourseList();
            cbCourseID.DisplayMember = "courseID";
            cbCourseID.ValueMember = "courseID";
            cbCourseID.SelectedIndex = 0;

        }

        private void FrmAddTeach_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
            txtTeachID_TextChanged(txtTeachID, e);
            cbContactID_SelectedIndexChanged(sender, e);
            cbCourseID_SelectedIndexChanged(sender , e);
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            TeachDAL teachDAL = new TeachDAL();
            if (string.IsNullOrWhiteSpace(txtTeachID.Text))
            {
                erprvAddTeach.SetError(txtTeachID, "This field is required.");
                isValid = false;
            }
            else if (teachDAL.IsTeachExist(txtTeachID.Text))
            {
                erprvAddTeach.SetError(txtTeachID, "TeachID already exists.");
                isValid = false;
            }
            else
            {
                erprvAddTeach.SetError(txtTeachID, string.Empty); // Clear error if text is not empty
            }


            if (cbContactID.SelectedItem is DataRowView selectedContactRow && cbCourseID.SelectedItem is DataRowView selectedCourseRow)
            {

                string contactID = selectedContactRow["contactID"].ToString();
                string courseID = selectedCourseRow["courseID"].ToString();

                if (teachDAL.IsTeachExist(contactID, courseID))
                {
                    erprvAddTeach.SetError(cbContactID, "Khóa học tồn tại");
                    erprvAddTeach.SetError(cbCourseID, "Khóa học tồn tại");
                    isValid = false;
                }
                else
                {
                    erprvAddTeach.SetError(cbContactID, "");
                    erprvAddTeach.SetError(cbCourseID, "");
                }
            }


            return isValid;

        }

        private void btnAddTeach_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbContactID.SelectedItem != null && cbCourseID.SelectedItem != null && cbContactID.SelectedItem is DataRowView && cbCourseID.SelectedItem is DataRowView)
                {
                    DataRowView selectedContactRow = cbContactID.SelectedItem as DataRowView;
                    DataRowView selectedCourseRow = cbCourseID.SelectedItem as DataRowView;

                    string contactID = selectedContactRow["contactID"].ToString();
                    string courseID = selectedCourseRow["courseID"].ToString();


                    TeachDAL teachDAL = new TeachDAL();
                    if (!ValidateInputs())
                    {
                        MessageBox.Show("Thông tin thêm không hợp lệ");
                    }
                    else
                    {
                        teachDAL.CreateTeach(new Teach(txtTeachID.Text, contactID, courseID));
                        MessageBox.Show("Thêm dạy học thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAddTeach_Click:{ex.Message}");
            }
        }

        private void txtTeachID_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();

        }

        private void cbContactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void cbCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInputs();

        }

    }
}
