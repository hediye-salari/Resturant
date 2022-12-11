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
using DomainModel.View_model;

namespace Resturant
{
    public partial class frmCustomer : Form
    {
        public string CurrentCustomer { get; set; }
        private int CustomerID = 0;
        private void dosearch()
        {
            CustomerSearchModel sm = new CustomerSearchModel();
            if (txtsearchfirstname.Text != null)
            {
                sm.FirstName = txtsearchfirstname.Text;
            }
            if (txtsearchlastname.Text != null)
            {
                sm.LastName = txtsearchlastname.Text;
            }

            if (txtsearchmobile.Text != null)
            {
                sm.Mobile = txtsearchmobile.Text;
            }
            if (txtsearchtel.Text != null)
            {
                sm.Tel = txtsearchtel.Text;
            }
            using (DataAccess.Repositories.CustomerRepositoryInterFace repo = new CustomerRepositoryInterFace())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.Search(sm);

            }
        }


        public frmCustomer()
        {
            InitializeComponent();
        }

       




        private void GoToAddMode()
        {
            btnsave.Visible = true;
            btnUpdate.Visible = false;
            btnCancele.Visible = false;
        }
        private void GoToEditeMode()
        {
            btnsave.Visible = false;
            btnUpdate.Visible = true;
            btnCancele.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess.Repositories.CustomerRepositoryInterFace repo = new CustomerRepositoryInterFace();
            Cusstomer emp = new Cusstomer
            {
                FirstName = txtName.Text,
                LastName = txtFamily.Text,
                Mobile = txtMobile.Text,
                Tel = txtTel.Text
            };

            repo.AddNew(emp);
            BindGrid();
            ClearForm();
        }


        private void ClearForm()
        {
            txtName.Text = "";
            txtFamily.Text = "";
            txtMobile.Text = "";
            txtTel.Text = "";


        }

        private void BindGrid()
        {
            dataGridView1.DataSource = false;
            DataAccess.Repositories.CustomerRepositoryInterFace repo = new CustomerRepositoryInterFace();
            //dataGridView1.DataSource = null;
            List<Cusstomer> cusstomers = repo.GetAll();
            dataGridView1.DataSource =cusstomers;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess.Repositories.CustomerRepositoryInterFace repo = new CustomerRepositoryInterFace();
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
                this.CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Cusstomer cust = repo.Get(CustomerID);
                txtName.Text = cust.FirstName;
                txtFamily.Text = cust.LastName;
                txtMobile.Text = cust.Mobile;
                txtTel.Text = cust.Tel;
                GoToEditeMode();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.AutoGenerateColumns = false;
            BindGrid();
            GoToAddMode();
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Cusstomer cust = new Cusstomer()

            {
                FirstName = txtName.Text,
                LastName = txtFamily.Text,
                Mobile = txtMobile.Text,
                Tel = txtTel.Text,
                CustomerID = this.CustomerID

            };

            DataAccess.Repositories.CustomerRepositoryInterFace repo = new DataAccess.Repositories.CustomerRepositoryInterFace();
            repo.Update(cust);
            ClearForm();
            GoToAddMode();
            BindGrid();
        }

        private void txtsearchfirstname_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtsearchlastname_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtsearchmobile_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtsearchtel_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
