using BNP.SeniorEvaluation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.SeniorEvaluation.Data.EntityConfiguration;

public class BookEntityConfiguration: IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(x => x.Title).HasMaxLength(50);
        
        builder
            .Property(i => i.DateCreated)
            .ValueGeneratedOnAdd();
        
        builder
            .Property(i => i.DateUpdated)
            .ValueGeneratedOnAddOrUpdate();

    }
}