namespace StudentManager
{
    partial class FrmStatisticResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.chartScoreResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPassPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartScoreResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistic By Courses";
            // 
            // chartScoreResult
            // 
            chartArea2.Name = "ChartArea1";
            this.chartScoreResult.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartScoreResult.Legends.Add(legend2);
            this.chartScoreResult.Location = new System.Drawing.Point(49, 89);
            this.chartScoreResult.Name = "chartScoreResult";
            this.chartScoreResult.Size = new System.Drawing.Size(1050, 300);
            this.chartScoreResult.TabIndex = 4;
            this.chartScoreResult.Text = "chart1";
            // 
            // lblPassPercent
            // 
            this.lblPassPercent.AutoSize = true;
            this.lblPassPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassPercent.Location = new System.Drawing.Point(633, 406);
            this.lblPassPercent.Name = "lblPassPercent";
            this.lblPassPercent.Size = new System.Drawing.Size(138, 25);
            this.lblPassPercent.TabIndex = 5;
            this.lblPassPercent.Text = "Pass percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter by student ID:";
            // 
            // cbStudentID
            // 
            this.cbStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(225, 405);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(186, 24);
            this.cbStudentID.TabIndex = 9;
            this.cbStudentID.SelectedIndexChanged += new System.EventHandler(this.cbStudentID_SelectedIndexChanged);
            // 
            // FrmStatisticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStudentID);
            this.Controls.Add(this.lblPassPercent);
            this.Controls.Add(this.chartScoreResult);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatisticResult";
            this.Text = "Statistic Result";
            this.Load += new System.EventHandler(this.FrmStatisticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartScoreResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScoreResult;
        private System.Windows.Forms.Label lblPassPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStudentID;
    }
}