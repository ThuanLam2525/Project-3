using QuanLyBanHang.DAL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;

namespace QuanLyBanHang.BLL
{
    class DeviceBLL
    {
        DeviceDAL device = new DeviceDAL();
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase;
        public List<DeviceDTO> getAll()
        {
            return device.getAll();
        }
        public void addDevice(DeviceDTO dv)
        {
            DeviceDAL dva = new DeviceDAL();
            dva.addDevice(dv);
        }

        public void updateDevice(int masp, DeviceDTO dv)
        {
            DeviceDAL dva = new DeviceDAL();
            dva.updateDevice(masp, dv);
        }

        public void deleteDevice(int masp)
        {
            DeviceDAL dva = new DeviceDAL();
            dva.deleteDevice(masp);
        }
        public DeviceDTO getDeviceById(int id)
        {
            return device.getDeviceById(id);
        }
        public int getCurrentDeviceId()
        {
            DeviceDAL dva = new DeviceDAL();
            return dva.getCurrentDeviceId();
        }
        public List<DeviceDTO> searchByName(string name)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();

            if (name.Equals("")) return list;
            else
            {
                foreach (DeviceDTO device in list)
                {
                    if (device.name.IndexOf(name, stringComparison) >= 0)
                    {
                        kq.Add(device);
                    }
                }
                return kq;
            }
        }

        public List<DeviceDTO> searchByCatalog(string catalog)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if (device.catalog.Equals(catalog))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }
        public List<DeviceDTO> searchByType(string type)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if (device.type.Equals(type))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }
        public List<DeviceDTO> searchByTypeAndCatalog(string type, string catalog)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if (device.catalog.Equals(catalog) && device.type.Equals(type))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }
        public List<DeviceDTO> searchByTypeAndCatalogAndName(string type, string catalog, string name)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if (device.catalog.Equals(catalog) && device.type.Equals(type) && (device.name.IndexOf(name, stringComparison) >= 0))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }

        public List<DeviceDTO> searchByTypeAndName(string type, string name)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if ((device.name.IndexOf(name, stringComparison) >= 0) && device.type.Equals(type))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }
        public List<DeviceDTO> searchByNameAndCatalog(string name, string catalog)
        {
            List<DeviceDTO> list = device.getAll();
            List<DeviceDTO> kq = new List<DeviceDTO>();
            foreach (DeviceDTO device in list)
            {
                if (device.catalog.Equals(catalog) && (device.name.IndexOf(name, stringComparison) >= 0))
                {
                    kq.Add(device);
                }
            }
            return kq;
        }
    }
}
