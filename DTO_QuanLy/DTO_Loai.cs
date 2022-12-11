using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Loai
    {
        private string _MaLoai;
        private string _TenLoai;
        /*=======GETTER/SETTER=======*/
        public string MaLoai
        {
            get
            {
                return _MaLoai;
            }
            set
            {
                _MaLoai = value;
            }
        }
        public string TenLoai
        {
            get
            {
                return _TenLoai;
            }
            set
            {
                _TenLoai = value;
            }
        }
        public DTO_Loai()
        {

        }   
        public DTO_Loai(string maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
        }
    }
}
