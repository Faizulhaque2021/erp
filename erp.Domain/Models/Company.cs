using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp.Domain.Models
{
    public class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string address { get; set; }
        public string businessType { get; set; }
        public string contactNumber { get; set; }
        public string tinNumber { get; set; }
        public string binNumber { get; set; }
    }
}
