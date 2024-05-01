namespace StudentManager.DepartmentForms
{
    partial class FrmManageDepartment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAddedDepartment = new System.Windows.Forms.TextBox();
            this.txtEditedDepartment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbEditedDepartment = new System.Windows.Forms.ComboBox();
            this.cbRemovedDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDepartment = new System.Windows.Forms.DataGridView();
            this.erprvDpmMng = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvDpmMng)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddedDepartment);
            this.groupBox1.Location = new System.Drawing.Point(77, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEditedDepartment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbEditedDepartment);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Location = new System.Drawing.Point(77, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbRemovedDepartment);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Location = new System.Drawing.Point(77, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove";
            // 
            // txtAddedDepartment
            // 
            this.txtAddedDepartment.Location = new System.Drawing.Point(196, 44);
            this.txtAddedDepartment.Name = "txtAddedDepartment";
            this.txtAddedDepartment.Size = new System.Drawing.Size(203, 22);
            this.txtAddedDepartment.TabIndex = 4;
            this.txtAddedDepartment.TextChanged += new System.EventHandler(this.txtAddedDepartment_TextChanged);
            // 
            // txtEditedDepartment
            // 
            this.txtEditedDepartment.Location = new System.Drawing.Point(196, 79);
            this.txtEditedDepartment.Name = "txtEditedDepartment";
            this.txtEditedDepartment.Size = new System.Drawing.Size(203, 22);
            this.txtEditedDepartment.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(196, 121);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(196, 84);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbEditedDepartment
            // 
            this.cbEditedDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditedDepartment.FormattingEnabled = true;
            this.cbEditedDepartment.Location = new System.Drawing.Point(196, 26);
            this.cbEditedDepartment.Name = "cbEditedDepartment";
            this.cbEditedDepartment.Size = new System.Drawing.Size(203, 24);
            this.cbEditedDepartment.TabIndex = 7;
            // 
            // cbRemovedDepartment
            // 
            this.cbRemovedDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemovedDepartment.FormattingEnabled = true;
            this.cbRemovedDepartment.Location = new System.Drawing.Point(196, 38);
            this.cbRemovedDepartment.Name = "cbRemovedDepartment";
            this.cbRemovedDepartment.Size = new System.Drawing.Size(203, 24);
            this.cbRemovedDepartment.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Department Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Department Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Department:";
            // 
            // dtgvDepartment
            // 
            this.dtgvDepartment.AllowUserToAddRows = false;
            this.dtgvDepartment.AllowUserToDeleteRows = false;
            this.dtgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDepartment.Location = new System.Drawing.Point(677, 134);
            this.dtgvDepartment.Name = "dtgvDepartment";
            this.dtgvDepartment.RowHeadersWidth = 51;
            this.dtgvDepartment.RowTemplate.Height = 24;
            this.dtgvDepartment.Size = new System.Drawing.Size(500, 458);
            this.dtgvDepartment.TabIndex = 6;
            // 
            // erprvDpmMng
            // 
            this.erprvDpmMng.ContainerControl = this;
            // 
            // FrmManageDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 641);
            this.Controls.Add(this.dtgvDepartment);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageDepartment";
            this.Text = "Manage Department";
            this.Load += new System.EventHandler(this.FrmManageDepartment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvDpmMng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAddedDepartment;
        private System.Windows.Forms.TextBox txtEditedDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEditedDepartment;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRemovedDepartment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dtgvDepartment;
        private System.Windows.Forms.ErrorProvider erprvDpmMng;
    }
}