using LiveCharts;
using Login_Account.FormData.CourseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Login_Account.FormData
{
    public partial class Statics : Form
    {

        public Statics()
        {
            InitializeComponent();
        }
        private void DrawPieChart(double value1, double value2)
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Gender";
            chart1.Legends[0].BorderColor = Color.Black;
            string seriesname = "Gender";
            chart1.Series.Add(seriesname);

            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            chart1.Series[seriesname].Points.AddXY("Male" , value1);
            chart1.Series[seriesname].Points.AddXY("Female" , value2);


        }
        private void Statics_Load(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                double total = Convert.ToDouble(student.TotalStudent());
                double totalmale = Convert.ToDouble(student.TotalMaleStudent());
                double totalfemale = Convert.ToDouble(student.TotalFemaleStudent());
                double percentsMale = totalmale * 100 / total;
                double percentsFemale = totalfemale * 100 / total;
                lbSumOfStudent.Text = "Total of Student: " + total.ToString() + " (100%) ";
                lbMale.Text = "Total of Male: " + totalmale.ToString() + "  (" + percentsMale.ToString("0.00") + "%)";
                lbFamale.Text = "Total of Famale: " + totalfemale.ToString() + "  (" + percentsFemale.ToString("0.00") + "%)";
                this.DrawPieChart(totalmale, totalfemale);

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
           
        }
        public void Chart()
        {
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
