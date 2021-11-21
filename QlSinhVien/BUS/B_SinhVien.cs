using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_SinhVien
    {
        public static DataTable GetAllSinhVien()
        {
            return D_SinhVien.getData();
        }
    }
}