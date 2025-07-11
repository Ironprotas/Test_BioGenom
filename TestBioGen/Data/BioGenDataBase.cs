using Microsoft.EntityFrameworkCore;
using TestBioGen.Enitty;

namespace TestBioGen.Data;

public class BioGenDataBase : DbContext
{
    public BioGenDataBase(DbContextOptions<BioGenDataBase> options) : base(options)
    {
        
    }
    public DbSet<UserEntity>  Users { get; set; }
    public DbSet<UserQuestionnaireEnity>  Questionnaires { get; set; }
    public DbSet<UserHealthStatistics>  UserHealthSatistics { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<UserEntity>(e =>
        {
            e.ToTable("Users");
            e.HasKey(x => x.Id);
            e.HasOne(x => x.Questionnaires)
                .WithOne(x => x.User)
                .HasForeignKey<UserQuestionnaireEnity>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UserQuestionnaireEnity>(e =>
        {
            e.ToTable("UserQuestionnaires");
            e.HasKey(x => x.Id);
            e.HasIndex(x => x.UserId);
            
        });
        
        modelBuilder.Entity<UserHealthStatistics>(e =>
        {
            e.ToTable("UserHealthStatistics");
            e.HasKey(x => x.Id);
            e.HasIndex(x => x.UserId);
            e.Property(x => x.AddAt).HasDefaultValueSql("now()");
        });
    }
}