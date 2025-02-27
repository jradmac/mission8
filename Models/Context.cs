using mission8.Models;
using Type = mission8.Models.Type;

namespace Microsoft.EntityFrameworkCore;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    
    public DbSet<Quadrent1> Quadrent1s { get; set; }
    
    public DbSet<Type> Type { get; set; }
    


    
    protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
    {
        modelBuilder.Entity<Type>().HasData(
            new Type { TypeId = 1, TypeName = "Home"},
            new Type { TypeId = 2, TypeName = "School"},
            new Type { TypeId = 3, TypeName = "Work"},
            new Type { TypeId = 4, TypeName = "Church"}
        );
        
        // Configure DateOnly conversion for all Quadrant models
        modelBuilder.Entity<Quadrent1>()
            .Property(q => q.DataType)
            .HasConversion(
                v => v.ToDateTime(TimeOnly.MinValue),
                v => DateOnly.FromDateTime(v)
            );
        
    }
}