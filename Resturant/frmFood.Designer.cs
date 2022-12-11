
namespace Resturant
{
    partial class frmFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmnFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIngredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchIngredient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchPriceTo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsearchcategory = new System.Windows.Forms.ComboBox();
            this.txtSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearxhFoodName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmFoodCategory,
            this.clmnFoodName,
            this.clmnUnitPrice,
            this.clmnIngredients,
            this.clmDescription,
            this.clmnDelete,
            this.clmnUpdate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 259);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnID
            // 
            this.clmnID.DataPropertyName = "FoodID";
            this.clmnID.HeaderText = "شناسه";
            this.clmnID.MinimumWidth = 8;
            this.clmnID.Name = "clmnID";
            this.clmnID.Visible = false;
            this.clmnID.Width = 150;
            // 
            // clmFoodCategory
            // 
            this.clmFoodCategory.DataPropertyName = "FoodCategoryID";
            this.clmFoodCategory.HeaderText = "رده";
            this.clmFoodCategory.MinimumWidth = 8;
            this.clmFoodCategory.Name = "clmFoodCategory";
            this.clmFoodCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFoodCategory.Width = 150;
            // 
            // clmnFoodName
            // 
            this.clmnFoodName.DataPropertyName = "FoodName";
            this.clmnFoodName.HeaderText = "نام غذا";
            this.clmnFoodName.MinimumWidth = 8;
            this.clmnFoodName.Name = "clmnFoodName";
            this.clmnFoodName.Width = 150;
            // 
            // clmnUnitPrice
            // 
            this.clmnUnitPrice.DataPropertyName = "UnitPrice";
            this.clmnUnitPrice.HeaderText = "قیمت غذا";
            this.clmnUnitPrice.MinimumWidth = 8;
            this.clmnUnitPrice.Name = "clmnUnitPrice";
            this.clmnUnitPrice.Width = 150;
            // 
            // clmnIngredients
            // 
            this.clmnIngredients.DataPropertyName = "Ingredients";
            this.clmnIngredients.HeaderText = "ترکیبات";
            this.clmnIngredients.MinimumWidth = 8;
            this.clmnIngredients.Name = "clmnIngredients";
            this.clmnIngredients.Width = 150;
            // 
            // clmDescription
            // 
            this.clmDescription.DataPropertyName = "Description";
            this.clmDescription.HeaderText = "توضیحات";
            this.clmDescription.MinimumWidth = 8;
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Width = 150;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 8;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 150;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 8;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(561, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(125, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(688, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(129, 32);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "ویرایش ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(688, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(129, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearchIngredient);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSearchPriceTo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbsearchcategory);
            this.panel1.Controls.Add(this.txtSearchPriceFrom);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSearxhFoodName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(873, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 415);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearchIngredient
            // 
            this.txtSearchIngredient.Location = new System.Drawing.Point(103, 235);
            this.txtSearchIngredient.Name = "txtSearchIngredient";
            this.txtSearchIngredient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchIngredient.Size = new System.Drawing.Size(142, 26);
            this.txtSearchIngredient.TabIndex = 31;
            this.txtSearchIngredient.TextChanged += new System.EventHandler(this.txtSearchIngredient_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(259, 241);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "محتویات";
            // 
            // txtSearchPriceTo
            // 
            this.txtSearchPriceTo.Location = new System.Drawing.Point(103, 179);
            this.txtSearchPriceTo.Name = "txtSearchPriceTo";
            this.txtSearchPriceTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchPriceTo.Size = new System.Drawing.Size(142, 26);
            this.txtSearchPriceTo.TabIndex = 29;
            this.txtSearchPriceTo.TextChanged += new System.EventHandler(this.txtSearchPriceTo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(262, 179);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "قیمت تا";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(284, 69);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "رده";
            // 
            // cmbsearchcategory
            // 
            this.cmbsearchcategory.FormattingEnabled = true;
            this.cmbsearchcategory.Location = new System.Drawing.Point(103, 66);
            this.cmbsearchcategory.Name = "cmbsearchcategory";
            this.cmbsearchcategory.Size = new System.Drawing.Size(142, 28);
            this.cmbsearchcategory.TabIndex = 26;
            this.cmbsearchcategory.SelectedIndexChanged += new System.EventHandler(this.cmbsearchcategory_SelectedIndexChanged);
            // 
            // txtSearchPriceFrom
            // 
            this.txtSearchPriceFrom.Location = new System.Drawing.Point(103, 126);
            this.txtSearchPriceFrom.Name = "txtSearchPriceFrom";
            this.txtSearchPriceFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchPriceFrom.Size = new System.Drawing.Size(142, 26);
            this.txtSearchPriceFrom.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(262, 126);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "قیمت از";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtSearxhFoodName
            // 
            this.txtSearxhFoodName.Location = new System.Drawing.Point(103, 18);
            this.txtSearxhFoodName.Name = "txtSearxhFoodName";
            this.txtSearxhFoodName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearxhFoodName.Size = new System.Drawing.Size(142, 26);
            this.txtSearxhFoodName.TabIndex = 14;
            this.txtSearxhFoodName.TextChanged += new System.EventHandler(this.txtSearxhFoodName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(268, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "نام غذا";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(876, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "جستجو";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbFoodCategory);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtIngredients);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(26, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 440);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(794, 59);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "رده";
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(558, 51);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(162, 28);
            this.cmbFoodCategory.TabIndex = 34;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(21, 146);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(699, 218);
            this.txtDescription.TabIndex = 33;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(21, 95);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIngredients.Size = new System.Drawing.Size(699, 26);
            this.txtIngredients.TabIndex = 32;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(21, 51);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitPrice.Size = new System.Drawing.Size(186, 26);
            this.txtUnitPrice.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(756, 158);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "توضیحات ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "قیمت  واحد ";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(311, 51);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFoodName.Size = new System.Drawing.Size(150, 26);
            this.txtFoodName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(769, 110);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "محتویات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "نام غذا ";
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1254, 717);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmFood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم سفارش غذا ";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsearchcategory;
        private System.Windows.Forms.TextBox txtSearchPriceFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearxhFoodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchPriceTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchIngredient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFoodCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmFoodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
    }
}