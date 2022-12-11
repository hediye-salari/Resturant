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
    public partial class frmOrderDetails : Form
    {
       public int OrderID { get; set; }
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        private int OrderDetailsID = 0;

        private void GoToAddMode()
        {
            btnSave.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }
        private void GoToEditeMode()
        {
            btnSave.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
        }

        private void BindGride()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (OrderDetailesRepositoryInterFace repo = new OrderDetailesRepositoryInterFace())

            {
                dataGridView1.DataSource = null;
                List<OrderDetails> orders = repo.GetAll();
                dataGridView1.DataSource = repo;

            }
        }
        private void ClearForm()
        {
            txtQuantity.Text = "";
            txtUnitprice.Text = "";
            cmbfood.SelectedIndex = -1;
          
           

        }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
           
            BindGride();
            //BindOrderDetailesGride();
            //تمام غذاها رو میاره تو کومبو 
            BindFoodCombo();
            Inflateorder();
            this.WindowState = FormWindowState.Maximized;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;   // Turn off autosize
            //dataGridView1.AllowUserToResizeRows = true;                                 // Turn on letting user size columns
            //dataGridView1.AllowUserToOrderColumns = true;
            //dataGridView1.AutoGenerateColumns = false;
            
            dataGridView1.AutoGenerateColumns = false;
            BindGride();
          
            GoToAddMode();
           
            
        }
        private void Inflateorder()
        {
            var repo = new OrderRepositoryInterFace();
            List<Order> lst = repo.GetAll();

            cmborderID.ValueMember = "OrderID";
            cmborderID.DataSource = lst;
            cmborderID.DisplayMember = (OrderID).ToString();
            cmborderID.Enabled = false;
        }

        private void BindFoodCombo()
        {
            using (DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            {
                cmbfood.DisplayMember = "FoodName";
                cmbfood.ValueMember = "FoodID";
                cmbfood.DataSource = repo.GetAll();


            }


        }

        private void BindOrderDetailesGride()
        {
            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                dataGridView1.DataSource = repo.GetCurrentOrderItems(OrderID);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOrderDetailes_Click(object sender, EventArgs e)
        {
            using (DataAccess.Repositories.OrderRepositoryInterFace repo = new OrderRepositoryInterFace())
            {
                OrderDetails od = new OrderDetails();
                od.OrderID = this.OrderID;
                od.FoodID = Convert.ToInt32(cmbfood.SelectedValue);
                od.UnitPrice = Convert.ToInt32(txtUnitprice.Text);
                od.Quantity = Convert.ToInt32(txtQuantity.Text);

                //دیتا رو ثبت میکنه 
                repo.RegisterOrderItem(od);
                BindOrderDetailesGride();

            }
        }

        private void cmbfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int FoodID = Convert.ToInt32(cmbfood.SelectedValue);
            using (DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            {
                Food f = repo.Get(FoodID);
                txtUnitprice.Text = f.UnitPrice.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (OrderDetailesRepositoryInterFace repo = new OrderDetailesRepositoryInterFace())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetAll();

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            //OrderDetailsRepositories repos = new OrderDetailesRepositoryInterFace();


            //    dataGridView1.DataSource = null;
            //dataGridView1.DataSource = repos.GetAll();
            dataGridView1.AutoGenerateColumns = false;
            using (OrderDetailesRepositoryInterFace repos = new OrderDetailesRepositoryInterFace())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repos.GetAll();

            }
            DataAccess.Repositories.OrderDetailesRepositoryInterFace repo = new OrderDetailesRepositoryInterFace();
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا میخواهین دیتا حذف شود ؟", "پیغام خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ordid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    repo.Delete(ordid);
                    BindGrid();
                }
            }

            if (e.ColumnIndex == 7)
            {
                this.OrderDetailsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                OrderDetails ord = repo.Get(OrderDetailsID);
                txtQuantity.Text =  ord.Quantity.ToString();
                txtUnitprice.Text = ord.UnitPrice.ToString();
                cmbfood.SelectedItem = ord.Food;
                GoToEditeMode();
            }


        }

        

        private void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DataAccess.Repositories.OrderDetailesRepositoryInterFace repo = new OrderDetailesRepositoryInterFace())
            {
                dataGridView1.DataSource = false;
                List<OrderDetails> Food = repo.GetAll();
                dataGridView1.DataSource = Food;
                

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderDetails orderdetails = new OrderDetails()
            {
                Quantity = Convert.ToInt32(txtQuantity.Text),
                UnitPrice = Convert.ToInt32(txtUnitprice.Text),

                OrderDetailsID = this.OrderDetailsID

            };
            DataAccess.Repositories.OrderDetailesRepositoryInterFace repo = new OrderDetailesRepositoryInterFace();
            repo.Update(orderdetails);
            ClearForm();
            GoToAddMode();
            BindGride();
        }
    }
};


