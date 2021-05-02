using Entities.Concrete;
using Entities.Types;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntegrasyonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=Entegrasyon;Trusted_Connection=true");
        }

        public DbSet<Connect> Connects { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<RetailCustomer> RetailCustomers { get; set; }
        public DbSet<RetailInvoice> RetailInvoices { get; set; }
        public DbSet<RetailOrder> RetailOrders { get; set; }
        public DbSet<WholesaleCustomer> WholesaleCustomers { get; set; }
        public DbSet<WholesaleInvoice> WholesaleInvoices { get; set; }
        public DbSet<WholesaleOrder> WholesaleOrders { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<ModelType> ModelTypes { get; set; }
        public DbSet<OrderViaInternetInfo> OrderViaInternetInfos { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PostalAddress> PostalAddresses { get; set; }
        public DbSet<SaleViaInternetInfo> SaleViaInternetInfos { get; set; }
        public DbSet<SumLine> SumLines { get; set; }
        public DbSet<Variant> Variants { get; set; }
    }
}