
namespace Login_Account.FormData.CourseForm
{
    partial class PrintCourse
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
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.PrintToText = new System.Windows.Forms.Button();
            this.PrintFileImage = new System.Windows.Forms.Button();
            this.CheckList = new System.Windows.Forms.Button();
            this.manager_StudentDataSet2 = new Login_Account.Manager_StudentDataSet2();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Login_Account.Manager_StudentDataSet2TableAdapters.CourseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.AutoGenerateColumns = false;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lableDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_Course.DataSource = this.courseBindingSource;
            this.dataGridView_Course.Location = new System.Drawing.Point(12, 59);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.Size = new System.Drawing.Size(453, 221);
            this.dataGridView_Course.TabIndex = 0;
            // 
            // PrintToText
            // 
            this.PrintToText.Location = new System.Drawing.Point(12, 286);
            this.PrintToText.Name = "PrintToText";
            this.PrintToText.Size = new System.Drawing.Size(75, 44);
            this.PrintToText.TabIndex = 1;
            this.PrintToText.Text = "Print as text";
            this.PrintToText.UseVisualStyleBackColor = true;
            // 
            // PrintFileImage
            // 
            this.PrintFileImage.Location = new System.Drawing.Point(390, 286);
            this.PrintFileImage.Name = "PrintFileImage";
            this.PrintFileImage.Size = new System.Drawing.Size(75, 44);
            this.PrintFileImage.TabIndex = 2;
            this.PrintFileImage.Text = "Save File";
            this.PrintFileImage.UseVisualStyleBackColor = true;
            this.PrintFileImage.Click += new System.EventHandler(this.PrintFileImage_Click);
            // 
            // CheckList
            // 
            this.CheckList.Location = new System.Drawing.Point(390, 12);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(75, 41);
            this.CheckList.TabIndex = 3;
            this.CheckList.Text = "Check";
            this.CheckList.UseVisualStyleBackColor = true;
            this.CheckList.Click += new System.EventHandler(this.button3_Click);
            // 
            // manager_StudentDataSet2
            // 
            this.manager_StudentDataSet2.DataSetName = "Manager_StudentDataSet2";
            this.manager_StudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.manager_StudentDataSet2;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lableDataGridViewTextBoxColumn
            // 
            this.lableDataGridViewTextBoxColumn.DataPropertyName = "lable";
            this.lableDataGridViewTextBoxColumn.HeaderText = "lable";
            this.lableDataGridViewTextBoxColumn.Name = "lableDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 342);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.PrintFileImage);
            this.Controls.Add(this.PrintToText);
            this.Controls.Add(this.dataGridView_Course);
            this.Name = "PrintCourse";
            this.Text = "Print List Course";
            this.Load += new System.EventHandler(this.PrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Button PrintToText;
        private System.Windows.Forms.Button PrintFileImage;
        private System.Windows.Forms.Button CheckList;
        private Manager_StudentDataSet2 manager_StudentDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Manager_StudentDataSet2TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}