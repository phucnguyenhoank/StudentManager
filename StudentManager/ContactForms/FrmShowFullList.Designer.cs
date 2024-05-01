namespace StudentManager.ContactForms
{
    partial class FrmShowFullList
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
            this.dtgvContact = new System.Windows.Forms.DataGridView();
            this.cbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvContact
            // 
            this.dtgvContact.AllowUserToAddRows = false;
            this.dtgvContact.AllowUserToDeleteRows = false;
            this.dtgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContact.Location = new System.Drawing.Point(42, 12);
            this.dtgvContact.Name = "dtgvContact";
            this.dtgvContact.ReadOnly = true;
            this.dtgvContact.RowHeadersWidth = 51;
            this.dtgvContact.RowTemplate.Height = 24;
            this.dtgvContact.Size = new System.Drawing.Size(970, 430);
            this.dtgvContact.TabIndex = 1;
            this.dtgvContact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvContact_CellDoubleClick);
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(176, 503);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(267, 24);
            this.cbDepartmentName.TabIndex = 15;
            this.cbDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department Name:";
            // 
            // btnToPrinter
            // 
            this.btnToPrinter.Location = new System.Drawing.Point(910, 458);
            this.btnToPrinter.Name = "btnToPrinter";
            this.btnToPrinter.Size = new System.Drawing.Size(102, 33);
            this.btnToPrinter.TabIndex = 17;
            this.btnToPrinter.Text = "To Printer";
            this.btnToPrinter.UseVisualStyleBackColor = true;
            this.btnToPrinter.Click += new System.EventHandler(this.btnToPrinter_Click);
            // 
            // FrmShowFullList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 596);
            this.Controls.Add(this.btnToPrinter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartmentName);
            this.Controls.Add(this.dtgvContact);
            this.Name = "FrmShowFullList";
            this.Text = "Show Full List";
            this.Load += new System.EventHandler(this.FrmShowFullList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvContact;
        private System.Windows.Forms.ComboBox cbDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToPrinter;
    }
}