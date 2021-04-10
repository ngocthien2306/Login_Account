
namespace Login_Account.FormData.CourseForm
{
    partial class ListCourse
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
            this.Refersh_bt = new System.Windows.Forms.Button();
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
            this.dataGridView_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Course.AutoGenerateColumns = false;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lableDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_Course.DataSource = this.courseBindingSource;
            this.dataGridView_Course.Location = new System.Drawing.Point(0, 1);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.Size = new System.Drawing.Size(454, 304);
            this.dataGridView_Course.TabIndex = 0;
            this.dataGridView_Course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Course_CellContentClick);
            this.dataGridView_Course.DoubleClick += new System.EventHandler(this.dataGridView_Course_DoubleClick);
            // 
            // Refersh_bt
            // 
            this.Refersh_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Refersh_bt.BackColor = System.Drawing.Color.Moccasin;
            this.Refersh_bt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refersh_bt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Refersh_bt.Location = new System.Drawing.Point(170, 311);
            this.Refersh_bt.Name = "Refersh_bt";
            this.Refersh_bt.Size = new System.Drawing.Size(91, 46);
            this.Refersh_bt.TabIndex = 1;
            this.Refersh_bt.Text = "Refersh ";
            this.Refersh_bt.UseVisualStyleBackColor = false;
            this.Refersh_bt.Click += new System.EventHandler(this.Refersh_bt_Click);
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
            // ListCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 358);
            this.Controls.Add(this.Refersh_bt);
            this.Controls.Add(this.dataGridView_Course);
            this.Name = "ListCourse";
            this.Text = "ListCourse";
            this.Load += new System.EventHandler(this.ListCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Button Refersh_bt;
        private Manager_StudentDataSet2 manager_StudentDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Manager_StudentDataSet2TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}