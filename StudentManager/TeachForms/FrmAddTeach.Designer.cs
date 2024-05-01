namespace StudentManager.TeachForms
{
    partial class FrmAddTeach
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
            this.cbContactID = new System.Windows.Forms.ComboBox();
            this.cbCourseID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTeach = new System.Windows.Forms.Button();
            this.txtTeachID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erprvAddTeach = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erprvAddTeach)).BeginInit();
            this.SuspendLayout();
            // 
            // cbContactID
            // 
            this.cbContactID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactID.FormattingEnabled = true;
            this.cbContactID.Location = new System.Drawing.Point(181, 144);
            this.cbContactID.Name = "cbContactID";
            this.cbContactID.Size = new System.Drawing.Size(215, 24);
            this.cbContactID.TabIndex = 0;
            this.cbContactID.SelectedIndexChanged += new System.EventHandler(this.cbContactID_SelectedIndexChanged);
            // 
            // cbCourseID
            // 
            this.cbCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseID.FormattingEnabled = true;
            this.cbCourseID.Location = new System.Drawing.Point(181, 193);
            this.cbCourseID.Name = "cbCourseID";
            this.cbCourseID.Size = new System.Drawing.Size(215, 24);
            this.cbCourseID.TabIndex = 1;
            this.cbCourseID.SelectedIndexChanged += new System.EventHandler(this.cbCourseID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course ID:";
            // 
            // btnAddTeach
            // 
            this.btnAddTeach.Location = new System.Drawing.Point(181, 272);
            this.btnAddTeach.Name = "btnAddTeach";
            this.btnAddTeach.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeach.TabIndex = 5;
            this.btnAddTeach.Text = "Add";
            this.btnAddTeach.UseVisualStyleBackColor = true;
            this.btnAddTeach.Click += new System.EventHandler(this.btnAddTeach_Click);
            // 
            // txtTeachID
            // 
            this.txtTeachID.Location = new System.Drawing.Point(181, 96);
            this.txtTeachID.Name = "txtTeachID";
            this.txtTeachID.Size = new System.Drawing.Size(215, 22);
            this.txtTeachID.TabIndex = 6;
            this.txtTeachID.TextChanged += new System.EventHandler(this.txtTeachID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teach ID:";
            // 
            // erprvAddTeach
            // 
            this.erprvAddTeach.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Teaching";
            // 
            // FrmAddTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeachID);
            this.Controls.Add(this.btnAddTeach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCourseID);
            this.Controls.Add(this.cbContactID);
            this.Name = "FrmAddTeach";
            this.Text = "Add Teaching";
            this.Load += new System.EventHandler(this.FrmAddTeach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erprvAddTeach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContactID;
        private System.Windows.Forms.ComboBox cbCourseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTeach;
        private System.Windows.Forms.TextBox txtTeachID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erprvAddTeach;
        private System.Windows.Forms.Label label3;
    }
}