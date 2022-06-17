using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared_viewmodels
{
    public class Category_smaller
    {
        //public int MaLoai { get; set; }
        public virtual Category Category { get; set; }

        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public int SoLuongDaBan { get; set; }
        public string HinhAnh { get; set; }
    }
}
