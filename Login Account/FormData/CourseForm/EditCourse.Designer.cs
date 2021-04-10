
namespace Login_Account.FormData.CourseForm
{
    partial class EditCourse
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
            this.dec_richtext = new System.Windows.Forms.RichTextBox();
            this.Period_tb = new System.Windows.Forms.TextBox();
            this.Label_tb = new System.Windows.Forms.TextBox();
            this.Id_tb = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.NameCourse = new System.Windows.Forms.Label();
            this.Find_course = new System.Windows.Forms.Button();
            this.Edit_bt = new System.Windows.Forms.Button();
            this.remove_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dec_richtext
            // 
            this.dec_richtext.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_richtext.Location = new System.Drawing.Point(128, 165);
            this.dec_richtext.Name = "dec_richtext";
            this.dec_richtext.Size = new System.Drawing.Size(258, 103);
            this.dec_richtext.TabIndex = 15;
            this.dec_richtext.Text = "";
            // 
            // Period_tb
            // 
            this.Period_tb.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period_tb.Location = new System.Drawing.Point(128, 118);
            this.Period_tb.Name = "Period_tb";
            this.Period_tb.Size = new System.Drawing.Size(258, 25);
            this.Period_tb.TabIndex = 14;
            // 
            // Label_tb
            // 
            this.Label_tb.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_tb.Location = new System.Drawing.Point(128, 69);
            this.Label_tb.Name = "Label_tb";
            this.Label_tb.Size = new System.Drawing.Size(258, 25);
            this.Label_tb.TabIndex = 13;
            // 
            // Id_tb
            // 
            this.Id_tb.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_tb.Location = new System.Drawing.Point(128, 21);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(258, 25);
            this.Id_tb.TabIndex = 12;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(31, 183);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(85, 19);
            this.description.TabIndex = 11;
            this.description.Text = "Discription:";
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period.Location = new System.Drawing.Point(31, 125);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(58, 19);
            this.period.TabIndex = 10;
            this.period.Text = "Period:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(31, 72);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(49, 19);
            this.Label.TabIndex = 9;
            this.Label.Text = "Label:";
            // 
            // NameCourse
            // 
            this.NameCourse.AutoSize = true;
            this.NameCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameCourse.Location = new System.Drawing.Point(31, 21);
            this.NameCourse.Name = "NameCourse";
            this.NameCourse.Size = new System.Drawing.Size(77, 19);
            this.NameCourse.TabIndex = 8;
            this.NameCourse.Text = "Course ID:";
            // 
            // Find_course
            // 
            this.Find_course.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Find_course.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_course.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Find_course.Location = new System.Drawing.Point(402, 12);
            this.Find_course.Name = "Find_course";
            this.Find_course.Size = new System.Drawing.Size(75, 39);
            this.Find_course.TabIndex = 16;
            this.Find_course.Text = "Find";
            this.Find_course.UseVisualStyleBackColor = false;
            this.Find_course.Click += new System.EventHandler(this.Find_course_Click);
            // 
            // Edit_bt
            // 
            this.Edit_bt.BackColor = System.Drawing.Color.Lime;
            this.Edit_bt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_bt.Location = new System.Drawing.Point(34, 285);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(75, 39);
            this.Edit_bt.TabIndex = 17;
            this.Edit_bt.Text = "Edit";
            this.Edit_bt.UseVisualStyleBackColor = false;
            this.Edit_bt.Click += new System.EventHandler(this.Edit_bt_Click);
            // 
            // remove_bt
            // 
            this.remove_bt.BackColor = System.Drawing.Color.Orange;
            this.remove_bt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove_bt.Location = new System.Drawing.Point(402, 285);
            this.remove_bt.Name = "remove_bt";
            this.remove_bt.Size = new System.Drawing.Size(75, 39);
            this.remove_bt.TabIndex = 18;
            this.remove_bt.Text = "Remove";
            this.remove_bt.UseVisualStyleBackColor = false;
            this.remove_bt.Click += new System.EventHandler(this.remove_bt_Click);
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(489, 336);
            this.Controls.Add(this.remove_bt);
            this.Controls.Add(this.Edit_bt);
            this.Controls.Add(this.Find_course);
            this.Controls.Add(this.dec_richtext);
            this.Controls.Add(this.Period_tb);
            this.Controls.Add(this.Label_tb);
            this.Controls.Add(this.Id_tb);
            this.Controls.Add(this.description);
            this.Controls.Add(this.period);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NameCourse);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label NameCourse;
        private System.Windows.Forms.Button Find_course;
        private System.Windows.Forms.Button Edit_bt;
        private System.Windows.Forms.Button remove_bt;
        public System.Windows.Forms.RichTextBox dec_richtext;
        public System.Windows.Forms.TextBox Period_tb;
        public System.Windows.Forms.TextBox Label_tb;
        public System.Windows.Forms.TextBox Id_tb;
    }
}