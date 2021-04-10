
namespace Login_Account
{
    partial class SignIn_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn_Account));
            this.user_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.repass_label = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.repass_text = new System.Windows.Forms.TextBox();
            this.exitbt = new System.Windows.Forms.Button();
            this.signin_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.MediumTurquoise;
            this.user_label.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_label.Location = new System.Drawing.Point(151, 29);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(79, 13);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "Username:";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pass_label.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass_label.Location = new System.Drawing.Point(151, 88);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(79, 13);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password:";
            // 
            // repass_label
            // 
            this.repass_label.AutoSize = true;
            this.repass_label.BackColor = System.Drawing.Color.MediumTurquoise;
            this.repass_label.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repass_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repass_label.Location = new System.Drawing.Point(151, 149);
            this.repass_label.Name = "repass_label";
            this.repass_label.Size = new System.Drawing.Size(103, 13);
            this.repass_label.TabIndex = 2;
            this.repass_label.Text = "Re-Password:";
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(266, 25);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(128, 20);
            this.user_text.TabIndex = 3;
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(266, 84);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(128, 20);
            this.pass_text.TabIndex = 4;
            // 
            // repass_text
            // 
            this.repass_text.Location = new System.Drawing.Point(266, 145);
            this.repass_text.Name = "repass_text";
            this.repass_text.Size = new System.Drawing.Size(128, 20);
            this.repass_text.TabIndex = 5;
            // 
            // exitbt
            // 
            this.exitbt.BackColor = System.Drawing.Color.Red;
            this.exitbt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbt.Location = new System.Drawing.Point(12, 193);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(75, 35);
            this.exitbt.TabIndex = 6;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = false;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // signin_bt
            // 
            this.signin_bt.BackColor = System.Drawing.Color.LimeGreen;
            this.signin_bt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signin_bt.Location = new System.Drawing.Point(301, 193);
            this.signin_bt.Name = "signin_bt";
            this.signin_bt.Size = new System.Drawing.Size(75, 35);
            this.signin_bt.TabIndex = 7;
            this.signin_bt.Text = "Sign In";
            this.signin_bt.UseVisualStyleBackColor = false;
            this.signin_bt.Click += new System.EventHandler(this.signin_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_Account.Properties.Resources.signin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(406, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signin_bt);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.repass_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.repass_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.user_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn_Account";
            this.Text = "Sign in ";
            this.Load += new System.EventHandler(this.SignIn_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label repass_label;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox repass_text;
        private System.Windows.Forms.Button exitbt;
        private System.Windows.Forms.Button signin_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}