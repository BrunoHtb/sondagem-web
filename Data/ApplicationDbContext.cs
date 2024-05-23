using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SondagemPR.Models;

namespace SondagemPR.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Register> Registers { get; set; } = null!;
        public DbSet<Lot> Lots { get; set; } = null!;
        public DbSet<Regional> Regionals { get; set; } = null!;

    }
}
