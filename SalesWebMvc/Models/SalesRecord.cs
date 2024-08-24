using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public DateTime Date { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, double amount, SaleStatus status, DateTime date, Seller seller)
        {
            Id = id;
            Amount = amount;
            Status = status;
            Date = date;
            Seller = seller;
        }
    }
}
