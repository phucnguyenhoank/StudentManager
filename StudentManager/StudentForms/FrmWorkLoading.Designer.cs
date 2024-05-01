namespace StudentManager
{
    partial class frmWorkLoadingStudentList
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
            this.progressBarStudentListLoading = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerStudentList = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBarStudentListLoading
            // 
            this.progressBarStudentListLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarStudentListLoading.Location = new System.Drawing.Point(0, 0);
            this.progressBarStudentListLoading.Name = "progressBarStudentListLoading";
            this.progressBarStudentListLoading.Size = new System.Drawing.Size(509, 68);
            this.progressBarStudentListLoading.TabIndex = 0;
            this.progressBarStudentListLoading.Click += new System.EventHandler(this.progressBarStudentListLoading_Click);
            // 
            // backgroundWorkerStudentList
            // 
            this.backgroundWorkerStudentList.WorkerReportsProgress = true;
            this.backgroundWorkerStudentList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStudentList_DoWork);
            this.backgroundWorkerStudentList.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerStudentList_ProgressChanged);
            this.backgroundWorkerStudentList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStudentList_RunWorkerCompleted);
            // 
            // frmWorkLoadingStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 68);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarStudentListLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWorkLoadingStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importing...";
            this.Load += new System.EventHandler(this.frmWorkLoading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBarStudentListLoading;
        public System.ComponentModel.BackgroundWorker backgroundWorkerStudentList;
    }
}