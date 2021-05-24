using QuanLyBanHang.BLL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            CustomerDTO ct = new CustomerDTO();
            ct.name = txtname.Text;
            ct.sdt = txtsdt.Text;
            ct.address = txtaddress.Text;
            try
            {
                customerBLL.addCustomer(ct);
                tblcustomer.Rows.Add(customerBLL.getCurrentCustomerId(), ct.name, ct.sdt, ct.address);
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception) { MessageBox.Show("Thêm không thành công"); }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            List<CustomerDTO> list = customerBLL.getAll();
            foreach (CustomerDTO ct in list)
            {
                tblcustomer.Rows.Add(ct.id, ct.name, ct.sdt, ct.address);
            }
        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtname.Text = "";
            txtsdt.Text = "";
            txtaddress.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            CustomerDTO ct = new CustomerDTO();
            try
            {
                int selectedrowindex = tblcustomer.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblcustomer.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    //sua duoi db
                    ct.name = txtname.Text;
                    ct.sdt = txtsdt.Text;
                    ct.address = txtaddress.Text;
                    customerBLL.updateCustomer(Convert.ToInt32(txtID.Text), ct);

                    // sua trong table
                    selectedRow.Cells[1].Value = txtname.Text;
                    selectedRow.Cells[2].Value = txtsdt.Text;
                    selectedRow.Cells[3].Value = txtaddress.Text;
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else return;
            }
            catch (Exception) { MessageBox.Show("Sửa thông tin không thành công"); }
        }

        private void tblcustomer_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblcustomer.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtname.Text = row.Cells[1].Value.ToString();
                    txtsdt.Text = row.Cells[2].Value.ToString();
                    txtaddress.Text = row.Cells[3].Value.ToString();
                }
                else return;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Main().Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            try
            {
                int selectedrowindex = tblcustomer.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblcustomer.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    customerBLL.deleteCustomer(Convert.ToInt32(selectedRow.Cells[0].Value));
                    tblcustomer.Rows.Remove(selectedRow);
                }
                else return;
            }
            catch (Exception) { return; }
        }
    }
}
