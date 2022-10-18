using Microsoft.EntityFrameworkCore;
using ProvaNetCore.Models;

namespace ProvaNetCore.Data
{
    public class ProvaNetCoreDbContext : DbContext
    {
        public ProvaNetCoreDbContext(DbContextOptions<ProvaNetCoreDbContext> options) : base(options)
        {

        }

        public DbSet<Conta> Contas { get; set; }
    }
}
