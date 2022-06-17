using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared_viewmodels
{
    public class Category
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public virtual List<Category_smaller> Categories {get;set; } = new List<Category_smaller>();
    }
}
