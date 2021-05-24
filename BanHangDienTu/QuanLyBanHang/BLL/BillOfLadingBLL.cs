using QuanLyBanHang.DAL;
using QuanLyBanHang.DTO;
using System.Collections.Generic;

namespace QuanLyBanHang.BLL
{
    class BillOfLadingBLL
    {
        BillOfLadingDAL billOfLandingDAL = new BillOfLadingDAL();
        public List<BillOfLadingDTO> getAll()
        {
            return billOfLandingDAL.getAll();
        }
        public void updateBillOfLading(int id, BillOfLadingDTO bl)
        {
            billOfLandingDAL.updateBillOfLading(id, bl);
        }
        public void createBillOfLading(BillOfLadingDTO bl)
        {
            billOfLandingDAL.createBillOfLading(bl);
        }
        public BillOfLadingDTO getBillOfLadingById(int id)
        {
            return billOfLandingDAL.getBillOfLadingById(id);
        }
    }
}
