using Final2.Models.Enums;
using System.Collections.Generic;
using System.Linq;


namespace Final2.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double ammount, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Seller = seller;
        }

        public void AddSales(SalesRecord sr) 
        { 
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr); 
        }
    }
}
