namespace StudentManager.ContactForms
{
    partial class FrmContactSelector
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvContact
            // 
            this.dtgvContact.AllowUserToAddRows = false;
            this.dtgvContact.AllowUserToDeleteRows = false;
            this.dtgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvContact.Location = new System.Drawing.Point(0, 0);
            this.dtgvContact.Name = "dtgvContact";
            this.dtgvContact.ReadOnly = true;
            this.dtgvContact.RowHeadersWidth = 51;
            this.dtgvContact.RowTemplate.Height = 24;
            this.dtgvContact.Size = new System.Drawing.Size(970, 430);
            this.dtgvContact.TabIndex = 0;
            this.dtgvContact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvContact_CellDoubleClick);
            // 
            // FrmContactSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 501);
            this.Controls.Add(this.dtgvContact);
            this.Name = "FrmContactSelector";
            this.Text = "Contact Selector";
            this.Load += new System.EventHandler(this.FrmContactSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvContact;
    }
}