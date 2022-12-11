using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private string _MaKH;
        private string _HoTenKH;
        private string _SDTKH;
        private string _DiaChi;

        /*=======GETTER/SETTER=======*/
        public string MaKH
        {
            get
            {
                return _MaKH;
            }
            set
            {
                _MaKH = value;
            }
        }
        public string HoTenKH
        {
            get
            {
                return _HoTenKH;
            }
            set
            {
                _HoTenKH = value;
            }
        }
       
        public string SDTKH
        {
            get
            {
                return _SDTKH;
            }
            set
            {
                _SDTKH = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string makh, string hotenkh, string sdtkh, string diachi)
        {
            this.MaKH = makh;
            this.HoTenKH = hotenkh;
            this.SDTKH = sdtkh;
            this.DiaChi = diachi;
        }
    }
}
