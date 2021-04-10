
namespace Login_Account.FormData
{
    partial class Statics
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.lbSumOfStudent = new System.Windows.Forms.Label();
            this.lbMale = new System.Windows.Forms.Label();
            this.lbFamale = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSumOfStudent
            // 
            this.lbSumOfStudent.AutoSize = true;
            this.lbSumOfStudent.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumOfStudent.ForeColor = System.Drawing.Color.SeaShell;
            this.lbSumOfStudent.Location = new System.Drawing.Point(23, 30);
            this.lbSumOfStudent.Name = "lbSumOfStudent";
            this.lbSumOfStudent.Size = new System.Drawing.Size(140, 25);
            this.lbSumOfStudent.TabIndex = 0;
            this.lbSumOfStudent.Text = "Total Students:";
            // 
            // lbMale
            // 
            this.lbMale.AutoSize = true;
            this.lbMale.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMale.ForeColor = System.Drawing.Color.SeaShell;
            this.lbMale.Location = new System.Drawing.Point(23, 92);
            this.lbMale.Name = "lbMale";
            this.lbMale.Size = new System.Drawing.Size(58, 25);
            this.lbMale.TabIndex = 1;
            this.lbMale.Text = "Male:";
            // 
            // lbFamale
            // 
            this.lbFamale.AutoSize = true;
            this.lbFamale.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamale.ForeColor = System.Drawing.Color.SeaShell;
            this.lbFamale.Location = new System.Drawing.Point(23, 153);
            this.lbFamale.Name = "lbFamale";
            this.lbFamale.Size = new System.Drawing.Size(84, 25);
            this.lbFamale.TabIndex = 2;
            this.lbFamale.Text = "Female: ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(340, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Lime;
            dataPoint1.Label = "#VAL{P1}";
            dataPoint1.LegendText = "Male";
            dataPoint2.Color = System.Drawing.Color.Yellow;
            dataPoint2.Label = "#VAL{P1}";
            dataPoint2.LegendText = "Female";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(315, 286);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(667, 322);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbFamale);
            this.Controls.Add(this.lbMale);
            this.Controls.Add(this.lbSumOfStudent);
            this.Name = "Statics";
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSumOfStudent;
        private System.Windows.Forms.Label lbMale;
        private System.Windows.Forms.Label lbFamale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}