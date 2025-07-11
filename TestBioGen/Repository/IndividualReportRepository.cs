using Microsoft.EntityFrameworkCore;
using TestBioGen.Data;
using TestBioGen.Enitty;

namespace TestBioGen.Repository;

public interface IIndividualReportRepository
{
    public Task<UserHealthStatistics> GetDailyIntake();
}


public class IndividualReportRepository(BioGenDataBase context) : IIndividualReportRepository
{

    public async Task<UserHealthStatistics> GetDailyIntake()
    {
        var dailyIntake =  await context.UserHealthSatistics.AsNoTracking()
            .OrderByDescending(x => x.AddAt)
            .FirstOrDefaultAsync();
        
        return dailyIntake;
    }
}