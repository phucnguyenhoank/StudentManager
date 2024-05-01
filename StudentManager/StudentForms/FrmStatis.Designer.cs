namespace StudentManager
{
    partial class FrmStatis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartStatis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatis
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatis.ChartAreas.Add(chartArea1);
            this.chartStatis.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStatis.Legends.Add(legend1);
            this.chartStatis.Location = new System.Drawing.Point(0, 0);
            this.chartStatis.Name = "chartStatis";
            this.chartStatis.Size = new System.Drawing.Size(800, 450);
            this.chartStatis.TabIndex = 0;
            this.chartStatis.Text = "chart1";
            this.chartStatis.Click += new System.EventHandler(this.chartStatis_Click);
            // 
            // FrmStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartStatis);
            this.Name = "FrmStatis";
            this.Text = "Statis By Month";
            this.Load += new System.EventHandler(this.frmStatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatis;
    }
}