using Microsoft.EntityFrameworkCore;
using WebApi.MultiTenant.Models;

namespace WebApi.MultiTenant.Data
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext(DbContextOptions<CustomerDataContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
