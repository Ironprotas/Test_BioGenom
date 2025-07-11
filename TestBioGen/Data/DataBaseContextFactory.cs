using Microsoft.EntityFrameworkCore;

namespace TestBioGen.Data;

public class DataBaseContextFactory
{
    public BioGenDataBase CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BioGenDataBase>();
        optionsBuilder.UseNpgsql(
            ""
        );
        return new BioGenDataBase(optionsBuilder.Options);
    }
}