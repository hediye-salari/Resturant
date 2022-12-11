using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DomainModel.Models;

namespace Resturant
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeRepositoryInterFace repo = new EmployeeRepositoryInterFace();
            bool r = repo.Login(txtUsername.Text, txtPassword.Text);
            if (r)
            {
                frmSwitch frm = new frmSwitch();
                frm.CurrentUser = txtUsername.Text;
                //هاید یعنی فرم جاری رو ببند و فرم سوییچ را باز کن 
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("نام کاربری و پسوورد اشتباه وارد شده است  ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerRepositories repo = new CustomerRepositories();
            bool r = repo.LoginCustomer(txtUsernameE.Text, txtPasswordE.Text);
            if (r)
            {
                frmswitchCustomer frm = new frmswitchCustomer();
                frm.CurrentCustomer = txtUsername.Text;
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("نام کاربری و پسوورد اشتباه وارد شده است  ");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
