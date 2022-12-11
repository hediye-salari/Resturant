using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DataAccess.Repositories;




namespace Resturant
{
    public partial class frmSwitch : Form
    {
        //برای اینکه کاربر وارد شده را در در فرم نمایش دهد باید از فرم لاگین به این فرم 
        //پاس داده شود پس 
        public string  CurrentUser { get; set; }
        public frmSwitch()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmSwitch_Load(object sender, EventArgs e)
        {
           

            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.Blue;
                   
                    // 4#
                    break;
                }


                //فرم را به محض اجرا ماکسیمایز میکنه 
                this.WindowState = FormWindowState.Maximized;
                lblCurentdate.Text = FrameWork.PersianDate.TopersianDate(DateTime.Now);
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblcurentuser.Text = CurrentUser;
               
            }
        }

        //private Color GetYourColour()
        //{
        //    throw new NotImplementedException();
        //}

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lblCurentdate.Text = FrameWork.PersianDate.TopersianDate(DateTime.Now);
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurentdate.Text = FrameWork.PersianDate.TopersianDate(DateTime.Now);
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void CategoryManagement_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmFoodCategory)
                {
                    ExistingForm.Activate();
                    return;
                }
            }

            frmFoodCategory frm = new frmFoodCategory();
            frm.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frm.Show();
        }

        private void EmployeeManagement_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmEmployee)
                {
                    ExistingForm.Activate();
                    return;
                }
            }

            frmEmployee child = new frmEmployee();
            child.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            child.Show();
        }

        private void FoodManagement_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmFood)
                {
                    ExistingForm.Activate();
                    return;
                }
            }
            frmFood frm = new frmFood();
            frm.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frm.Show();
        }

        private void OrderManagment_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmOrder)
                {
                    ExistingForm.Activate();
                    return;
                }
            }
            frmOrder frm = new frmOrder();
            //کاربری که لاگین کرده همان کاربری تسن که در سیستم است 
            frm.UserName = this.CurrentUser;
            frm.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frm.Show();
        }

        private void مدیریتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmCustomer)
                {
                    ExistingForm.Activate();
                    return;
                }
            }
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmSwitch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }

        
    }

