
namespace Resturant
{
    partial class frmSwitch
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblcurentuser = new System.Windows.Forms.ToolStripLabel();
            this.lblCurentdate = new System.Windows.Forms.ToolStripLabel();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CategoryManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.FoodManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمشتریانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblcurentuser,
            this.lblCurentdate,
            this.lblTime});
            this.toolStrip1.Location = new System.Drawing.Point(186, 684);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1240, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // lblcurentuser
            // 
            this.lblcurentuser.Name = "lblcurentuser";
            this.lblcurentuser.Size = new System.Drawing.Size(0, 20);
            // 
            // lblCurentdate
            // 
            this.lblCurentdate.Name = "lblCurentdate";
            this.lblCurentdate.Size = new System.Drawing.Size(0, 20);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryManagement,
            this.FoodManagement,
            this.EmployeeManagement,
            this.OrderManagment,
            this.مدیریتمشتریانToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 709);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // CategoryManagement
            // 
            this.CategoryManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CategoryManagement.Font = new System.Drawing.Font("B Aria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CategoryManagement.Margin = new System.Windows.Forms.Padding(10);
            this.CategoryManagement.Name = "CategoryManagement";
            this.CategoryManagement.Size = new System.Drawing.Size(153, 34);
            this.CategoryManagement.Text = "مدیریت رده بندی  ";
            this.CategoryManagement.Click += new System.EventHandler(this.CategoryManagement_Click);
            // 
            // FoodManagement
            // 
            this.FoodManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FoodManagement.Font = new System.Drawing.Font("B Aria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodManagement.Margin = new System.Windows.Forms.Padding(10);
            this.FoodManagement.Name = "FoodManagement";
            this.FoodManagement.Size = new System.Drawing.Size(153, 34);
            this.FoodManagement.Text = "مدیریت منو";
            this.FoodManagement.Click += new System.EventHandler(this.FoodManagement_Click);
            // 
            // EmployeeManagement
            // 
            this.EmployeeManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EmployeeManagement.Font = new System.Drawing.Font("B Aria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EmployeeManagement.Margin = new System.Windows.Forms.Padding(10);
            this.EmployeeManagement.Name = "EmployeeManagement";
            this.EmployeeManagement.Size = new System.Drawing.Size(153, 34);
            this.EmployeeManagement.Text = "مدیریت کارمندان";
            this.EmployeeManagement.Click += new System.EventHandler(this.EmployeeManagement_Click);
            // 
            // OrderManagment
            // 
            this.OrderManagment.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OrderManagment.Font = new System.Drawing.Font("B Aria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderManagment.Margin = new System.Windows.Forms.Padding(10);
            this.OrderManagment.Name = "OrderManagment";
            this.OrderManagment.Size = new System.Drawing.Size(153, 34);
            this.OrderManagment.Text = "مدیریت سفارشات";
            this.OrderManagment.Click += new System.EventHandler(this.OrderManagment_Click);
            // 
            // مدیریتمشتریانToolStripMenuItem
            // 
            this.مدیریتمشتریانToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.مدیریتمشتریانToolStripMenuItem.Font = new System.Drawing.Font("B Aria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.مدیریتمشتریانToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.مدیریتمشتریانToolStripMenuItem.Name = "مدیریتمشتریانToolStripMenuItem";
            this.مدیریتمشتریانToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.مدیریتمشتریانToolStripMenuItem.Text = "مدیریت مشتریان";
            this.مدیریتمشتریانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمشتریانToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.BackgroundImage = global::Resturant.Properties.Resources._123;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(783, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 437);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Resturant.Properties.Resources._123;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(741, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(635, 501);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox3.BackgroundImage = global::Resturant.Properties.Resources._123;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(702, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(712, 567);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSwitch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پنل کاربری کارمندان";
            this.Load += new System.EventHandler(this.frmSwitch_Load);
            this.Click += new System.EventHandler(this.EmployeeManagement_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmSwitch_MouseDoubleClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblcurentuser;
        private System.Windows.Forms.ToolStripLabel lblCurentdate;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem CategoryManagement;
        protected System.Windows.Forms.ToolStripMenuItem FoodManagement;
        protected System.Windows.Forms.ToolStripMenuItem EmployeeManagement;
        protected System.Windows.Forms.ToolStripMenuItem OrderManagment;
        protected System.Windows.Forms.ToolStripMenuItem مدیریتمشتریانToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}