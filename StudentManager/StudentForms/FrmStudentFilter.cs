using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace StudentManager
{
    public partial class FrmStudentFilter : Form
    {
        public FrmStudentFilter()
        {
            InitializeComponent();

        }


        private DataTable filteredData;

        public DataTable FilteredData
        {
            get { return filteredData; }
        }
        
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {

                string studentID = txtStudentIDFilter.Text;
                string firstStudentName = txtStudentFirstNameFilter.Text;
                string lastStudentName = txtStudentLastNameFilter.Text;
                string phoneNumber = txtStudentPhoneNumberFilter.Text;
                DateTime studentBirthday = dtpStudentBirthdayFilter.Value.Date;
                string gender = (radioBtnStudentGenderFilter.Checked) ? "Male" : ((radioBtnBothGender.Checked) ? "" : "Female");
                string address = txtStudentAddressFilter.Text;


                StudentDAL studentDAL = new StudentDAL();
                filteredData = studentDAL.GetStudentFilterResult(studentID, firstStudentName, lastStudentName, phoneNumber, studentBirthday, gender, address);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnApplyFilter_Click:{ex.Message}");
            }


        }

        private void btnCancelStudentFilter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmStudentFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
