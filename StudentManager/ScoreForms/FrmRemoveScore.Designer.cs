namespace StudentManager
{
    partial class FrmRemoveScore
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
            this.btnRemoveScore = new System.Windows.Forms.Button();
            this.dtgvScoreList = new System.Windows.Forms.DataGridView();
            this.erprvRemoveScore = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvRemoveScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.Location = new System.Drawing.Point(561, 390);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(117, 43);
            this.btnRemoveScore.TabIndex = 0;
            this.btnRemoveScore.Text = "Remove";
            this.btnRemoveScore.UseVisualStyleBackColor = true;
            this.btnRemoveScore.Click += new System.EventHandler(this.btnRemoveScore_Click);
            // 
            // dtgvScoreList
            // 
            this.dtgvScoreList.AllowUserToAddRows = false;
            this.dtgvScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScoreList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvScoreList.Location = new System.Drawing.Point(0, 0);
            this.dtgvScoreList.Name = "dtgvScoreList";
            this.dtgvScoreList.ReadOnly = true;
            this.dtgvScoreList.RowHeadersWidth = 51;
            this.dtgvScoreList.RowTemplate.Height = 24;
            this.dtgvScoreList.Size = new System.Drawing.Size(813, 384);
            this.dtgvScoreList.TabIndex = 5;
            // 
            // erprvRemoveScore
            // 
            this.erprvRemoveScore.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(684, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 43);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmRemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtgvScoreList);
            this.Controls.Add(this.btnRemoveScore);
            this.Name = "FrmRemoveScore";
            this.Text = "Remove Score";
            this.Load += new System.EventHandler(this.FrmRemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvRemoveScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveScore;
        private System.Windows.Forms.DataGridView dtgvScoreList;
        private System.Windows.Forms.ErrorProvider erprvRemoveScore;
        private System.Windows.Forms.Button btnRefresh;
    }
}