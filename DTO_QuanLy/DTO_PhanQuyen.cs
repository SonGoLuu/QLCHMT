using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhanQuyen
    {
        private string _MaQuyen;
        private string _TenQuyen;
        private string _ChiTietQuyen;
        /*=======GETTER/SETTER=======*/
        public string MaQuyen
        {
            get
            {
                return _MaQuyen;
            }
            set
            {
                _MaQuyen = value;
            }
        }
        public string TenQuyen
        {
            get
            {
                return _TenQuyen;
            }
            set
            {
                _TenQuyen = value;
            }
        }
        public string ChiTietQuyen
        {
            get
            {
                return _ChiTietQuyen;
            }
            set
            {
                _ChiTietQuyen = value;
            }
        }
        public DTO_PhanQuyen()
        {

        }
        public DTO_PhanQuyen(string maquyen, string tenquyen, string chitietquyen)
        {
            this.MaQuyen = maquyen;
            this.TenQuyen = tenquyen;
            this.ChiTietQuyen = chitietquyen;
        }    
    }
}
