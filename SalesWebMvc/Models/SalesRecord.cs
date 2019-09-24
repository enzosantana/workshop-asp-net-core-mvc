using System;
using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int MyProperty { get; set; }
        public SalesStatus SaleStatus { get; set; }

    }
}
