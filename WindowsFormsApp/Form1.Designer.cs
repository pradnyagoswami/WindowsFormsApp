namespace WindowsFormsApp
{
    partial class Loginform
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
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttoncancle = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lalPassword = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonlogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonlogin.Location = new System.Drawing.Point(151, 227);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(108, 23);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "LOGIN";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttoncancle
            // 
            this.buttoncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttoncancle.ForeColor = System.Drawing.Color.Red;
            this.buttoncancle.Location = new System.Drawing.Point(298, 227);
            this.buttoncancle.Name = "buttoncancle";
            this.buttoncancle.Size = new System.Drawing.Size(108, 23);
            this.buttoncancle.TabIndex = 1;
            this.buttoncancle.Text = "CANCLE";
            this.buttoncancle.UseVisualStyleBackColor = false;
            this.buttoncancle.Click += new System.EventHandler(this.buttoncancle_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Linen;
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(165, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "USERNAME";
            // 
            // lalPassword
            // 
            this.lalPassword.AutoSize = true;
            this.lalPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lalPassword.Location = new System.Drawing.Point(165, 118);
            this.lalPassword.Name = "lalPassword";
            this.lalPassword.Size = new System.Drawing.Size(70, 13);
            this.lalPassword.TabIndex = 3;
            this.lalPassword.Text = "PASSWORD";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(317, 80);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 20);
            this.textUsername.TabIndex = 4;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(317, 111);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 5;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 312);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lalPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.buttoncancle);
            this.Controls.Add(this.buttonlogin);
            this.Name = "Loginform";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttoncancle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lalPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
    }
}

