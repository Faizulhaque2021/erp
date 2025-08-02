using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp.Domain.Models
{
    public class Supplier
    {
        public int supplierId { get; set; }
        public string Name { get; set; }
        public string productType { get; set; }
        public string Local { get; set; }
        public string bankAccount { get; set; }
        public string contact { get; set; }
        public string officeAddress { get; set; }
        public string contactPerson { get; set; }
        public string email { get; set; }
        public string binNumber { get; set; }
        public string tinNumber { get; set; }
    }
}
