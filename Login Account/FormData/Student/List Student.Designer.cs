
namespace Login_Account
{
    partial class displaylist_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displaylist_student));
            this.button1_refesh = new System.Windows.Forms.Button();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.EditStudent = new System.Windows.Forms.Button();
            this.RemoveStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_refesh
            // 
            this.button1_refesh.BackColor = System.Drawing.Color.LimeGreen;
            this.button1_refesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1_refesh.Location = new System.Drawing.Point(386, 315);
            this.button1_refesh.Name = "button1_refesh";
            this.button1_refesh.Size = new System.Drawing.Size(125, 36);
            this.button1_refesh.TabIndex = 1;
            this.button1_refesh.Text = "Refesh";
            this.button1_refesh.UseVisualStyleBackColor = false;
            this.button1_refesh.Click += new System.EventHandler(this.button1_refesh_Click);
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Student.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(0, -1);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(879, 311);
            this.dataGridView_Student.TabIndex = 2;
            this.dataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_Student.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // EditStudent
            // 
            this.EditStudent.BackColor = System.Drawing.Color.DarkOrange;
            this.EditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditStudent.Location = new System.Drawing.Point(0, 314);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(83, 36);
            this.EditStudent.TabIndex = 3;
            this.EditStudent.Text = "Edit";
            this.EditStudent.UseVisualStyleBackColor = false;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.BackColor = System.Drawing.Color.Red;
            this.RemoveStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveStudent.Location = new System.Drawing.Point(797, 315);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(82, 35);
            this.RemoveStudent.TabIndex = 4;
            this.RemoveStudent.Text = "Remove";
            this.RemoveStudent.UseVisualStyleBackColor = false;
            this.RemoveStudent.Click += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // displaylist_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(879, 351);
            this.Controls.Add(this.RemoveStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.button1_refesh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "displaylist_student";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Display List";
            this.Load += new System.EventHandler(this.displaylist_student_Load);
            this.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_refesh;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button RemoveStudent;
    }
}