namespace StudentManager
{
    partial class FrmStudentList
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
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.btnResetStudentList = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToResizeRows = false;
            this.dataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudentList.ColumnHeadersHeight = 25;
            this.dataGridViewStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.RowHeadersVisible = false;
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 50;
            this.dataGridViewStudentList.RowTemplate.ReadOnly = true;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(853, 566);
            this.dataGridViewStudentList.TabIndex = 0;
            this.dataGridViewStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirdViewStudentList_CellDoubleClick);
            // 
            // btnResetStudentList
            // 
            this.btnResetStudentList.BackColor = System.Drawing.Color.Green;
            this.btnResetStudentList.FlatAppearance.BorderSize = 0;
            this.btnResetStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetStudentList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStudentList.ForeColor = System.Drawing.Color.White;
            this.btnResetStudentList.Location = new System.Drawing.Point(451, 572);
            this.btnResetStudentList.Name = "btnResetStudentList";
            this.btnResetStudentList.Size = new System.Drawing.Size(93, 39);
            this.btnResetStudentList.TabIndex = 7;
            this.btnResetStudentList.Text = "Reset";
            this.btnResetStudentList.UseVisualStyleBackColor = false;
            this.btnResetStudentList.Click += new System.EventHandler(this.btnResetStudentList_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(550, 572);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 39);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(649, 572);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 39);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(165)))));
            this.btnExportToExcel.FlatAppearance.BorderSize = 0;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.Location = new System.Drawing.Point(748, 572);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(93, 39);
            this.btnExportToExcel.TabIndex = 10;
            this.btnExportToExcel.Text = "Export";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 629);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnResetStudentList);
            this.Controls.Add(this.dataGridViewStudentList);
            this.MaximizeBox = false;
            this.Name = "FrmStudentList";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Button btnResetStudentList;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}