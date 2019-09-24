using System;
using SalesWebMvc.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public double baseSalary { get; set; }
        public SalesRecord SalesRecord { get; set; }

        public Seller(int id, string name, string email, DateTime birthdate, double baseSalary, SalesRecord salesRecord)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthdate = birthdate;
            this.baseSalary = baseSalary;
            SalesRecord = salesRecord;
        }

        List<SalesRecord> SellerSales = new List<SalesRecord>();

        public void AddSales(SalesRecord sr)
        {
            SellerSales.Add(sr);
        }


    }
}
