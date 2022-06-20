using WebMobile.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebMobile.DAL
{
    public class CredenciallDbContext : DbContext
    {
        public CredenciallDbContext() : base("CredencialDbContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<CMS> CMSs { get; set; }
    }
}