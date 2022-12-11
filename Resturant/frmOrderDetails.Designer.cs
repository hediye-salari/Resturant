
namespace Resturant
{
    partial class frmOrderDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfood = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmborderID = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmOrderDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "قیمت";
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(76, 87);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(121, 26);
            this.txtUnitprice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "انتخاب غذا ";
            // 
            // cmbfood
            // 
            this.cmbfood.FormattingEnabled = true;
            this.cmbfood.Location = new System.Drawing.Point(76, 25);
            this.cmbfood.Name = "cmbfood";
            this.cmbfood.Size = new System.Drawing.Size(121, 28);
            this.cmbfood.TabIndex = 4;
            this.cmbfood.SelectedIndexChanged += new System.EventHandler(this.cmbfood_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(76, 159);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 26);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "تعداد";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(234, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnAddOrderDetailes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cmborderID);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbfood);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtUnitprice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(378, 341);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات سفارش ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(103, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(125, 37);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cmborderID
            // 
            this.cmborderID.FormattingEnabled = true;
            this.cmborderID.Location = new System.Drawing.Point(76, 219);
            this.cmborderID.Name = "cmborderID";
            this.cmborderID.Size = new System.Drawing.Size(121, 28);
            this.cmborderID.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(234, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(138, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "ویرایش ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "شناسه سفارش غذا ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderDetailsID,
            this.clmFoodName,
            this.clm,
            this.clmQuantity,
            this.clmUnitPrice,
            this.clmTotalPrice,
            this.clmdelete,
            this.clmUpdate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 226);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // clmOrderDetailsID
            // 
            this.clmOrderDetailsID.DataPropertyName = "OrderDetailsID";
            this.clmOrderDetailsID.HeaderText = "شناسه";
            this.clmOrderDetailsID.MinimumWidth = 8;
            this.clmOrderDetailsID.Name = "clmOrderDetailsID";
            this.clmOrderDetailsID.Visible = false;
            this.clmOrderDetailsID.Width = 150;
            // 
            // clmFoodName
            // 
            this.clmFoodName.DataPropertyName = "FoodName";
            this.clmFoodName.HeaderText = "نام غذا";
            this.clmFoodName.MinimumWidth = 8;
            this.clmFoodName.Name = "clmFoodName";
            this.clmFoodName.Width = 150;
            // 
            // clm
            // 
            this.clm.DataPropertyName = "OrderID";
            this.clm.HeaderText = "شناسه غذا";
            this.clm.MinimumWidth = 8;
            this.clm.Name = "clm";
            this.clm.Width = 150;
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "Quantity";
            this.clmQuantity.HeaderText = "تعداد";
            this.clmQuantity.MinimumWidth = 8;
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 150;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.DataPropertyName = "UnitPrice";
            this.clmUnitPrice.HeaderText = "قیمت";
            this.clmUnitPrice.MinimumWidth = 8;
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.Width = 150;
            // 
            // clmTotalPrice
            // 
            this.clmTotalPrice.DataPropertyName = "TotalPrice";
            this.clmTotalPrice.HeaderText = "قیمت کل";
            this.clmTotalPrice.MinimumWidth = 8;
            this.clmTotalPrice.Name = "clmTotalPrice";
            this.clmTotalPrice.Width = 150;
            // 
            // clmdelete
            // 
            this.clmdelete.HeaderText = "حذف";
            this.clmdelete.MinimumWidth = 8;
            this.clmdelete.Name = "clmdelete";
            this.clmdelete.Text = "حذف";
            this.clmdelete.UseColumnTextForButtonValue = true;
            this.clmdelete.Width = 150;
            // 
            // clmUpdate
            // 
            this.clmUpdate.HeaderText = "ویرایش";
            this.clmUpdate.MinimumWidth = 8;
            this.clmUpdate.Name = "clmUpdate";
            this.clmUpdate.Text = "ویرایش";
            this.clmUpdate.UseColumnTextForButtonValue = true;
            this.clmUpdate.Width = 150;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1227, 696);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmOrderDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم ثبت جزییات سفارش ";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfood;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmborderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn clmdelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}