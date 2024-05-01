namespace StudentManager
{
    partial class frmAddCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoursePeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(170, 47);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(303, 22);
            this.txtCourseID.TabIndex = 1;
            this.txtCourseID.TextChanged += new System.EventHandler(this.txtCourseID_TextChanged);
            // 
            // txtCourseLabel
            // 
            this.txtCourseLabel.Location = new System.Drawing.Point(170, 103);
            this.txtCourseLabel.Name = "txtCourseLabel";
            this.txtCourseLabel.Size = new System.Drawing.Size(303, 22);
            this.txtCourseLabel.TabIndex = 3;
            this.txtCourseLabel.TextChanged += new System.EventHandler(this.txtCourseLabel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label";
            // 
            // txtCoursePeriod
            // 
            this.txtCoursePeriod.Location = new System.Drawing.Point(170, 147);
            this.txtCoursePeriod.Name = "txtCoursePeriod";
            this.txtCoursePeriod.Size = new System.Drawing.Size(303, 22);
            this.txtCoursePeriod.TabIndex = 5;
            this.txtCoursePeriod.TextChanged += new System.EventHandler(this.txtCoursePeriod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(170, 200);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(303, 60);
            this.txtCourseDescription.TabIndex = 7;
            this.txtCourseDescription.TextChanged += new System.EventHandler(this.txtCourseDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(183, 310);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(151, 38);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 403);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoursePeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCourse";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoursePeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}