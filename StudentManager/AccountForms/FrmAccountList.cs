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
    public partial class FrmAccountList : Form
    {

        public FrmAccountList()
        {
            InitializeComponent();
        }

        private void frmAccountList_Load(object sender, EventArgs e)
        {

            AccountDAL accountDAL = new AccountDAL();

            dataGridViewAccountList.DataSource = accountDAL.GetAccountList();
            dataGridViewAccountList.Columns["username"].HeaderText = "Tài khoản";
            dataGridViewAccountList.Columns["hashedPassword"].HeaderText = "Mật khẩu";
            dataGridViewAccountList.Columns["email"].HeaderText = "Email";
            dataGridViewAccountList.Columns["type"].HeaderText = "Loại tài khoản";

            dataGridViewAccountList.Columns["hashedPassword"].ReadOnly = true;
            dataGridViewAccountList.Columns["type"].ReadOnly = true;

        }



        /*

        private void dataGridViewAccountList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
            // Bắt sự kiện khi giá trị của cell thay đổi
            if (e.ColumnIndex == dataGridViewAccountList.Columns["isAdmin"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridViewAccountList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isAdmin = Convert.ToBoolean(cell.Value);
                string username = dataGridViewAccountList.Rows[e.RowIndex].Cells["username"].Value.ToString();

                MessageBox.Show($"Giá trị IsAdmin của người dùng {username} đã thay đổi thành: {isAdmin}");
            }
            

        }
        */


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDAL accountDAL = new AccountDAL();

                // Duyệt qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in dataGridViewAccountList.Rows)
                {
                    // Lấy giá trị của các cột từ DataGridViewRow
                    string username = row.Cells["username"].Value.ToString();
                    string hashedPassword = row.Cells["hashedPassword"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();
                    bool isAdmin = Convert.ToBoolean(row.Cells["isAdmin"].Value);
                    string type = row.Cells["type"].Value.ToString();

                    // Tạo đối tượng Account mới từ các giá trị lấy được
                    Account account = new Account(username, hashedPassword, email, isAdmin, type);

                    // Cập nhật thông tin tài khoản vào cơ sở dữ liệu
                    if (!accountDAL.UpdateAccount(account))
                    {
                        MessageBox.Show($"Không thể cập nhật thông tin tài khoản cho {username}");
                    }
                }

                MessageBox.Show("Saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnSaveChanges_Click: {ex.Message}");
            }
        }

        private void dataGridViewAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một ô trong cột 'type'
            if (e.ColumnIndex >= 0 && dataGridViewAccountList.Columns[e.ColumnIndex].Name == "type")
            {
                // Hiển thị form chọn loại tài khoản
                using (var form = new Form())
                {
                    form.Text = "Chọn loại tài khoản";
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Size = new Size(300, 150);

                    // Tạo ComboBox để người dùng chọn
                    ComboBox comboBoxType = new ComboBox();
                    
                    comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxType.Items.Add(AccountConst.Student);
                    comboBoxType.Items.Add(AccountConst.HumanResources);
                    comboBoxType.SelectedIndex = 0; // Chọn giá trị đầu tiên làm mặc định
                    comboBoxType.Size = new Size(150, 25); // Đặt kích thước của ComboBox
                    comboBoxType.Location = new Point(70, 20); // Đặt vị trí của ComboBox trong form


                    // Thêm ComboBox vào form
                    form.Controls.Add(comboBoxType);

                    // Tạo nút OK để người dùng xác nhận
                    Button buttonOK = new Button();
                    buttonOK.Text = "OK/Cancel";
                    buttonOK.DialogResult = DialogResult.OK;
                    buttonOK.Size = new Size(80, 30); // Đặt kích thước của nút OK
                    buttonOK.Location = new Point(120, 50); // Đặt vị trí của nút OK trong form


                    // Thêm sự kiện click cho nút OK để cập nhật giá trị vào ô trong DataGridView
                    buttonOK.Click += (s, args) =>
                    {
                        // Lấy giá trị được chọn từ ComboBox
                        string selectedType = comboBoxType.SelectedItem?.ToString();

                        // Kiểm tra nếu người dùng đã chọn giá trị
                        if (!string.IsNullOrEmpty(selectedType))
                        {
                            // Cập nhật giá trị của ô trong cột 'type' với giá trị được chọn
                            dataGridViewAccountList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = selectedType;
                        }

                        // Đóng form
                        form.Close();
                    };

                    // Thêm nút OK vào form
                    form.Controls.Add(buttonOK);

                    // Hiển thị form dưới dạng dialog
                    form.ShowDialog();
                }
            }
        }
    }
}
