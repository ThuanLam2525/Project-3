using Newtonsoft.Json;
using QuanLyBanHang.BLL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class ChiTietHoaDon : Form
    {
        public static int id;
        bool flag = false;
        List<CartDv> listSP = new List<CartDv>();

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label lblCusName;
        private TextBox txtHd_id;
        private Label lblNgayTao;
        private Label lblId;
        private TextBox textBox4;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private Button btnAdd;
        private DateTimePicker txtCreateDate;
        private Button btnClose;
        private Button btnClear;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnCheckEmail;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnSearch;
        private RadioButton rdCombo;
        private RadioButton rdProduct;
        private ComboBox cboType;
        private ComboBox cboCatalog;
        private Label label14;
        private TextBox txtProductName;
        private Label label13;
        private Label label12;
        private Panel panel4;
        private TextBox txtTotal;
        private Label label11;
        private Label label9;
        private DataGridView tblProduct;
        private DataGridView lbSearch;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Tên;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;

        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckEmail = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtHd_id = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSearch = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdCombo = new System.Windows.Forms.RadioButton();
            this.rdProduct = new System.Windows.Forms.RadioButton();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboCatalog = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tblProduct = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbSearch)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 749);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(849, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(451, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 48);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm hóa đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 234);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCusName);
            this.groupBox1.Controls.Add(this.txtHd_id);
            this.groupBox1.Controls.Add(this.lblNgayTao);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.Location = new System.Drawing.Point(999, 22);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(94, 29);
            this.btnCheckEmail.TabIndex = 8;
            this.btnCheckEmail.Text = "Kiểm tra";
            this.btnCheckEmail.UseVisualStyleBackColor = true;
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(536, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(149, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email khách hàng:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(691, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.CustomFormat = "MM/dd/yyyy";
            this.txtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCreateDate.Location = new System.Drawing.Point(169, 93);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(250, 30);
            this.txtCreateDate.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(691, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(288, 30);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(691, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(288, 30);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(691, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 30);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(536, 70);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(134, 23);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Tên khách hàng:";
            // 
            // txtHd_id
            // 
            this.txtHd_id.Location = new System.Drawing.Point(169, 46);
            this.txtHd_id.Name = "txtHd_id";
            this.txtHd_id.Size = new System.Drawing.Size(250, 30);
            this.txtHd_id.TabIndex = 2;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(51, 93);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(88, 23);
            this.lblNgayTao.TabIndex = 1;
            this.lblNgayTao.Text = "Ngày bán:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(107, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 515);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rdCombo);
            this.groupBox2.Controls.Add(this.rdProduct);
            this.groupBox2.Controls.Add(this.cboType);
            this.groupBox2.Controls.Add(this.cboCatalog);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.tblProduct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 515);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSearch);
            this.groupBox3.Location = new System.Drawing.Point(578, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 212);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // lbSearch
            // 
            this.lbSearch.AllowUserToAddRows = false;
            this.lbSearch.AllowUserToDeleteRows = false;
            this.lbSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lbSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column5});
            this.lbSearch.Location = new System.Drawing.Point(19, 28);
            this.lbSearch.MultiSelect = false;
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.ReadOnly = true;
            this.lbSearch.RowHeadersWidth = 51;
            this.lbSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lbSearch.Size = new System.Drawing.Size(549, 179);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "dataGridView1";
            this.lbSearch.DoubleClick += new System.EventHandler(this.lbSearch_DoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã sp";
            this.Column6.MinimumWidth = 60;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 151;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdCombo
            // 
            this.rdCombo.AutoSize = true;
            this.rdCombo.Location = new System.Drawing.Point(460, 36);
            this.rdCombo.Name = "rdCombo";
            this.rdCombo.Size = new System.Drawing.Size(120, 27);
            this.rdCombo.TabIndex = 7;
            this.rdCombo.Text = "Tìm Combo";
            this.rdCombo.UseVisualStyleBackColor = true;
            this.rdCombo.Visible = false;
            this.rdCombo.CheckedChanged += new System.EventHandler(this.rdCombo_CheckedChanged);
            this.rdCombo.Click += new System.EventHandler(this.rdCombo_Click);
            // 
            // rdProduct
            // 
            this.rdProduct.AutoSize = true;
            this.rdProduct.Checked = true;
            this.rdProduct.Location = new System.Drawing.Point(375, 34);
            this.rdProduct.Name = "rdProduct";
            this.rdProduct.Size = new System.Drawing.Size(83, 27);
            this.rdProduct.TabIndex = 6;
            this.rdProduct.TabStop = true;
            this.rdProduct.Text = "Tìm SP";
            this.rdProduct.UseVisualStyleBackColor = true;
            this.rdProduct.Visible = false;
            this.rdProduct.CheckedChanged += new System.EventHandler(this.rdProduct_CheckedChanged);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Học tập - Văn phòng",
            "Đồ họa - Kỹ thuật",
            "Mỏng nhẹ",
            "Gaming",
            "Cao cấp - Sang trọng",
            "Workstation",
            "Mainboard",
            "CPU",
            "RAM",
            "VGA",
            "SSD",
            "Webcam",
            "Microphone",
            "Dây cáp"});
            this.cboType.Location = new System.Drawing.Point(169, 119);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(170, 31);
            this.cboType.TabIndex = 5;
            // 
            // cboCatalog
            // 
            this.cboCatalog.FormattingEnabled = true;
            this.cboCatalog.Items.AddRange(new object[] {
            "Laptop",
            "Máy bộ",
            "Linh kiện",
            "Phụ kiện"});
            this.cboCatalog.Location = new System.Drawing.Point(169, 77);
            this.cboCatalog.Name = "cboCatalog";
            this.cboCatalog.Size = new System.Drawing.Size(170, 31);
            this.cboCatalog.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Loại:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(169, 35);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 30);
            this.txtProductName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Danh mục:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên SP:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 40);
            this.panel4.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(688, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(288, 30);
            this.txtTotal.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(48, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nháy đúp một dòng để xóa";
            // 
            // tblProduct
            // 
            this.tblProduct.AllowUserToAddRows = false;
            this.tblProduct.AllowUserToDeleteRows = false;
            this.tblProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Tên,
            this.Column4,
            this.Column1});
            this.tblProduct.Location = new System.Drawing.Point(3, 232);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.RowHeadersWidth = 51;
            this.tblProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProduct.Size = new System.Drawing.Size(1143, 211);
            this.tblProduct.TabIndex = 0;
            this.tblProduct.Text = "dataGridView1";
            this.tblProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProduct_CellValueChanged);
            this.tblProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tblProduct_RowsAdded);
            this.tblProduct.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.tblProduct_RowsRemoved);
            this.tblProduct.DoubleClick += new System.EventHandler(this.tblProduct_DoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã sản phẩm";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Tên
            // 
            this.Tên.HeaderText = "Tên sản phẩm";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            this.Tên.ReadOnly = true;
            this.Tên.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Đơn giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(833, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 30);
            this.textBox4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách hàng:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(169, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 30);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(169, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 30);
            this.textBox6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hóa đơn:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(833, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 30);
            this.textBox7.TabIndex = 2;
            // 
            // ChiTietHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(1158, 816);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChiTietHoaDon";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbSearch)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new HoaDon().Visible = true;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // trường hơp tạo mới hóa đơn
            if (id == 0)
            {
                clearData();
            }
            // xem hóa đơn 
            else
            {
                InvoiceBLL invoiceBLL = new InvoiceBLL();
                CustomerBLL customerBLL = new CustomerBLL();

                InvoiceDTO invoice = invoiceBLL.getInvoiceById(id);
                txtHd_id.Text = id.ToString();
                txtTotal.Text = invoice.totalMoney.ToString();
                txtCreateDate.Text = invoice.createdDate.ToString();


                // tách json thông tin sản phẩm để đưa vào bảng
                InvoiceJson detailInvoice = JsonConvert.DeserializeObject<InvoiceJson>(invoice.detail);
                List<CartDv> cartDvs = detailInvoice.ThietBi;

                foreach (CartDv device in cartDvs)
                {
                    tblProduct.Rows.Add(device.Device.id, device.Device.name, device.Quantity, device.Device.price);
                }
                
                // load thong tin khach hang
                CustomerDTO customer = customerBLL.getCustomerById(invoice.customer_id);
                txtEmail.Text = customer.username;
                txtAddress.Text = customer.address;
                txtName.Text = customer.name;
                txtPhone.Text = customer.sdt;
                txtEmail.Text = customer.username;

                setReadOnly();
                cboCatalog.Enabled = false;
                cboType.Enabled = false;
            }
        }

        private void setReadOnly()
        {
            txtHd_id.ReadOnly = true;
            txtCreateDate.Enabled = false;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtProductName.ReadOnly = true;
            btnSearch.Enabled = false;
            btnCheckEmail.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = false;
        }
        private void clearData()
        {
            txtHd_id.ReadOnly = true;
            txtEmail.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
            txtProductName.Text = "";
            lbSearch.Rows.Clear();
            tblProduct.Rows.Clear();
            tblProduct.Refresh();
        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            string email = txtEmail.Text;
            int check = customerBLL.checkEmailExist(email);
            if (email.Equals(""))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng thử lại", "Kiểm tra Email");
            }
            else if (check == 1)
            {
                flag = true;
                CustomerDTO customer = customerBLL.getCustomerByEmail(email);
                txtName.Text = customer.name;
                txtAddress.Text = customer.address;
                txtPhone.Text = customer.sdt;
            }
            else
            {
                flag = true;
                MessageBox.Show("Email hợp lệ", "Kiểm tra Email");
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DeviceBLL deviceBLL = new DeviceBLL();
            lbSearch.Rows.Clear();
            if (rdProduct.Checked)
            {
                // tim theo ten
                if (cboCatalog.Text.Equals("") && cboType.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByName(txtProductName.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if(kq.amount >0 ) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }
                // tim theo catalog
                if (cboType.Text.Equals("") && txtProductName.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByCatalog(cboCatalog.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }

                // tim theo type
                if (cboCatalog.Text.Equals("") && txtProductName.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByType(cboType.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }

                // tim theo ten + catalog
                if (cboType.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByNameAndCatalog(txtProductName.Text, cboCatalog.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }

                // tim theo ten + type
                if (cboCatalog.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByTypeAndName(cboType.Text, txtProductName.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }

                // tim theo catalog + type
                if (txtProductName.Text.Equals(""))
                {
                    List<DeviceDTO> results = deviceBLL.searchByTypeAndCatalog(cboType.Text, cboCatalog.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }

                // tim theo ten + type + catalog
                else
                {
                    List<DeviceDTO> results = deviceBLL.searchByTypeAndCatalogAndName(cboType.Text, cboCatalog.Text, txtProductName.Text);
                    foreach (DeviceDTO kq in results)
                    {
                        if (kq.amount > 0) lbSearch.Rows.Add(kq.id, kq.name, kq.amount, kq.price);
                    }
                }
            }
        }

        private void rdCombo_Click(object sender, EventArgs e)
        {
            cboCatalog.Enabled = false;
            cboType.Enabled = false;
        }

        private void rdProduct_CheckedChanged(object sender, EventArgs e)
        {
            cboCatalog.Enabled = true;
            cboType.Enabled = true;
        }

        private void lbSearch_DoubleClick(object sender, EventArgs e)
        {
            bool flag = false;
            if (lbSearch.SelectedCells.Count > 0)
            {
                int selectedrowindex = lbSearch.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = lbSearch.Rows[selectedrowindex];
                foreach (DataGridViewRow row in tblProduct.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        break;
                    }
                    if (row.Cells[0].Value.Equals(selectedRow.Cells[0].Value))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    tblProduct.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value, 1, selectedRow.Cells[3].Value);
                    if (rdCombo.Checked) { }
                    else
                    {
                        DeviceDTO device = new DeviceDTO();
                        device.id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        device.name = selectedRow.Cells[1].Value.ToString();
                        device.price = Convert.ToDecimal(selectedRow.Cells[3].Value);

                        listSP.Add(new CartDv { Device = device, Quantity = Convert.ToInt32(selectedRow.Cells[2].Value) });
                    }
                }
            }
        }

        private void tblProduct_DoubleClick(object sender, EventArgs e)
        {
            /*if (tblProduct.SelectedRows.Count > 0)
            {*/
            if (id != 0)
            {
                tblProduct.ReadOnly = true;
            }
            else
            {
                try
                {
                    int selectedrowindex = tblProduct.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tblProduct.Rows[selectedrowindex];
                    if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                    {
                        tblProduct.Rows.Remove(selectedRow);
                        foreach (CartDv sp in listSP)
                        {
                            if (selectedRow.Cells[1].Value.ToString().Equals(sp.Device.name))
                            {
                                listSP.Remove(sp);
                            }
                        }
                        
                    }
                    else return;
                }
                catch (Exception) { return; }
            }

        }

        private void tblProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in tblProduct.Rows)
            {
                total += (Convert.ToDouble(row.Cells[2].Value)) * (Convert.ToDouble(row.Cells[3].Value));
            }
            txtTotal.Text = total.ToString();
        }

        private void tblProduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in tblProduct.Rows)
            {
                total += (Convert.ToDouble(row.Cells[2].Value)) * (Convert.ToDouble(row.Cells[3].Value));

            }
            txtTotal.Text = total.ToString();

        }

        private void tblProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            DeviceBLL deviceBLL = new DeviceBLL();
            List<DeviceDTO> list = deviceBLL.getAll();

            foreach (DataGridViewRow row in tblProduct.Rows)
            {
                //so sanh sl sp trong kho
                foreach (DeviceDTO sp in list)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == sp.id && (Convert.ToInt32(row.Cells[2].Value)) > sp.amount)
                    {
                        flag = false;
                        MessageBox.Show("Sản phẩm vượt quá số lượng trong kho", "Thông báo");
                        row.Cells[2].Value = 1;
                    }
                    else flag = true;
                }
                

                //tinh tong
                total += (Convert.ToDouble(row.Cells[2].Value)) * (Convert.ToDouble(row.Cells[3].Value));

            }
            txtTotal.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tblProduct.Rows.Count < 1)
            {
                MessageBox.Show("Bảng sản phẩm đang để trống", "Thông báo");
            }
            else
            {
                // check email ton tai chua
                CustomerBLL customerBLL = new CustomerBLL();
                CustomerDTO cs = new CustomerDTO();
                string email = txtEmail.Text;
                int check = customerBLL.checkEmailExist(email);
                if (check != 1)
                {
                    // tao customer 
                    cs.username = txtEmail.Text;
                    cs.sdt = txtPhone.Text;
                    cs.name = txtName.Text;
                    cs.address = txtAddress.Text;
                    cs.password = txtPhone.Text;
                    customerBLL.addCustomerByInvoice(cs);
                }
                // neu ton tai thi ko addCustomer, add Invoice
                InvoiceBLL invoiceBLL = new InvoiceBLL();
                InvoiceDTO invoice = new InvoiceDTO();
                DeviceBLL deviceBLL = new DeviceBLL();

                invoice.customer_id = customerBLL.getCustomerByEmail(email).id;
                invoice.totalMoney = Convert.ToDecimal(txtTotal.Text);
                invoice.createdDate = DateTime.Parse(txtCreateDate.Text);

                invoice.status = "Chưa xử lý";


                InvoiceJson json = new InvoiceJson()
                {
                    ThietBi = listSP
                };

                invoice.detail = JsonConvert.SerializeObject(json);


                if (flag)
                {
                    // add vao db Invoice
                    invoiceBLL.createInvoice(invoice);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    // tru sl sp trong kho
                    foreach (CartDv sp in listSP)
                    {
                        foreach (DeviceDTO spKho in deviceBLL.getAll())
                        {
                            if (spKho.id == sp.Device.id)
                            {
                                spKho.amount = spKho.amount - sp.Quantity;
                                deviceBLL.updateDevice(spKho.id, spKho);
                                break;
                            }
                        }
                    }

                    
                }

            }
        }

        private void rdCombo_CheckedChanged(object sender, EventArgs e)
        {
            lbSearch.Rows.Clear();
        }
    }
}
