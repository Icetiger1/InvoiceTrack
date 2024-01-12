namespace InvoiceTrack.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
