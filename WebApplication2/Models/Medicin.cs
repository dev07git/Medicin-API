using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Medicin
    {
        public string MedicinName { get; set; }
        public string Notes { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Qty { get; set; }
        public string BrandName { get; set; }
        public string BgColor { get; set; }

    }
}
