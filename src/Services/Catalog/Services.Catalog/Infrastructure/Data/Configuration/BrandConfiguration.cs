namespace Services.Catalog.Infrastructure.Data.Configuration;

internal sealed class BrandConfiguration : BaseConfiguration<Brand, BrandId>
{
    public override void Configure(EntityTypeBuilder<Brand> builder)
    {
        base.Configure(builder);

        
        builder.Property(e => e.Id)
               .HasConversion(
                   id => id.Value,
                   value => new(value))
               .ValueGeneratedOnAdd();

        builder.Property(e => e.Name).HasMaxLength(DataSchemaLength.Medium);
    }
}
