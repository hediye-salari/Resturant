using DataAccess.Repositories;
using DomainModel.BaseModel;
using DomainModel.Models;
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
    public partial class frmFoodCategory : Form
    {
        private int FoodCategoryID = 0;
        //public int FoodCategoryID { get; private set; }

        public frmFoodCategory()
        {
            InitializeComponent();
        }

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

        private void frmFoodCategory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.AutoGenerateColumns = false;
            BindGride();

            GoToAddMode();

            //Bindcategories();
        }
        private void ClearForm()
        {

            txtDescription.Text = "";
            txtcategoryname.Text = "";

        }
        private void BindGride()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace())

            {
                dataGridView1.DataSource = null;
                List<FoodCategory> foods = repo.GetAll();
                dataGridView1.DataSource = foods;
            }


        }
        //private void Bindcategories()
        //{
        //    using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new DataAccess.Repositories.FoodCategoryRepositoryInterFace())

        //    {
        //        cmbFoodCategory.DisplayMember = "CategoryName";
        //        cmbFoodCategory.ValueMember = "FoodCategoryID";
        //        List<FoodCategory> cats = repo.GetAll();
        //        FoodCategory fc = new FoodCategory { CategoryName = "...انتخاب نمایید ...", FoodCategoryID = -1 };
        //        //عددی میزاریم برای آیدی که در دیتا بی نیست 
        //        cats.Insert(0, fc);
        //        cmbFoodCategory.DataSource = cats;
        //    }

        //}
        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace())
            {
                FoodCategory f = new FoodCategory
                {

                    CategoryName = txtcategoryname.Text,
                    Description = txtDescription.Text,

                };

                OperationResult op = repo.AddNew(f);
                if (op.Success)
                {

                    ClearForm();
                    BindGride();
                }
                else
                {
                    MessageBox.Show(op.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace();



            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا میخواهید دیتا حذف شود ", "پیغام خطا ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FoodCategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    repo.Delete(FoodCategoryID);

                    BindGride();


                }

            }


            if (e.ColumnIndex == 4)
            {
                this.FoodCategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                FoodCategory foodc = repo.Get(FoodCategoryID);
                txtcategoryname.Text = foodc.CategoryName;
                txtDescription.Text = foodc.Description;
                GoToEditeMode();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FoodCategory foodcategory = new FoodCategory()
            {
                CategoryName = txtcategoryname.Text,
                Description = txtDescription.Text,
                FoodCategoryID = this.FoodCategoryID


            };
            DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace();
            repo.Update(foodcategory);
            ClearForm();
            GoToAddMode();
            BindGride();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
    }
}

