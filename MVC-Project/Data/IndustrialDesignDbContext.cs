 using IndustrialDesign.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IndustrialDesign.Data
{
    public class IndustrialDesignDbContext : IdentityDbContext<User>
    {
        public IndustrialDesignDbContext(DbContextOptions<IndustrialDesignDbContext> options)
            : base(options)
        {
            base.Database.Migrate();
        }
        public DbSet<FinishedOrder>? FinishedOrders { get; set; }
        public DbSet<PendingOrder>? PendingOrders { get; set; }
        

    }

}