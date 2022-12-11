using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
   
    public partial class frmswitchCustomer : Form
    {
        public string CurrentCustomer { get; set; }
        public frmswitchCustomer()
        {
            InitializeComponent();
        }

       

        private void frmswitchCustomer_Load(object sender, EventArgs e)
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
                this.WindowState = FormWindowState.Maximized;
                lblCurentdate.Text = FrameWork.PersianDate.TopersianDate(DateTime.Now);
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblcurentuser.Text = CurrentCustomer;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void سفارشغذاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmOrder)
                {
                    ExistingForm.Activate();
                    return;
                }
            }
            frmOrderDetails frmorder = new frmOrderDetails();
            //کاربری که لاگین کرده همان کاربری تسن که در سیستم است 
            //frmorder.UserName = this.CurrentCustomer;
            //frmorder.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frmorder.Show();
        }

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

        private void ویرایشپنلکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingForm in this.MdiChildren)
            {
                if (ExistingForm is frmCustomer)
                {
                    ExistingForm.Activate();
                    return;
                }
            }
            frmCustomer frmcustomer = new frmCustomer();
            frmcustomer.MdiParent = this;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            frmcustomer.Show();

        }
    }
}


