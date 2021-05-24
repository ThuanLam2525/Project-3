using QuanLyBanHang.BLL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            List<EmployeeDTO> list = employeeBLL.getAll();
            foreach (EmployeeDTO nv in list)
            {
                tblEmployee.Rows.Add(nv.id, nv.username, nv.password, nv.name, nv.sdt);
            }

        }

        private void tblEmployee_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblEmployee.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtusername.Text = row.Cells[1].Value.ToString();
                    txtpassword.Text = row.Cells[2].Value.ToString();
                    txtname.Text = row.Cells[3].Value.ToString();
                    txtsdt.Text = row.Cells[4].Value.ToString();
                }
                else return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtname.Text = "";
            txtpassword.Text = "";
            txtsdt.Text = "";
            txtusername.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            EmployeeDTO nv = new EmployeeDTO();
            nv.username = txtusername.Text;
            nv.password = txtpassword.Text;
            nv.name = txtname.Text;
            nv.sdt = txtsdt.Text;
            try
            {
                employeeBLL.addEmployee(nv);
                tblEmployee.Rows.Add(employeeBLL.getCurrentEmployeeId(), nv.username, nv.password, nv.name, nv.sdt);
            }
            catch (Exception) { return; }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            EmployeeDTO nv = new EmployeeDTO();
            try
            {
                int selectedrowindex = tblEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblEmployee.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    //sua duoi db
                    nv.username = txtusername.Text;
                    nv.password = txtpassword.Text;
                    nv.name = txtname.Text;
                    nv.sdt = txtsdt.Text;
                    employeeBLL.updateEmployee(Convert.ToInt32(txtID.Text), nv);

                    // sua trong table
                    selectedRow.Cells[1].Value = txtusername.Text;
                    selectedRow.Cells[2].Value = txtpassword.Text;
                    selectedRow.Cells[3].Value = txtname.Text;
                    selectedRow.Cells[4].Value = txtsdt.Text;
                }
                else return;
            }
            catch (Exception) { return; }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            try
            {
                int selectedrowindex = tblEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tblEmployee.Rows[selectedrowindex];
                if (selectedrowindex >= 0 && (selectedRow.Cells[0].Value != null))
                {
                    employeeBLL.deleteEmployee(Convert.ToInt32(selectedRow.Cells[0].Value));
                    tblEmployee.Rows.Remove(selectedRow);

                }
                else return;
            }
            catch (Exception) { return; }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Main().Visible = true;
        }
    }
}
