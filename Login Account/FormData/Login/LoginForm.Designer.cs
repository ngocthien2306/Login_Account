
namespace Login_Account
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.user_lb = new System.Windows.Forms.Label();
            this.pass_lb = new System.Windows.Forms.Label();
            this.Username_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Exit_bt = new System.Windows.Forms.Button();
            this.Login_bt = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_lb
            // 
            this.user_lb.AutoSize = true;
            this.user_lb.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lb.Location = new System.Drawing.Point(233, 42);
            this.user_lb.Name = "user_lb";
            this.user_lb.Size = new System.Drawing.Size(76, 14);
            this.user_lb.TabIndex = 0;
            this.user_lb.Text = "Username";
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lb.Location = new System.Drawing.Point(233, 88);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(79, 14);
            this.pass_lb.TabIndex = 1;
            this.pass_lb.Text = "Password";
            // 
            // Username_tb
            // 
            this.Username_tb.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_tb.Location = new System.Drawing.Point(321, 38);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(155, 22);
            this.Username_tb.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Username_tb, "Enter name");
            // 
            // Password_tb
            // 
            this.Password_tb.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tb.Location = new System.Drawing.Point(321, 84);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(155, 22);
            this.Password_tb.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Password_tb, "Enter pass");
            this.Password_tb.UseSystemPasswordChar = true;
            // 
            // Exit_bt
            // 
            this.Exit_bt.BackColor = System.Drawing.Color.OrangeRed;
            this.Exit_bt.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bt.Location = new System.Drawing.Point(321, 164);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(63, 23);
            this.Exit_bt.TabIndex = 4;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.UseVisualStyleBackColor = false;
            this.Exit_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_bt
            // 
            this.Login_bt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_bt.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_bt.Location = new System.Drawing.Point(419, 164);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(57, 23);
            this.Login_bt.TabIndex = 5;
            this.Login_bt.Text = "Login";
            this.Login_bt.UseVisualStyleBackColor = false;
            this.Login_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.CadetBlue;
            this.addUser.Font = new System.Drawing.Font("Microsoft YaHei Light", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(321, 121);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(155, 26);
            this.addUser.TabIndex = 7;
            this.addUser.Text = "New account!";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::Login_Account.Properties.Resources.Login;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Enter pass";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Enter name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(206, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(506, 246);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Username_tb);
            this.Controls.Add(this.pass_lb);
            this.Controls.Add(this.user_lb);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_lb;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button Exit_bt;
        private System.Windows.Forms.Button Login_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

