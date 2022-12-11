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
using DataAccess.Service;
using DomainModel.BaseModel;
using DomainModel.View_model;

namespace Resturant
{
    public partial class frmFood : Form
    {
        private int FoodID = 0;
        private void dosearch()
        {
            FoodSearchModel sm = new FoodSearchModel();
            if (txtSearxhFoodName.Text!=null)
            {
                sm.FoodName = txtSearxhFoodName.Text;
            }
            if (txtSearchIngredient.Text != null)
            {
                sm.Ingredients =txtSearchIngredient.Text;
            }
            if (cmbsearchcategory.SelectedIndex>0)
            {
                sm.CategoryID = Convert.ToInt32(cmbsearchcategory.SelectedValue);
            }
            if (txtSearchPriceFrom.Text!="")
            {
                sm.UnitpriceFrom = Convert.ToInt32(txtSearchPriceFrom.Text);
            }
            if (txtSearchPriceTo.Text != "")
            {
                sm.UnitpriceTo = Convert.ToInt32(txtSearchPriceTo.Text);
            }

            using(DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.Search(sm);

            }

        }
        public frmFood()
        {
            InitializeComponent();
        }
        #region UIUTILITY
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


        #endregion
      
        private void btnSave_Click(object sender, EventArgs e)
        {

            using (DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            {
                Food f = new Food
                {
                    CategoryID = Convert.ToInt32(cmbFoodCategory.SelectedValue),
                    Description = txtDescription.Text,
                    FoodName = txtFoodName.Text,
                    Ingredients = txtIngredients.Text,
                    UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
                    FoodCategory=(FoodCategory)cmbFoodCategory.SelectedItem
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

                //    DomainModel.Models.Food food = new Food
                //    {
                //        FoodName = txtFoodName.Text,
                //        //UnitPrice =Convert.ToInt32( txtUnitPrice.Text),
                //        Description = txtDescription.Text,
                //        Ingredients = txtIngredients.Text,

                //    };
                //    int id = repo.AddNew();

                //    if (id==-1000)
                //    {
                //        MessageBox.Show("UserName Alrady Exist");
                //    }

                //    BindGride();
                //    ClearForm();

                //}
            }
        }

        private void ClearForm()
        {
            txtFoodName.Text = "";
            txtUnitPrice.Text = "";
            txtDescription.Text = "";
            txtIngredients.Text = "";
            cmbFoodCategory.SelectedIndex = -1;

        }



        private void frmFood_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.AutoGenerateColumns = false;
            BindGride();
            Bindcategories();
            GoToAddMode();
            BindSearchcategories();
            BindGridecombobox();
        }

        
        #region Binding
        private void BindGride()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            {
                dataGridView1.DataSource = false;
                List<Food> Food = repo.GetAll();
                dataGridView1.DataSource = Food;
                BindGridecombobox();

            }
        }

        private void BindGridecombobox()
        {
            using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace())
            {
                
                clmFoodCategory.DisplayMember = "CategoryName";
                clmFoodCategory.ValueMember = "FoodCategoryID";
                List<FoodCategory> FC = repo.GetAll();
                cmbFoodCategory.DataSource = FC;
            }

        }
                

        private void Bindcategories()
        {
            using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace())

            {
                cmbFoodCategory.DisplayMember = "CategoryName";
                cmbFoodCategory.ValueMember = "FoodCategoryID";
                List<FoodCategory> FC = repo.GetAll();
                FoodCategory fc = new FoodCategory { CategoryName = "...انتخاب نمایید ...", FoodCategoryID = -1 };
                //عددی میزاریم برای آیدی که در دیتا بی نیست 
                FC.Insert(0, fc);
                cmbFoodCategory.DataSource = FC;
                
            }

        }
        

        private void BindSearchcategories()
        {
            using (DataAccess.Repositories.FoodCategoryRepositoryInterFace repo = new FoodCategoryRepositoryInterFace())

            {
                cmbsearchcategory.DisplayMember = "CategoryName";
                cmbsearchcategory.ValueMember = "FoodCategoryID";
                List<FoodCategory> cats = repo.GetAll();
                FoodCategory fc = new FoodCategory { CategoryName = "...انتخاب نمایید ...", FoodCategoryID = -1 };
                //عددی میزاریم برای آیدی که در دیتا بیس نیست 
                cats.Insert(0, fc);
                cmbsearchcategory.DataSource = cats;
            }

        }





        #endregion


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace();
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا میخواهید دیتا حذف شود ", "پیغام خطا ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int foodid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    repo.Delete(foodid);
                    BindGride();
                }

            }

            if (e.ColumnIndex == 7)
            {
                this.FoodID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Food food = repo.Get(FoodID);
                cmbFoodCategory.SelectedItem =(FoodCategory) food.FoodCategory;
                txtFoodName.Text = food.FoodName;
                txtUnitPrice.Text = food.UnitPrice.ToString();
                txtIngredients.Text = food.Ingredients;
                txtDescription.Text = food.Description;
               
                GoToEditeMode();

                


            }

           
        }
  
            //using (FoodRepositoryInterFace repo = new FoodRepositoryInterFace())
            //{
            //    FoodID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //    if (e.ColumnIndex == 5)
            //    {
            //        if (MessageBox.Show("آیا میخواهید دیتا حذف شود ؟", "alret", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            var op = repo.Delete(FoodID);
            //            if (op.Success)
            //            {
            //                BindGride();
            //            }
            //            else
            //            {
            //                MessageBox.Show(op.Message);
            //            }
                        
            //            if (e.ColumnIndex ==6)
            //            {
            //               this. FoodID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //                Food foods = repo.Get(FoodID);
            //                txtFoodName.Text = foods.FoodName;
            //                txtDescription.Text = foods.Description;
            //                txtUnitPrice.Text = foods.UnitPrice.ToString();
            //                txtIngredients.Text = foods.Ingredients;
            //                //cmbFoodCategory.Text =Convert.ToString (foods.FoodCategory);
            //                GoToEditeMode();
            //            }
            //        }
            //    }
            //}
        
    private void btnUpdate_Click(object sender, EventArgs e)
        {
            Food food = new Food()
            {
                FoodName = txtFoodName.Text,
                UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
                Ingredients = txtIngredients.Text,
                Description = txtDescription.Text,
                FoodCategory = (FoodCategory)cmbFoodCategory.SelectedItem,
                FoodID=this.FoodID
                
            };
            DataAccess.Repositories.FoodRepositoryInterFace repo = new FoodRepositoryInterFace();
            repo.Update(food);
            ClearForm();
            GoToAddMode();
            BindGride();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSearxhFoodName_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void cmbsearchcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dosearch();
        }

        private void txtSearchPriceTo_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void txtSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            dosearch();
        }

        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFoodCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        
    