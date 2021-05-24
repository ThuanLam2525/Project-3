using Newtonsoft.Json;
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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            
            // truong hop tao moi Phieeu
            if (id == 0)
            {
                clearData();
                btnedit.Enabled = false;
            }
            else
            // Load phieu voi Id dc chon
            {
                BillOfLadingBLL billOfLadingBLL = new BillOfLadingBLL();
                BillOfLadingDTO bl = billOfLadingBLL.getBillOfLadingById(id);
                InvoiceBLL invoiceBLL = new InvoiceBLL();

                btnadd.Enabled = false;
                txtId.Text = bl.id.ToString();
                txtInvoiceId.ReadOnly = true;
                txtaddress.Text = bl.address.ToString();
                txtInvoiceId.Text = bl.invoice_id.ToString();
                txtReceiver.Text = bl.receiverName.ToString();
                txtshipdate.Text = bl.shipDate.ToString();
                txtId.Text = id.ToString();

                // get data from Invoice by invoice_id to load on table
                InvoiceDTO invoice = invoiceBLL.getInvoiceById(bl.invoice_id);

                InvoiceJson detailInvoice = JsonConvert.DeserializeObject<InvoiceJson>(invoice.detail);
                List<CartDv> cartDvs = detailInvoice.ThietBi;

                foreach (CartDv device in cartDvs)
                {
                    tblProduct.Rows.Add(device.Device.id, device.Device.name, device.Quantity, device.Device.price);
                }

                flag = true;
            }

        }

        private void clearData()
        {
            txtaddress.Text = "";
            txtId.Text = "";
            txtInvoiceId.Text = "";
            txtReceiver.Text = "";
            txtshipdate.Text = "";
            tblProduct.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            BillOfLadingBLL billOfLadingBLL = new BillOfLadingBLL();
            BillOfLadingDTO bl = new BillOfLadingDTO();
            if (txtReceiver.Text.Equals("") || txtaddress.Text.Equals("") || txtshipdate.Text.Equals("") || txtInvoiceId.Text.Equals(""))
            {
                MessageBox.Show("Giá trị nhập vào không được để trống!!! ", "Thông báo");
            }
            bl.receiverName = txtReceiver.Text;
            bl.address = txtaddress.Text;
            bl.shipDate = Convert.ToDateTime(txtshipdate.Text);
            bl.status = "Chưa giao hàng";
            bl.invoice_id = Convert.ToInt32(txtInvoiceId.Text);
            if(flag)
            {
                billOfLadingBLL.createBillOfLading(bl);
                MessageBox.Show("Tạo thành công ", "Thông báo");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            BillOfLadingBLL billOfLadingBLL = new BillOfLadingBLL();
            BillOfLadingDTO bl = billOfLadingBLL.getBillOfLadingById(id);
            if (txtReceiver.Text.Equals("") || txtaddress.Text.Equals("") || txtshipdate.Text.Equals("") || txtInvoiceId.Text.Equals(""))
            {
                MessageBox.Show("Giá trị nhập vào không được để trống!!! ", "Thông báo");
            }
            bl.receiverName = txtReceiver.Text;
            bl.address = txtaddress.Text;
            bl.shipDate = Convert.ToDateTime(txtshipdate.Text);
            if (flag)
            {
                billOfLadingBLL.updateBillOfLading(Convert.ToInt32(txtId.Text), bl);
                MessageBox.Show("Cập nhật thành công ", "Thông báo");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Visible = false;
            new ListDelivery().Show();
        }

        private void txtInvoiceId_MouseLeave(object sender, EventArgs e)
        {
            // kiem tra co ton tai ma hoa don do ko, neu co thi load du lieu , ko thi bao loi
            try
            {
                InvoiceBLL invoiceBLL = new InvoiceBLL();
                InvoiceDTO invoice = invoiceBLL.getInvoiceById(Convert.ToInt32(txtInvoiceId.Text));
                tblProduct.Rows.Clear();
                if (invoice == null)
                {
                    MessageBox.Show("Hóa đơn này chưa được xử lý !!!", "Thông báo");
                }
                else
                {
                    CustomerBLL customerBLL = new CustomerBLL();
                    CustomerDTO customer = customerBLL.getCustomerById(invoice.customer_id);
                    txtaddress.Text = customer.address;
                    txtReceiver.Text = customer.name;

                    //load table san pham
                    InvoiceJson detailInvoice = JsonConvert.DeserializeObject<InvoiceJson>(invoice.detail);
                    List<CartDv> cartDvs = detailInvoice.ThietBi;

                    foreach (CartDv device in cartDvs)
                    {
                        tblProduct.Rows.Add(device.Device.id, device.Device.name, device.Quantity, device.Device.price);
                    }

                    flag = true;
                }
            }
            catch (Exception) { MessageBox.Show("Không tồn tại Mã hóa đơn này!!", "Thông báo"); }
        }
    }
}
