using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Login_Account.FormData.CourseForm
{
    public partial class PrintCourse : Form
    {
        public PrintCourse()
        {
            InitializeComponent();
        }

        private void PrintCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet1.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.manager_StudentDataSet2.Course);
            this.ShowList();

        }
        private bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Course", dataBase.Getcon);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Course");
                dataGridView_Course.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Course"];
                dataGridView_Course.DataSource = table;
                dataGridView_Course.ReadOnly = true;
                dataGridView_Course.AllowUserToAddRows = false;
                dataBase.Closeconnection();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.ShowList();
        }

        private void PrintFileImage_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application(); 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null; 
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet; 
            worksheet.Name = "Exported from gridview"; 
            for (int i = 1; i < dataGridView_Course.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView_Course.Columns[i - 1].HeaderText;
            }  
            for (int i = 0; i < dataGridView_Course.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_Course.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_Course.Rows[i].Cells[j].Value.ToString();
                }
            }  
            workbook.SaveAs("D:\\list4.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            MessageBox.Show("Save file successful!", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            app.Quit();
        }
    }
}
