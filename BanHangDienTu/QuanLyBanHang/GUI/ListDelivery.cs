using QuanLyBanHang.BLL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class ListDelivery : Form
    {
        public ListDelivery()
        {
            InitializeComponent();
        }

        private void ListDelivery_Load(object sender, EventArgs e)
        {
            BillOfLadingBLL billOfLadingBLL = new BillOfLadingBLL();
            List<BillOfLadingDTO> list = billOfLadingBLL.getAll();
            foreach (BillOfLadingDTO bl in list)
            {
                tblPhieuGiao.Rows.Add(bl.id, bl.invoice_id, bl.receiverName, bl.address, bl.shipDate.ToShortDateString(), bl.status);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = tblPhieuGiao.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblPhieuGiao.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    Delivery.id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    new Delivery().Show();
                    this.Visible = false;
                }
                else return;
            }
            catch (Exception) { return; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BillOfLadingBLL billOfLadingBLL = new BillOfLadingBLL();
                BillOfLadingDTO bl = new BillOfLadingDTO();
                int selectedrowindex = tblPhieuGiao.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblPhieuGiao.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    bl.receiverName = selectedRow.Cells[2].Value.ToString();
                    bl.invoice_id = Convert.ToInt32(selectedRow.Cells[1].Value);
                    bl.address = selectedRow.Cells[3].Value.ToString();
                    bl.shipDate = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    bl.status = selectedRow.Cells[5].Value.ToString();
                    billOfLadingBLL.updateBillOfLading(Convert.ToInt32(selectedRow.Cells[0].Value), bl);
                    MessageBox.Show("Cập nhật thành công!!!", "Thông báo");
                }
                else return;
            }
            catch (Exception) { MessageBox.Show("Vui lòng chọn giá trị để cập nhật", "Thông báo"); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Main().Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Delivery.id = 0;
            new Delivery().Visible = true;
            Visible = false;
        }
    }
}
