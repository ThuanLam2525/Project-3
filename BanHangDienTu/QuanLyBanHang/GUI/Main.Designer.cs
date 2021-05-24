
namespace QuanLyBanHang.GUI
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btninvoice = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnemployee = new System.Windows.Forms.Button();
            this.btndevice = new System.Windows.Forms.Button();
            this.btnbilloflading = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý cửa hàng";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(917, 73);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(96, 35);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Đăng xuất";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chào Admin, ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btninvoice);
            this.groupBox1.Controls.Add(this.btncustomer);
            this.groupBox1.Controls.Add(this.btnemployee);
            this.groupBox1.Controls.Add(this.btndevice);
            this.groupBox1.Controls.Add(this.btnbilloflading);
            this.groupBox1.Location = new System.Drawing.Point(4, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1029, 571);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ thống";
            // 
            // btninvoice
            // 
            this.btninvoice.Location = new System.Drawing.Point(564, 269);
            this.btninvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(194, 57);
            this.btninvoice.TabIndex = 5;
            this.btninvoice.Text = "Quản lý hoá đơn";
            this.btninvoice.UseVisualStyleBackColor = true;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(418, 134);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(194, 57);
            this.btncustomer.TabIndex = 4;
            this.btncustomer.Text = "Quản lý khách hàng";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.Location = new System.Drawing.Point(711, 134);
            this.btnemployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(194, 57);
            this.btnemployee.TabIndex = 3;
            this.btnemployee.Text = "Quản lý nhân viên";
            this.btnemployee.UseVisualStyleBackColor = true;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btndevice
            // 
            this.btndevice.Location = new System.Drawing.Point(107, 134);
            this.btndevice.Margin = new System.Windows.Forms.Padding(4);
            this.btndevice.Name = "btndevice";
            this.btndevice.Size = new System.Drawing.Size(194, 57);
            this.btndevice.TabIndex = 1;
            this.btndevice.Text = "Quản lý sản phẩm";
            this.btndevice.UseVisualStyleBackColor = true;
            this.btndevice.Click += new System.EventHandler(this.btndevice_Click);
            // 
            // btnbilloflading
            // 
            this.btnbilloflading.Location = new System.Drawing.Point(260, 269);
            this.btnbilloflading.Margin = new System.Windows.Forms.Padding(4);
            this.btnbilloflading.Name = "btnbilloflading";
            this.btnbilloflading.Size = new System.Drawing.Size(194, 57);
            this.btnbilloflading.TabIndex = 0;
            this.btnbilloflading.Text = "Quản lý phiếu giao hàng";
            this.btnbilloflading.UseVisualStyleBackColor = true;
            this.btnbilloflading.Click += new System.EventHandler(this.btnbilloflading_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Hệ thống quản lý cửa hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btndevice;
        private System.Windows.Forms.Button btnbilloflading;
    }
}