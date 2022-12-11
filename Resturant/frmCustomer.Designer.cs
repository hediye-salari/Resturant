
namespace Resturant
{
    partial class frmCustomer
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancele = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchtel = new System.Windows.Forms.TextBox();
            this.txtsearchmobile = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.txtsearchlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtsearchfirstname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(177, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 35);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "ویرایش ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancele
            // 
            this.btnCancele.BackColor = System.Drawing.Color.Red;
            this.btnCancele.ForeColor = System.Drawing.Color.Black;
            this.btnCancele.Location = new System.Drawing.Point(13, 313);
            this.btnCancele.Name = "btnCancele";
            this.btnCancele.Size = new System.Drawing.Size(158, 35);
            this.btnCancele.TabIndex = 22;
            this.btnCancele.Text = "بازگشت";
            this.btnCancele.UseVisualStyleBackColor = false;
            this.btnCancele.Click += new System.EventHandler(this.btnCancele_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(32, 132);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(177, 26);
            this.txtTel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "تلفن ";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(32, 183);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(177, 26);
            this.txtMobile.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "نام خانوادگی ";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(32, 81);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(177, 26);
            this.txtFamily.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "موبایل";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnName,
            this.clmnLastName,
            this.clmnMobile,
            this.clmnTel,
            this.clmnDelete,
            this.clmnUpdate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 276);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnID
            // 
            this.clmnID.DataPropertyName = "CustomerID";
            this.clmnID.HeaderText = "شناسه";
            this.clmnID.MinimumWidth = 8;
            this.clmnID.Name = "clmnID";
            this.clmnID.ReadOnly = true;
            this.clmnID.Visible = false;
            this.clmnID.Width = 150;
            // 
            // clmnName
            // 
            this.clmnName.DataPropertyName = "FirstName";
            this.clmnName.HeaderText = "نام";
            this.clmnName.MinimumWidth = 8;
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            this.clmnName.Width = 150;
            // 
            // clmnLastName
            // 
            this.clmnLastName.DataPropertyName = "LastName";
            this.clmnLastName.HeaderText = "نام خانوادگی";
            this.clmnLastName.MinimumWidth = 8;
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.ReadOnly = true;
            this.clmnLastName.Width = 150;
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "موبایل";
            this.clmnMobile.MinimumWidth = 8;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.ReadOnly = true;
            this.clmnMobile.Width = 150;
            // 
            // clmnTel
            // 
            this.clmnTel.DataPropertyName = "Tel";
            this.clmnTel.HeaderText = "تلفن";
            this.clmnTel.MinimumWidth = 8;
            this.clmnTel.Name = "clmnTel";
            this.clmnTel.ReadOnly = true;
            this.clmnTel.Width = 150;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 8;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.ReadOnly = true;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 150;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 8;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.ReadOnly = true;
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 150;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(177, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(158, 34);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 26);
            this.txtName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "نام";
            // 
            // txtsearchtel
            // 
            this.txtsearchtel.Location = new System.Drawing.Point(10, 197);
            this.txtsearchtel.Name = "txtsearchtel";
            this.txtsearchtel.Size = new System.Drawing.Size(100, 26);
            this.txtsearchtel.TabIndex = 25;
            this.txtsearchtel.TextChanged += new System.EventHandler(this.txtsearchtel_TextChanged);
            // 
            // txtsearchmobile
            // 
            this.txtsearchmobile.Location = new System.Drawing.Point(10, 146);
            this.txtsearchmobile.Name = "txtsearchmobile";
            this.txtsearchmobile.Size = new System.Drawing.Size(100, 26);
            this.txtsearchmobile.TabIndex = 25;
            this.txtsearchmobile.TextChanged += new System.EventHandler(this.txtsearchmobile_TextChanged);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.Color.White;
            this.lbltel.Location = new System.Drawing.Point(257, 203);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(33, 20);
            this.lbltel.TabIndex = 25;
            this.lbltel.Text = "تلفن ";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.ForeColor = System.Drawing.Color.White;
            this.lblmobile.Location = new System.Drawing.Point(249, 152);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(41, 20);
            this.lblmobile.TabIndex = 25;
            this.lblmobile.Text = "موبایل";
            // 
            // txtsearchlastname
            // 
            this.txtsearchlastname.Location = new System.Drawing.Point(10, 81);
            this.txtsearchlastname.Name = "txtsearchlastname";
            this.txtsearchlastname.Size = new System.Drawing.Size(100, 26);
            this.txtsearchlastname.TabIndex = 25;
            this.txtsearchlastname.TextChanged += new System.EventHandler(this.txtsearchlastname_TextChanged);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.ForeColor = System.Drawing.Color.White;
            this.lbllastname.Location = new System.Drawing.Point(213, 90);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(77, 20);
            this.lbllastname.TabIndex = 25;
            this.lbllastname.Text = "نام خانوادگی ";
            // 
            // txtsearchfirstname
            // 
            this.txtsearchfirstname.Location = new System.Drawing.Point(10, 25);
            this.txtsearchfirstname.Name = "txtsearchfirstname";
            this.txtsearchfirstname.Size = new System.Drawing.Size(100, 26);
            this.txtsearchfirstname.TabIndex = 15;
            this.txtsearchfirstname.TextChanged += new System.EventHandler(this.txtsearchfirstname_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(268, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 20);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "نام";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancele);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 354);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرم اطلاعات مشتری";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsearchfirstname);
            this.groupBox2.Controls.Add(this.txtsearchtel);
            this.groupBox2.Controls.Add(this.lbltel);
            this.groupBox2.Controls.Add(this.txtsearchlastname);
            this.groupBox2.Controls.Add(this.txtsearchmobile);
            this.groupBox2.Controls.Add(this.lblmobile);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lbllastname);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 354);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1131, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت مشتریان";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancele;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTel;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.TextBox txtsearchtel;
        private System.Windows.Forms.TextBox txtsearchmobile;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.TextBox txtsearchlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtsearchfirstname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}