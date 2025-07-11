using Microsoft.AspNetCore.Mvc;
using TestBioGen.Repository;

namespace TestBioGen.Controllers;

[ApiController]
[Route("diagnostics/nutrition-quality-short/last-result")]
public class IndividualReportController : ControllerBase
{
    private readonly IIndividualReportRepository _reportRepository;

    public IndividualReportController(IIndividualReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }

    [HttpGet("dailyIntake")]
    public async Task<IActionResult> DailyIntake()
    {
        var res = await _reportRepository.GetDailyIntake();
        return Ok(res);
    }
}