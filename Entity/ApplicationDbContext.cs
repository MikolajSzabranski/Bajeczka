using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    // {
    //     
    // }
    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    public DbSet<UserEntity> Users { get; set; }
	public DbSet<MovieEntity> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }

}