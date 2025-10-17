using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUDN32025
{
    public static class Session
    {
        public static string IDAccount { get; set; }
        public static string TypeOfAccount { get; set; }
        public static string MaDocGia { get; set; }
        public static string HoTen { get; set; }

        //Xóa Session khi đăng xuất hoặc đóng ứng dụng
        public static void Clear()
        {
            IDAccount = null;
            TypeOfAccount = null;
            MaDocGia = null;
            HoTen = null;
        }
    }
}
