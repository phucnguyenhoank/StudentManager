namespace StudentManager
{
    partial class FrmCoursePrinter
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
            this.rpvCouseList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvCouseList
            // 
            this.rpvCouseList.Location = new System.Drawing.Point(12, 60);
            this.rpvCouseList.Name = "rpvCouseList";
            this.rpvCouseList.ServerReport.BearerToken = null;
            this.rpvCouseList.Size = new System.Drawing.Size(1275, 594);
            this.rpvCouseList.TabIndex = 1;
            // 
            // FrmCoursePrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 687);
            this.Controls.Add(this.rpvCouseList);
            this.Name = "FrmCoursePrinter";
            this.Text = "Print Course";
            this.Load += new System.EventHandler(this.FrmPrintCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpvCouseList;
    }
}