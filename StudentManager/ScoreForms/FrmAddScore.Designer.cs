namespace StudentManager
{
    partial class FrmAddScore
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
            this.txtScoreDescription = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cbCourseLabel = new System.Windows.Forms.ComboBox();
            this.dtgvScoreStudent = new System.Windows.Forms.DataGridView();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScoreStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScoreDescription
            // 
            this.txtScoreDescription.Location = new System.Drawing.Point(170, 297);
            this.txtScoreDescription.Multiline = true;
            this.txtScoreDescription.Name = "txtScoreDescription";
            this.txtScoreDescription.Size = new System.Drawing.Size(273, 60);
            this.txtScoreDescription.TabIndex = 15;
            this.txtScoreDescription.TextChanged += new System.EventHandler(this.txtScoreDescription_TextChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(170, 244);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(273, 22);
            this.txtScore.TabIndex = 13;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(170, 69);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(273, 22);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // cbCourseLabel
            // 
            this.cbCourseLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseLabel.FormattingEnabled = true;
            this.cbCourseLabel.Location = new System.Drawing.Point(170, 113);
            this.cbCourseLabel.Name = "cbCourseLabel";
            this.cbCourseLabel.Size = new System.Drawing.Size(273, 24);
            this.cbCourseLabel.TabIndex = 16;
            // 
            // dtgvScoreStudent
            // 
            this.dtgvScoreStudent.AllowUserToAddRows = false;
            this.dtgvScoreStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScoreStudent.Location = new System.Drawing.Point(470, 65);
            this.dtgvScoreStudent.Name = "dtgvScoreStudent";
            this.dtgvScoreStudent.ReadOnly = true;
            this.dtgvScoreStudent.RowHeadersWidth = 51;
            this.dtgvScoreStudent.RowTemplate.Height = 24;
            this.dtgvScoreStudent.Size = new System.Drawing.Size(882, 349);
            this.dtgvScoreStudent.TabIndex = 17;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(241, 387);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(179, 27);
            this.btnAddScore.TabIndex = 18;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(170, 181);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(273, 24);
            this.cbSemester.TabIndex = 23;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Semester:";
            // 
            // FrmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.dtgvScoreStudent);
            this.Controls.Add(this.cbCourseLabel);
            this.Controls.Add(this.txtScoreDescription);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtStudentID);
            this.Name = "FrmAddScore";
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.FrmAddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScoreStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScoreDescription;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cbCourseLabel;
        private System.Windows.Forms.DataGridView dtgvScoreStudent;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSemester;
    }
}