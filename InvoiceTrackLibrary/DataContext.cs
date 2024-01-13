using InvoiceTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTrackLibrary
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions op) : base(op)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
