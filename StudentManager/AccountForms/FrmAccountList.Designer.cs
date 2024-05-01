namespace StudentManager
{
    partial class FrmAccountList
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
            this.dataGridViewAccountList = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccountList
            // 
            this.dataGridViewAccountList.AllowUserToAddRows = false;
            this.dataGridViewAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccountList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAccountList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAccountList.Name = "dataGridViewAccountList";
            this.dataGridViewAccountList.RowHeadersVisible = false;
            this.dataGridViewAccountList.RowHeadersWidth = 51;
            this.dataGridViewAccountList.RowTemplate.Height = 24;
            this.dataGridViewAccountList.Size = new System.Drawing.Size(1044, 276);
            this.dataGridViewAccountList.TabIndex = 0;
            this.dataGridViewAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccountList_CellClick);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(445, 304);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(157, 31);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FrmAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 380);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridViewAccountList);
            this.Name = "FrmAccountList";
            this.Text = "Account List";
            this.Load += new System.EventHandler(this.frmAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccountList;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}