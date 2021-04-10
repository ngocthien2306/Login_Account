
namespace Login_Account
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.label1student = new System.Windows.Forms.Label();
            this.label2firstname = new System.Windows.Forms.Label();
            this.label3lastname = new System.Windows.Forms.Label();
            this.label4birthday = new System.Windows.Forms.Label();
            this.label5gender = new System.Windows.Forms.Label();
            this.label6address = new System.Windows.Forms.Label();
            this.label7phone = new System.Windows.Forms.Label();
            this.label8picture = new System.Windows.Forms.Label();
            this.ID_student = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.malebutton = new System.Windows.Forms.RadioButton();
            this.femalebutton = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.Button();
            this.loadimage = new System.Windows.Forms.Button();
            this.errorID = new System.Windows.Forms.Label();
            this.errorphone = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1student
            // 
            this.label1student.AutoSize = true;
            this.label1student.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1student.ForeColor = System.Drawing.Color.Black;
            this.label1student.Location = new System.Drawing.Point(12, 28);
            this.label1student.Name = "label1student";
            this.label1student.Size = new System.Drawing.Size(64, 16);
            this.label1student.TabIndex = 0;
            this.label1student.Text = "ID Student:";
            // 
            // label2firstname
            // 
            this.label2firstname.AutoSize = true;
            this.label2firstname.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2firstname.Location = new System.Drawing.Point(12, 78);
            this.label2firstname.Name = "label2firstname";
            this.label2firstname.Size = new System.Drawing.Size(65, 16);
            this.label2firstname.TabIndex = 1;
            this.label2firstname.Text = "First Name:";
            // 
            // label3lastname
            // 
            this.label3lastname.AutoSize = true;
            this.label3lastname.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3lastname.Location = new System.Drawing.Point(12, 123);
            this.label3lastname.Name = "label3lastname";
            this.label3lastname.Size = new System.Drawing.Size(64, 16);
            this.label3lastname.TabIndex = 2;
            this.label3lastname.Text = "Last Name:";
            // 
            // label4birthday
            // 
            this.label4birthday.AutoSize = true;
            this.label4birthday.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4birthday.Location = new System.Drawing.Point(12, 171);
            this.label4birthday.Name = "label4birthday";
            this.label4birthday.Size = new System.Drawing.Size(51, 16);
            this.label4birthday.TabIndex = 3;
            this.label4birthday.Text = "Birthday:";
            // 
            // label5gender
            // 
            this.label5gender.AutoSize = true;
            this.label5gender.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5gender.Location = new System.Drawing.Point(13, 219);
            this.label5gender.Name = "label5gender";
            this.label5gender.Size = new System.Drawing.Size(48, 16);
            this.label5gender.TabIndex = 4;
            this.label5gender.Text = "Gender:";
            // 
            // label6address
            // 
            this.label6address.AutoSize = true;
            this.label6address.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6address.Location = new System.Drawing.Point(12, 262);
            this.label6address.Name = "label6address";
            this.label6address.Size = new System.Drawing.Size(73, 16);
            this.label6address.TabIndex = 5;
            this.label6address.Text = "Address No: ";
            // 
            // label7phone
            // 
            this.label7phone.AutoSize = true;
            this.label7phone.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7phone.Location = new System.Drawing.Point(12, 306);
            this.label7phone.Name = "label7phone";
            this.label7phone.Size = new System.Drawing.Size(86, 16);
            this.label7phone.TabIndex = 6;
            this.label7phone.Text = "Phone Number:";
            // 
            // label8picture
            // 
            this.label8picture.AutoSize = true;
            this.label8picture.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8picture.Location = new System.Drawing.Point(14, 379);
            this.label8picture.Name = "label8picture";
            this.label8picture.Size = new System.Drawing.Size(47, 16);
            this.label8picture.TabIndex = 7;
            this.label8picture.Text = "Picture: ";
            this.label8picture.Click += new System.EventHandler(this.label8picture_Click);
            // 
            // ID_student
            // 
            this.ID_student.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_student.Location = new System.Drawing.Point(119, 28);
            this.ID_student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID_student.Name = "ID_student";
            this.ID_student.Size = new System.Drawing.Size(140, 23);
            this.ID_student.TabIndex = 0;
            this.ID_student.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_ID_KeyPress);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(119, 304);
            this.phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(140, 23);
            this.phone.TabIndex = 7;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // address1
            // 
            this.address1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1.Location = new System.Drawing.Point(119, 258);
            this.address1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(140, 23);
            this.address1.TabIndex = 6;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(119, 123);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(140, 23);
            this.lastname.TabIndex = 2;
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(119, 74);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(140, 23);
            this.firstname.TabIndex = 1;
            // 
            // datetime
            // 
            this.datetime.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.CustomFormat = "dd/MM/yyyy";
            this.datetime.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(119, 171);
            this.datetime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.datetime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(140, 23);
            this.datetime.TabIndex = 3;
            this.datetime.Value = new System.DateTime(2021, 3, 10, 13, 58, 46, 0);
            this.datetime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // malebutton
            // 
            this.malebutton.AutoSize = true;
            this.malebutton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malebutton.Location = new System.Drawing.Point(119, 217);
            this.malebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.malebutton.Name = "malebutton";
            this.malebutton.Size = new System.Drawing.Size(55, 21);
            this.malebutton.TabIndex = 4;
            this.malebutton.TabStop = true;
            this.malebutton.Text = "Male";
            this.malebutton.UseVisualStyleBackColor = true;
            // 
            // femalebutton
            // 
            this.femalebutton.AutoSize = true;
            this.femalebutton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalebutton.Location = new System.Drawing.Point(192, 217);
            this.femalebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femalebutton.Name = "femalebutton";
            this.femalebutton.Size = new System.Drawing.Size(67, 21);
            this.femalebutton.TabIndex = 5;
            this.femalebutton.TabStop = true;
            this.femalebutton.Text = "Female";
            this.femalebutton.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.OrangeRed;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(16, 491);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 28);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1exit_Click);
            // 
            // adding
            // 
            this.adding.BackColor = System.Drawing.Color.Lime;
            this.adding.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adding.Location = new System.Drawing.Point(253, 489);
            this.adding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(75, 28);
            this.adding.TabIndex = 9;
            this.adding.Text = "Add";
            this.adding.UseVisualStyleBackColor = false;
            this.adding.Click += new System.EventHandler(this.button2add_Click);
            // 
            // loadimage
            // 
            this.loadimage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loadimage.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadimage.Location = new System.Drawing.Point(119, 455);
            this.loadimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadimage.Name = "loadimage";
            this.loadimage.Size = new System.Drawing.Size(89, 28);
            this.loadimage.TabIndex = 8;
            this.loadimage.Text = "Upload image";
            this.loadimage.UseVisualStyleBackColor = false;
            this.loadimage.Click += new System.EventHandler(this.button1_loadimage_Click);
            // 
            // errorID
            // 
            this.errorID.AutoSize = true;
            this.errorID.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorID.ForeColor = System.Drawing.Color.Red;
            this.errorID.Location = new System.Drawing.Point(265, 31);
            this.errorID.Name = "errorID";
            this.errorID.Size = new System.Drawing.Size(0, 16);
            this.errorID.TabIndex = 11;
            // 
            // errorphone
            // 
            this.errorphone.AutoSize = true;
            this.errorphone.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorphone.ForeColor = System.Drawing.Color.Red;
            this.errorphone.Location = new System.Drawing.Point(265, 307);
            this.errorphone.Name = "errorphone";
            this.errorphone.Size = new System.Drawing.Size(0, 17);
            this.errorphone.TabIndex = 21;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.CadetBlue;
            this.picture.Location = new System.Drawing.Point(119, 335);
            this.picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(196, 112);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 16;
            this.picture.TabStop = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(349, 532);
            this.Controls.Add(this.errorphone);
            this.Controls.Add(this.errorID);
            this.Controls.Add(this.loadimage);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.femalebutton);
            this.Controls.Add(this.malebutton);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.ID_student);
            this.Controls.Add(this.label8picture);
            this.Controls.Add(this.label7phone);
            this.Controls.Add(this.label6address);
            this.Controls.Add(this.label5gender);
            this.Controls.Add(this.label4birthday);
            this.Controls.Add(this.label3lastname);
            this.Controls.Add(this.label2firstname);
            this.Controls.Add(this.label1student);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1student;
        private System.Windows.Forms.Label label2firstname;
        private System.Windows.Forms.Label label3lastname;
        private System.Windows.Forms.Label label4birthday;
        private System.Windows.Forms.Label label5gender;
        private System.Windows.Forms.Label label6address;
        private System.Windows.Forms.Label label7phone;
        private System.Windows.Forms.Label label8picture;
        private System.Windows.Forms.TextBox ID_student;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.RadioButton malebutton;
        private System.Windows.Forms.RadioButton femalebutton;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Button loadimage;
        private System.Windows.Forms.Label errorID;
        private System.Windows.Forms.Label errorphone;
    }
}