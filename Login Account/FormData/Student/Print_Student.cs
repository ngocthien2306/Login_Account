using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using System.IO;
using DataTable = System.Data.DataTable;
using Login_Account.FormData.CourseForm;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Login_Account.FormData
{
    public partial class Print_Student : Form
    {
        public Print_Student()
        {
            InitializeComponent();
        }
        private bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Add_Student", dataBase.Getcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Add_Student");
                dataBase.Closeconnection();
                dataGridView_Student.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Add_Student"];
                dataGridView_Student.DataSource = table;
                dataGridView_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_Student.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void Save_Documment()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.DefaultExt = ".docx";
                save.Filter = "Word|*.docx";
                save.AddExtension = true;
                save.InitialDirectory = @"C:\Desktop.docx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    object filename = save.FileName;
                    Application word = new Application();
                    word.ShowAnimation = false;
                    word.Visible = false;
                    object missing = System.Reflection.Missing.Value;
                    Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    Paragraph para1 = document.Content.Paragraphs.Add(ref missing); 
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Text = "List of Student\nClass: 19110CLA2\nObject Winform Programming";
                    para1.Range.InsertParagraphAfter();
                    int rows = dataGridView_Student.Rows.Count + 1;
                    int cols = dataGridView_Student.Columns.Count + 1;
                    Table table = document.Tables.Add(para1.Range, rows, cols, ref missing, ref missing);
                    table.Borders.Enable = 1;
                    table.Rows[1].Cells[1].Range.Text = "STT";
                    for (int i = 1; i < table.Rows.Count; i++)
                    {
                        for (int j = 2; j < table.Columns.Count + 1; j++)
                        {

                            //Header 
                            table.Rows[i + 1].Cells[1].Range.Text = i.ToString();
                            table.Rows[1].Cells[j].Range.Text = dataGridView_Student.Columns[j - 2].HeaderText.ToString();
                            table.Rows[1].Cells[j].Range.Font.Bold = 1;
                            table.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            table.Rows[1].Cells[j].Range.Font.Size = 10;
                            table.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorAqua;
                            table.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            table.Rows[i + 1].Cells[j].Range.Text = dataGridView_Student.Rows[i - 1].Cells[j - 2].Value.ToString();
                            
                            if (j == 9)
                            {

                                Image sparePicture = ByteArrayToImage((byte[])dataGridView_Student.Rows[i - 1].Cells[7].Value); //Change to your datagrid's name
                                Clipboard.SetDataObject(sparePicture);

                                table.Rows[i + 1].Cells[j].Range.Paste();
                                Clipboard.Clear();
                            }
                        }
                    }
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    word.Quit(ref missing, ref missing, ref missing);
                    word = null;
                    MessageBox.Show("Save data successful!");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        public Image ByteArrayToImage(byte[] value)
        {
            using(MemoryStream ms = new MemoryStream(value))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            Save_Documment();
        }
        private void Statics_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet2.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.manager_StudentDataSet2.Add_Student);
            // TODO: This line of code loads data into the 'manager_StudentDataSet1.Add_Student' table. You can move, or remove it, as needed.
            ShowList();
        }
        Student student = new Student();
        private void BtCheckStatics_Click(object sender, EventArgs e)
        {

            if(YesRadi.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                if(start > end)
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }
                if(malestudentCheck.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end and gender = 'Male'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
                else if (FemaleStudentCheck.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end and gender = 'Female'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
            }
            else
            {
                if(AllStudentCheck.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student");
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
                else if(FemaleStudentCheck.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where gender = 'Female'");
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where gender = 'Male'");
                    dataGridView_Student.DataSource = student.getStudents(command);
                }
            }                     
        }
    }
}
