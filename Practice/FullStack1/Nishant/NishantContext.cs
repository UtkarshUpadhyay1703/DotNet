using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;

public class NishantContext:DbContext{
    public DbSet<Nishant> Nishants{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString=@"server=localhost;port=3306;user=root;password=sah_utk;database=test";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Nishant>(entity=>{
            entity.HasKey(e=>e.Id);
            entity.Property(e=>e.Name);
            entity.Property(e=>e.Email);
        });
        modelBuilder.Entity<Nishant>().ToTable("nishant");
    }
}