using BNP.SeniorEvaluation.Data.EntityConfiguration;
using BNP.SeniorEvaluation.Domain;

namespace BNP.SeniorEvaluation.Data;
using Microsoft.EntityFrameworkCore;

public partial class AppDbContext: DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasKey(i => i.Id);
        modelBuilder
            .Entity<Author>()
            .Property(i => i.FirstName)
            .HasMaxLength(50)
            .IsRequired();
        
        modelBuilder
            .Entity<Author>()
            .Property(i => i.LastName)
            .HasMaxLength(50)
            .IsRequired();

        modelBuilder
            .Entity<Author>()
            .Property(i => i.DateCreated)
            .ValueGeneratedOnAdd();
        
        
        modelBuilder
            .Entity<Author>()
            .Property(i => i.DateUpdated)
            .ValueGeneratedOnAddOrUpdate();

        modelBuilder.Entity<Author>()
            .HasMany(e => e.Books)
            .WithOne(e => e.Author)
            .HasForeignKey(x => x.AuthorId)
            .HasPrincipalKey(x => x.Id);


        modelBuilder.ApplyConfiguration(new BookEntityConfiguration());


        Seed(modelBuilder);
    }
}