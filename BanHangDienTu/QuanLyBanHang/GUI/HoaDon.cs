using QuanLyBanHang.BLL;
using QuanLyBanHang.DTO;
using QuanLyBanHang.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class HoaDon : Form
    {
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtCreateDate;
        private TextBox txtTotal;
        private TextBox txtCustomerName;
        private TextBox txtID;
        private Label lblNgayTao;
        private Label lblTongTien;
        private Label lblKh_id;
        private Label lblId;
        private Button btnThem;
        private Button btnChon;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button btnClose;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewComboBoxColumn Column1;
        private DataGridView tblInvoice;

        public HoaDon()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblKh_id = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblInvoice = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 308);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblNgayTao);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.lblKh_id);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hóa đơn";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(184, 189);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(203, 29);
            this.txtCreateDate.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(184, 146);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(203, 29);
            this.txtTotal.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(184, 96);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(203, 29);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(184, 45);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(203, 29);
            this.txtID.TabIndex = 4;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(51, 191);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(76, 21);
            this.lblNgayTao.TabIndex = 3;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(51, 148);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(78, 21);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblKh_id
            // 
            this.lblKh_id.AutoSize = true;
            this.lblKh_id.Location = new System.Drawing.Point(51, 99);
            this.lblKh_id.Name = "lblKh_id";
            this.lblKh_id.Size = new System.Drawing.Size(120, 21);
            this.lblKh_id.TabIndex = 1;
            this.lblKh_id.Text = "Tên khách hàng:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(358, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 46);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(120, 46);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(168, 46);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Xem chi tiết hóa đơn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // panel2
            // 
            // 
            // tblInvoice
            // 
            this.tblInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.tblInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInvoice.Location = new System.Drawing.Point(0, 0);
            this.tblInvoice.MultiSelect = false;
            this.tblInvoice.Name = "tblInvoice";
            this.tblInvoice.RowHeadersWidth = 51;
            this.tblInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblInvoice.Size = new System.Drawing.Size(1115, 403);
            this.tblInvoice.TabIndex = 0;
            this.tblInvoice.Text = "dataGridView1";
            this.tblInvoice.SelectionChanged += new System.EventHandler(this.tblInvoice_SelectionChanged);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tblInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 403);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnChon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 125);
            this.panel3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(815, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 46);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tổng tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày tạo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.Items.AddRange(new object[] {
            "Chưa xử lý",
            "Đã xử lý"});
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HoaDon
            // 
            this.ClientSize = new System.Drawing.Size(1115, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            InvoiceBLL bll = new InvoiceBLL();
            List<InvoiceDTO> listInvoice = bll.getAllInvoice();

            CustomerBLL customerBLL = new CustomerBLL();

            foreach (InvoiceDTO hd in listInvoice)
            {
                String name = customerBLL.getCustomerById(hd.customer_id).name;
                this.tblInvoice.Rows.Add(hd.id, name, hd.totalMoney, hd.createdDate.ToString("dd-MM-yyyy"), hd.status);
            }
        }

        private void tblInvoice_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblInvoice.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtCustomerName.Text = row.Cells[1].Value.ToString();
                    txtTotal.Text = row.Cells[2].Value.ToString();
                    txtCreateDate.Text = row.Cells[3].Value.ToString();
                }
                else return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon.id = 0;
            new ChiTietHoaDon().Show();
            this.Visible = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon.id = Convert.ToInt32(txtID.Text);
            new ChiTietHoaDon().Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Main().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceBLL invoiceBLL = new InvoiceBLL();
                int selectedrowindex = tblInvoice.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblInvoice.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    invoiceBLL.updateInvoiceStatus(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[4].Value.ToString());
                    MessageBox.Show("Cập nhật thành công!!!", "Thông báo");
                }
                else return;
            }
            catch (Exception) { MessageBox.Show("Vui lòng chọn giá trị để cập nhật", "Thông báo"); }
        }
    }
}
