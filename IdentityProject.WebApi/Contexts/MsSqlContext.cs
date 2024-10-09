using IdentityProject.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebApi.Contexts;

public class MsSqlContext : DbContext
{

    public MsSqlContext(DbContextOptions opt): base(opt)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Docker kurulu olanlar 
        optionsBuilder.UseSqlServer("Server= localhost,1433; Database = Identit_db; User=sa; Password=admin123456789; TrustServerCertificate=true");

        // Localdb
        //optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database=Identit_db; Trusted_Connection = true");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}
