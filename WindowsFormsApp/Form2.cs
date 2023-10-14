using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        List<String> deptlist = new List<String>()
        { "HR","Admin","Sales","Development","Testing","Marketing"


        };
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbDepartment.DataSource = dept
          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = deptlist;    
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtHRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrossSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtBasicSalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs + hra + ta + da) - pf;


            txtHRA.Text=hra.ToString();
            txtTA.Text=ta.ToString();
            txtDA.Text=da.ToString();
            txtPF.Text=pf.ToString();
            txtGrossSalary.Text=gross.ToString();


        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            string msg=txtID.Text + " \n" +txtName.Text + "\n" + cmbDepartment.Text+"\n"+ txtGrossSalary.Text;
            lblmsg.Text=msg;
        }
    }
}
