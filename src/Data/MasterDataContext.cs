using Microsoft.EntityFrameworkCore;
using WebApi.MultiTenant.Models;

namespace WebApi.MultiTenant.Data
{
    public class MasterDataContext : DbContext
    {
        public MasterDataContext(DbContextOptions<MasterDataContext> options) : base(options)
        {
            
        }
        
        public DbSet<Customer> Customers { get; set; }
    }
}
