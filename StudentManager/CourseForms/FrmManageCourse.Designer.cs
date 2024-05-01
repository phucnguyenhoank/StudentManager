namespace StudentManager
{
    partial class FrmManageCourse
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudHoursNumber = new System.Windows.Forms.NumericUpDown();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lbxCourseList = new System.Windows.Forms.ListBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblTotalCourse = new System.Windows.Forms.Label();
            this.btnCourseDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 207);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(261, 95);
            this.txtDescription.TabIndex = 16;
            // 
            // nudHoursNumber
            // 
            this.nudHoursNumber.Location = new System.Drawing.Point(284, 147);
            this.nudHoursNumber.Name = "nudHoursNumber";
            this.nudHoursNumber.Size = new System.Drawing.Size(193, 22);
            this.nudHoursNumber.TabIndex = 15;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(284, 100);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(193, 22);
            this.txtLabel.TabIndex = 14;
            // 
            // lbxCourseList
            // 
            this.lbxCourseList.FormattingEnabled = true;
            this.lbxCourseList.ItemHeight = 16;
            this.lbxCourseList.Location = new System.Drawing.Point(530, 36);
            this.lbxCourseList.Name = "lbxCourseList";
            this.lbxCourseList.Size = new System.Drawing.Size(334, 244);
            this.lbxCourseList.TabIndex = 24;
            this.lbxCourseList.SelectedIndexChanged += new System.EventHandler(this.lbxCourseList_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(284, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 22);
            this.txtID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(143, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(51, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(24, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Hours number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(110, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Label:";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(546, 415);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(128, 23);
            this.btnRemoveCourse.TabIndex = 19;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(385, 415);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(128, 23);
            this.btnEditCourse.TabIndex = 17;
            this.btnEditCourse.Text = "Edit";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(222, 415);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(128, 23);
            this.btnAddCourse.TabIndex = 18;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(762, 333);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(102, 38);
            this.btnLast.TabIndex = 23;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(654, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 38);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(546, 333);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 38);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(438, 333);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(102, 38);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblTotalCourse
            // 
            this.lblTotalCourse.AutoSize = true;
            this.lblTotalCourse.Location = new System.Drawing.Point(760, 289);
            this.lblTotalCourse.Name = "lblTotalCourse";
            this.lblTotalCourse.Size = new System.Drawing.Size(84, 16);
            this.lblTotalCourse.TabIndex = 25;
            this.lblTotalCourse.Text = "Total Course";
            // 
            // btnCourseDetails
            // 
            this.btnCourseDetails.Location = new System.Drawing.Point(530, 289);
            this.btnCourseDetails.Name = "btnCourseDetails";
            this.btnCourseDetails.Size = new System.Drawing.Size(118, 23);
            this.btnCourseDetails.TabIndex = 33;
            this.btnCourseDetails.Text = "course details";
            this.btnCourseDetails.UseVisualStyleBackColor = true;
            this.btnCourseDetails.Click += new System.EventHandler(this.btnCourseDetails_Click);
            // 
            // FrmManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 467);
            this.Controls.Add(this.btnCourseDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTotalCourse);
            this.Controls.Add(this.lbxCourseList);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.nudHoursNumber);
            this.Controls.Add(this.txtLabel);
            this.Name = "FrmManageCourse";
            this.Text = "Manage Course";
            this.Load += new System.EventHandler(this.FrmManageCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudHoursNumber;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.ListBox lbxCourseList;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblTotalCourse;
        private System.Windows.Forms.Button btnCourseDetails;
    }
}