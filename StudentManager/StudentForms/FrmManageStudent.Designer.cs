namespace StudentManager
{
    partial class FrmManageStudent
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
            this.grboxGender = new System.Windows.Forms.GroupBox();
            this.rbtnStudentGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbtnStudentGenderMale = new System.Windows.Forms.RadioButton();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnUploadStudentPicture = new System.Windows.Forms.Button();
            this.picboxStudentImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStudentBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentLastname = new System.Windows.Forms.Label();
            this.lblNoticeLogin = new System.Windows.Forms.Label();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnCancelManageStudent = new System.Windows.Forms.Button();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetEntries = new System.Windows.Forms.Button();
            this.dtgvSearchStudentList = new System.Windows.Forms.DataGridView();
            this.txtSearchStringInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTotalStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.errorProviderUserInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.grboxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserInput)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxGender
            // 
            this.grboxGender.Controls.Add(this.rbtnStudentGenderFemale);
            this.grboxGender.Controls.Add(this.rbtnStudentGenderMale);
            this.grboxGender.Location = new System.Drawing.Point(499, 327);
            this.grboxGender.Name = "grboxGender";
            this.grboxGender.Size = new System.Drawing.Size(194, 54);
            this.grboxGender.TabIndex = 79;
            this.grboxGender.TabStop = false;
            this.grboxGender.Text = "Gender";
            // 
            // rbtnStudentGenderFemale
            // 
            this.rbtnStudentGenderFemale.AutoSize = true;
            this.rbtnStudentGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStudentGenderFemale.Location = new System.Drawing.Point(103, 24);
            this.rbtnStudentGenderFemale.Name = "rbtnStudentGenderFemale";
            this.rbtnStudentGenderFemale.Size = new System.Drawing.Size(85, 24);
            this.rbtnStudentGenderFemale.TabIndex = 55;
            this.rbtnStudentGenderFemale.TabStop = true;
            this.rbtnStudentGenderFemale.Text = "Female";
            this.rbtnStudentGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnStudentGenderMale
            // 
            this.rbtnStudentGenderMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnStudentGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStudentGenderMale.Location = new System.Drawing.Point(21, 24);
            this.rbtnStudentGenderMale.Name = "rbtnStudentGenderMale";
            this.rbtnStudentGenderMale.Size = new System.Drawing.Size(82, 24);
            this.rbtnStudentGenderMale.TabIndex = 52;
            this.rbtnStudentGenderMale.TabStop = true;
            this.rbtnStudentGenderMale.Text = "Male";
            this.rbtnStudentGenderMale.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.Green;
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Location = new System.Drawing.Point(1378, 101);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(106, 36);
            this.btnSearchStudent.TabIndex = 78;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoveStudent.FlatAppearance.BorderSize = 0;
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStudent.Location = new System.Drawing.Point(545, 743);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(145, 56);
            this.btnRemoveStudent.TabIndex = 77;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnUploadStudentPicture
            // 
            this.btnUploadStudentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnUploadStudentPicture.FlatAppearance.BorderSize = 0;
            this.btnUploadStudentPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadStudentPicture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadStudentPicture.ForeColor = System.Drawing.Color.White;
            this.btnUploadStudentPicture.Location = new System.Drawing.Point(561, 667);
            this.btnUploadStudentPicture.Name = "btnUploadStudentPicture";
            this.btnUploadStudentPicture.Size = new System.Drawing.Size(127, 37);
            this.btnUploadStudentPicture.TabIndex = 62;
            this.btnUploadStudentPicture.Text = "Upload";
            this.btnUploadStudentPicture.UseVisualStyleBackColor = false;
            this.btnUploadStudentPicture.Click += new System.EventHandler(this.btnUploadStudentPicture_Click);
            // 
            // picboxStudentImage
            // 
            this.picboxStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxStudentImage.Location = new System.Drawing.Point(316, 485);
            this.picboxStudentImage.Name = "picboxStudentImage";
            this.picboxStudentImage.Size = new System.Drawing.Size(371, 179);
            this.picboxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxStudentImage.TabIndex = 76;
            this.picboxStudentImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(192, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Picture:";
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAddress.Location = new System.Drawing.Point(316, 402);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(377, 65);
            this.txtStudentAddress.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(180, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 74;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(174, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "Birth day:";
            // 
            // dtpStudentBirthday
            // 
            this.dtpStudentBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStudentBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStudentBirthday.Location = new System.Drawing.Point(316, 334);
            this.dtpStudentBirthday.Name = "dtpStudentBirthday";
            this.dtpStudentBirthday.Size = new System.Drawing.Size(160, 27);
            this.dtpStudentBirthday.TabIndex = 72;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(316, 279);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(377, 36);
            this.txtStudentPhoneNumber.TabIndex = 60;
            this.txtStudentPhoneNumber.TextChanged += new System.EventHandler(this.txtStudentPhoneNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(121, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Phone number:";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentLastName.Location = new System.Drawing.Point(316, 224);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(377, 36);
            this.txtStudentLastName.TabIndex = 59;
            this.txtStudentLastName.TextChanged += new System.EventHandler(this.txtStudentLastName_TextChanged);
            // 
            // lblStudentLastname
            // 
            this.lblStudentLastname.AutoSize = true;
            this.lblStudentLastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLastname.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentLastname.Location = new System.Drawing.Point(162, 224);
            this.lblStudentLastname.Name = "lblStudentLastname";
            this.lblStudentLastname.Size = new System.Drawing.Size(117, 23);
            this.lblStudentLastname.TabIndex = 70;
            this.lblStudentLastname.Text = "Last name:";
            // 
            // lblNoticeLogin
            // 
            this.lblNoticeLogin.AutoSize = true;
            this.lblNoticeLogin.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeLogin.Location = new System.Drawing.Point(251, 301);
            this.lblNoticeLogin.Name = "lblNoticeLogin";
            this.lblNoticeLogin.Size = new System.Drawing.Size(0, 21);
            this.lblNoticeLogin.TabIndex = 69;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnEditStudent.FlatAppearance.BorderSize = 0;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnEditStudent.Location = new System.Drawing.Point(367, 743);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(145, 56);
            this.btnEditStudent.TabIndex = 63;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnCancelManageStudent
            // 
            this.btnCancelManageStudent.BackColor = System.Drawing.Color.Gray;
            this.btnCancelManageStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelManageStudent.FlatAppearance.BorderSize = 0;
            this.btnCancelManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelManageStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnCancelManageStudent.Location = new System.Drawing.Point(882, 743);
            this.btnCancelManageStudent.Name = "btnCancelManageStudent";
            this.btnCancelManageStudent.Size = new System.Drawing.Size(145, 56);
            this.btnCancelManageStudent.TabIndex = 64;
            this.btnCancelManageStudent.Text = "Cancel";
            this.btnCancelManageStudent.UseVisualStyleBackColor = false;
            this.btnCancelManageStudent.Click += new System.EventHandler(this.btnCancelManageStudent_Click);
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentFirstName.Location = new System.Drawing.Point(316, 164);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(377, 36);
            this.txtStudentFirstName.TabIndex = 58;
            this.txtStudentFirstName.TextChanged += new System.EventHandler(this.txtStudentFirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(160, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "First name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(316, 108);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(241, 36);
            this.txtStudentID.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(160, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(536, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 54);
            this.label1.TabIndex = 67;
            this.label1.Text = "Manage Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManager.Properties.Resources.LOGO_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetEntries
            // 
            this.btnResetEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetEntries.FlatAppearance.BorderSize = 0;
            this.btnResetEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEntries.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEntries.ForeColor = System.Drawing.Color.White;
            this.btnResetEntries.Location = new System.Drawing.Point(716, 743);
            this.btnResetEntries.Name = "btnResetEntries";
            this.btnResetEntries.Size = new System.Drawing.Size(145, 56);
            this.btnResetEntries.TabIndex = 80;
            this.btnResetEntries.Text = "Reset";
            this.btnResetEntries.UseVisualStyleBackColor = false;
            this.btnResetEntries.Click += new System.EventHandler(this.btnResetEntries_Click);
            // 
            // dtgvSearchStudentList
            // 
            this.dtgvSearchStudentList.AllowUserToAddRows = false;
            this.dtgvSearchStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearchStudentList.Location = new System.Drawing.Point(744, 164);
            this.dtgvSearchStudentList.Name = "dtgvSearchStudentList";
            this.dtgvSearchStudentList.ReadOnly = true;
            this.dtgvSearchStudentList.RowHeadersWidth = 51;
            this.dtgvSearchStudentList.RowTemplate.Height = 24;
            this.dtgvSearchStudentList.Size = new System.Drawing.Size(740, 549);
            this.dtgvSearchStudentList.TabIndex = 81;
            this.dtgvSearchStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSearchStudentList_CellContentClick);
            this.dtgvSearchStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSearchStudentList_CellDoubleClick);
            // 
            // txtSearchStringInput
            // 
            this.txtSearchStringInput.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStringInput.Location = new System.Drawing.Point(1088, 101);
            this.txtSearchStringInput.Name = "txtSearchStringInput";
            this.txtSearchStringInput.Size = new System.Drawing.Size(241, 36);
            this.txtSearchStringInput.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(878, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Name or address:";
            // 
            // btnTotalStudent
            // 
            this.btnTotalStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTotalStudent.FlatAppearance.BorderSize = 0;
            this.btnTotalStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalStudent.ForeColor = System.Drawing.Color.White;
            this.btnTotalStudent.Location = new System.Drawing.Point(1286, 743);
            this.btnTotalStudent.Name = "btnTotalStudent";
            this.btnTotalStudent.Size = new System.Drawing.Size(198, 56);
            this.btnTotalStudent.TabIndex = 85;
            this.btnTotalStudent.Text = "Total Student";
            this.btnTotalStudent.UseVisualStyleBackColor = false;
            this.btnTotalStudent.Click += new System.EventHandler(this.btnTotalStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(184, 743);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(145, 56);
            this.btnAddStudent.TabIndex = 86;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // errorProviderUserInput
            // 
            this.errorProviderUserInput.ContainerControl = this;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(1282, 716);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(128, 22);
            this.lblTotalStudent.TabIndex = 87;
            this.lblTotalStudent.Text = "Total Student: ";
            // 
            // FrmManageStudent
            // 
            this.AcceptButton = this.btnSearchStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1547, 827);
            this.Controls.Add(this.lblTotalStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnTotalStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchStringInput);
            this.Controls.Add(this.dtgvSearchStudentList);
            this.Controls.Add(this.btnResetEntries);
            this.Controls.Add(this.grboxGender);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnUploadStudentPicture);
            this.Controls.Add(this.picboxStudentImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpStudentBirthday);
            this.Controls.Add(this.txtStudentPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.lblStudentLastname);
            this.Controls.Add(this.lblNoticeLogin);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnCancelManageStudent);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmManageStudent";
            this.Text = "Manage Student";
            this.Load += new System.EventHandler(this.FrmManageStudent_Load);
            this.grboxGender.ResumeLayout(false);
            this.grboxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxGender;
        private System.Windows.Forms.RadioButton rbtnStudentGenderFemale;
        private System.Windows.Forms.RadioButton rbtnStudentGenderMale;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnUploadStudentPicture;
        private System.Windows.Forms.PictureBox picboxStudentImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthday;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.Label lblStudentLastname;
        private System.Windows.Forms.Label lblNoticeLogin;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnCancelManageStudent;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResetEntries;
        private System.Windows.Forms.DataGridView dtgvSearchStudentList;
        private System.Windows.Forms.TextBox txtSearchStringInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTotalStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ErrorProvider errorProviderUserInput;
        private System.Windows.Forms.Label lblTotalStudent;
    }
}