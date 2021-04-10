
namespace Login_Account.FormData
{
    partial class Print_Student
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
            this.BtCheckStatics = new System.Windows.Forms.Button();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet2 = new Login_Account.Manager_StudentDataSet2();
            this.AllStudentCheck = new System.Windows.Forms.RadioButton();
            this.malestudentCheck = new System.Windows.Forms.RadioButton();
            this.FemaleStudentCheck = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BrithBW = new System.Windows.Forms.Label();
            this.NoRadi = new System.Windows.Forms.RadioButton();
            this.YesRadi = new System.Windows.Forms.RadioButton();
            this.lbRange = new System.Windows.Forms.Label();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.add_StudentTableAdapter = new Login_Account.Manager_StudentDataSet2TableAdapters.Add_StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCheckStatics
            // 
            this.BtCheckStatics.BackColor = System.Drawing.Color.SpringGreen;
            this.BtCheckStatics.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCheckStatics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtCheckStatics.Location = new System.Drawing.Point(761, 28);
            this.BtCheckStatics.Name = "BtCheckStatics";
            this.BtCheckStatics.Size = new System.Drawing.Size(75, 47);
            this.BtCheckStatics.TabIndex = 0;
            this.BtCheckStatics.Text = "Check";
            this.BtCheckStatics.UseVisualStyleBackColor = false;
            this.BtCheckStatics.Click += new System.EventHandler(this.BtCheckStatics_Click);
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.AutoGenerateColumns = false;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_Student.DataSource = this.addStudentBindingSource;
            this.dataGridView_Student.Location = new System.Drawing.Point(2, 121);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(850, 318);
            this.dataGridView_Student.TabIndex = 1;
            this.dataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataMember = "Add_Student";
            this.addStudentBindingSource.DataSource = this.manager_StudentDataSet2;
            // 
            // manager_StudentDataSet2
            // 
            this.manager_StudentDataSet2.DataSetName = "Manager_StudentDataSet2";
            this.manager_StudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllStudentCheck
            // 
            this.AllStudentCheck.AutoSize = true;
            this.AllStudentCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStudentCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllStudentCheck.Location = new System.Drawing.Point(2, 40);
            this.AllStudentCheck.Name = "AllStudentCheck";
            this.AllStudentCheck.Size = new System.Drawing.Size(45, 23);
            this.AllStudentCheck.TabIndex = 2;
            this.AllStudentCheck.TabStop = true;
            this.AllStudentCheck.Text = "All";
            this.AllStudentCheck.UseVisualStyleBackColor = true;
            // 
            // malestudentCheck
            // 
            this.malestudentCheck.AutoSize = true;
            this.malestudentCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malestudentCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.malestudentCheck.Location = new System.Drawing.Point(86, 40);
            this.malestudentCheck.Name = "malestudentCheck";
            this.malestudentCheck.Size = new System.Drawing.Size(60, 23);
            this.malestudentCheck.TabIndex = 3;
            this.malestudentCheck.TabStop = true;
            this.malestudentCheck.Text = "Male";
            this.malestudentCheck.UseVisualStyleBackColor = true;
            // 
            // FemaleStudentCheck
            // 
            this.FemaleStudentCheck.AutoSize = true;
            this.FemaleStudentCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleStudentCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FemaleStudentCheck.Location = new System.Drawing.Point(185, 40);
            this.FemaleStudentCheck.Name = "FemaleStudentCheck";
            this.FemaleStudentCheck.Size = new System.Drawing.Size(75, 23);
            this.FemaleStudentCheck.TabIndex = 4;
            this.FemaleStudentCheck.TabStop = true;
            this.FemaleStudentCheck.Text = "Female";
            this.FemaleStudentCheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.BrithBW);
            this.panel1.Controls.Add(this.NoRadi);
            this.panel1.Controls.Add(this.YesRadi);
            this.panel1.Controls.Add(this.lbRange);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(364, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 103);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 25);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // BrithBW
            // 
            this.BrithBW.AutoSize = true;
            this.BrithBW.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrithBW.Location = new System.Drawing.Point(3, 67);
            this.BrithBW.Name = "BrithBW";
            this.BrithBW.Size = new System.Drawing.Size(123, 19);
            this.BrithBW.TabIndex = 3;
            this.BrithBW.Text = "Birthday Between: ";
            // 
            // NoRadi
            // 
            this.NoRadi.AutoSize = true;
            this.NoRadi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRadi.Location = new System.Drawing.Point(263, 19);
            this.NoRadi.Name = "NoRadi";
            this.NoRadi.Size = new System.Drawing.Size(49, 23);
            this.NoRadi.TabIndex = 2;
            this.NoRadi.TabStop = true;
            this.NoRadi.Text = "NO";
            this.NoRadi.UseVisualStyleBackColor = true;
            // 
            // YesRadi
            // 
            this.YesRadi.AutoSize = true;
            this.YesRadi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRadi.Location = new System.Drawing.Point(160, 19);
            this.YesRadi.Name = "YesRadi";
            this.YesRadi.Size = new System.Drawing.Size(50, 23);
            this.YesRadi.TabIndex = 1;
            this.YesRadi.TabStop = true;
            this.YesRadi.Text = "YES";
            this.YesRadi.UseVisualStyleBackColor = true;
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRange.Location = new System.Drawing.Point(3, 19);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(110, 19);
            this.lbRange.TabIndex = 0;
            this.lbRange.Text = "Use Date Range:";
            // 
            // btSaveFile
            // 
            this.btSaveFile.BackColor = System.Drawing.Color.Orange;
            this.btSaveFile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSaveFile.Location = new System.Drawing.Point(76, 445);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(152, 38);
            this.btSaveFile.TabIndex = 6;
            this.btSaveFile.Text = "Save To Text File";
            this.btSaveFile.UseVisualStyleBackColor = false;
            this.btSaveFile.Click += new System.EventHandler(this.btSaveFile_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.SpringGreen;
            this.btPrint.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPrint.Location = new System.Drawing.Point(644, 445);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(125, 38);
            this.btPrint.TabIndex = 7;
            this.btPrint.Text = "To Printer ";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // add_StudentTableAdapter
            // 
            this.add_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // Print_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FemaleStudentCheck);
            this.Controls.Add(this.malestudentCheck);
            this.Controls.Add(this.AllStudentCheck);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.BtCheckStatics);
            this.Name = "Print_Student";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Statics_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCheckStatics;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.RadioButton AllStudentCheck;
        private System.Windows.Forms.RadioButton malestudentCheck;
        private System.Windows.Forms.RadioButton FemaleStudentCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label BrithBW;
        private System.Windows.Forms.RadioButton NoRadi;
        private System.Windows.Forms.RadioButton YesRadi;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.Button btPrint;
        private Manager_StudentDataSet2 manager_StudentDataSet2;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private Manager_StudentDataSet2TableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}