using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=SGLSTORE;Integrated Security=True");
    }
}
