namespace StudentManager
{
    partial class FrmEditRemoveStudent
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
            this.btnUploadStudentPicture = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditStudentAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEditStudentBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEditStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentLastname = new System.Windows.Forms.Label();
            this.lblNoticeLogin = new System.Windows.Forms.Label();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnCancelEditStudent = new System.Windows.Forms.Button();
            this.txtEditStudentFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.rbtnEditStudentGenderMale = new System.Windows.Forms.RadioButton();
            this.picboxEditStudentImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnEditStudentGenderFemale = new System.Windows.Forms.RadioButton();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.grboxGender = new System.Windows.Forms.GroupBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEditStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.grboxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadStudentPicture
            // 
            this.btnUploadStudentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnUploadStudentPicture.FlatAppearance.BorderSize = 0;
            this.btnUploadStudentPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadStudentPicture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadStudentPicture.ForeColor = System.Drawing.Color.White;
            this.btnUploadStudentPicture.Location = new System.Drawing.Point(962, 559);
            this.btnUploadStudentPicture.Name = "btnUploadStudentPicture";
            this.btnUploadStudentPicture.Size = new System.Drawing.Size(127, 37);
            this.btnUploadStudentPicture.TabIndex = 37;
            this.btnUploadStudentPicture.Text = "Upload";
            this.btnUploadStudentPicture.UseVisualStyleBackColor = false;
            this.btnUploadStudentPicture.Click += new System.EventHandler(this.btnUploadStudentPicture_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(667, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Picture:";
            // 
            // txtEditStudentAddress
            // 
            this.txtEditStudentAddress.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStudentAddress.Location = new System.Drawing.Point(243, 531);
            this.txtEditStudentAddress.Multiline = true;
            this.txtEditStudentAddress.Name = "txtEditStudentAddress";
            this.txtEditStudentAddress.Size = new System.Drawing.Size(377, 65);
            this.txtEditStudentAddress.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(107, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(106, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Birth day:";
            // 
            // dtpEditStudentBirthday
            // 
            this.dtpEditStudentBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditStudentBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditStudentBirthday.Location = new System.Drawing.Point(243, 463);
            this.dtpEditStudentBirthday.Name = "dtpEditStudentBirthday";
            this.dtpEditStudentBirthday.Size = new System.Drawing.Size(160, 27);
            this.dtpEditStudentBirthday.TabIndex = 47;
            this.dtpEditStudentBirthday.ValueChanged += new System.EventHandler(this.dtpEditStudentBirthday_ValueChanged);
            // 
            // txtEditStudentPhoneNumber
            // 
            this.txtEditStudentPhoneNumber.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStudentPhoneNumber.Location = new System.Drawing.Point(243, 408);
            this.txtEditStudentPhoneNumber.Name = "txtEditStudentPhoneNumber";
            this.txtEditStudentPhoneNumber.Size = new System.Drawing.Size(377, 36);
            this.txtEditStudentPhoneNumber.TabIndex = 35;
            this.txtEditStudentPhoneNumber.TextChanged += new System.EventHandler(this.txtEditStudentPhoneNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(48, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Phone number:";
            // 
            // txtEditStudentLastName
            // 
            this.txtEditStudentLastName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStudentLastName.Location = new System.Drawing.Point(243, 353);
            this.txtEditStudentLastName.Name = "txtEditStudentLastName";
            this.txtEditStudentLastName.Size = new System.Drawing.Size(377, 36);
            this.txtEditStudentLastName.TabIndex = 34;
            this.txtEditStudentLastName.TextChanged += new System.EventHandler(this.txtEditStudentLastName_TextChanged);
            // 
            // lblStudentLastname
            // 
            this.lblStudentLastname.AutoSize = true;
            this.lblStudentLastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLastname.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentLastname.Location = new System.Drawing.Point(89, 353);
            this.lblStudentLastname.Name = "lblStudentLastname";
            this.lblStudentLastname.Size = new System.Drawing.Size(117, 23);
            this.lblStudentLastname.TabIndex = 45;
            this.lblStudentLastname.Text = "Last name:";
            // 
            // lblNoticeLogin
            // 
            this.lblNoticeLogin.AutoSize = true;
            this.lblNoticeLogin.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeLogin.Location = new System.Drawing.Point(178, 430);
            this.lblNoticeLogin.Name = "lblNoticeLogin";
            this.lblNoticeLogin.Size = new System.Drawing.Size(0, 21);
            this.lblNoticeLogin.TabIndex = 44;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnEditStudent.FlatAppearance.BorderSize = 0;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnEditStudent.Location = new System.Drawing.Point(243, 652);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(145, 56);
            this.btnEditStudent.TabIndex = 38;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnCancelEditStudent
            // 
            this.btnCancelEditStudent.BackColor = System.Drawing.Color.Gray;
            this.btnCancelEditStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEditStudent.FlatAppearance.BorderSize = 0;
            this.btnCancelEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnCancelEditStudent.Location = new System.Drawing.Point(944, 652);
            this.btnCancelEditStudent.Name = "btnCancelEditStudent";
            this.btnCancelEditStudent.Size = new System.Drawing.Size(145, 56);
            this.btnCancelEditStudent.TabIndex = 39;
            this.btnCancelEditStudent.Text = "Cancel";
            this.btnCancelEditStudent.UseVisualStyleBackColor = false;
            this.btnCancelEditStudent.Click += new System.EventHandler(this.btnCancelEditStudent_Click);
            // 
            // txtEditStudentFirstName
            // 
            this.txtEditStudentFirstName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStudentFirstName.Location = new System.Drawing.Point(243, 293);
            this.txtEditStudentFirstName.Name = "txtEditStudentFirstName";
            this.txtEditStudentFirstName.Size = new System.Drawing.Size(377, 36);
            this.txtEditStudentFirstName.TabIndex = 33;
            this.txtEditStudentFirstName.TextChanged += new System.EventHandler(this.txtEditStudentFirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(87, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "First name:";
            // 
            // txtEditStudentID
            // 
            this.txtEditStudentID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStudentID.Location = new System.Drawing.Point(243, 237);
            this.txtEditStudentID.Name = "txtEditStudentID";
            this.txtEditStudentID.Size = new System.Drawing.Size(241, 36);
            this.txtEditStudentID.TabIndex = 32;
            this.txtEditStudentID.TextChanged += new System.EventHandler(this.txtEditStudentID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(87, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(344, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 54);
            this.label1.TabIndex = 42;
            this.label1.Text = "Student Information Editor";
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoveStudent.FlatAppearance.BorderSize = 0;
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStudent.Location = new System.Drawing.Point(475, 652);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(145, 56);
            this.btnRemoveStudent.TabIndex = 53;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.BackColor = System.Drawing.Color.Green;
            this.btnFindStudent.FlatAppearance.BorderSize = 0;
            this.btnFindStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindStudent.ForeColor = System.Drawing.Color.White;
            this.btnFindStudent.Location = new System.Drawing.Point(514, 237);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(106, 36);
            this.btnFindStudent.TabIndex = 54;
            this.btnFindStudent.Text = "Find";
            this.btnFindStudent.UseVisualStyleBackColor = false;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // rbtnEditStudentGenderMale
            // 
            this.rbtnEditStudentGenderMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnEditStudentGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEditStudentGenderMale.Location = new System.Drawing.Point(21, 24);
            this.rbtnEditStudentGenderMale.Name = "rbtnEditStudentGenderMale";
            this.rbtnEditStudentGenderMale.Size = new System.Drawing.Size(82, 24);
            this.rbtnEditStudentGenderMale.TabIndex = 52;
            this.rbtnEditStudentGenderMale.TabStop = true;
            this.rbtnEditStudentGenderMale.Text = "Male";
            this.rbtnEditStudentGenderMale.UseVisualStyleBackColor = true;
            this.rbtnEditStudentGenderMale.CheckedChanged += new System.EventHandler(this.radioBtnEditStudentGender_CheckedChanged);
            // 
            // picboxEditStudentImage
            // 
            this.picboxEditStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxEditStudentImage.Location = new System.Drawing.Point(776, 243);
            this.picboxEditStudentImage.Name = "picboxEditStudentImage";
            this.picboxEditStudentImage.Size = new System.Drawing.Size(313, 296);
            this.picboxEditStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxEditStudentImage.TabIndex = 51;
            this.picboxEditStudentImage.TabStop = false;
            this.picboxEditStudentImage.Click += new System.EventHandler(this.picboxEditStudentImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManager.Properties.Resources.LOGO_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(62, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnEditStudentGenderFemale
            // 
            this.rbtnEditStudentGenderFemale.AutoSize = true;
            this.rbtnEditStudentGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEditStudentGenderFemale.Location = new System.Drawing.Point(103, 24);
            this.rbtnEditStudentGenderFemale.Name = "rbtnEditStudentGenderFemale";
            this.rbtnEditStudentGenderFemale.Size = new System.Drawing.Size(85, 24);
            this.rbtnEditStudentGenderFemale.TabIndex = 55;
            this.rbtnEditStudentGenderFemale.TabStop = true;
            this.rbtnEditStudentGenderFemale.Text = "Female";
            this.rbtnEditStudentGenderFemale.UseVisualStyleBackColor = true;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // grboxGender
            // 
            this.grboxGender.Controls.Add(this.rbtnEditStudentGenderFemale);
            this.grboxGender.Controls.Add(this.rbtnEditStudentGenderMale);
            this.grboxGender.Location = new System.Drawing.Point(426, 456);
            this.grboxGender.Name = "grboxGender";
            this.grboxGender.Size = new System.Drawing.Size(194, 54);
            this.grboxGender.TabIndex = 56;
            this.grboxGender.TabStop = false;
            this.grboxGender.Text = "Gender";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(716, 652);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(145, 56);
            this.btnAddCourse.TabIndex = 57;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // FrmEditRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelEditStudent;
            this.ClientSize = new System.Drawing.Size(1173, 753);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.grboxGender);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnUploadStudentPicture);
            this.Controls.Add(this.picboxEditStudentImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEditStudentAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEditStudentBirthday);
            this.Controls.Add(this.txtEditStudentPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditStudentLastName);
            this.Controls.Add(this.lblStudentLastname);
            this.Controls.Add(this.lblNoticeLogin);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnCancelEditStudent);
            this.Controls.Add(this.txtEditStudentFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditRemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Editor";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxEditStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.grboxGender.ResumeLayout(false);
            this.grboxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnEditStudentGenderMale;
        private System.Windows.Forms.Button btnUploadStudentPicture;
        private System.Windows.Forms.PictureBox picboxEditStudentImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditStudentAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEditStudentBirthday;
        private System.Windows.Forms.TextBox txtEditStudentPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditStudentLastName;
        private System.Windows.Forms.Label lblStudentLastname;
        private System.Windows.Forms.Label lblNoticeLogin;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnCancelEditStudent;
        private System.Windows.Forms.TextBox txtEditStudentFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.RadioButton rbtnEditStudentGenderFemale;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.GroupBox grboxGender;
        private System.Windows.Forms.Button btnAddCourse;
    }
}