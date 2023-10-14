namespace WindowsFormsApp
{
    partial class Form2
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculate.ForeColor = System.Drawing.Color.Purple;
            this.btnCalculate.Location = new System.Drawing.Point(548, 291);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDisplay.Location = new System.Drawing.Point(664, 291);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(84, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Emp ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(84, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Emp Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.ForeColor = System.Drawing.Color.Blue;
            this.lblDepartment.Location = new System.Drawing.Point(84, 91);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.ForeColor = System.Drawing.Color.Blue;
            this.lblBasicSalary.Location = new System.Drawing.Point(84, 127);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(65, 13);
            this.lblBasicSalary.TabIndex = 5;
            this.lblBasicSalary.Text = "Basic Salary";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.ForeColor = System.Drawing.Color.Blue;
            this.lblHRA.Location = new System.Drawing.Point(84, 168);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(30, 13);
            this.lblHRA.TabIndex = 6;
            this.lblHRA.Text = "HRA";
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.ForeColor = System.Drawing.Color.Blue;
            this.lblTA.Location = new System.Drawing.Point(84, 206);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(21, 13);
            this.lblTA.TabIndex = 7;
            this.lblTA.Text = "TA";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.ForeColor = System.Drawing.Color.Blue;
            this.lblDA.Location = new System.Drawing.Point(84, 241);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(22, 13);
            this.lblDA.TabIndex = 8;
            this.lblDA.Text = "DA";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.ForeColor = System.Drawing.Color.Blue;
            this.lblPF.Location = new System.Drawing.Point(84, 271);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(20, 13);
            this.lblPF.TabIndex = 9;
            this.lblPF.Text = "PF";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.ForeColor = System.Drawing.Color.Blue;
            this.lblGrossSalary.Location = new System.Drawing.Point(84, 301);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(66, 13);
            this.lblGrossSalary.TabIndex = 10;
            this.lblGrossSalary.Text = "Gross Salary";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Location = new System.Drawing.Point(178, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 12;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(178, 83);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(178, 127);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBasicSalary.TabIndex = 14;
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(178, 165);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHRA.Size = new System.Drawing.Size(100, 20);
            this.txtHRA.TabIndex = 15;
            this.txtHRA.TextChanged += new System.EventHandler(this.txtHRA_TextChanged);
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(178, 206);
            this.txtTA.Name = "txtTA";
            this.txtTA.ReadOnly = true;
            this.txtTA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTA.Size = new System.Drawing.Size(100, 20);
            this.txtTA.TabIndex = 16;
            this.txtTA.TextChanged += new System.EventHandler(this.txtTA_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(178, 232);
            this.txtDA.Name = "txtDA";
            this.txtDA.ReadOnly = true;
            this.txtDA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 17;
            this.txtDA.TextChanged += new System.EventHandler(this.txtDA_TextChanged);
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(178, 268);
            this.txtPF.Name = "txtPF";
            this.txtPF.ReadOnly = true;
            this.txtPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPF.Size = new System.Drawing.Size(100, 20);
            this.txtPF.TabIndex = 18;
            this.txtPF.TextChanged += new System.EventHandler(this.txtPF_TextChanged);
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(178, 301);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.ReadOnly = true;
            this.txtGrossSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGrossSalary.Size = new System.Drawing.Size(100, 20);
            this.txtGrossSalary.TabIndex = 19;
            this.txtGrossSalary.TextChanged += new System.EventHandler(this.txtGrossSalary_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(439, 53);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(36, 13);
            this.lblmsg.TabIndex = 21;
            this.lblmsg.Text = "lblmsg";
            this.lblmsg.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Label lblmsg;
    }
}