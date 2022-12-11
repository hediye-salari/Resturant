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
using DomainModel.BaseModel;
using DomainModel.Models;
using DomainModel.View_model;


namespace Resturant
{

    public partial class frmOrder : Form
    {

        private void GoToAddMode()
        {
            //دکمه ادد دیده بشه ولی دکمه آپدیت و کنسل دیده نشود 
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }
        private void GoToEditeMode()
        {
            //دکمه ادد دیده نشه ولی دکمه آپدیت و کنسل دیده شود 
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }

        private void dosearch()
        {
            OrderSearchModel sm = new OrderSearchModel();

            if (comserchCustomer.SelectedIndex > 0)
            {
                sm.CustomerID = Convert.ToInt32(comserchCustomer.SelectedValue);
            }
            if (combSearchEmployee.SelectedIndex > 0)
            {
                sm.EmployeeID = Convert.ToInt32(combSearchEmployee.SelectedValue);
            }
            if (faDatePickerFrom.SelectedDateTime < txtOrderDate.SelectedDateTime)
            {
                sm.FromDate = Convert.ToDateTime(faDatePickerFrom.SelectedDateTime);
            }
            if (faDatePickerto.SelectedDateTime > txtOrderDate.SelectedDateTime)
            {
                sm.FromDate = Convert.ToDateTime(faDatePickerto.SelectedDateTime);
            }


            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.Search(sm);

            }



        }
        public string UserName { get; set; }
        public int OrderID { get; private set; }
        //private int OrderID = 0;
        private int currentEmployeeID;
        public frmOrder()
        {
            InitializeComponent();
        }



        private void faDatePicker1_SelectedDateTimeChanged(object sender, EventArgs e)
        {

        }

        //private void BindGride()
        //{
        //    dataGridView1.AutoGenerateColumns = false;
        //    using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())

        //    {
        //        dataGridView1.DataSource = null;
        //        List<Order> orders = repo.GetAll();
        //        dataGridView1.DataSource = repo;
        //    }
        //}
        private void frmOrder_Load(object sender, EventArgs e)
        {
            //BindGride();
            txtOrderDate.SelectedDateTime = DateTime.Now.Date;
            this.WindowState = FormWindowState.Maximized;
            SetCurrentUserIDBasedOnCurrentUserName();
            InflateEmployees();
            InflateCustomer();
            InflatesearchCustomer();
            InflatesearchEmployees();
            GoToAddMode();

        }



        private void InflateCustomer()
        {
            var repo = new CustomerRepositoryInterFace();
            List<Cusstomer> lst = repo.GetAll();
            lst.Insert(0, new Cusstomer { CustomerID = -1, LastName = "...انتخاب کنید ..." });
            cmbcustomer.DisplayMember = "LastName";
            cmbcustomer.ValueMember = "CustomerID";
            cmbcustomer.DataSource = lst;

        }
        private void InflatesearchCustomer()
        {
            var repo = new CustomerRepositoryInterFace();
            List<Cusstomer> lst = repo.GetAll();
            lst.Insert(0, new Cusstomer { CustomerID = -1, LastName = "...انتخاب کنید..." });
            comserchCustomer.DisplayMember = "LastName";
            comserchCustomer.ValueMember = "CustomerID";
            comserchCustomer.DataSource = lst;

        }
        private void InflatesearchEmployees()
        {
            var repo = new EmployeeRepositoryInterFace();
            List<Employee> lst = repo.GetAll();
            lst.Insert(0, new Employee { EmployeeID = -1, UserName = "...انتخاب کنید ..." });
            cmbEmployee.DisplayMember = "UserName";
            combSearchEmployee.DisplayMember = "UserName";
            combSearchEmployee.ValueMember = "EmployeeID";
            combSearchEmployee.DataSource = lst;



        }
        private void InflateEmployees()
        {
            var repo = new EmployeeRepositoryInterFace();
            List<Employee> lst = repo.GetAll();

            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = lst;
            cmbEmployee.SelectedValue = currentEmployeeID;
            cmbEmployee.Enabled = false;
        }
        private void SetCurrentUserIDBasedOnCurrentUserName()
        {
            EmployeeRepositoryInterFace repo = new EmployeeRepositoryInterFace();
            var cu = repo.GetEmployeeByUserName(UserName);
            currentEmployeeID = cu.EmployeeID;

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                Order o = new Order();
                o.CustomerID = Convert.ToInt32(cmbcustomer.SelectedValue);
                o.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                o.OrderDate = txtOrderDate.SelectedDateTime;
                o.OrderDescription = txtDescription.Text;
                OperationResult op = repo.AddNew(o);
                if (op.Success)
                {
                    //TODO Register Order Items
                    frmOrderDetails frm = new frmOrderDetails();
                    frm.OrderID = op.RecordID;
                    //show diaalog baraye ine k ta in formesh tamam nashodeh form ghabli faal nashe 
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(op.Message);
                }

            }
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (OrderRepositoryInterFace repos = new OrderRepositoryInterFace())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repos.GetAll();

            }
            DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace();
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا میخواهین دیتا حذف شود ؟", "پیغام خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ordid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    repo.Delete(ordid);
                    BindGrid();
                }
            }

            if (e.ColumnIndex == 4)
            {
                this.OrderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Order ord = repo.Get(OrderID);
                txtDescription.Text = ord.OrderDescription;

                GoToEditeMode();
            }

        }

        private void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                dataGridView1.DataSource = false;
                List<Order> Food = repo.GetAll();
                dataGridView1.DataSource = Food;


            }
        }

        private void comserchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void combSearchEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            dosearch();
        }

        private void faDatePickerFrom_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void faDatePickerto_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Order order = new Order()
            {
                Description = txtDescription.Text,
                Customer = (Cusstomer)cmbcustomer.SelectedItem,
                OrderID = this.OrderID

            };
            DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace();
            repo.Update(order);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }

        private void ClearForm()
        {
            txtDescription.Text = "";
            cmbcustomer.SelectedIndex = -1;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToAddMode();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                Order o = new Order();
                o.CustomerID = Convert.ToInt32(cmbcustomer.SelectedValue);
                o.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                o.OrderDate = txtOrderDate.SelectedDateTime;
                o.OrderDescription = txtDescription.Text;
                OperationResult op = repo.AddNew(o);
                if (op.Success)
                {
                    //TODO Register Order Items
                    frmOrderDetails frm = new frmOrderDetails();
                    frm.OrderID = op.RecordID;
                    //show diaalog baraye ine k ta in formesh tamam nashodeh form ghabli faal nashe 
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(op.Message);
                }
            }
        }
    }
}
