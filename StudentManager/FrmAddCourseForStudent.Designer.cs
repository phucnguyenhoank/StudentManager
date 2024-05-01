namespace StudentManager
{
    partial class FrmAddCourseForStudent
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cbSelectedSemester = new System.Windows.Forms.ComboBox();
            this.lbxAvailableCourse = new System.Windows.Forms.ListBox();
            this.lbxSelectedCourse = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.erprvAddCourseForStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erprvAddCourseForStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(40, 59);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // cbSelectedSemester
            // 
            this.cbSelectedSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectedSemester.FormattingEnabled = true;
            this.cbSelectedSemester.Location = new System.Drawing.Point(510, 59);
            this.cbSelectedSemester.Name = "cbSelectedSemester";
            this.cbSelectedSemester.Size = new System.Drawing.Size(121, 24);
            this.cbSelectedSemester.TabIndex = 1;
            this.cbSelectedSemester.SelectedIndexChanged += new System.EventHandler(this.cbSelectedSemester_SelectedIndexChanged);
            // 
            // lbxAvailableCourse
            // 
            this.lbxAvailableCourse.FormattingEnabled = true;
            this.lbxAvailableCourse.ItemHeight = 16;
            this.lbxAvailableCourse.Location = new System.Drawing.Point(40, 153);
            this.lbxAvailableCourse.Name = "lbxAvailableCourse";
            this.lbxAvailableCourse.Size = new System.Drawing.Size(295, 148);
            this.lbxAvailableCourse.TabIndex = 2;
            // 
            // lbxSelectedCourse
            // 
            this.lbxSelectedCourse.FormattingEnabled = true;
            this.lbxSelectedCourse.ItemHeight = 16;
            this.lbxSelectedCourse.Location = new System.Drawing.Point(510, 153);
            this.lbxSelectedCourse.Name = "lbxSelectedCourse";
            this.lbxSelectedCourse.Size = new System.Drawing.Size(295, 148);
            this.lbxSelectedCourse.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Available Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selected Course";
            // 
            // erprvAddCourseForStudent
            // 
            this.erprvAddCourseForStudent.ContainerControl = this;
            // 
            // btnUnAdd
            // 
            this.btnUnAdd.Location = new System.Drawing.Point(378, 243);
            this.btnUnAdd.Name = "btnUnAdd";
            this.btnUnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnUnAdd.TabIndex = 10;
            this.btnUnAdd.Text = "Un-add";
            this.btnUnAdd.UseVisualStyleBackColor = true;
            this.btnUnAdd.Click += new System.EventHandler(this.btnUnAdd_Click);
            // 
            // FrmAddCourseForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 362);
            this.Controls.Add(this.btnUnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxSelectedCourse);
            this.Controls.Add(this.lbxAvailableCourse);
            this.Controls.Add(this.cbSelectedSemester);
            this.Controls.Add(this.txtStudentID);
            this.Name = "FrmAddCourseForStudent";
            this.Text = "Add Course For Student";
            this.Load += new System.EventHandler(this.FrmAddCourseForStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erprvAddCourseForStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cbSelectedSemester;
        private System.Windows.Forms.ListBox lbxAvailableCourse;
        private System.Windows.Forms.ListBox lbxSelectedCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erprvAddCourseForStudent;
        private System.Windows.Forms.Button btnUnAdd;
    }
}