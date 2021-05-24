using QuanLyBanHang.DAL;
using QuanLyBanHang.DTO;
using System.Collections.Generic;

namespace QuanLyBanHang.BLL
{
    class EmployeeBLL
    {
        public string CheckLogin(string mail, string pass)
        {
            EmployeeDAL nva = new EmployeeDAL();
            string kq = nva.login(mail, pass);
            return kq;
        }
        public List<EmployeeDTO> getAll()
        {
            EmployeeDAL nva = new EmployeeDAL();
            return nva.getAll();
        }
        public void addEmployee(EmployeeDTO nv)
        {
            EmployeeDAL nva = new EmployeeDAL();
            nva.addEmployee(nv);
        }

        public void updateEmployee(int manv, EmployeeDTO nv)
        {
            EmployeeDAL nva = new EmployeeDAL();
            nva.updateEmployee(manv, nv);
        }
        public void deleteEmployee(int manv)
        {
            EmployeeDAL nva = new EmployeeDAL();
            nva.deleteEmployee(manv);
        }
        public int getCurrentEmployeeId()
        {
            EmployeeDAL nva = new EmployeeDAL();
            return nva.getCurrentEmployeeId();
        }
    }
}
