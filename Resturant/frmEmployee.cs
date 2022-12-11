using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DomainModel.Models;
using DomainModel.View_model;

namespace Resturant
{

    public partial class frmEmployee : Form
    {
        public string CurrentUser { get; set; }
        private int EmployeeID = 0;


        private void dosearch()
        {
            EmployeeSearchModel sm = new EmployeeSearchModel();
            if (txtFirstNameSearch.Text!=null)
            {
                sm.FirstName = txtFirstNameSearch.Text;
            }
            if (txtLastNameSearch.Text != null)
            {
                sm.LastName = txtLastNameSearch.Text;
            }
            if (txtUserName.Text != null)
            {
                sm.UserName = txtUserNameSearch.Text;
            }
            if (txtPassWordSearch.Text != null)
            {
                sm.Password = txtPassWordSearch.Text;
            }
            if (txtMobileSearch.Text != null)
            {
                sm.Mobile = txtMobileSearch.Text;
            }
            using (DataAccess.Repositories.EmployeeRepositoryInterFace repo=new EmployeeRepositoryInterFace())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.Search(sm);
            }
        }
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void GoToAddMode()
        {
            //دکمه ادد دیده بشه ولی دکمه آپدیت و کنسل دیده نشود 
            btnsave.Visible = true;
            btnUpdate.Visible = false;
            btnCancele.Visible = false;
        }
        private void GoToEditeMode()
        {
            //دکمه ادد دیده نشه ولی دکمه آپدیت و کنسل دیده شود 
            btnsave.Visible = false;
            btnUpdate.Visible = true;
            btnCancele.Visible = true;
        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();

            //dataGridView1.Columns.Add(dgvimgcol);

            //dataGridView1.RowTemplate.Height = 50;

            //dataGridView1.AllowUserToAddRows = false;

           
            dataGridView1.AutoGenerateColumns = false;
            this.WindowState = FormWindowState.Maximized;
            BindGrid();
            GoToAddMode();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            DataAccess.Repositories.EmployeeRepositoryInterFace repo = new EmployeeRepositoryInterFace();
            DomainModel.Models.Employee emp = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Mobile = txtMobile.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text,
                //picture = Convert.ToString(pictureBox1)
            };
            repo.AddNew(emp);
            /* int id =*/

            //if (id == -1000)
            //{
            //    MessageBox.Show("UserName Alrady Exist");
            //}
            //DataAccess.Repositories.EmployeeRepositories repo = new EmployeeRepositories();
            //DomainModel.Models.Employee emp = new DomainModel.Models.Employee()
            //{
            //    FirstName = txtFirstName.Text,
            //    LastName = txtLastName.Text,
            //    Mobile = txtMobile.Text,
            //    UserName = txtUserName.Text,
            //    Password = txtPassword.Text
            //};

            //int id = repo.Add(emp);
            //if (id == -1000)
            //{
            //    MessageBox.Show("UserName Already Exist");
            //}
            //try
            //{
            //repo.Add(emp);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}



            BindGrid();
            ClearForm();
        }
        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";

        }
        private void BindGrid()
        {
            //برای وارد کردن دیتا در گرید ویو 
            dataGridView1.DataSource = false;//مقدار دیتا گرید و اول خالی کن 
            DataAccess.Repositories.EmployeeRepositoryInterFace repo = new EmployeeRepositoryInterFace();
            List<Employee> Employees = repo.GetAll();
            dataGridView1.DataSource = Employees;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess.Repositories.EmployeeRepositoryInterFace repo = new EmployeeRepositoryInterFace();
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("آیا میخواهین دیتا حذف شود ؟", "پیغام خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int empId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    repo.Delete(empId);
                    BindGrid();
                    
                }
            }

            if (e.ColumnIndex == 6)
            {
                //آیدی را بدست میاریم 
                //تا عملیات ویرایش بر اساس آیدی که یونیک است انجام شود 
                //private int EmployeeID = 0; چون دکمه آپدیت  آیدی ندارد یک آیدی در سطح پرایوت تعریف میکنیم 
                this.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Employee emp = repo.Get(EmployeeID);
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtMobile.Text = emp.Mobile;
                txtUserName.Text = emp.UserName;
                txtPassword.Text = emp.Password;
                GoToEditeMode();
            }
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //این دکمه زده شد بره تو دیتا بیس ذخیره کنه تغییرات را و دکمه ادد را نمایش بده و کل مقادیر را پاک کن  
            Employee emp = new Employee()
            //امپلویی میسازه میگه برو  این و تو دیتا بیس ذخیره کن 
            //تابع آپدیت در ریپوزیتوری از ما یک  ایمپلویی میگیره 
            {
                FirstName =txtFirstName.Text,
                LastName = txtLastName.Text,
                Mobile = txtMobile.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                //در سطح کلاس مینویسیم 
                //private int EmployeeID = 0;
                EmployeeID = this.EmployeeID

            };
            //حالا میخواهیم تغییرات در دیتا بیس ثبت شود 
            DataAccess.Repositories.EmployeeRepositoryInterFace repo = new DataAccess.Repositories.EmployeeRepositoryInterFace();
            repo.Update(emp);
            ClearForm();
            GoToAddMode();
            BindGrid();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstNameSearch_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtLastNameSearch_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtUserNameSearch_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtPassWordSearch_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtMobileSearch_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MemoryStream mmst = new MemoryStream();
            //pictureBox1.Image.Save(mmst, pictureBox1.Image.RawFormat);
            //byte[] img = mmst.ToArray();
            //dataGridView1.Rows.Add(img);
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //OpenFileDialog opnfd = new OpenFileDialog();
            //opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            //if (opnfd.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = new Bitmap(opnfd.FileName);

            //}

        }
    }
}



