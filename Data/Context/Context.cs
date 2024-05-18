
using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{
    public DbSet<TCompany> Table_Company { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data Source=eiger.liara.cloud,31508;Initial Catalog=CompanyDb;User Id=sa;Password=z5Y0vidaGciDckNqm7xRmgCB;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }
}