using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;
public class CollectionContext:DbContext{
    public DbSet<Employee> Employees{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString=@"server=localhost;port=3306;user=root;password=sah_utk;database=helping";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>(entity=>{
            entity.HasKey(e => e.employee_id);
            entity.Property(e=>e.employee_name).IsRequired();
            entity.Property(e=>e.employee_address).IsRequired();
            entity.Property(e=>e.employee_mobile_no).IsRequired();
            entity.Property(e=>e.employee_aadhar_no).IsRequired();
            entity.Property(e=>e.employee_bank_account_no).IsRequired();
            entity.Property(e=>e.employee_email_id).IsRequired();
            entity.Property(e=>e.employee_password).IsRequired();
            entity.Property(e=>e.employee_qualification).IsRequired();
            entity.Property(e=>e.employee_status).IsRequired();
        });
        modelBuilder.Entity<Employee>().ToTable("signup_employee");
    }
}