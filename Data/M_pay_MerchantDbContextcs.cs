using Backend_Mss.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Mss.Data
{
    public class MpayDbContext : DbContext
    {
        public MpayDbContext(DbContextOptions options) : base(options)
        {
        }

        //Dbset

       public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Merchant_tpe> Merchants_tpes { get; set; }
        public DbSet<Subscriber_operation> Subscribers_operations { get; set; }
        public DbSet<Subscriber_verification> Subscribers_verifications { get; set; }
    }
}
