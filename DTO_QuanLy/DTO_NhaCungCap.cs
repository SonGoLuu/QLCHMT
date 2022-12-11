using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhaCungCap
    {
        private string _MaNCC;
        private string _TenNCC;
        /*=======GETTER/SETTER=======*/
        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }
            set
            {
                _MaNCC = value;
            }
        }
        public string TenNCC
        {
            get
            {
                return _TenNCC;
            }
            set
            {
                _TenNCC = value;
            }
        }
        public DTO_NhaCungCap()
        {

        }
        public DTO_NhaCungCap(string mancc, string tenncc)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
        }
    }
}
