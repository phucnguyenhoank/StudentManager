namespace StudentManager
{
    partial class FrmAvgScoreByCourse
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
            this.dtgvAvgScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAvgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAvgScore
            // 
            this.dtgvAvgScore.AllowUserToAddRows = false;
            this.dtgvAvgScore.AllowUserToDeleteRows = false;
            this.dtgvAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAvgScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvAvgScore.Location = new System.Drawing.Point(0, 0);
            this.dtgvAvgScore.Name = "dtgvAvgScore";
            this.dtgvAvgScore.RowHeadersWidth = 51;
            this.dtgvAvgScore.RowTemplate.Height = 24;
            this.dtgvAvgScore.Size = new System.Drawing.Size(800, 372);
            this.dtgvAvgScore.TabIndex = 0;
            // 
            // FrmAvgScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvAvgScore);
            this.Name = "FrmAvgScoreByCourse";
            this.Text = "Avg Score By Course";
            this.Load += new System.EventHandler(this.FrmAvgScoreByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAvgScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAvgScore;
    }
}