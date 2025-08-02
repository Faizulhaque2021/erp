using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp.Domain.Models
{
    public class Product
    {
        public int productId { get; set; }
        public int? cateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string productType { get; set; }
        public string wareHouse { get; set; }
        public string openingStock { get; set; }
        public string minStock { get; set; }
        public string maxStock { get; set; }
        public string hsnCode { get; set; }
        public string unit { get; set; }
        public Category Category { get; set; }
    }
}
