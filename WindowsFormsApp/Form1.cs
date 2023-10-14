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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void buttoncancle_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Admin" && textPassword.Text == "Admin")
            {
                MessageBox.Show("Login Successfully");
                //Form2 form2 = new Form2();
                //form2.Show();
                //this.Hide();//this refer to the login form

                MdiForm obj=new MdiForm();
                obj.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Login failure");
            
            }


        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
